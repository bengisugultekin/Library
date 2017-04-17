using Library.Entity.DatabaseConnection;
using Library.Entity.Model;
using Library.Entity.Model.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace Library.DAL
{
    public class RentRepository
    {
        public static void AddRent(Rent rent)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                db.Rent.Add(rent);

                var result = db.Book.Find(rent.BookID);
                result.IsRented = true;

                db.SaveChanges();
            }
        }

        //public static List<Rent> GetAllRent()
        //{
        //    using (LibraryDbContext db = new LibraryDbContext())
        //    {
        //        return db.Rent.ToList();
        //    }
        //}

        public static List<ViewRent> GetAllRents()
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                return db.Rent.Select(r => new ViewRent
                {
                    BookName = r.Book.BookName,
                    UserName = r.User.UserName,
                    RentDate = r.RentDate,
                    ReturnDate = r.ReturnDate,

                }).ToList();
            }
        }


    }
}
