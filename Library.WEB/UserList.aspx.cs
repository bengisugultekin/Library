using Library.DAL;
using System;

namespace Library.WEB
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = UserRepository.GetAllUsers();
            Repeater1.DataBind();
        }
    }
}