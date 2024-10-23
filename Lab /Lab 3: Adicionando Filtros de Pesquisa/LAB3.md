### Lab 3: Adicionando Filtros de Pesquisa

#### Objetivo:
Adicionar um método `GET` para pesquisar livros por título e autor.

#### Passos:
1. **Navegue até o arquivo `BooksController.cs`.**
2. **Adicione um método `GET` para pesquisar livros por título e autor.**
   - Coloque o cursor no final da lista de métodos `GET`.
   - Digite `// Método para pesquisar livros por título e autor` e deixe o Copilot sugerir o código.

Exemplo de código esperado:

```csharp
[HttpGet("search")]
public ActionResult<List<Book>> SearchBooks(string? title, string? author)
{
    var result = Books.Where(b => 
        (title == null || b.Title.Contains(title)) &&
        (author == null || b.Author.Contains(author))).ToList();

    return result;
}
```

3. **Teste a funcionalidade de busca criando requisições para o novo método `GET`.**