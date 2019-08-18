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
using SistemaAcademico.usuarios;

namespace SistemaAcademico.forms.Admin
{
    public partial class FormUsuarios : Form
    {

        public FormUsuarios()
        {
            InitializeComponent();

            // Deixa já selecionado opções nos ListBoxes e pesquisa
            cmbTipo.SelectedIndex = 0; // Todos Usuários
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTipo.Focus();
            cmbFiltro.Items.Clear();

            // Adiciona os filtros de cada tipo de usuário
            switch (cmbTipo.Text)
            {
                case "Administradores":
                    cmbFiltro.Items.Add("Cargo");
                    break;
                case "Alunos":
                    cmbFiltro.Items.AddRange(new string[] { "RA", "Curso" });
                    break;
                case "Professores":
                    cmbFiltro.Items.AddRange(new string[]
                        { "Registro", "Formação" });
                    break;
            }

            // Adiciona os filtros que são comuns a todos os usuários (ID (tipo inteiro) não pode 
            // ser usado no comando ILIKE do PostgreSQL, portanto não se pode filtrar por ele
            cmbFiltro.Items.AddRange(new string[]
                {"Nome", "RG", "CPF", "Telefone", "Email", "Login", "Senha"});

            // Seleciona um filtro pré-definido, dependendo do tipo de usuário
            switch (cmbTipo.Text)
            {
                case "Administradores":
                    cmbFiltro.SelectedIndex = cmbFiltro.Items.IndexOf("Cargo");
                    break;
                case "Alunos":
                    cmbFiltro.SelectedIndex = cmbFiltro.Items.IndexOf("RA");
                    break;
                case "Professores":
                    cmbFiltro.SelectedIndex = cmbFiltro.Items.IndexOf("Registro");
                    break;
                default:
                    cmbFiltro.SelectedIndex = cmbFiltro.Items.IndexOf("Nome");
                    break;
            }

            cmbFiltro.Enabled = true;
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFiltro.Focus();
            txtEntrada.Enabled = true;
            txtEntrada.ForeColor = Color.DarkGray;
            txtEntrada.Text = "Pesquise um(a) " + cmbFiltro.Text;
        }

        private void txtEntrada_Enter(object sender, EventArgs e)
        {
            if (txtEntrada.Text == "Pesquise um(a) " + cmbFiltro.Text)
            {
                txtEntrada.ForeColor = Color.Black;
                txtEntrada.Text = "";
            }
        }

        private void txtEntrada_Leave(object sender, EventArgs e)
        {
            if (txtEntrada.Text == "")
                cmbFiltro_SelectedIndexChanged(null, null);
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEntrada.Text) ||
                txtEntrada.Text == "Pesquise um(a) " + cmbFiltro.Text)
            {
                pesquisarUsuarios();
                return;
            }

            dgvResultados.UseWaitCursor = true;

            // Reatribui o DataSource do dgvResultados filtrando por ocorrências de txtEntrada.Text
            // na coluna cmbFiltro.Text.ToLower()
            switch (cmbTipo.Text)
            {
                case "Todos Usuários":
                    if (dgvResultados.RowCount == 0)
                        pesquisarUsuarios();
                    dgvResultados.DataSource = new ExecutarDB().ListarUsuarios(
                        "id, login, senha, rg, cpf, email, nome, telefone, tipo",
                        "usuarios",
                        $"{cmbFiltro.Text.ToLower()} ILIKE '{txtEntrada.Text}%' " +
                        $"ORDER BY {cmbFiltro.Text.ToLower()} ASC");
                    break;
                case "Administradores":
                    if (dgvResultados.RowCount == 0)
                        pesquisarUsuarios();
                    dgvResultados.DataSource = new ExecutarDB().ListarAdmins(
                        "administradores.id, cargo, login, rg, cpf, senha, email, nome, telefone",
                        "usuarios INNER JOIN administradores ON " +
                        "usuarios.id = administradores.user_id",
                        $"{cmbFiltro.Text.ToLower()} ILIKE '{txtEntrada.Text}%' " +
                        $"ORDER BY {cmbFiltro.Text.ToLower()} ASC");
                    break;
                case "Alunos":
                    if (dgvResultados.RowCount == 0)
                        pesquisarUsuarios();
                    dgvResultados.DataSource = new ExecutarDB().ListarAlunos(
                        "alunos.id, ra, curso, datamatricula, login, rg, cpf, senha, email, nome, telefone",
                        "usuarios INNER JOIN alunos ON " +
                        "usuarios.id = alunos.user_id",
                        $"{cmbFiltro.Text.ToLower()} ILIKE '{txtEntrada.Text}%' " +
                        $"ORDER BY {(cmbFiltro.Text == "Data Matrícula" ? "datamatricula" : cmbFiltro.Text.ToLower())} ASC");
                    break;
                case "Professores":
                    if (dgvResultados.RowCount == 0)
                        pesquisarUsuarios();
                    dgvResultados.DataSource = new ExecutarDB().ListarProfessores(
                        "professores.id, registro, formacao, login, senha, rg, cpf, email, nome, telefone",
                        "usuarios INNER JOIN professores ON " +
                        "usuarios.id = professores.user_id",
                        $"{cmbFiltro.Text.ToLower()} ILIKE '{txtEntrada.Text}%' " +
                        $"ORDER BY {(cmbFiltro.Text == "Formação" ? "formacao" : cmbFiltro.Text.ToLower())} ASC");
                    break;
            }

            dgvResultados.UseWaitCursor = false;
        }

        private void pesquisarUsuarios()
        {
            dgvResultados.UseWaitCursor = true;

            switch (cmbTipo.Text)
            {
                case "Todos Usuários":
                    dgvResultados.DataSource = new ExecutarDB().ListarUsuarios(
                        "*", $"usuarios ORDER BY {cmbFiltro.Text.ToLower()} ASC",
                        null);
                    dgvResultados.Columns["Tipo"].Visible = true;
                    break;
                case "Administradores":
                    dgvResultados.DataSource = new ExecutarDB().ListarAdmins(
                        "administradores.id, cargo, login, senha, rg, cpf, email, nome, telefone",
                        "usuarios INNER JOIN administradores ON " +
                        "usuarios.id = administradores.user_id " +
                        $"ORDER BY {cmbFiltro.Text.ToLower()} ASC", null);
                    dgvResultados.Columns["Tipo"].Visible = false;
                    break;
                case "Alunos":
                    dgvResultados.DataSource = new ExecutarDB().ListarAlunos(
                        "alunos.id, ra, curso, datamatricula, login, senha, rg, cpf, email, nome, telefone",
                        "usuarios INNER JOIN alunos ON " +
                        "usuarios.id = alunos.user_id " +
                        $"ORDER BY {(cmbFiltro.Text == "Data Matrícula" ? "datamatricula" : cmbFiltro.Text.ToLower())} ASC",
                        null);
                    dgvResultados.Columns["Tipo"].Visible = false;
                    break;
                case "Professores":
                    dgvResultados.DataSource = new ExecutarDB().ListarProfessores(
                        "professores.id, registro, formacao, login, senha, rg, cpf, email, nome, telefone",
                        "usuarios INNER JOIN professores ON " +
                        "usuarios.id = professores.user_id " +
                        $"ORDER BY {(cmbFiltro.Text == "Formação" ? "formacao" : cmbFiltro.Text.ToLower())} ASC", null);
                    dgvResultados.Columns["Tipo"].Visible = false;
                    break;
            }

            dgvResultados.UseWaitCursor = false;
        }

        // Formata as colunas para melhor vizualização
        private void formatarColunas()
        {
            // Formatação de colunas presentes em todos os tipos de usuários
            dgvResultados.Columns["ID"].Width = 60;
            dgvResultados.Columns["Login"].Width = 100;
            dgvResultados.Columns["Senha"].Width = 100;
            dgvResultados.Columns["Email"].Width = 125;
            dgvResultados.Columns["CPF"].Width = 130;
            dgvResultados.Columns["Nome"].MinimumWidth = 250;
            dgvResultados.Columns["Telefone"].Width = 130;
            dgvResultados.Columns["Login"].DisplayIndex = 0;
            dgvResultados.Columns["Senha"].DisplayIndex = 0;
            dgvResultados.Columns["Telefone"].DisplayIndex = 0;
            //dgvResultados.Columns["Email"].DisplayIndex = 0;
            dgvResultados.Columns["CPF"].DisplayIndex = 0;
            dgvResultados.Columns["RG"].DisplayIndex = 0;
            dgvResultados.Columns["Nome"].DisplayIndex = 0;
            dgvResultados.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvResultados.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvResultados.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            // Formatação de colunas específica dependendo do tipo de usuário
            switch (cmbTipo.Text)
            {
                case "Todos Usuários":
                    dgvResultados.Columns["ID"].HeaderText = "Usuário";
                    dgvResultados.Columns["Tipo"].DisplayIndex = 3;
                    break;
                case "Administradores":
                    dgvResultados.Columns["ID"].HeaderText = "Admin";
                    dgvResultados.Columns["Cargo"].DisplayIndex = 1;
                    break;
                case "Alunos":
                    dgvResultados.Columns["ID"].HeaderText = "Aluno";
                    dgvResultados.Columns["dataMatricula"].HeaderText = "Matrícula";
                    dgvResultados.Columns["RA"].Width = 100;
                    dgvResultados.Columns["Curso"].Width = 60;
                    dgvResultados.Columns["dataMatricula"].DisplayIndex = 4;
                    dgvResultados.Columns["RA"].DisplayIndex = 1;
                    dgvResultados.Columns["Curso"].DisplayIndex = 1;
                    break;
                case "Professores":
                    dgvResultados.Columns["ID"].HeaderText = "Prof.";
                    dgvResultados.Columns["Registro"].Width = 100;
                    dgvResultados.Columns["Formacao"].Width = 500;
                    dgvResultados.Columns["Registro"].DisplayIndex = 1;
                    dgvResultados.Columns["Formacao"].DisplayIndex = dgvResultados.Columns.Count - 1;
                    foreach (DataGridViewRow l in dgvResultados.Rows)
                        if (!String.IsNullOrWhiteSpace(l.Cells["Formacao"].Value.ToString()))
                            l.Cells["Formacao"].Value = l.Cells["Formacao"].Value.ToString().Replace("\n", " ");
                    break;
            }

            dgvResultados.Columns["ID"].DisplayIndex = 0;
            dgvResultados.Columns["Login"].DisplayIndex = dgvResultados.Columns.Count - 1;
            dgvResultados.Columns["Senha"].DisplayIndex = dgvResultados.Columns.Count - 1;

            //dgvResultados.Columns["ID"].Visible = false;
            
            // Formatação de dados que utilizam máscara
            foreach (DataGridViewRow l in dgvResultados.Rows)
            {
                l.Cells["RG"].Value = $"{l.Cells["RG"].Value.ToString().Substring(0, 2)}.{l.Cells["RG"].Value.ToString().Substring(1, 3)}.{l.Cells["RG"].Value.ToString().Substring(4, 3)}-{l.Cells["RG"].Value.ToString().Substring(8)}";
                l.Cells["CPF"].Value = $"{l.Cells["CPF"].Value.ToString().Substring(0, 3)}.{l.Cells["CPF"].Value.ToString().Substring(3, 3)}.{l.Cells["CPF"].Value.ToString().Substring(6, 3)}-{l.Cells["CPF"].Value.ToString().Substring(9)}";
                if (!String.IsNullOrWhiteSpace(l.Cells["Telefone"].Value.ToString()))
                    l.Cells["Telefone"].Value = $"({l.Cells["Telefone"].Value.ToString().Substring(0, 2)}) {l.Cells["Telefone"].Value.ToString().Substring(2, 5)}-{l.Cells["Telefone"].Value.ToString().Substring(7)}";
            }
        }

        private void dgvResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            habilitarBotoes();
        }

        private void dgvResultados_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            habilitarBotoes();
        }

        // Habilita o botão de alterar e excluir caso alguém seja selecionado
        private void habilitarBotoes()
        {
            // Retornar se todo mundo ou mais de uma pessoa (linha) for selecionada
            if (dgvResultados.AreAllCellsSelected(false)
                || dgvResultados.SelectedColumns.Count > 1)
            {
                return;
            }

            // Se há alguma célula selecionada
            if (dgvResultados.SelectedCells.Count != 0)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                string ID = // Valor da coluna ID da linha da célula(s) selecionada
                    dgvResultados.Rows[dgvResultados.SelectedCells[0].RowIndex]
                    .Cells["ID"].Value.ToString();
                btnAlterar.Text = "Alterar #" + ID;
                btnExcluir.Text = "Excluir #" + ID;
            }
            else
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnAlterar.Text = "Alterar";
                btnExcluir.Text = "Excluir";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro formcadastro = new FormCadastro();

            // Encontra o FormMenu pai e formata o novo FormCadastro para mostrar como MDI dele
            formcadastro.MdiParent = Application.OpenForms["FormMenu"];
            formcadastro.Dock = DockStyle.Fill;
            //Hide();
            formcadastro.TopMost = true;
            formcadastro.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celulas = // Resgata as células da linha da célula selecionada
                dgvResultados.Rows[dgvResultados.SelectedCells[0].RowIndex].Cells;
            FormCadastro formcadastro = new FormCadastro();

            // A classe/colunas de Usuario não consegue guardar todos os atributos de um
            // Admin, Aluno ou Usuario, por isso é preciso resgatar do BD
            // os outros atributos e instanciar a classe especificada no Tipo
            if (cmbTipo.Text == "Todos Usuários")
            {
                int idSelecionado = Convert.ToInt16(celulas["ID"].Value); // ID de usuário
                switch (celulas["Tipo"].Value.ToString())
                {
                    case "Administrador":
                        usuarios.Admin admin = new ExecutarDB().ListarAdmins(
                            "cargo", "administradores", $"user_id = {idSelecionado}")[0];
                        admin.ID = idSelecionado;
                        admin.Login = celulas["Login"].Value.ToString();
                        admin.Senha = celulas["Senha"].Value.ToString();
                        admin.RG = celulas["RG"].Value.ToString();
                        admin.CPF = celulas["CPF"].Value.ToString();
                        admin.Email = celulas["Email"].Value.ToString();
                        admin.Nome = celulas["Nome"].Value.ToString();
                        admin.Telefone = celulas["Telefone"].Value.ToString();
                        formcadastro = new FormCadastro(admin);
                        break;
                    case "Aluno":
                        usuarios.Aluno aluno = new ExecutarDB().ListarAlunos(
                            "ra, curso, datamatricula", "alunos", $"user_id = {idSelecionado}")[0];
                        aluno.ID = idSelecionado;
                        aluno.Login = celulas["Login"].Value.ToString();
                        aluno.Senha = celulas["Senha"].Value.ToString();
                        aluno.RG = celulas["RG"].Value.ToString();
                        aluno.CPF = celulas["CPF"].Value.ToString();
                        aluno.Email = celulas["Email"].Value.ToString();
                        aluno.Nome = celulas["Nome"].Value.ToString();
                        aluno.Telefone = celulas["Telefone"].Value.ToString();
                        formcadastro = new FormCadastro(aluno);
                        break;
                    case "Professor":
                        usuarios.Professor professor = new ExecutarDB().ListarProfessores(
                            "registro, formacao", "professores", $"user_id = {idSelecionado}")[0];
                        professor.ID = idSelecionado;
                        professor.Login = celulas["Login"].Value.ToString();
                        professor.Senha = celulas["Senha"].Value.ToString();
                        professor.RG = celulas["RG"].Value.ToString();
                        professor.CPF = celulas["CPF"].Value.ToString();
                        professor.Email = celulas["Email"].Value.ToString();
                        professor.Nome = celulas["Nome"].Value.ToString();
                        professor.Telefone = celulas["Telefone"].Value.ToString();
                        formcadastro = new FormCadastro(professor);
                        break;
                }
            }

            // Resgata o tipo de usuário e instancia esse tipo com os dados
            switch (cmbTipo.Text)
            {
                case "Administradores":
                    usuarios.Admin admin = new usuarios.Admin(
                        celulas["Login"].Value.ToString(),
                        celulas["Senha"].Value.ToString(),
                        celulas["RG"].Value.ToString(),
                        celulas["CPF"].Value.ToString(),
                        celulas["Email"].Value.ToString(),
                        celulas["Nome"].Value.ToString(),
                        celulas["Telefone"].Value.ToString(),
                        celulas["Cargo"].Value.ToString()
                    );
                    admin.ID = new ExecutarDB().ListarUsuarios("user_id", "administradores",
                        $"id = {celulas["ID"].Value.ToString()}")[0].ID;
                    formcadastro = new FormCadastro(admin);
                    break;
                case "Alunos":
                    usuarios.Aluno aluno = new usuarios.Aluno(
                        celulas["Login"].Value.ToString(),
                        celulas["Senha"].Value.ToString(),
                        celulas["RG"].Value.ToString(),
                        celulas["CPF"].Value.ToString(),
                        celulas["Email"].Value.ToString(),
                        celulas["Nome"].Value.ToString(),
                        celulas["Telefone"].Value.ToString(),
                        celulas["RA"].Value.ToString(),
                        celulas["Curso"].Value.ToString(),
                        Convert.ToDateTime(celulas["dataMatricula"].Value)
                    );
                    aluno.ID = new ExecutarDB().ListarUsuarios("user_id", "alunos",
                         $"id = {celulas["ID"].Value.ToString()}")[0].ID;
                    formcadastro = new FormCadastro(aluno);
                    break;
                case "Professores":
                    usuarios.Professor professor = new usuarios.Professor(
                        celulas["Login"].Value.ToString(),
                        celulas["Senha"].Value.ToString(),
                        celulas["RG"].Value.ToString(),
                        celulas["CPF"].Value.ToString(),
                        celulas["Email"].Value.ToString(),
                        celulas["Nome"].Value.ToString(),
                        celulas["Telefone"].Value.ToString(),
                        celulas["Registro"].Value.ToString(),
                        celulas["Formacao"].Value.ToString()
                    );
                    professor.ID = new ExecutarDB().ListarUsuarios("user_id", "professores",
                         $"id = {celulas["ID"].Value.ToString()}")[0].ID;
                    formcadastro = new FormCadastro(professor);
                    break;
            }

            // Encontra o FormMenu pai e formata o novo FormCadastro para mostrar como MDI dele
            formcadastro.MdiParent = Application.OpenForms["FormMenu"];
            formcadastro.Dock = DockStyle.Fill;
            //Hide();
            formcadastro.TopMost = true;
            formcadastro.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection selecionado =
                dgvResultados.Rows[dgvResultados.SelectedCells[0].RowIndex].Cells;

            if (MessageBox.Show(null, "Deseja excluir " + selecionado["Nome"].Value + "?",
                "Excluindo #" + selecionado["ID"].Value, MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            Enabled = false;

            if (cmbTipo.Text == "Todos Usuários")
            {
                // Caso o dgvResultados esteja com a fonte de dados da tabela usuarios
                // O ID de usuário já está disponível, portanto só resta usá-lo para
                // deletar na tabela usuarios e na tabela do tipo do usuario
                new ExecutarDB().Executar("DELETE FROM usuarios " +
                    $"WHERE id = {selecionado["ID"].Value.ToString()}");
                switch (selecionado["Tipo"].Value.ToString())
                {
                    case "Administradores":
                        new ExecutarDB().Executar("DELETE FROM administradores " +
                            $"WHERE id = {selecionado["ID"].Value.ToString()}");
                        break;
                    case "Alunos":
                        new ExecutarDB().Executar("DELETE FROM alunos " +
                            $"WHERE id = {selecionado["ID"].Value.ToString()}");
                        break;
                    case "Professores":
                        new ExecutarDB().Executar("DELETE FROM professores " +
                            $"WHERE id = {selecionado["ID"].Value.ToString()}");
                        break;
                }
            }
            else
            {
                // Pega o user_id da tabela do tipo do usuário, que é encontrada
                // na tabela usuarios (como id) e na do tipo do usuário (como user_id), 
                // permitindo deletar nas duas tabelas
                int idUsuario = (int)new ExecutarDB().Executar("SELECT user_id " +
                    $"FROM {cmbTipo.Text.ToLower()} " +
                    $"WHERE id = {selecionado["ID"].Value.ToString()}");
                new ExecutarDB().Executar($"DELETE FROM {cmbTipo.Text.ToLower()} " +
                    $"WHERE user_id =  {idUsuario}");
                new ExecutarDB().Executar("DELETE FROM usuarios " +
                    $"WHERE id = {idUsuario}");
            }

            Enabled = true;

            dgvResultados.ClearSelection();
            habilitarBotoes();

            // Atualiza o dgvResultados com os dados atualizados
            txtEntrada.Text = "";
            pesquisarUsuarios();
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterar_Click(null, null);
        }

        private void dgvResultados_DataSourceChanged(object sender, EventArgs e)
        {
            formatarColunas();
        }

        private void FormUsuarios_VisibleChanged(object sender, EventArgs e)
        {
            pesquisarUsuarios();
        }
    }
}
