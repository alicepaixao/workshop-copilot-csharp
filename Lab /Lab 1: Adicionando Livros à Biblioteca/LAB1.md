### Lab 1: Adicionando Livros à Biblioteca

#### Objetivo:
Praticar como o GitHub Copilot pode ajudar na criação de um CRUD básico para gerenciar livros em um sistema.

#### Passos:
1. **Abra o projeto `BookManagerApi`.**
2. **Navegue até o arquivo `BooksController.cs` no diretório `Controllers`.**
3. **Adicione um novo livro à lista de livros.**
   - Coloque o cursor no final da lista `private static readonly List<Book> Books`.
   - Digite `,` e pressione `Enter`.
   - Deixe que o Copilot sugira novos livros para serem adicionados. Aceite a sugestão.

Exemplo de código esperado:

```csharp
new Book
{
    Id = 3,
    Title = "O Pequeno Príncipe",
    Author = "Antoine de Saint-Exupéry",
    Year = 1943,
    Description = "Um dos maiores clássicos da literatura infantil.",
    Pages = 96
}
```

4. **Repita o processo para adicionar mais livros.**
5. **Verifique se os livros foram adicionados corretamente executando o projeto.**
