using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaAcademico.util;

namespace SistemaAcademico.forms.Admin
{
    public partial class FormMaterias : Form
    {
        private string Modo = "Criar"; // Controla se o Form está criando ou editando uma matéria

        public FormMaterias()
        {
            InitializeComponent();
            cmbFiltroProfessor.SelectedIndex = 0;
            resgatarCursos();
        }

        // Preenche o cmbCurso e o cmbDadosCurso
        private void resgatarCursos()
        {
            cmbCurso.Items.Clear();
            cmbDadosCurso.Items.Clear();
            foreach (Curso curso in new ExecutarDB().ListarCursos("sigla", "cursos", null))
            {
                cmbCurso.Items.Add(curso.Sigla);
                cmbDadosCurso.Items.Add(curso.Sigla);
            }
            cmbCurso.Enabled = true;
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMaterias.UseWaitCursor = true;
            dgvMaterias.Rows.Clear();

            // Preenche o dgvMaterias com os nomes e siglas das matérias do curso selecionado no cmbCurso
            foreach (Materia materia in new ExecutarDB().ListarMaterias("sigla, nome", "materias",
                $"curso = '{cmbCurso.Text}' ORDER BY nome ASC"))
                dgvMaterias.Rows.Add(materia.Sigla, materia.Nome);

            dgvMaterias.Enabled = true;
            dgvMaterias.UseWaitCursor = false;
        }

        // Inicia a alteração de uma matéria existente
        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Configura botões e altera texto
            limparCampos();
            Modo = "Alterar";
            lblTitulo.Text = "Alterando Matéria " + dgvMaterias.Rows[e.RowIndex].Cells["Sigla"].Value;
            cmbCurso.Enabled = false;
            cmbDadosCurso.Enabled = false;
            gpbAlunos.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Text = "Salvar";
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
            for (int i = 0; i < cmbCurso.Items.Count; i++)
                cmbDadosCurso.Items.Add(cmbCurso.Items[i]);
            cmbFiltroProfessor_SelectedIndexChanged(null, null);

            // Preenche os campos com os dados da matéria
            // Dados
            cmbDadosCurso.SelectedIndex = cmbCurso.SelectedIndex;
            txtNome.Text = dgvMaterias.Rows[e.RowIndex].Cells["NomeMateria"].Value.ToString();
            Materia materia = new ExecutarDB().ListarMaterias("*", "materias", $"curso = '{cmbDadosCurso.Text}' AND sigla = " +
                $"'{dgvMaterias.Rows[e.RowIndex].Cells["Sigla"].Value}'")[0];
            txtSigla.Text = materia.Sigla;

            // Professor
            usuarios.Professor lecionador;
            if (materia.Lecionador != -1)
            {
                lecionador = new ExecutarDB().ListarProfessores("registro, rg, cpf, nome", "professores INNER JOIN usuarios ON user_id = usuarios.id", $"professores.id = {materia.Lecionador}")[0];
                txtEntradaProfessor.Text = lecionador.Registro;
                lblProfessorRegistro.Text = "Registro: " + lecionador.Registro;
                lblProfessorRG.Text = "RG: " + lecionador.RG;
                lblProfessorCPF.Text = "CPF: " + lecionador.CPF;
                lblProfessorNome.Text = "Nome: " + lecionador.Nome;
            }

            // Alunos
            // por causa da atualização no cmbDadosCurso.SelectedIndex, os alunos já são resgatados
            // Marca quais alunos estão cursando essa matéria
            for (int i = 0; i < dgvAlunos.RowCount; i++)
                foreach (int idEstudante in materia.Estudantes)
                    if (Convert.ToInt32(dgvAlunos.Rows[i].Cells["ID"].Value) == idEstudante)
                        dgvAlunos.Rows[i].Cells["Cursando"].Value = true;
                    
        }

        // Cria ou atualiza uma matéria
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            splitContainer.Enabled = false;

            if (!validarDados())
            {
                splitContainer.Enabled = true;
                return;
            }

            // Resgata os dados que vão ser utilizados nas duas operações
            int idLecionador = -1;
            List<usuarios.Professor> lecionador = new ExecutarDB().ListarProfessores("professores.id", "professores INNER JOIN usuarios ON user_id = usuarios.id",
                $"{cmbFiltroProfessor.Text.ToLower()} = '{cmbResultadosProfessor.Text}'");
            if (lecionador.Count != 0)
                idLecionador = lecionador[0].ID;
            MessageBox.Show(idLecionador.ToString());

            string rowsEstudantes = "";
            for (int i = 0; i < dgvAlunos.RowCount; i++)
            {
                // Adiciona apenas os alunos marcados na coluna Cursando
                if (Convert.ToBoolean(dgvAlunos.Rows[i].Cells["Cursando"].Value))
                {
                    rowsEstudantes += dgvAlunos.Rows[i].Cells["ID"].Value.ToString();
                    if (i != dgvAlunos.RowCount - 1)
                        rowsEstudantes += " ";
                }
            }
            rowsEstudantes = rowsEstudantes.Trim();
            int[] idsEstudantes = !String.IsNullOrWhiteSpace(rowsEstudantes) ? new int[rowsEstudantes.Split(' ').Length] : new int[0];
            for (int i = 0; i < idsEstudantes.Length; i++)
                idsEstudantes[i] = Convert.ToInt32(rowsEstudantes.Split(' ')[i]);

            // Criando matéria
            if (Modo == "Criar")
            {
                // Resgata os outros dados necessários e insere na tabela materias da DB
                new ExecutarDB().Executar("INSERT INTO materias (curso, sigla, nome, lecionador_id, estudantes_id) VALUES " +
                    $"('{cmbDadosCurso.Text}', '{txtSigla.Text}', '{txtNome.Text}', {(idLecionador == -1 ? "NULL" : idLecionador.ToString())}, " + (idsEstudantes.Length != 0 ? "'{" + String.Join(", ", idsEstudantes) + "}' " : "NULL ") + ")");
            }
            else

            // Atualizando matéria
            {
                string oldSigla = dgvMaterias.SelectedRows[0].Cells["Sigla"].Value.ToString();

                // Resgata os outros dados necessários e atualiza a linha na tabela materias da DB
                new ExecutarDB().Executar("UPDATE materias SET " + $"curso = '{cmbCurso.Text}', sigla = '{txtSigla.Text}', " + $"nome = '{txtNome.Text}', " +
                    $"lecionador_id = {(idLecionador != -1 ? idLecionador.ToString() : "NULL")}, " +
                    "estudantes_id = " + (idsEstudantes.Length != 0 ? "'{" + String.Join(", ", idsEstudantes) + "}' " : "NULL ") +
                    $"WHERE curso = '{cmbDadosCurso.Text}' AND sigla = '{oldSigla}'");

                Modo = "Criar";
            }
            

            limparCampos();
            foreach (Curso curso in new ExecutarDB().ListarCursos("sigla", "cursos", null))
                cmbDadosCurso.Items.Add(curso.Sigla);
            cmbCurso_SelectedIndexChanged(null, null);
            cmbCurso.Enabled = true;

            splitContainer.Enabled = true;
        }

        // Valida os dados inseridos
        private bool validarDados()
        {
            // Verifica se está vazio e troca a cor
            if (String.IsNullOrWhiteSpace(txtSigla.Text))
                txtSigla.BackColor = Color.FromArgb(255, 192, 192);
            else txtSigla.BackColor = SystemColors.Window;
            if (String.IsNullOrWhiteSpace(txtNome.Text))
                txtNome.BackColor = Color.FromArgb(255, 192, 192);
            else txtNome.BackColor = SystemColors.Window;
            if (String.IsNullOrWhiteSpace(txtSigla.Text) || String.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show(null, "Alguns dados necessários estão incompletos, por favor verificá-los", "Erro " + Modo.ToLower());
                return false;
            }

            // Verifica se já há outra matéria com a mesma sigla no mesmo curso
            List<Materia> m = new ExecutarDB().ListarMaterias("sigla, nome", "materias", $"curso = '{cmbDadosCurso.SelectedValue}' ORDER BY nome ASC");
            for (int i = 0; i < m.Count; i++)
            {
                if (txtSigla.Text == m[i].Sigla && i != dgvMaterias.SelectedRows[0].Index)
                {
                    MessageBox.Show(null, $"Já existe uma matéria com a sigla {txtSigla.Text} no curso " +
                        $"{cmbDadosCurso.SelectedValue}:\n{m[i].Nome}.",
                        "Erro ao criar matéria");
                    splitContainer.Enabled = true;
                    return false;
                }
            }


            return true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string nomeMateria = dgvMaterias.SelectedRows[0].Cells["NomeMateria"].Value.ToString();
            string siglaMateria = dgvMaterias.SelectedRows[0].Cells["Sigla"].Value.ToString();

            if (MessageBox.Show(null, $"Deseja realmente apagar a matéria \"{nomeMateria}\" ({siglaMateria})?", "Excluindo matéria", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            new ExecutarDB().Executar($"DELETE FROM materias WHERE sigla = '{siglaMateria}'");

            btnExcluir.Enabled = false;
            btnSalvar.Text = "Criar";
            gpbAlunos.Enabled = false;
            cmbCurso.Enabled = true;
            cmbCurso.SelectedIndex = cmbDadosCurso.SelectedIndex;
            limparCampos();
            cmbCurso_SelectedIndexChanged(null, null);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Modo = "Criar";
            btnExcluir.Enabled = false;
            btnSalvar.Text = "Criar";
            gpbAlunos.Enabled = false;
            cmbCurso.Enabled = true;
            limparCampos();
            cmbDadosCurso.Items.Clear();
            foreach (Curso curso in new ExecutarDB().ListarCursos("sigla", "cursos", null))
                cmbDadosCurso.Items.Add(curso.Sigla);
        }

        private void limparCampos()
        {
            lblTitulo.Text = Modo + " Matéria";
            //dgvMaterias.ClearSelection();
            btnCancelar.Enabled = false;
            //cmbCurso_SelectedIndexChanged(null, null);

            txtNome.Clear();
            txtSigla.Clear();
            txtSigla.BackColor = SystemColors.Window;
            txtNome.BackColor = SystemColors.Window;
            cmbDadosCurso.Items.Clear();
            cmbDadosCurso.Enabled = true;

            txtEntradaProfessor.Clear();
            cmbResultadosProfessor.Items.Clear();
            lblProfessorRegistro.Text = "Registro: ";
            lblProfessorRG.Text = "RG: ";
            lblProfessorCPF.Text = "CPF: ";
            lblProfessorNome.Text = "Nome: ";

            txtEntradaPesquisaAluno.Clear();
            ckbMostrarNaoCursando.Checked = true;
            resgatarAlunos();

            string cursoSelecionado = cmbCurso.Text;
            //resgatarCursos();
            cmbCurso.SelectedIndex = cmbCurso.Items.IndexOf(cursoSelecionado);
            cmbFiltroProfessor.SelectedItem = cmbFiltroProfessor.Items.IndexOf("Registro");
            cmbFiltroPesquisaAluno.SelectedIndex = cmbFiltroPesquisaAluno.Items.IndexOf("RA");
        }
        
        private void cmbDadosCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Modo == "Criar")
                btnSalvar.Enabled = true; // Permite criar
            gpbAlunos.Enabled = true;
            resgatarAlunos();
        }

        private void cmbFiltroProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = cmbFiltroProfessor.SelectedItem.ToString().ToLower();

            cmbResultadosProfessor.Items.Clear();
            txtEntradaProfessor.Clear();

            // Preenche cmbResultadosProfessor com uma lista de dados do tipo filtro de todos professores
            List<usuarios.Professor> professores = new ExecutarDB().ListarProfessores(filtro, $"professores INNER JOIN usuarios ON user_id = usuarios.id ORDER BY {filtro} ASC", null);
            switch (filtro)
            {
                case "registro":
                    foreach (usuarios.Professor professor in professores)
                        cmbResultadosProfessor.Items.Add(professor.Registro);
                    break;
                case "rg":
                    foreach (usuarios.Professor professor in professores)
                        cmbResultadosProfessor.Items.Add(professor.RG);
                    break;
                case "cpf":
                    foreach (usuarios.Professor professor in professores)
                        cmbResultadosProfessor.Items.Add(professor.CPF);
                    break;
                case "nome":
                    foreach (usuarios.Professor professor in professores)
                        cmbResultadosProfessor.Items.Add(professor.Nome);
                    break;

            }
        }

        private void txtEntradaProfessor_TextChanged(object sender, EventArgs e)
        {
            cmbResultadosProfessor.Items.Clear();

            string filtro = cmbFiltroProfessor.SelectedItem.ToString().ToLower();
            string entrada = txtEntradaProfessor.Text;

            // Resgata os professores que correspondem a entrada do filtro inserido
            List<usuarios.Professor> professores;
            if (!String.IsNullOrWhiteSpace(entrada)) // Se estiver filtrando pela entrada
                professores = new ExecutarDB().ListarProfessores(filtro, "professores INNER JOIN usuarios ON user_id = usuarios.id", $"{filtro} ILIKE '{entrada}%' ORDER BY {filtro} ASC");
            else
                professores = new ExecutarDB().ListarProfessores(filtro, $"professores INNER JOIN usuarios ON user_id = usuarios.id ORDER BY {filtro} ASC", null);
            switch (filtro)
            {
                case "registro":
                    foreach (usuarios.Professor professor in professores)
                        cmbResultadosProfessor.Items.Add(professor.Registro);
                    break;
                case "rg":
                    foreach (usuarios.Professor professor in professores)
                        cmbResultadosProfessor.Items.Add(professor.RG);
                    break;
                case "cpf":
                    foreach (usuarios.Professor professor in professores)
                        cmbResultadosProfessor.Items.Add(professor.CPF);
                    break;
                case "nome":
                    foreach (usuarios.Professor professor in professores)
                        cmbResultadosProfessor.Items.Add(professor.Nome);
                    break;
            }
            
            // Preenche os campos se há correspondentes e há uma entrada
            if (cmbResultadosProfessor.Items.Count != 0 && !String.IsNullOrWhiteSpace(entrada))
                cmbResultadosProfessor.SelectedIndex = 0;
            else
            {
                // Limpar labels
                lblProfessorRegistro.Text = "Registro: ";
                lblProfessorRG.Text = "RG: ";
                lblProfessorCPF.Text = "CPF: ";
                lblProfessorNome.Text = "Nome: ";
            }
        }

        private void cmbResultadosProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Resgata dados do professor selecionado a partir do filtro e da entrada
            string filtro = cmbFiltroProfessor.SelectedItem.ToString().ToLower();
            usuarios.Professor primeiroDaLista = new ExecutarDB().ListarProfessores("registro, rg, cpf, nome", "professores INNER JOIN usuarios ON user_id = usuarios.id", $"{filtro} = '{cmbResultadosProfessor.SelectedItem}'")[0];
            lblProfessorRegistro.Text = "Registro: " + primeiroDaLista.Registro;
            lblProfessorRG.Text = "RG: " + primeiroDaLista.RG;
            lblProfessorCPF.Text = "CPF: " + primeiroDaLista.CPF;
            lblProfessorNome.Text = "Nome: " + primeiroDaLista.Nome;
        }

        private void txtEntradaProfessor_Leave(object sender, EventArgs e)
        {
            if (cmbResultadosProfessor.Items.Count != 0 && !String.IsNullOrWhiteSpace(txtEntradaProfessor.Text))
                txtEntradaProfessor.Text = cmbResultadosProfessor.Text;
        }

        private void ckbMostrarNaoCursando_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMostrarNaoCursando.Checked)
                for (int i = 0; i < dgvAlunos.RowCount; i++)
                    dgvAlunos.Rows[i].Visible = true;
            else
                for (int i = 0; i < dgvAlunos.RowCount; i++)
                    dgvAlunos.Rows[i].Visible = Convert.ToBoolean(dgvAlunos.Rows[i].Cells["Cursando"].Value);
        }

        private void txtEntradaPesquisaAluno_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEntradaPesquisaAluno.Text))
                for (int i = 0; i < dgvAlunos.RowCount; i++)
                    dgvAlunos.Rows[i].Visible = true;

            for (int i = 0; i < dgvAlunos.RowCount; i++)
                if (dgvAlunos.Rows[i].Cells[cmbFiltroPesquisaAluno.Text].Value.ToString().Contains(txtEntradaPesquisaAluno.Text))
                    dgvAlunos.Rows[i].Visible = true;
                else
                    dgvAlunos.Rows[i].Visible = false;
        }

        private void resgatarAlunos()
        {
            dgvAlunos.Rows.Clear();

            List<usuarios.Aluno> alunosDoCurso = new ExecutarDB().ListarAlunos("ra, nome, rg, cpf, alunos.id", "alunos INNER JOIN usuarios ON user_id = usuarios.id", $"curso = '{cmbDadosCurso.Text}' ORDER BY nome ASC");
            foreach (usuarios.Aluno aluno in alunosDoCurso)
            {
                var novaLinha = dgvAlunos.Rows.Add();
                dgvAlunos.Rows[novaLinha].Cells["Cursando"].Value = false;
                dgvAlunos.Rows[novaLinha].Cells["RA"].Value = aluno.RA;
                dgvAlunos.Rows[novaLinha].Cells["NomeAluno"].Value = aluno.Nome;
                dgvAlunos.Rows[novaLinha].Cells["RG"].Value = aluno.RG;
                dgvAlunos.Rows[novaLinha].Cells["CPF"].Value = aluno.CPF;
                dgvAlunos.Rows[novaLinha].Cells["ID"].Value = aluno.ID;
            }
        }
    }
}
