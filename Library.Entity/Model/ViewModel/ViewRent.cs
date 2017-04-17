using System;

namespace Library.Entity.Model.ViewModel
{
    public class ViewRent
    {
        public string BookName { get; set; }

        public string UserName { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}
