using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ChangePassord : System.Web.UI.Page
    {
        string email = "";
        DataClasses1DataContext _context = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            email=Request.QueryString["Email"];
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text != TextBoxpassword2.Text)
            {
                LabelErrorr.Text = "Password Does Not Match Please Try Again!";
            }
            else
            {
                var query = _context.users.SingleOrDefault(u => u.Email == email);
                LabelErrorr.Text = query.Id.ToString();
                query.Password = TextBoxPassword.Text;
                _context.SubmitChanges();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Your Password has been updated successfully '); window.location ='/webForm1.aspx';", true);
            }
        }
    }
}