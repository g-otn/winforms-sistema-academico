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
    public partial class FormCadastro : Form
    {
        // Guarda o "modo" que este form está, para o botão de cadastrar não abrir
        // o form que está alterando e o botão de alterar não abrir o form que está cadastrando
        public string Modo = "Alterar";
        private int idUsuario; // Guarda o user_id

        public FormCadastro()
        {
            InitializeComponent();
            Modo = "Cadastrar";
            lblTitulo.Text = Modo;
            btnConfirmar.Text = "Confirmar";
        }

        public FormCadastro(usuarios.Admin admin)
        {
            InitializeComponent();
            lblTitulo.Text = Modo;
            cmbTipoUsuario.Enabled = false;
            cmbTipoUsuario.SelectedIndex = 0;

            idUsuario = admin.ID;
            txtLogin.Text = admin.Login;
            txtSenha.Text = admin.Senha;
            mtxtRG.Text = admin.RG; // O MaskedTextBox os remove os símbolos "." e "-"
            mtxtCPF.Text = admin.CPF; // O MaskedTextBox os remove os símbolos "." e "-" 
            txtEmail.Text = admin.Email;
            txtNome.Text = admin.Nome;
            mtxtTelefone.Text = admin.Telefone; // O MaskedTextBox os remove os símbolos "(", ")" e "-"
            txtCargo.Text = admin.Cargo;
        }

        public FormCadastro(usuarios.Aluno aluno)
        {
            InitializeComponent();
            lblTitulo.Text = Modo;
            cmbTipoUsuario.Enabled = false;
            cmbTipoUsuario.SelectedIndex = 1;

            idUsuario = aluno.ID;
            txtLogin.Text = aluno.Login;
            txtSenha.Text = aluno.Senha;
            mtxtRG.Text = aluno.RG; // O MaskedTextBox os remove os símbolos "." e "-"
            mtxtCPF.Text = aluno.CPF; // O MaskedTextBox os remove os símbolos "." e "-" 
            txtEmail.Text = aluno.Email;
            txtNome.Text = aluno.Nome;
            mtxtTelefone.Text = aluno.Telefone; // O MaskedTextBox os remove os símbolos "(", ")" e "-"
            mtxtRA.Text = aluno.RA;
            cmbCurso.Text = aluno.Curso;
            dtpDataMatricula.Value = aluno.dataMatricula;
        }

        public FormCadastro(usuarios.Professor professor)
        {
            InitializeComponent();
            lblTitulo.Text = Modo;
            cmbTipoUsuario.Enabled = false;
            cmbTipoUsuario.SelectedIndex = 2;

            idUsuario = professor.ID;
            txtLogin.Text = professor.Login;
            txtSenha.Text = professor.Senha;
            mtxtRG.Text = professor.RG; // O MaskedTextBox os remove os símbolos "." e "-"
            mtxtCPF.Text = professor.CPF; // O MaskedTextBox os remove os símbolos "." e "-" 
            txtEmail.Text = professor.Email;
            txtNome.Text = professor.Nome;
            mtxtTelefone.Text = professor.Telefone; // O MaskedTextBox os remove os símbolos "(", ")" e "-"
            mtxtRegistro.Text = professor.Registro;
            txtFormacao.Text = professor.Formacao;
        }

        // Gerencia os campos que devem ser exibidos dependendo do tipo de usuário
        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipoUsuario.SelectedItem) {
                case "Administrador":
                    gpbAluno.Enabled = false;
                    gpbAluno.Visible = false;
                    gpbProfessor.Enabled = false;
                    gpbProfessor.Visible = false;
                    gpbAdmin.Enabled = true;
                    gpbAdmin.Visible = true;
                    break;
                case "Aluno":
                    gpbAdmin.Enabled = false;
                    gpbAdmin.Visible = false;
                    gpbProfessor.Enabled = false;
                    gpbProfessor.Visible = false;
                    gpbAluno.Enabled = true;
                    gpbAluno.Visible = true;
                    cmbCurso.Items.Clear();
                    List<Curso> siglas = new ExecutarDB().ListarCursos("sigla", "cursos", null);
                    for (int i = 0; i < siglas.Count; i++)
                        cmbCurso.Items.Add(siglas[i].Sigla);
                    break;
                case "Professor":
                    gpbAdmin.Enabled = false;
                    gpbAdmin.Visible = false;
                    gpbAluno.Enabled = false;
                    gpbAluno.Visible = false;
                    gpbProfessor.Enabled = true;
                    gpbProfessor.Visible = true;
                    break;
            }
            btnConfirmar.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Substituição opcional de Login e Senha
            if (String.IsNullOrWhiteSpace(txtLogin.Text)
                && String.IsNullOrWhiteSpace(txtSenha.Text)
                && MessageBox.Show(null, "Login e Senha vazios, deseja usar o RG" +
                " como login e o CPF como senha?", "Aviso", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
            {
                txtLogin.Text = mtxtRG.Text;
                txtSenha.Text = mtxtCPF.Text;
            }
            else if (String.IsNullOrWhiteSpace(txtLogin.Text)
                && MessageBox.Show(null, "Login vazio, deseja usar o RG como login?",
                    "Aviso", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                txtLogin.Text = mtxtRG.Text;
            else if (String.IsNullOrWhiteSpace(txtSenha.Text)
                && MessageBox.Show(null, "Senha vazia, deseja usar o CPF como senha?",
                    "Aviso", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                txtSenha.Text = mtxtCPF.Text;

            // Validação de dados de usuário
            if (!mtxtRG.MaskCompleted)
                mtxtRG.BackColor = Color.FromArgb(255, 192, 192);
            else mtxtRG.BackColor = SystemColors.Window;
            if (!mtxtCPF.MaskCompleted)
                mtxtCPF.BackColor = Color.FromArgb(255, 192, 192);
            else mtxtCPF.BackColor = SystemColors.Window;
            if (String.IsNullOrWhiteSpace(txtNome.Text))
                txtNome.BackColor = Color.FromArgb(255, 192, 192);
            else txtNome.BackColor = SystemColors.Window;
            if (!String.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@"))
                txtEmail.BackColor = Color.FromArgb(255, 192, 192);
            else txtNome.BackColor = SystemColors.Window;

            switch (cmbTipoUsuario.SelectedItem) {
                case "Administrador":
                    // Validação de dados de administrador
                    if (String.IsNullOrWhiteSpace(txtCargo.Text))
                    {
                        txtCargo.BackColor = Color.FromArgb(255, 192, 192);
                        MessageBox.Show(null, "Alguns dados estão incorretos ou incompletos, por favor verificá-los", "Erro ao cadastrar");
                        return;
                    }
                    else txtCargo.BackColor = SystemColors.Window;
                    if (!mtxtRG.MaskCompleted || !mtxtCPF.MaskCompleted
                        || String.IsNullOrWhiteSpace(txtNome.Text) ||
                        (!String.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@")))
                    {
                        MessageBox.Show(null, "Alguns dados estão incorretos ou incompletos, por favor verificá-los", "Erro ao cadastrar");
                        return;
                    }

                    // Inserção ou Atualização de dados de administrador
                    if (Modo == "Cadastrar")
                    {
                        // Cadastro de novo usuário admin
                        usuarios.Admin admin = new usuarios.Admin();
                        admin.Login = txtLogin.Text;
                        admin.Senha = txtSenha.Text;
                        admin.RG = mtxtRG.Text;
                        admin.CPF = mtxtCPF.Text;
                        admin.Email = txtEmail.Text;
                        admin.Nome = txtNome.Text;
                        admin.Telefone = mtxtTelefone.Text;
                        admin.Cargo = txtCargo.Text;

                        switch (admin.Cadastrar())
                        {
                            case 0:
                                Close();
                                break;
                            case 1:
                                MessageBox.Show("Login e Email em uso");
                                break;
                            case 2:
                                MessageBox.Show("Login em uso");
                                break;
                            case 3:
                                MessageBox.Show("Email em uso");
                                break;
                        }
                    } else
                    {
                        // Alteração de dados de usuário admin existente
                        new ExecutarDB().Executar("UPDATE usuarios SET " +
                            $"login = '{txtLogin.Text}', senha = '{txtSenha.Text}', " +
                            $"rg = '{mtxtRG.Text}', cpf = '{mtxtCPF.Text}', " +
                            $"email = '{txtEmail.Text}', nome = '{txtNome.Text}', " +
                            $"telefone = '{mtxtTelefone.Text}' " +
                            $"WHERE id = {idUsuario}");
                        new ExecutarDB().Executar("UPDATE administradores SET " +
                            $"cargo = '{txtCargo.Text}'");
                        Close();
                    }
                    break;
                case "Aluno":
                    // Validação de dados de aluno
                    if (!mtxtRA.MaskCompleted || cmbCurso.SelectedIndex == -1)
                    {
                        if (!mtxtRA.MaskCompleted)
                            mtxtRA.BackColor = Color.FromArgb(255, 192, 192);
                        else mtxtRA.BackColor = SystemColors.Window;
                        if (cmbCurso.SelectedIndex == -1)
                            cmbCurso.BackColor = Color.FromArgb(255, 192, 192);
                        else cmbCurso.BackColor = SystemColors.Window;
                        MessageBox.Show(null, "Alguns dados estão incorretos ou incompletos, por favor verificá-los", "Erro ao cadastrar");
                        return;
                    }
                    if (!mtxtRG.MaskCompleted || !mtxtCPF.MaskCompleted
                        || String.IsNullOrWhiteSpace(txtNome.Text) ||
                        (!String.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@")))
                    {
                        MessageBox.Show(null, "Alguns dados estão incorretos ou incompletos, por favor verificá-los", "Erro ao cadastrar");
                        return;
                    }
                    
                    // Inserção ou Atualização de dados de aluno
                    if (Modo == "Cadastrar")
                    {
                        // Cadastro de novo usuário aluno
                        usuarios.Aluno aluno = new usuarios.Aluno();
                        aluno.Login = txtLogin.Text;
                        aluno.Senha = txtSenha.Text;
                        aluno.RG = mtxtRG.Text;
                        aluno.CPF = mtxtCPF.Text;
                        aluno.Email = txtEmail.Text;
                        aluno.Nome = txtNome.Text;
                        aluno.Telefone = mtxtTelefone.Text;
                        aluno.RA = mtxtRA.Text;
                        aluno.Curso = cmbCurso.SelectedItem.ToString();
                        aluno.dataMatricula = dtpDataMatricula.Value;

                        switch (aluno.Cadastrar())
                        {
                            case 0:
                                Close();
                                break;
                            case 1:
                                MessageBox.Show("Login e Email em uso");
                                break;
                            case 2:
                                MessageBox.Show("Login em uso");
                                break;
                            case 3:
                                MessageBox.Show("Email em uso");
                                break;
                        }
                    }
                    else
                    {
                        // Alteração de dados de usuário aluno existente
                        new ExecutarDB().Executar("UPDATE usuarios SET " +
                            $"login = '{txtLogin.Text}', senha = '{txtSenha.Text}', " +
                            $"rg = '{mtxtRG.Text}', cpf = '{mtxtCPF.Text}', " +
                            $"email = '{txtEmail.Text}', nome = '{txtNome.Text}', " +
                            $"telefone = '{mtxtTelefone.Text}' " +
                            $"WHERE id = {idUsuario}");
                        new ExecutarDB().Executar("UPDATE alunos SET " +
                            $"ra = '{mtxtRA.Text}', " +
                            $"curso = '{cmbCurso.SelectedItem.ToString()}', " +
                            $"datamatricula = '{dtpDataMatricula.Value}' " +
                            $"WHERE user_id = {idUsuario}");
                        Close();
                    }
                    break;
                case "Professor":
                    // Validação de dados de professor
                    if (!mtxtRegistro.MaskCompleted)
                    {
                        mtxtRegistro.BackColor = Color.FromArgb(255, 192, 192);
                        MessageBox.Show(null, "Alguns dados estão incorretos ou incompletos, por favor verificá-los", "Erro ao cadastrar");
                        return;
                    } else mtxtRegistro.BackColor = SystemColors.Window;
                    if (!mtxtRG.MaskCompleted || !mtxtCPF.MaskCompleted
                        || String.IsNullOrWhiteSpace(txtNome.Text) ||
                        (!String.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@")))
                    {
                        MessageBox.Show(null, "Alguns dados estão incorretos ou incompletos, por favor verificá-los", "Erro ao cadastrar");
                        return;
                    }

                    // Inserção ou Atualização de dados de professor
                    if (Modo == "Cadastrar")
                    {
                        // Cadastro de novo usuário aluno
                        usuarios.Professor professor = new usuarios.Professor();
                        professor.Login = txtLogin.Text;
                        professor.Senha = txtSenha.Text;
                        professor.RG = mtxtRG.Text;
                        professor.CPF = mtxtCPF.Text;
                        professor.Email = txtEmail.Text;
                        professor.Nome = txtNome.Text;
                        professor.Telefone = mtxtTelefone.Text;
                        professor.Registro = mtxtRegistro.Text;
                        professor.Formacao = txtFormacao.Text;

                        switch (professor.Cadastrar())
                        {
                            case 0:
                                Close();
                                break;
                            case 1:
                                MessageBox.Show("Login e Email em uso");
                                break;
                            case 2:
                                MessageBox.Show("Login em uso");
                                break;
                            case 3:
                                MessageBox.Show("Email em uso");
                                break;
                        }
                    }
                    else
                    {
                        // Alteração de dados de usuário admin existente
                        new ExecutarDB().Executar("UPDATE usuarios SET " +
                            $"login = '{txtLogin.Text}', senha = '{txtSenha.Text}', " +
                            $"rg = '{mtxtRG.Text}', cpf = '{mtxtCPF.Text}', " +
                            $"email = '{txtEmail.Text}', nome = '{txtNome.Text}', " +
                            $"telefone = '{mtxtTelefone.Text}' " +
                            $"WHERE id = {idUsuario}");
                        new ExecutarDB().Executar("UPDATE professores SET " +
                            $"registro = '{mtxtRegistro.Text}', " +
                            $"formacao = '{txtFormacao.Text}' " +
                            $"WHERE user_id = {idUsuario}");
                        Close();
                    }
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
