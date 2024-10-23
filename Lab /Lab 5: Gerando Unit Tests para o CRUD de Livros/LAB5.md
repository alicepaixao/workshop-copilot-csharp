### Lab 5: Gerando Unit Tests para o CRUD de Livros

#### Objetivo:
Gerar automaticamente testes unitários para garantir que o CRUD de livros funcione corretamente.

#### Passos:
1. **Navegue até o arquivo `BooksControllerTests.cs` no diretório `Tests`.**
2. **Crie testes para o método `POST` usando o Copilot.**
   - Selecione o método `PostBook` no arquivo `BooksController.cs`.
   - Use o Copilot para gerar um teste.

Exemplo de código sugerido:

```csharp
[Fact]
public void PostBook_ShouldReturnCreatedAtActionResult()
{
    var controller = new BooksController();
    var newBook = new Book { Id = 5, Title = "Test Book", Author = "Test Author", Year = 2023 };

    var result = controller.PostBook(newBook);

    var actionResult = Assert.IsType<CreatedAtActionResult>(result);
    Assert.Equal(newBook, actionResult.Value);
}
```

3. **Crie mais testes para os métodos `GET`, `PUT` e `DELETE`.**
