using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaAcademico.util;

namespace SistemaAcademico.usuarios
{
    public class Aluno : Usuario
    {
        public string RA { get; set; }
        public string Curso { get; set; }
        public DateTime dataMatricula { get; set; }

        public Aluno() { }

        public Aluno(string Login, string Senha, string RG, string CPF, string Email, 
            string Nome, string Telefone, string RA, string Curso, DateTime dataMatricula)
        {
            this.Login = Login;
            this.Senha = Senha;
            this.RG = RG;
            this.CPF = CPF;
            this.Email = Email;
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.RA = RA;
            this.Curso = Curso;
            this.dataMatricula = dataMatricula;
        }

        public int Cadastrar()
        {
            // Pesquisa no BD se esse usuário já existe
            List<Aluno> alunoComLoginIgual = new ExecutarDB().ListarAlunos(
                "login, email", "usuarios", $"login = '{Login}' OR email = '{Email}'");
            if (alunoComLoginIgual.Count != 0) // Se existe
            {
                if (Login == alunoComLoginIgual[0].Login
                    && Email == alunoComLoginIgual[0].Email)
                {
                    return 1; // Login e Email em uso
                }
                else if (Login == alunoComLoginIgual[0].Login)
                {
                    return 2; // Login em uso
                }
                else
                {
                    return 3; // Email em uso
                }
            }

            // Insere uma nova linha na tabela usuarios
            int idCadastrado = int.Parse(new ExecutarDB().Executar(
                "INSERT INTO usuarios (login, senha, rg, cpf, email, nome, telefone, tipo) " +
                    $"VALUES ('{Login}', '{Senha}', '{RG}', '{CPF}', '{Email}', '{Nome}', '{Telefone}', 'Aluno') " +
                    "RETURNING id", 0));

            // Insere uma nova linha na tabela professores
            new ExecutarDB().Executar(
                "INSERT INTO alunos (ra, curso, datamatricula, user_id) " +
                    $"VALUES ('{RA}', '{Curso}', '{dataMatricula}', {idCadastrado})");

            return 0; // Usuário cadastrado
        }
    }
}
