using Library.Entity.DatabaseConnection;
using Library.Entity.Model;
using Library.Entity.Models.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace Library.DAL
{
    public class BookRepository
    {
        public static List<ViewBook> GetAllBooks()
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                return db.Book.Select(b => new ViewBook
                {
                    BookID = b.BookID,
                    BookName = b.BookName,
                    BookSubject = b.BookSubject,
                    PageCount = b.PageCount,
                    IsRented = b.IsRented,
                    ShelfNumber = b.ShelfNumber,
                    WriterName = b.Writer.WriterName,
                }).ToList();
            }
        }

        public static void AddBook(Book book)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                db.Book.Add(book);
                db.SaveChanges();
            }
        }

        public static Book GetBook(int id)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                return db.Book.Find(id);
            }
        }

    }
}
