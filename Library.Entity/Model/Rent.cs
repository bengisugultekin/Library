using System;

namespace Library.Entity.Model
{
    public class Rent
    {
        public int RentID { get; set; }

        public int BookID { get; set; }

        public int UserID { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }


        //Mapping
        public Book Book { get; set; }

        public User User { get; set; }
    }
}
