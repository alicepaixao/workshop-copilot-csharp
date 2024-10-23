
### Lab 7: Implementando Paginação

#### Objetivo:
Criar um método que retorne os livros com suporte a paginação.

#### Passos:
1. **Navegue até o arquivo `BooksController.cs`.**
2. **Crie um método `GET` para retornar livros com paginação.**
   - Coloque o cursor no final do arquivo.
   - Digite `// Método para paginação` e deixe que o Copilot sugira o código.

Exemplo de código esperado:

```csharp
[HttpGet("paged")]
public ActionResult<List<Book>> GetPagedBooks(int page = 1, int pageSize = 5)
{
    var pagedBooks = Books.Skip((page - 1) * pageSize).Take(pageSize).ToList();
    return pagedBooks;
}
```

3. **Teste o novo método com diferentes valores de `page` e `pageSize`.**
