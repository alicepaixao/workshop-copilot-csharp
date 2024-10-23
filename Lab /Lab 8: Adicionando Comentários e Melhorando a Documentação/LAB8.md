
### Lab 8: Adicionando Comentários e Melhorando a Documentação

#### Objetivo:
Gerar automaticamente a documentação do código usando o Copilot.

#### Passos:
1. **Navegue até o arquivo `BooksController.cs`.**
2. **Gere comentários XML para cada método.**
   - Selecione o código de um método como `GetBookById`.
   - Solicite ao Copilot que gere a documentação para o método.

Exemplo de comentário sugerido:

```csharp
/// <summary>
/// Retorna um livro específico pelo Id.
/// </summary>
/// <param name="id">O Id do livro.</param>
/// <returns>O livro correspondente ao Id.</returns>
[HttpGet("{id}")]
public ActionResult<Book> GetBookById(int id)
{
    var book = Books.FirstOrDefault(b => b.Id == id);
    if (book == null)
    {
        return NotFound();
    }

    return book;
}
```

3. **Adicione a documentação em todos os métodos do controlador.**