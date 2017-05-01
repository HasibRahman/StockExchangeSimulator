using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using User;
using StockUserBusinessLogicLayer;
namespace StockUser
{
    public partial class Registration : System.Web.UI.Page
    {
        Users user = new Users();
        BusinessLayer businessLayer = new BusinessLayer();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            user.FullName = txtFullName.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPass.Text;
            businessLayer.Register(user);
        }

    }
}