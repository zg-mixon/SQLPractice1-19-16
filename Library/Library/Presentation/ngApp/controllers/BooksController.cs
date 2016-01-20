using Library.Presentation.ngApp.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Library.Presentation.ngApp.controllers
{
    public class BooksController : ApiController
    {
        public BookService _bookservice;

        public BooksController(BookService bookService) { 
            _bookservice = bookService;
        }
        public IList<BookDTO> Get()
        {
            return _bookservice.ListBooks();
        }
    }
}

    

