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

namespace SistemaAcademico.forms.Aluno
{
    public partial class FormMinhasNotas : Form
    {
        private usuarios.Aluno alunoLogado;

        public FormMinhasNotas(int ID)
        {
            InitializeComponent();

            alunoLogado = new ExecutarDB().ListarAlunos("id, curso", "alunos", $"user_id = {ID}")[0];

            resgatarMateriasCursadas();
        }

        private void resgatarMateriasCursadas()
        {
            foreach (Materia materia in new ExecutarDB().ListarMaterias("sigla, estudantes_id", "materias", $"curso = '{alunoLogado.Curso}'"))
                // Procura aluno no Estudantes
                for (int i = 0; i < materia.Estudantes.Length; i++)
                    if (materia.Estudantes[i] == alunoLogado.ID)
                        adicionarMateria(materia.Sigla);
        }

        private void adicionarMateria(string sigla)
        {
            
        }
    }
}
