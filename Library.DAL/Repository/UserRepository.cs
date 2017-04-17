using Library.Entity.DatabaseConnection;
using Library.Entity.Model;
using System.Collections.Generic;
using System.Linq;

namespace Library.DAL
{
    public class UserRepository
    {
        public static void AddUser(User user)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                db.User.Add(user);
                db.SaveChanges();
            }
        }

        public static List<User> GetAllUsers()
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                return db.User.ToList();
            }
        }
    }
}
