using Library.Entity.DatabaseConnection;
using Library.Entity.Model;
using System.Collections.Generic;
using System.Linq;

namespace Library.DAL
{
    public class WriterRepository
    {
        public static List<Writer> GetAllWriters()
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                return db.Writer.ToList();
            }
        }

        public static void AddWriter(Writer writer)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                db.Writer.Add(writer);
                db.SaveChanges();
            }
        }

        public static void DeleteWriter(int id)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                var result = db.Writer.Find(id);
                db.Writer.Remove(result);
                db.SaveChanges();


            }
        }

        public static void UpdateWriter(int id, string name)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                var result = db.Writer.Find(id);
                result.WriterName = name;
                db.SaveChanges();
            }
        }


        public static Writer GetWriter(int id)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                return db.Writer.Find(id);
            }
        }

    }
}
