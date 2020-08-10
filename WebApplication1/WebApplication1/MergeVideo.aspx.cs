using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Splicer;
using Splicer.Timeline;
using Splicer.Renderer;
using FFMpegSharp.FFMPEG;
using FFMpegSharp;

namespace WebApplication1
{
    public partial class MergeVideo : System.Web.UI.Page
    {
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (count == 0)
            {

                UpdateList();
                count++;
            }

            String link = @"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\marge\" + "output.avi";
            Literal1.Text = "<Video width=100% Controls><Source src=" + link + " type=video/avi></video>";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            margeVideos();
            UpdateList();

        }
        public void UpdateList()
        {

            //ListBox1.Items.Clear();
            foreach (string i in Directory.GetFiles(Server.MapPath("~/VideoMarger/")))
            {
                FileInfo info = new FileInfo(i);
                ListBox1.Items.Add(info.Name);
            }

        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            if (ListBox1.SelectedIndex < 0)
            {
                Labelplay.Text = "Video Does not Exist";
                
            }
            else
            {
                Labelplay.Text = ListBox1.SelectedItem.Text;
                String link = "VideoMarger/" + ListBox1.SelectedItem.Text;
                Literal1.Text = "<Video width=100% Controls><Source src=" + link + " type=video/mp4></video>";
              
            }
        }

        public void margeVideos()
        {
            
            string path = Path.GetFileName(FileUpload1.FileName);
            path = path.Replace(" ", "");
            FileUpload1.SaveAs(Server.MapPath("~/AudioVideo/") + path);
            String link = @"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\AudioVideo\" + path;
            
            string path2 = Path.GetFileName(FileUpload2.FileName);
            path = path.Replace(" ", "");
            FileUpload2.SaveAs(Server.MapPath("~/AudioVideo/") + path2);
            String link2 = @"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\AudioVideo\" + path2;

            FFMpeg encoder = new FFMpeg();

            encoder.Join(
                new FileInfo(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoMarger\Marged.mp4"),
                VideoInfo.FromPath(link),
                VideoInfo.FromPath(link2)
                
            );
        }
    }
}