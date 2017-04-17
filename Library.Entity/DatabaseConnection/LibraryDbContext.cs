namespace Library.Entity.DatabaseConnection
{
    using Library.Entity.Model;
    using System.Data.Entity;

    public class LibraryDbContext : DbContext
    {

        public LibraryDbContext()
            : base("name=LibraryDb")
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Writer> Writer { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
        public virtual DbSet<User> User { get; set; }
    }


}