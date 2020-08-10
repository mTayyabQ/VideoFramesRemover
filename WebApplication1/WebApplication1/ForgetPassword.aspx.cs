using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        DataClasses1DataContext _context = new DataClasses1DataContext();
        
        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
           user userTable = new user();
           var query = _context.users.SingleOrDefault(u => u.Email == TextBoxEmail.Text);
           if (query != null)
           {
               string url;
               url = "ChangePassord.aspx?Email=" +
                   TextBoxEmail.Text;
               Response.Redirect(url);
               
           }
           else
            {
                LabelErrorr.Text = "Email you enter does not exist!";

            }
        }
    }
}