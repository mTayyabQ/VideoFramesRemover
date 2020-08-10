using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DeleteFrames : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string path = Path.GetFileName(FileUpload1.FileName);
            path = path.Replace(" ", "");
            FileUpload1.SaveAs(Server.MapPath("~/Videos/") + path);

            string url= "C:\\Users\\It Complex\\Downloads\\VideoEditor\\WebApplication1\\WebApplication1\\Videos\\" +
                FileUpload1.PostedFile.FileName; ;
            //url = "vidioEditor.aspx?Url=" + "C:\\Users\\It Complex\\Downloads\\VideoEditor\\WebApplication1\\WebApplication1\\Videos\\" +
            //    FileUpload1.PostedFile.FileName;
            HttpCookie cookie = new HttpCookie("Path");
            cookie["VideoPath"] = url;
            cookie.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(cookie);
            Response.Redirect("~/vidioEditor.aspx");
        }
    }
}