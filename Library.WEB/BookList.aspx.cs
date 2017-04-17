using Library.DAL;
using System;

namespace Library.WEB
{
    public partial class BookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Repeater1.DataSource = BookRepository.GetAllBooks();
            Repeater1.DataBind();

        }
    }
}