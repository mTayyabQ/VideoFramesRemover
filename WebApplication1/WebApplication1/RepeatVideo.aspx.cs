using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FFMpegSharp.FFMPEG;
namespace WebApplication1
{
    public partial class RepeatVideo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelProcess.Text = "Video";
            Literal1.Text = "<Video  width=100%  Controls loop><Source src=" + @"C: \Users\It Complex\Downloads\videoeditor3_SoWMWPTx_ZGO2.mp4" + " type=video/mp4></video> ";

            // string inputImageFile = @"F:\filr.jpg",
            //  audioImageFile = @"F:\audio.mp3",
            //outputImageFile = @"F:\video.mp4";
            // FFMpeg encoder = new FFMpeg();
            // new FFMpeg().PosterWithAudio(
            //     new FileInfo(inputImageFile),
            //     new FileInfo(audioImageFile),
            //     new FileInfo(outputImageFile));
        }

        protected void ButtonPlay_Click(object sender, EventArgs e)
        {
       //     string inputVideoFile = @"C:\Users\It Complex\Downloads\videoeditor3_SoWMWPTx_ZGO2.mp4",
       //inputAudioFile = @"C:\Users\It Complex\Downloads\YQEH4cIyBa8BZocG_1595565346.mp3",
       //outputVideoFile = @"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\AudioVideoMarged\AudioVideo.mp4";

       //     FFMpeg encoder = new FFMpeg();

       //     new FFMpeg()
       //         .ReplaceAudio(
       //             FFMpegSharp.VideoInfo.FromPath(inputVideoFile),
       //             new FileInfo(inputAudioFile),
       //             new FileInfo(outputVideoFile)
       //         );
       //     Literal1.Text = "<Video  width=100%  Controls ><Source src=" + outputVideoFile + " type=video/mp4></video> ";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int value = Convert.ToInt16(TextBox1.Text);
            //for (int i = 0; i <= value; i++) 
            //{
            // repeat();
            //}

            string path = Path.GetFileName(FileUpload1.FileName);
            path = path.Replace(" ", "");
            FileUpload1.SaveAs(Server.MapPath("~/AudioVideo/") + path);
            String link = @"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\AudioVideo\" + path;

            string path2 = Path.GetFileName(FileUpload2.FileName);
            path = path.Replace(" ", "");
            FileUpload2.SaveAs(Server.MapPath("~/AudioVideo/") + path2);
            String link2 = @"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\AudioVideo\" + path2;


            string inputVideoFile = @"C:\Users\It Complex\Downloads\" + FileUpload1.PostedFile.FileName,
     inputAudioFile = @"C:\Users\It Complex\Downloads\"+ FileUpload2.PostedFile.FileName,
     outputVideoFile = @"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\AudioVideoMarged\margerr.mp4";
            LabelProcess.Text = "Video in Process...";
            FFMpeg encoder = new FFMpeg();

            new FFMpeg()
                .ReplaceAudio(
                    FFMpegSharp.VideoInfo.FromPath(inputVideoFile),
                    new FileInfo(inputAudioFile),
                    new FileInfo(outputVideoFile)
                );


            string linkPath = "AudioVideoMarged/margerr.mp4";
            Literal1.Text = "<Video  width=100%  Controls loop><Source src=" + linkPath + " type=video/mp4></video> ";
            LabelProcess.Text = "Processed Video... ";
        }
        
    }
}