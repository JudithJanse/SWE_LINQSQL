using SWE.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<LibraryContext>()
   .UseInMemoryDatabase(databaseName: "InMemoryDB")
   .Options;

using (var context = new LibraryContext(options))
{
    var author = new Author
    {
        Name = "Geronimo Stilton",
    };
    var book = new Book
    {
        Title = "Fantasia",
        Author = author
    };

    context.Books.Add(book);
    context.SaveChanges();

}
