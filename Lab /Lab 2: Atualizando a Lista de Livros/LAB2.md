
### Lab 2: Atualizando a Lista de Livros

#### Objetivo:
Usar o GitHub Copilot para criar um método `PUT` e permitir a atualização de livros existentes.

#### Passos:
1. **Navegue até o arquivo `BooksController.cs`.**
2. **Crie um método `PUT` para atualizar informações de um livro existente.**
   - Coloque o cursor após o método `POST`.
   - Comece digitando `[HttpPut("{id}")]` e deixe que o Copilot sugira o código para o método.
   
Exemplo de código esperado:

```csharp
[HttpPut("{id}")]
public IActionResult UpdateBook(int id, Book updatedBook)
{
    var book = Books.FirstOrDefault(b => b.Id == id);
    if (book == null)
    {
        return NotFound();
    }
    
    book.Title = updatedBook.Title;
    book.Author = updatedBook.Author;
    book.Pages = updatedBook.Pages;
    
    return NoContent();
}
```

3. **Teste a atualização criando requisições para o método `PUT`.**
