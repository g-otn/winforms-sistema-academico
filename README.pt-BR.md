# winforms-sistema-academico
Um simples sistema acadêmico, feito mais para testar/aprender Windows Forms e conexões com banco de dados do que uso prático.

## Características
- Sistema de login
- Usuários administradores, professores e estudantes.
- CRUD de usuários, cursos, matérias, alunos das matérias e notas.

![users_list](https://user-images.githubusercontent.com/44736064/63220391-d5d26c00-c15c-11e9-82dd-aabc87bc0c8d.png)

![subjects_crud](https://user-images.githubusercontent.com/44736064/63220392-d79c2f80-c15c-11e9-9320-ab4afa4358a3.png)

## Instalando e executando
1. Instale o [PostgreSQL](https://www.postgresql.org/) (compatível com 10.5).
2. Instale o [Npgsql](https://www.npgsql.org/) através do Console do Gerenciador de Pacotes:
```cmd
PM> Install-Package Npgsql
```
3. Abra o [pgAdmin 4](https://www.pgadmin.org/) e configure o necessário (usuário, servidor e banco de dados) até que você esteja pronto para criar tabelas. 

Nesse ponto, a lista em seu pgAdmin deve mostrar algo como:

<p align="center">
    <img alt="pgadmin example" src="https://user-images.githubusercontent.com/44736064/63220268-1c729700-c15a-11e9-8de7-f1415159a361.png">
</p>

4. Dê um clique direito no seu banco de dados e clique em "Query Tool..."
5. Abra/cole e execute os scripts SQL localizados no projeto em ``sql/``:
   - ``init.sql``: Irá criar todas as tabelas necessárias.
   - ``admin.sql`` Irá inserir um usuário administrador (usuário/senha: ``admin``) para você poder logar.
6. No projeto, vá para ``SistemaAcademico/util/ConectaDB.cs`` e troque os valores das constantes para corresponderem as configurações do seu banco de dados. Exemplo:
```csharp
private const string serverName =   "localhost";
private const string port =         "5432"; 
private const string userName =     "postgres";
private const string password =     "senhaforte";
private const string dataBaseName = "SistemaAcademico";
```
7. Compile e execute o projeto, você deve ver uma tela de login.


## Agradecimentos
Obrigado ao Prof. Dr. Fretz Sievers Junior por atribuir este projeto e disponibilizar o código em ``SistemaAcademico/util/ConectaDB.cs``.