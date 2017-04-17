using Library.DAL;
using Library.Entity.Model;
using System;

namespace Library.WEB
{
    public partial class AddNewBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListWriter.DataSource = WriterRepository.GetAllWriters();
                DropDownListWriter.DataTextField = "WriterName";
                DropDownListWriter.DataValueField = "WriterID";
                DropDownListWriter.DataBind();
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {

            Book newBook = new Book()
            {
                BookName = TextBoxBookName.Text,
                BookSubject = TextBoxSubject.Text,
                ShelfNumber = int.Parse(TextBoxShelfNo.Text),
                PageCount = int.Parse(TextBoxPage.Text),
                WriterID = int.Parse(DropDownListWriter.SelectedItem.Value)
            };

            BookRepository.AddBook(newBook);

            Response.Redirect("BookList.aspx");

        }
    }
}
