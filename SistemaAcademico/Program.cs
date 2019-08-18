using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            forms.FormLogin formlogin;
            do
            {
                // Mostra o FormLogin sempre que o FormMenu for fechado
                // Até que formlogin.login[0] seja "nenhum" (fechou FormLogin sem logar)
                formlogin = new forms.FormLogin();
                Application.Run(formlogin);

                switch (formlogin.infoLogin[0]) // Escolhe qual menu exibir baseado no tipo do usuário
                {
                    case "Administrador":
                        Application.Run(new forms.Admin.FormMenu(formlogin.infoLogin[2], formlogin.infoLogin[1]));
                        break;
                    case "Aluno":
                        Application.Run(new forms.Aluno.FormMenu(formlogin.infoLogin[2], formlogin.infoLogin[1]));
                        break;
                    case "Professor":
                        Application.Run(new forms.Professor.FormMenu(formlogin.infoLogin[2], formlogin.infoLogin[1]));
                        break;
                }
            } while (formlogin.infoLogin[0] != null);


        }
    }
}
