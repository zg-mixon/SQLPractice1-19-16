using Library.Domain.Models;
using Library.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Presentation.ngApp.services
{
    public class BookService
    {
        private BookRepository _bookRepo;

        public BookService(BookRepository bookRepo) {
            _bookRepo = bookRepo;
        }

        private BookDTO Map(Book dbBook) {
            return new BookDTO()
            {
                Id = dbBook.Id,
                Title = dbBook.Title,
                Author = dbBook.Author != null ? new AuthorDTO()
                {
                    Id = dbBook.Author.Id,
                    Name = dbBook.Author.Name
                }:null,
                Isbn = dbBook.Isbn
            };
        }
                
                    

        public IList<BookDTO> ListBooks()
        {
            return (from b in _bookRepo.List()
                    select Map(b)).ToList();
        }
    }
}