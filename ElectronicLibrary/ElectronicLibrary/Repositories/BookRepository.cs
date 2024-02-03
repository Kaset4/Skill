using ElectronicLibrary.Models;
using AppContext = ElectronicLibrary.Core.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary.Repositories
{
    public class BookRepository: IBookRepository
    {
        public void Create(Book book)
        {
            using (AppContext db = new AppContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            using (AppContext db = new AppContext())
            {
                Book book = db.Books.Find(id);
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }

        public List<Book> FindAll()
        {
            using (AppContext db = new AppContext())
            {
                return db.Books.ToList();
            }
        }

        public Book FindById(int id)
        {
            using (AppContext db = new AppContext())
            {
                return db.Books.Find(id);
            }
        }

        public void UpdateByYear(int id, int NewYear)
        {
            using (AppContext db = new AppContext())
            {
                var book = db.Books.Find(id);
                book.PublicationYear = NewYear;

                db.SaveChanges();
            }
        }

        public List<Book> GetBooksByGenreAndYearRange(string genre, int YearRangeFirst, int YearRangeSecond)
        {
            using (var db = new AppContext())
            {
                return db.Books.Where(s => s.Genre == genre && s.PublicationYear >= YearRangeFirst && s.PublicationYear <= YearRangeSecond).ToList();
            }
        }

        public int GetCountBooksByGenre(string genre)
        {
            using(AppContext db = new AppContext())
            {
                return db.Books.Where(s => s.Genre.Equals(genre)).Count();
            }
        }

        public int GetCountBooksByAuthor(string author)
        {
            using (AppContext db = new AppContext())
            {
                return db.Books.Where(s => s.Author.Equals(author)).Count();
            }
        }

        public bool IsBookInLibraryByAuthorAndTitle(string author, string title)
        {
            using( var db = new AppContext())
            {
                if (db.Books.Where(s => s.Author == author && s.Title == title).Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsBookBorrowedByUser(int bookId, int userId) 
        {
            using ( var db = new AppContext())
            {
                if (db.Users.Find(userId).Books.Contains(db.Books.Find(bookId)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Book GetLatestReleasedBook()
        {
            using(var  db = new AppContext())
            {
                return  db.Books.OrderByDescending(o => o.PublicationYear).FirstOrDefault();
            }
        }

        public List<Book> GetAllBooksSortedByTitle()
        {
            using ( var db = new AppContext())
            {
                return db.Books.OrderBy(o => o.Title).ToList();
            }
        }

        public List<Book> GetAllBooksSortedByPublicationYearDescending()
        {
            using (var db = new AppContext())
            {
                return db.Books.OrderByDescending(o => o.PublicationYear).ToList();
            }
        }
    }
}
