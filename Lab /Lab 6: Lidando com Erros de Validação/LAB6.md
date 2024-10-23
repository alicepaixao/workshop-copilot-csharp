
### Lab 6: Lidando com Erros de Validação

#### Objetivo:
Utilizar o Copilot para adicionar validações de entrada de dados no cadastro de livros.

#### Passos:
1. **Navegue até o arquivo `BooksController.cs`.**
2. **Adicione uma validação para garantir que os campos `Title` e `Author` não estejam vazios.**
   - Coloque o cursor no início do método `POST`.
   - Digite `// Validações de entrada de dados` e permita que o Copilot sugira o código.

Exemplo de código esperado:

```csharp
if (string.IsNullOrEmpty(book.Title) || string.IsNullOrEmpty(book.Author))
{
    return BadRequest("Title and Author are required fields.");
}
```

3. **Teste as validações criando livros sem título ou autor e observe o retorno `BadRequest`.**