using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaAcademico.usuarios;
using Npgsql;

namespace SistemaAcademico.util
{
    class ExecutarDB
    {
        public object Executar(string comando)
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conexao);

                // Retorna a primeira coluna da primeira linha do resultado gerado pelo comando
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\nComando: " + comando);
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }
        }

        public string Executar(string comando, int colunaRetorno)
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                // Caso o comando queira retornar um valor após a execução (RETURNING)
                if (dr.Read())
                {
                    // Resgata o valor da coluna colunaRetorno na linha executada
                    return dr[colunaRetorno].ToString();
                }
                else return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\nComando: " + comando);
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }
        }

        public List<Usuario> ListarUsuarios(string colunas, string tabela, string condicao)
        {
            List<Usuario> usuarios = new List<Usuario>();

            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = condicao == null
                    ? $"SELECT {colunas} FROM {tabela}"
                    : $"SELECT {colunas} FROM {tabela} WHERE {condicao}";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                // Para cada 'usuario' ("linha" do DB pelo dr.Read()), atribui 
                // os valores das colunas 'ler' contidos em 'dr' 
                string[] ler = colunas.Split(new string[] { ", " }, StringSplitOptions.None); // Resgata as colunas
                while (dr.Read()) // Cada loop é uma linha encontrada
                {
                    Usuario usuario = new Usuario();
                    for (int i = 0; i < ler.Length; i++) // Para cada "coluna"
                    {
                        switch (ler[i]) // Descobre qual é a coluna e atribui ao atributo
                        {
                            case "usuarios.id":
                            case "id":
                                usuario.ID = Convert.ToInt16(dr["id"]);
                                break;
                            case "login":
                                usuario.Login = dr["login"].ToString();
                                break;
                            case "senha":
                                usuario.Senha = dr["senha"].ToString();
                                break;
                            case "rg":
                                usuario.RG = dr["rg"].ToString();
                                break;
                            case "cpf":
                                usuario.CPF = dr["cpf"].ToString();
                                break;
                            case "email":
                                usuario.Email = dr["email"].ToString();
                                break;
                            case "nome":
                                usuario.Nome = dr["nome"].ToString();
                                break;
                            case "telefone":
                                usuario.Telefone = dr["telefone"].ToString();                                    
                                break;
                            case "tipo":
                                usuario.Tipo = dr["tipo"].ToString();
                                break;
                            case "*":
                                usuario.ID = Convert.ToInt16(dr["id"]);
                                usuario.Login = dr["login"].ToString();
                                usuario.Senha = dr["senha"].ToString();
                                usuario.RG = dr["rg"].ToString();
                                usuario.CPF = dr["cpf"].ToString();
                                usuario.Email = dr["email"].ToString();
                                usuario.Nome = dr["nome"].ToString();
                                usuario.Telefone = dr["telefone"].ToString();
                                usuario.Tipo = dr["tipo"].ToString();
                                break;
                        }
                    }
                    usuarios.Add(usuario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\nColunas: \"" + colunas + "\"\nTabela: \"" + tabela + "\"\nCondicao: \"" + condicao + "\"");
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }
            return usuarios;
        }

        public List<Admin> ListarAdmins(string colunas, string tabela, string condicao)
        {
            List<Admin> admins = new List<Admin>();

            NpgsqlConnection conexao = null;
            try
            {
                // Conecta com o DB, cria e executa o comando e resgata a tabela
                conexao = ConectaDB.getConexao(); // Conecta com o banco de dados
                string sql = condicao == null // Define o comando
                    ? $"SELECT {colunas} FROM {tabela}"
                    : $"SELECT {colunas} FROM {tabela} WHERE {condicao}";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao); // Cria o comando
                NpgsqlDataReader dr = cmd.ExecuteReader(); // Executa o comando

                // Para cada 'admin' ("linha" do DB pelo dr.Read()), atribui 
                // os valores das colunas 'ler' contidos em 'dr' 
                string[] ler = colunas.Split(new string[] { ", " }, StringSplitOptions.None); // Resgata as colunas
                while (dr.Read()) // Cada loop é uma linha encontrada
                {
                    Admin admin = new Admin();

                    for (int i = 0; i < ler.Length; i++) // Para cada "coluna"
                    {
                        switch (ler[i]) // Descobre qual é a coluna e atribui ao atributo
                        {
                            case "administradores.id":
                            case "id":
                                admin.ID = Convert.ToInt16(dr["id"]);
                                break;
                            case "login":
                                admin.Login = dr["login"].ToString();
                                break;
                            case "senha":
                                admin.Senha = dr["senha"].ToString();
                                break;
                            case "rg":
                                admin.RG = dr["rg"].ToString();
                                break;
                            case "cpf":
                                admin.CPF = dr["cpf"].ToString();
                                break;
                            case "email":
                                admin.Email = dr["email"].ToString();
                                break;
                            case "nome":
                                admin.Nome = dr["nome"].ToString();
                                break;
                            case "telefone":
                                admin.Telefone = dr["telefone"].ToString();
                                break;
                            case "cargo":
                                admin.Cargo = dr["cargo"].ToString();
                                break;
                            case "*":
                                admin.ID = Convert.ToInt16(dr["id"]);
                                admin.Login = dr["login"].ToString();
                                admin.Senha = dr["senha"].ToString();
                                admin.RG = dr["rg"].ToString();
                                admin.CPF = dr["cpf"].ToString();
                                admin.Email = dr["email"].ToString();
                                admin.Nome = dr["nome"].ToString();
                                admin.Telefone = dr["telefone"].ToString();
                                admin.Cargo = dr["cargo"].ToString();
                                break;
                        }
                    }
                    admins.Add(admin);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\nColunas: \"" + colunas + "\"\nTabela: \"" + tabela + "\"\nCondicao: \"" + condicao + "\"");
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }
            return admins;
        }

        public List<Aluno> ListarAlunos(string colunas, string tabela, string condicao)
        {
            List<Aluno> alunos = new List<Aluno>();

            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = condicao == null
                    ? $"SELECT {colunas} FROM {tabela}"
                    : $"SELECT {colunas} FROM {tabela} WHERE {condicao}";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                // Para cada 'aluno' ("linha" do DB pelo dr.Read()), atribui 
                // os valores das colunas 'ler' contidos em 'dr' 
                string[] ler = colunas.Split(new string[] { ", " }, StringSplitOptions.None); // Resgata as colunas
                while (dr.Read()) // Cada loop é uma linha encontrada
                {
                    Aluno aluno = new Aluno();

                    for (int i = 0; i < ler.Length; i++) // Para cada "coluna"
                    {
                        switch (ler[i]) // Descobre qual é a coluna e atribui ao atributo
                        {
                            case "alunos.id":
                            case "id":
                                aluno.ID = Convert.ToInt16(dr["id"]);
                                break;
                            case "login":
                                aluno.Login = dr["login"].ToString();
                                break;
                            case "senha":
                                aluno.Senha = dr["senha"].ToString();
                                break;
                            case "rg":
                                aluno.RG = dr["rg"].ToString();
                                break;
                            case "cpf":
                                aluno.CPF = dr["cpf"].ToString();
                                break;
                            case "email":
                                aluno.Email = dr["email"].ToString();
                                break;
                            case "nome":
                                aluno.Nome = dr["nome"].ToString();
                                break;
                            case "telefone":
                                aluno.Telefone = dr["telefone"].ToString();
                                break;
                            case "ra":
                                aluno.RA = dr["ra"].ToString();
                                break;
                            case "curso":
                                aluno.Curso = dr["curso"].ToString();
                                break;
                            case "datamatricula":
                                aluno.dataMatricula = Convert.ToDateTime(dr["datamatricula"]);
                                break;
                            case "*":
                                aluno.ID = Convert.ToInt16(dr["id"]);
                                aluno.Login = dr["login"].ToString();
                                aluno.Senha = dr["senha"].ToString();
                                aluno.RG = dr["rg"].ToString();
                                aluno.CPF = dr["cpf"].ToString();
                                aluno.Email = dr["email"].ToString();
                                aluno.Nome = dr["nome"].ToString();
                                aluno.Telefone = dr["telefone"].ToString();
                                aluno.RA = dr["ra"].ToString();
                                aluno.Curso = dr["curso"].ToString();
                                aluno.dataMatricula = Convert.ToDateTime(dr["datamatricula"]);
                                break;
                        }
                    }
                    alunos.Add(aluno);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\nColunas: \"" + colunas + "\"\nTabela: \"" + tabela + "\"\nCondicao: \"" + condicao + "\"");
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }
            return alunos;
        }

        public List<Professor> ListarProfessores(string colunas, string tabela, string condicao)
        {
            List<Professor> professores = new List<Professor>();

            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = condicao == null
                    ? $"SELECT {colunas} FROM {tabela}"
                    : $"SELECT {colunas} FROM {tabela} WHERE {condicao}";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                // Para cada 'professor' ("linha" do DB pelo dr.Read()), atribui 
                // os valores das colunas 'ler' contidos em 'dr' 
                string[] ler = colunas.Split(new string[] { ", " }, StringSplitOptions.None); // Resgata as colunas
                while (dr.Read()) // Cada loop é uma linha encontrada
                {
                    Professor professor = new Professor();

                    for (int i = 0; i < ler.Length; i++) // Para cada "coluna"
                    {
                        switch (ler[i]) // Descobre qual é a coluna e atribui ao atributo
                        {
                            case "professores.id":
                            case "id":
                                professor.ID = Convert.ToInt16(dr["id"]);
                                break;
                            case "login":
                                professor.Login = dr["login"].ToString();
                                break;
                            case "senha":
                                professor.Senha = dr["senha"].ToString();
                                break;
                            case "rg":
                                professor.RG = dr["rg"].ToString();
                                break;
                            case "cpf":
                                professor.CPF = dr["cpf"].ToString();
                                break;
                            case "email":
                                professor.Email = dr["email"].ToString();
                                break;
                            case "nome":
                                professor.Nome = dr["nome"].ToString();
                                break;
                            case "telefone":
                                professor.Telefone = dr["telefone"].ToString();
                                break;
                            case "registro":
                                professor.Registro = dr["registro"].ToString();
                                break;
                            case "formacao":
                                professor.Formacao = dr["formacao"].ToString();
                                break;
                            case "*":
                                professor.ID = Convert.ToInt16(dr["id"]);
                                professor.Login = dr["login"].ToString();
                                professor.Senha = dr["senha"].ToString();
                                professor.RG = dr["rg"].ToString();
                                professor.CPF = dr["cpf"].ToString();
                                professor.Email = dr["email"].ToString();
                                professor.Nome = dr["nome"].ToString();
                                professor.Telefone = dr["telefone"].ToString();
                                professor.Registro = dr["registro"].ToString();
                                professor.Formacao = dr["formacao"].ToString();
                                break;
                        }
                    }
                    professores.Add(professor);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\nColunas: \"" + colunas + "\"\nTabela: \"" + tabela + "\"\nCondicao: \"" + condicao + "\"");
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }
            return professores;
        }

        public List<Curso> ListarCursos(string colunas, string tabela, string condicao)
        {
            List<Curso> cursos = new List<Curso>();

            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = condicao == null
                    ? $"SELECT {colunas} FROM {tabela}"
                    : $"SELECT {colunas} FROM {tabela} WHERE {condicao}";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                // Para cada 'Curso' ("linha" do DB pelo dr.Read()), atribui 
                // os valores das colunas 'ler' contidos em 'dr' 
                string[] ler = colunas.Split(new string[] { ", " }, StringSplitOptions.None); // Resgata as colunas
                while (dr.Read()) // Cada loop é uma linha encontrada
                {
                    Curso curso = new Curso();
                    for (int i = 0; i < ler.Length; i++) // Para cada "coluna"
                    {
                        switch (ler[i]) // Descobre qual é a coluna e atribui ao atributo
                        {
                            case "sigla":
                                curso.Sigla = dr["sigla"].ToString();
                                break;
                            case "cursos.nome":
                            case "nome":
                                curso.Nome = dr["nome"].ToString();
                                break;
                            case "*":
                                curso.Sigla = dr["sigla"].ToString();
                                curso.Nome = dr["nome"].ToString();
                                break;
                        }
                    }
                    cursos.Add(curso);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\nColunas: \"" + colunas + "\"\nTabela: \"" + tabela + "\"\nCondicao: \"" + condicao + "\"");
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }
            return cursos;
        }

        public List<Materia> ListarMaterias(string colunas, string tabela, string condicao)
        {
            List<Materia> materias = new List<Materia>();

            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = condicao == null
                    ? $"SELECT {colunas} FROM {tabela}"
                    : $"SELECT {colunas} FROM {tabela} WHERE {condicao}";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                // Para cada 'Materia' ("linha" do DB pelo dr.Read()), atribui 
                // os valores das colunas 'ler' contidos em 'dr' 
                string[] ler = colunas.Split(new string[] { ", " }, StringSplitOptions.None); // Resgata as colunas
                while (dr.Read()) // Cada loop é uma linha encontrada
                {
                    Materia materia = new Materia();
                    for (int i = 0; i < ler.Length; i++) // Para cada "coluna"
                    {
                        switch (ler[i]) // Descobre qual é a coluna e atribui ao atributo
                        {
                            case "materias.curso":
                            case "curso":
                                materia.Curso = dr["curso"].ToString();
                                break;
                            case "materias.sigla":
                            case "sigla":
                                materia.Sigla = dr["sigla"].ToString();
                                break;
                            case "materias.nome":
                            case "nome":
                                materia.Nome = dr["nome"].ToString();
                                break;
                            case "lecionador_id":
                                materia.Lecionador = dr["lecionador_id"] is DBNull ? -1 : Convert.ToInt16(dr["lecionador_id"]);
                                break;
                            case "notas":
                                materia.Notas = dr["notas"] is DBNull ? new string[0] : (string[])dr["notas"];
                                break;
                            case "pesos":
                                materia.Pesos = dr["pesos"] is DBNull ? new float[0] : (float[])dr["pesos"];
                                break;
                            case "estudantes_id":
                                materia.Estudantes = dr["estudantes_id"] is DBNull ? new int[0] : (int[])dr["estudantes_id"];
                                break;
                            case "*":
                                materia.Curso = dr["curso"].ToString();
                                materia.Sigla = dr["sigla"].ToString();
                                materia.Nome = dr["nome"].ToString();
                                // Checagem para não tentar converter DBNull em algo
                                materia.Lecionador = dr["lecionador_id"] is DBNull ? -1 : Convert.ToInt16(dr["lecionador_id"]);
                                materia.Notas = dr["notas"] is DBNull ? new string[0] : (string[])dr["notas"];
                                materia.Pesos = dr["pesos"] is DBNull ? new float[0] : (float[])dr["pesos"];
                                materia.Estudantes = dr["estudantes_id"] is DBNull ? new int[0] : (int[])dr["estudantes_id"];
                                break;
                        }
                    }
                    materias.Add(materia);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\nColunas: \"" + colunas + "\"\nTabela: \"" + tabela + "\"\nCondicao: \"" + condicao + "\"");
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }

            return materias;
        }

        public List<Nota> ListarNotas(string colunas, string tabela, string condicao)
        {
            List<Nota> notas = new List<Nota>();

            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaDB.getConexao();
                string sql = condicao == null
                    ? $"SELECT {colunas} FROM {tabela}"
                    : $"SELECT {colunas} FROM {tabela} WHERE {condicao}";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                // Para cada 'Nota' ("linha" do DB pelo dr.Read()), atribui 
                // os valores das colunas 'ler' contidos em 'dr' 
                string[] ler = colunas.Split(new string[] { ", " }, StringSplitOptions.None); // Resgata as colunas
                while (dr.Read()) // Cada loop é uma linha encontrada
                {
                    Nota nota = new Nota();
                    for (int i = 0; i < ler.Length; i++) // Para cada "coluna"
                    {
                        switch (ler[i]) // Descobre qual é a coluna e atribui ao atributo
                        {
                            case "notas.curso":
                            case "curso":
                                nota.Curso = dr["nome"].ToString();
                                break;
                            case "estudante_id":
                                nota.Estudante = Convert.ToInt16(dr["estudante_id"]);
                                break;
                            case "materia":
                                nota.Materia = dr["materia"].ToString();
                                break;
                            case "num_nota":
                                nota.NumeroDaNota = Convert.ToInt16(dr["num_nota"]);
                                break;
                            case "valor":
                                nota.Valor = dr["valor"] is DBNull ? -1 : Convert.ToDouble(dr["valor"]);
                                break;
                            case "*":
                                nota.Curso = dr["nome"].ToString();
                                nota.Estudante = Convert.ToInt16(dr["estudante_id"]);
                                nota.Materia = dr["materia"].ToString();
                                nota.NumeroDaNota = Convert.ToInt16(dr["num_nota"]);
                                nota.Valor = dr["valor"] is DBNull ? -1 : Convert.ToDouble(dr["valor"]);
                                break;
                        }
                    }
                    notas.Add(nota);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n\nColunas: \"" + colunas + "\"\nTabela: \"" + tabela + "\"\nCondicao: \"" + condicao + "\"");
            }
            finally
            {
                if (conexao != null) conexao.Close();
            }

            return notas;
        }
    }
}
