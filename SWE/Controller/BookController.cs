using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal.InMemoryDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace SWE.Controller
{
    internal class BookController
    {
        namespace InMemoryDatabase.Controllers
    {
        public class BookController : Controller
        {
            private readonly ILibraryRepository _repository;

            public BookController(ILibraryRepository repository)
            {
                _repository = repository;
            }

            public IActionResult Index()
            {
                var model = _repository.Books.Include(a => a.Author);

                return View(model);
            }

            public IActionResult Create()
            {
                var austen = new Author { Name = "Jane Austen" };

                var emma = new Book { Title = "Emma", Author = austen, Year = 1815 };

                _repository.Add(emma);

                _repository.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
        }
    }
}
