using Library.DAL;
using System;

namespace Library.WEB
{
    public partial class WriterList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Repeater1.DataSource = WriterRepository.GetAllWriters();
            Repeater1.DataBind();


            if (Request.QueryString["ID"] != null)
            {
                int id = int.Parse(Request.QueryString["ID"]);

                WriterRepository.DeleteWriter(id);

                Response.Redirect("WriterList.aspx");
            }
        }
    }
}