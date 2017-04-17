using Library.DAL;
using Library.Entity.Model;
using System;

namespace Library.WEB
{
    public partial class AddNewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            User newUser = new User()
            {
                UserName = TextBoxUserName.Text,
                Address = TextBoxAddress.Text,
                PhoneNumber = TextBoxPhone.Text
            };
            UserRepository.AddUser(newUser);
            Response.Redirect("UserList.aspx");
        }
    }
}