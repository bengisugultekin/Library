namespace Library.Entity.Model
{
    public class Book
    {
        public int BookID { get; set; }

        public string BookName { get; set; }

        public string BookSubject { get; set; }

        public int PageCount { get; set; }

        public int WriterID { get; set; }

        public int ShelfNumber { get; set; }    //int? veya Nullable<int> yaparak boş geçebilirsin

        public bool IsRented { get; set; }

        //Mapping
        public Writer Writer { get; set; }

    }
}
