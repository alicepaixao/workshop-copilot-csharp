### Lab 4: Deletando Livros

#### Objetivo:
Praticar como o Copilot pode ajudar a criar o método `DELETE` para remover livros.

#### Passos:
1. **Navegue até o arquivo `BooksController.cs`.**
2. **Adicione o método `DELETE` para remover livros da lista.**
   - Coloque o cursor após o método `PUT`.
   - Digite `[HttpDelete("{id}")]` e permita que o Copilot sugira o código para o método.

Exemplo de código esperado:

```csharp
[HttpDelete("{id}")]
public IActionResult DeleteBook(int id)
{
    var book = Books.FirstOrDefault(b => b.Id == id);
    if (book == null)
    {
        return NotFound();
    }

    Books.Remove(book);
    return NoContent();
}
```

3. **Teste a funcionalidade deletando livros e verificando o resultado.**