using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaAcademico.util;

namespace SistemaAcademico.usuarios
{
    public class Professor : Usuario
    {
        public string Registro { get; set; }
        public string Formacao { get; set; }

        public Professor() { }

        public Professor(string Login, string Senha, string RG, string CPF, string Email,
            string Nome, string Telefone, string Registro, string Formacao)
        {
            this.Login = Login;
            this.Senha = Senha;
            this.RG = RG;
            this.CPF = CPF;
            this.Email = Email;
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Registro = Registro;
            this.Formacao = Formacao;
        }

        public short Cadastrar()
        {
            // Pesquisa no BD se esse usuário já existe
            List<Professor> profComLoginIgual = new ExecutarDB().ListarProfessores(
                "login, email", "usuarios", $"login = '{Login}' OR email = '{Email}'");
            if (profComLoginIgual.Count != 0) // Se existe
            {
                if (Login == profComLoginIgual[0].Login
                    && Email == profComLoginIgual[0].Email)
                {
                    return 1; // Login e Email em uso
                }
                else if (Login == profComLoginIgual[0].Login)
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
                    $"VALUES ('{Login}', '{Senha}', '{RG}', '{CPF}', '{Email}', '{Nome}', '{Telefone}', 'Professor') " +
                    "RETURNING id", 0));

            // Insere uma nova linha na tabela professores
            new ExecutarDB().Executar(
                "INSERT INTO professores (registro, formacao, user_id) " +
                    $"VALUES ('{Registro}', '{Formacao}', {idCadastrado})");

            return 0; // Usuário cadastrado
        }
    }
}
