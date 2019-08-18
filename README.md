# winforms-sistema-academico
A small school management system, created for testing/learning Windows Forms and database connections rather than pratical usage.

***Veja este README em [Português brasileiro](https://github.com/g-otn/winforms-sistema-academico/blob/master/README.pt-BR.md).***

## Features
- Login system.
- Admin, teachers and students users.
- CRUD for users, courses, subjects, subjects' students and grades.

![users_list](https://user-images.githubusercontent.com/44736064/63220391-d5d26c00-c15c-11e9-82dd-aabc87bc0c8d.png)

![subjects_crud](https://user-images.githubusercontent.com/44736064/63220392-d79c2f80-c15c-11e9-9320-ab4afa4358a3.png)

## Installing and running
1. Install [PostgreSQL](https://www.postgresql.org/) (compatible with 10.5).
2. Install [Npgsql](https://www.npgsql.org/) through the Package Manager Console:
```cmd
PM> Install-Package Npgsql
```
3. Open [pgAdmin 4](https://www.pgadmin.org/) and set up what you need (user, server and database) until you are ready to create tables. 

At this point, the list on your pgAdmin should show something like this:

<p align="center">
    <img alt="pgadmin example" src="https://user-images.githubusercontent.com/44736064/63220268-1c729700-c15a-11e9-8de7-f1415159a361.png">
</p>

4. Right-click on your database and click on "Query Tool..."
5. Open/paste and run the SQL scripts located in the project at ``sql/``:
   - ``init.sql``: Will create all the necessary tables.
   - ``admin.sql``: Will insert an admin user (username/password: ``admin``) so you can log in.
6. In the project, go to ``SistemaAcademico/util/ConectaDB.cs`` and the change the constants values to match your database settings. Example:
```csharp
private const string serverName =   "localhost";
private const string port =         "5432"; 
private const string userName =     "postgres";
private const string password =     "ushallnotpass";
private const string dataBaseName = "SistemaAcademico";
```
7. Compile and run the project, you should see a log in window.


## Acknowledgements
Thanks to Prof. Dr. Fretz Sievers Junior for assigning this project and providing the code at ``SistemaAcademico/util/ConectaDB.cs``.