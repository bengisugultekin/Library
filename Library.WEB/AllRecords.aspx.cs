using Library.DAL;
using System;

namespace Library.WEB
{
    public partial class RentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = RentRepository.GetAllRents();
            Repeater1.DataBind();
        }
    }
}