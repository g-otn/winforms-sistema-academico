using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaAcademico.forms.Admin;
using SistemaAcademico.usuarios;

namespace SistemaAcademico.forms.Aluno
{
    public partial class FormMenu : Form
    {
        private int IDlogado;

        public FormMenu(string ID, string nomeUsuario)
        {
            InitializeComponent();

            IDlogado = Convert.ToInt32(ID);

            // Formata o nome do usuario conectado (Transforma: João da Silva em João da S.)
            if (nomeUsuario.Split(' ').Length > 1) // Se possuir sobrenomes
            {
                string[] partesNome = nomeUsuario.Split(' ');
                nomeUsuario = partesNome[0];
                for (int i = 1; i < partesNome.Length; i++)
                {
                    if (partesNome[i][0] != partesNome[i].ToLower()[0]) // Se é sobrenome
                        nomeUsuario += " " + partesNome[i][0] + ".";
                    else nomeUsuario += " " + partesNome[i];
                }
            }
            lblUsuarioNome.Text = nomeUsuario;

            // Vai para a página principal (FormHome)
            btnNotas_Click(null, null);
        }

        // Volta as cores dos botões ao original e colore o botão que foi selecionado
        void colorirBotoes(Button selecionado)
        {
            foreach (Button botao in panMenu.Controls.OfType<Button>())
            {
                if (botao.Name != selecionado.Name)
                    botao.BackColor = Color.FromArgb(60, 70, 80);
                else
                    botao.BackColor = Color.DarkCyan;
            }
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            colorirBotoes(btnNotas);
            Text = "Minhas Notas - Sistema Acadêmico";
            if (formEstaAberto("FormNotas")) return;

            // Iniciar FormNotas
            FormMinhasNotas formnotas = new FormMinhasNotas(IDlogado);
            formnotas.MdiParent = this;
            formnotas.Dock = DockStyle.Fill;
            formnotas.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Impede de abrir mais de um do mesmo Form
        private bool formEstaAberto(string nome)
        {
            foreach (Form filho in MdiChildren)
            {
                if (filho.Name != nome) filho.Hide(); // Esconde os demais Forms no Mdi
            }
            foreach (Form filho in MdiChildren)
            {
                if (filho.Name == nome)
                {
                    fecharFormsInacessiveis();
                    filho.Show(); // Mostra o form desejado já aberto
                    return true; // Diz que já há um form desse nome instanciado
                }
            }
            return false; // Não há um form desse nome instanciado (permite abrir um)
        }

        // Fecha formulários que não poderão ser acessados após abrir outro
        private void fecharFormsInacessiveis()
        {
            string[] forms = new string[] { // Lista de forms
                "FormCadastro"
            };

            foreach (string form in forms)
            {
                if (Application.OpenForms[form] != null) Application.OpenForms[form].Close();
            }
        }
    }
}
