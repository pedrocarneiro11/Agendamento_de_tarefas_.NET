
# API .NET Agendamento de tarefas :computer:
Essa API .NET foi desenvolvida como parte do desafio da trilha .NET da DIO (Digital Innovation One). A aplicação permite o gerenciamento de tarefas, possibilitando a criação, recuperação, atualização e exclusão de registros de tarefas. A API utiliza o framework Entity Framework para a persistência de dados.

# Sobre a API :rocket:

O objetivo dessa API é ajudar na organização da rotina por meio do gerenciamento de tarefas. É possível cadastrar uma lista de tarefas, permitindo uma melhor organização do seu dia a dia.

A lista de tarefas possui as seguintes propriedades:

- Id: identificador único da tarefa (inteiro)
- Título: título da tarefa (string)
- Descrição: descrição detalhada da tarefa (string)
- Data: data de execução da tarefa (DateTime)
- Status: status da tarefa (Enum)

Também foi gerada uma migration em um banco de dados.

# Métodos criados: :notebook:

Os seguintes endpoints foram criados:

Verbo	|Endpoint	|Parâmetro|	Body
|-------|----------|-------| -------|
GET	    |/Tarefa/{id}	|id	|N/A
GET	|/Tarefa/ObterTodos	|N/A	|N/A
GET	|/Tarefa/ObterPorTitulo	|titulo	|N/A
GET	|/Tarefa/ObterPorData	|data	|N/A
GET	|/Tarefa/ObterPorStatus	|status	|N/A
POST	|/Tarefa	|N/A	|Schema Tarefa
PUT	    |/Tarefa/{id}	|id	|Schema Tarefa
DELETE	|/Tarefa/{id}	|id	|N/A

# Banco de dados :floppy_disk:

Foi gerada uma migration para a criação do banco de dados utilizado pela API.