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
    public partial class FormNotas : Form
    {
        private string siglaMateria; // Usado para ser encontrado no banco de dados

        public FormNotas()
        {
            InitializeComponent();
            resgatarCursos();
        }

        // Preenche o cmbCurso
        private void resgatarCursos()
        {
            cmbCurso.Items.Clear();
            foreach (Curso curso in new ExecutarDB().ListarCursos("sigla", "cursos", null))
            {
                cmbCurso.Items.Add(curso.Sigla);
            }
            cmbCurso.Enabled = true;
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCancelar_Click(null, null);
            cmbMaterias.Items.Clear();

            // Resgata todos as matérias do curso selecionado no cmbCurso e preenche no cmbMaterias
            foreach (Materia materia in new ExecutarDB().ListarMaterias("nome", "materias", $"curso = '{cmbCurso.Text}' ORDER BY nome ASC"))
                cmbMaterias.Items.Add(materia.Nome);

            cmbMaterias.Enabled = true;

            dgvNotasAlunos.Enabled = false;
            gpbNotasPesos.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCancelar_Click(null, null); // Reinicia os DataGridViews

            // Resgata os alunos, notas, pesos, notas dos alunos da matéria e preenche
            Materia materia = new ExecutarDB().ListarMaterias("sigla, notas, pesos, estudantes_id", "materias", $"curso = '{cmbCurso.Text}' AND nome = '{cmbMaterias.Text}'")[0];
            siglaMateria = materia.Sigla;
            // Notas e pesos
            for (int i = 0; i < materia.Notas.Length; i++)
            {
                dgvNotasPesos.Rows.Add(materia.Notas[i], materia.Pesos[i], i);
                dgvNotasAlunos.Columns.Add(materia.Notas[i].Replace(' ', '_'), materia.Notas[i]);
                dgvNotasAlunos.Columns[materia.Notas[i].Replace(' ', '_')].Width = 50;
            }
            for (int i = 0; i < materia.Estudantes.Length; i++)
            {
                if (materia.Estudantes[i] == 0) break;

                // Alunos da matéria
                usuarios.Aluno estudante = new ExecutarDB().ListarAlunos("ra, nome", "alunos INNER JOIN usuarios ON user_id = usuarios.id", $"alunos.id = '{materia.Estudantes[i]}'")[0];
                dgvNotasAlunos.Rows.Add(estudante.RA, estudante.Nome);

                // Notas dos alunos
                List<Nota> notasDoEstudante = new ExecutarDB().ListarNotas("num_nota, valor", "notas",
                    $"curso = '{cmbCurso.Text}' AND estudante_id = '{materia.Estudantes[i]}' AND materia = '{siglaMateria}' ORDER BY num_nota ASC");
                for (int j = 0; j < notasDoEstudante.Count; j++)
                    dgvNotasAlunos[notasDoEstudante[j].NumeroDaNota + 3, i].Value = notasDoEstudante[j].Valor;

            }

            calcularMedia();

            dgvNotasAlunos.Enabled = true;
            gpbNotasPesos.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Atualiza pesos e notas
            string[] notas = new string[dgvNotasPesos.RowCount];
            float[] pesos = new float[dgvNotasPesos.RowCount];

            for (int i = 0; i < dgvNotasPesos.RowCount; i++)
            {
                notas[i] = dgvNotasPesos.Rows[i].Cells["NomeNota"].Value.ToString();
                pesos[i] = Convert.ToSingle(dgvNotasPesos.Rows[i].Cells["Peso"].Value);
            }
            new ExecutarDB().Executar("UPDATE materias SET notas = " + (notas.Length != 0 ? "'{\"" + String.Join("\", \"", notas) + "\"}', " : "NULL, ") +
                "pesos = " + (pesos.Length != 0 ? "'{" + String.Join("- ", pesos).Replace(',', '.').Replace('-', ',') + "}' " : "NULL ") +
                $"WHERE curso = '{cmbCurso.Text}' AND sigla = '{siglaMateria}'");

            // Atualiza notas de cada aluno
            new ExecutarDB().Executar($"DELETE FROM notas WHERE curso = '{cmbCurso.Text}' AND materia = '{siglaMateria}'"); // Deleta todas as notas
            for (int l = 0; l < dgvNotasAlunos.RowCount; l++)
            {
                int idAluno = new ExecutarDB().ListarAlunos("id", "alunos", $"ra = '{dgvNotasAlunos["RA", l].Value}'")[0].ID;
                for (int n = 3; n < dgvNotasAlunos.ColumnCount; n++) // Cada nota
                    if (dgvNotasAlunos[n, l].Value != null) // Se existir uma nota
                        new ExecutarDB().Executar($"INSERT INTO notas VALUES ('{cmbCurso.Text}', {idAluno}, '{siglaMateria}', {n - 3}, {dgvNotasAlunos[n, l].Value})");
            }

            btnCancelar_Click(null, null);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;

            // Limpa as notas dos alunos
            dgvNotasAlunos.Rows.Clear();
            for (int i = 0; i < dgvNotasPesos.RowCount; i++) // Limpa as colunas de notas
                dgvNotasAlunos.Columns.Remove(dgvNotasPesos.Rows[i].Cells["NomeNota"].Value.ToString());

            // Limpa as notas e pesos da matéria do dgvNotasPesos
            dgvNotasPesos.Rows.Clear();
        }

        private void btnAdicionarNota_Click(object sender, EventArgs e)
        {
            if (dgvNotasPesos.SelectedCells.Count != 0)
            {
                // Remover nota
                string nota = dgvNotasPesos.Rows[dgvNotasPesos.SelectedCells[0].RowIndex].Cells["NomeNota"].Value.ToString();
                dgvNotasPesos.Rows.RemoveAt(dgvNotasPesos.SelectedCells[0].RowIndex);
                dgvNotasAlunos.Columns.Remove(nota.Replace(' ', '_'));
                btnAdicionarNota.Text = "+";
            }
            else if (!String.IsNullOrWhiteSpace(txtNomeNota.Text))
            {
                // Adicionar nova nota
                for (int i = 0; i < dgvNotasPesos.RowCount; i++)
                    if (dgvNotasPesos.Rows[i].Cells["NomeNota"].Value.ToString() == txtNomeNota.Text)
                        return;
                dgvNotasPesos.Rows.Add(txtNomeNota.Text, "0,00");
                dgvNotasAlunos.Columns.Add(txtNomeNota.Text.Replace(' ', '_'), txtNomeNota.Text);
            }

            txtNomeNota.Clear();
            txtNomeNota.Focus();
        }

        private void dgvNotasPesos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdicionarNota.Text = "-";
        }

        private void txtNomeNota_TextChanged(object sender, EventArgs e)
        {
            dgvNotasPesos.ClearSelection();
            btnAdicionarNota.Text = "+";
        }

        private void dgvNotasPesos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calcularMedia();
        }

        private void dgvNotasAlunos_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dgvNotasAlunos.Columns["MediaFinal"].DisplayIndex = dgvNotasAlunos.ColumnCount - 1;
        }

        private void dgvNotasAlunos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 2)
            {
                try
                {
                    float teste = Convert.ToSingle(dgvNotasAlunos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                } catch
                {
                    dgvNotasAlunos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0,00";
                }
                calcularMedia(e.RowIndex);
            }
        }

        // Calcula a média de todos os alunos
        private void calcularMedia()
        {
            float[] pesos = new float[dgvNotasPesos.RowCount];

            for (int i = 0; i < dgvNotasPesos.RowCount; i++)
            {
                try
                {
                    pesos[i] = Convert.ToSingle(dgvNotasPesos.Rows[i].Cells["Peso"].Value.ToString());
                } catch
                {
                    dgvNotasPesos.Rows[i].Cells["Peso"].Value = "0,00";
                    pesos[i] = 0;
                }
            }

            for (int i = 0; i < dgvNotasAlunos.RowCount; i++)
            {
                float media = 0;

                // Soma de todas as notas multiplicadas pelo seus pesos
                for (int j = 3; j < dgvNotasAlunos.ColumnCount; j++)
                {
                    try
                    {
                        media += Convert.ToSingle(dgvNotasAlunos.Rows[i].Cells[j].Value.ToString()) * pesos[j - 3];
                    } catch
                    {
                        //dgvNotasAlunos.Rows[i].Cells[j].Value = "0,00";
                    }
                }

                // Atribuição da média final
                dgvNotasAlunos.Rows[i].Cells["MediaFinal"].Value = media;
            }
        }

        // Calcula a média de um aluno (linha) no dgvNotasAlunos
        private void calcularMedia(int linha)
        {
            float[] pesos = new float[dgvNotasPesos.RowCount];

            for (int i = 0; i < dgvNotasPesos.RowCount; i++)
            {
                try
                {
                    pesos[i] = Convert.ToSingle(dgvNotasPesos.Rows[i].Cells["Peso"].Value.ToString());
                }
                catch
                {
                    dgvNotasPesos.Rows[i].Cells["Peso"].Value = "0,00";
                    pesos[i] = 0;
                }
            }

            float media = 0;
            for (int j = 3; j < dgvNotasAlunos.ColumnCount; j++)
            {
                try
                {
                    media += Convert.ToSingle(dgvNotasAlunos.Rows[linha].Cells[j].Value.ToString()) * pesos[j - 3];
                } catch
                {
                    //dgvNotasAlunos.Rows[linha].Cells[j].Value = "0,00";
                }
            }

            // Atribuição da média final
            dgvNotasAlunos.Rows[linha].Cells["MediaFinal"].Value = media;
        }
    }
}
