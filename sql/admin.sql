-- Insere novo administrador
WITH novo_id AS (
  INSERT INTO
    public.usuarios (login, senha, rg, cpf, email, nome, telefone, tipo)
  VALUES
    (
      'admin', -- Login
      'admin', -- Senha
      '00000000AYZ',
      '09876543210',
      'admin@admin.com',
      'Administrador',
      '1234567890',
      'Administrador'
    )
  RETURNING id
)
INSERT INTO
  public.administradores (cargo, user_id)
VALUES
  ('Chefe', (select id from novo_id));

-- Select para checar inserção
SELECT
  nome "Nome",
  login "Login",
  senha "Senha"
FROM
  public.usuarios;