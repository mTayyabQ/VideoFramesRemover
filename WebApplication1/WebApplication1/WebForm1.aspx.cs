using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DataClasses1DataContext Context = new DataClasses1DataContext();
        protected void Button1_Click(object sender, EventArgs e)
        {  
            
            
            
            
            
            // String path="Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Dumbaa\\Documents\\Visual Studio 2012\\Projects\\WebApplication1\\WebApplication1\\App_Data\\Database1.mdf;Integrated Security=True";
        //    SqlConnection con = new SqlConnection(path);
        
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("ADD",con);
        //    //SqlCommand cmd = new SqlCommand("insert into reg (name, fName) VALUES (@name,@fname)", con);

        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@name",TextBoxName.Text);
        //    cmd.Parameters.AddWithValue("@fname", TextBoxFname.Text);
            
           
        //    cmd.ExecuteNonQuery();
        //    Response.Write("<Script> alert('Date inserted Successfully!')</Script>");
            
        //    con.Close();
        }
        user userTable = new user();
        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {   
            
           
            var query = Context.users.SingleOrDefault(i => i.Email ==TextBoxEmail.Text && i.Password == TextBoxPassword.Text);
            if (query != null)
            {
                Response.Redirect("/Wellcome.aspx");
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Welcome To VideoEditor '); window.location ='/Registration.aspx';", true);
            }
            else {
                LabelErrorr.Text="Email Or Password Invalid!";
            }
        }
    }
}