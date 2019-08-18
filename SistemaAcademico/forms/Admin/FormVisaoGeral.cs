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
    public partial class FormVisaoGeral : Form
    {
        public FormVisaoGeral()
        {
            InitializeComponent();
            contarUsuarios();
            resgatarInfoCursos();
        }

        private void contarUsuarios()
        {
            // Resgata a quantidade de usuários e de cada tipo de usuário
            lblNAdmins.Text = new ExecutarDB().Executar("SELECT COUNT(id) FROM administradores").ToString();
            lblNAlunos.Text = new ExecutarDB().Executar("SELECT COUNT(id) FROM alunos").ToString();
            lblNProfessores.Text = new ExecutarDB().Executar("SELECT COUNT(id) FROM professores").ToString();
            lblNUsuarios.Text = new ExecutarDB().Executar("SELECT COUNT(id) FROM usuarios").ToString();

            gpbUsuarios.UseWaitCursor = false;
        }

        private void resgatarInfoCursos()
        {
            List<Curso> cursos = new ExecutarDB().ListarCursos("sigla, nome", "cursos", null);

            foreach (Curso curso in cursos)
            {
                lblNome.Text += "\n" + curso.Nome;
                lblAlunos.Text += "\n" + new ExecutarDB().Executar($"SELECT COUNT(id) FROM alunos WHERE curso = '{curso.Sigla}'");
                lblMaterias.Text += "\n" + new ExecutarDB().Executar($"SELECT COUNT(sigla) FROM materias WHERE curso = '{curso.Sigla}'");
            }

            gpbCursos.UseWaitCursor = false;
        }
    }
}
