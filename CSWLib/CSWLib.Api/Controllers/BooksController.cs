using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CSWLib.Entity;
using CSWLib.Api.Models;

namespace CSWLib.Api.Controllers
{

    [RoutePrefix("api/book")]
    public class BooksController : ApiController
    {
        private CSWLibContext db = new CSWLibContext();

        // GET: api/Books
        [Route("")]
        public IHttpActionResult GetBooks()
        {

            List<BookViewModel> list = new List<BookViewModel>();

            foreach (var item in db.Books.Include("Category").Include("Author").ToList())
            {
                list.Add(new BookViewModel() {id = item.id, name = item.name, description = item.description, numberOfPages = item.numberOfPages, author = item.author.name, authorId = item.authorId , category = item.category.name, categoryId = item.categoryId});
            }

            var jsonData = new
            {
                books = list,
                number_of_elements = list.Count
            };

            return Ok(jsonData);            
        }

        // GET: api/category/{id}
        [Route("category/{id}")]
        public IHttpActionResult GetBooksByCategory(string id)
        {
            int tempId;
            if (!int.TryParse(id, out tempId))
            {
                return NotFound();
            }

            List<BookViewModel> list = new List<BookViewModel>();

            foreach (var item in db.Books.Include("Category").Include("Author").Where(x => x.categoryId == tempId).ToList())
            {
                list.Add(new BookViewModel() { id = item.id, name = item.name, description = item.description, numberOfPages = item.numberOfPages, author = item.author.name, authorId = item.authorId, category = item.category.name, categoryId = item.categoryId });
            }

            var jsonData = new
            {
                books = list,
                number_of_elements = list.Count
            };

            return Ok(jsonData);
        }


        // GET: api/category/{id}
        [Route("author/{id}")]
        public IHttpActionResult GetBooksByAuthor(string id)
        {
            int tempId;
            if (!int.TryParse(id, out tempId))
            {
                return NotFound();
            }

            List<BookViewModel> list = new List<BookViewModel>();

            foreach (var item in db.Books.Include("Category").Include("Author").Where(x => x.authorId == tempId).ToList())
            {
                list.Add(new BookViewModel() { id = item.id, name = item.name, description = item.description, numberOfPages = item.numberOfPages, author = item.author.name, authorId = item.authorId, category = item.category.name, categoryId = item.categoryId });
            }

            var jsonData = new
            {
                books = list,
                number_of_elements = list.Count
            };

            return Ok(jsonData);
        }
    }
}