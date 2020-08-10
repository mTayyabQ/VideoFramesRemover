using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DataClasses1DataContext Context = new DataClasses1DataContext();
        user UserTabl = new user();
        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text != TextBoxConfiPassword.Text)
            {
                LabelErrorr.Text = "Password Entities Does not matched! Try Again";
            }
            else
            {
                UserTabl.FirstName = TextBoxFirstName.Text;
                UserTabl.LastName = TextBoxLastName.Text;
                UserTabl.Email = TextBoxEmail.Text;
                UserTabl.Password = TextBoxPassword.Text;
                UserTabl.Age = Convert.ToInt32(TextBoxAge.Text);
                UserTabl.number = TextBoxNumber.Text;
                UserTabl.Gender = DropDownListGender.SelectedValue;
                UserTabl.Occupation = DropDownListOccupation.SelectedValue;
                
                Context.users.InsertOnSubmit(UserTabl);
                Context.SubmitChanges();
                Response.Write("<Script> alert('You Are Registered Successfully!')</Script>");
            }

        }
    }
}