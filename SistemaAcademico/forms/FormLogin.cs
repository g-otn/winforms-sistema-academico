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

namespace SistemaAcademico.forms
{
    public partial class FormLogin : Form
    {
        public string[] infoLogin = new string[3]{null, null, null}; // Guarda que tipo de usuário entrou e seu nome

        public FormLogin()
        {
            InitializeComponent();
            txtLogin.Focus();
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Email ou Usuário")
            {
                txtLogin.Text = "";
                txtLogin.ForeColor = Color.Black;
                txtLogin.BackColor = Color.White;
                panLogin.BackColor = Color.White;
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "Email ou Usuário";
                txtLogin.ForeColor = Color.Gray;
                txtLogin.BackColor = Color.FromArgb(245, 245, 245);
                panLogin.BackColor = Color.FromArgb(245, 245, 245);
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha" || txtSenha.Text == "")
            {
                txtSenha.UseSystemPasswordChar = true;
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
                txtSenha.BackColor = Color.White;
                panSenha.BackColor = Color.White;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.UseSystemPasswordChar = false;
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Gray;
                txtSenha.BackColor = Color.FromArgb(245, 245, 245);
                panSenha.BackColor = Color.FromArgb(245, 245, 245);
            }
        }

        private void panLogin_Click(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }

        private void panSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Focus();
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Entrar();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Entrar();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void Entrar()
        {
            string login = txtLogin.Text.Trim();
            string senha = txtSenha.Text;

            if ((login == "" || login == "Email ou Usuário")
                && (senha == "" || senha == "Senha"))
            {
                MessageBox.Show("Por favor insira um login e senha!");
                return;
            }
            else if (login == "" || login == "Email ou Usuário")
            {
                MessageBox.Show("Por favor insira um login!");
                return;
            } else if (senha == "" || senha == "Senha")
            {
                MessageBox.Show("Por favor insira uma senha!");
                return;
            }

            // Pesquisa no BD um usuário com o mesmo login/email e senha,
            // resgatando o primeiro usuário (deve sempre haver somente 1)
            // da lista retornada
            List<Usuario> usuario = new ExecutarDB().ListarUsuarios(
                "id, nome, tipo", "usuarios", 
                $"(login = '{login}' AND senha = '{senha}') OR " +
                $"(email = '{login}' AND email IS NOT NULL AND senha = '{senha}')"
            );
            if (usuario.Count != 0) // Se existe um usuário com esse login
            { 
                infoLogin = new string[3] { usuario[0].Tipo, usuario[0].Nome, usuario[0].ID.ToString() }; // Marca qual Menu deve abrir
                Close(); // Fechar tela de login para abrir o FormMenu (no Program.cs)
            } else
                MessageBox.Show("Login e/ou senha incorretos!");
        }
    }
}
