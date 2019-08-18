using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaAcademico.util;

namespace SistemaAcademico.usuarios
{
    public class Admin : Usuario
    {
        public string Cargo { get; set; }

        public Admin() { }

        public Admin(string Login, string Senha, string RG, string CPF, string Email, 
            string Nome, string Telefone, string Cargo)
        {
            this.Login = Login;
            this.Senha = Senha;
            this.RG = RG;
            this.CPF = CPF;
            this.Email = Email;
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Cargo = Cargo;
        }

        public short Cadastrar()
        {
            // Pesquisa no BD se esse usuário já existe
            List<Admin> adminComLoginIgual = new ExecutarDB().ListarAdmins(
                "login, email", "usuarios", $"login = '{Login}' OR email = '{Email}'");
            if (adminComLoginIgual.Count != 0) // Se existe
            {
                if (Login == adminComLoginIgual[0].Login
                    && Email == adminComLoginIgual[0].Email)
                {
                    return 1; // Login e Email em uso
                }
                else if (Login == adminComLoginIgual[0].Login)
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
                    $"VALUES ('{Login}', '{Senha}', '{RG}', '{CPF}', '{Email}', '{Nome}'," +
                    $" '{Telefone}', 'Administrador') " +
                    "RETURNING id", 0));

            // Insere uma nova linha na tabela administradores
            new ExecutarDB().Executar("INSERT INTO administradores (cargo, user_id) " +
                $"VALUES ('{Cargo}', {idCadastrado})");

            return 0; // Usuário cadastrado
        }
    }
}
