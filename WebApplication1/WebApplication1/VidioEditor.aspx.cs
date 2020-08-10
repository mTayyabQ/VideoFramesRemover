using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using GleamTech.VideoUltimate;
using System.Threading.Tasks;
using System.Threading;
//using AForge;
//using AForge.Video;
using FFMpegSharp;
using FFMpegSharp.FFMPEG;
using System.Collections;
//using Accord;
//using Accord.Video;
//using AForge.Video.FFMPEG;
//using Accord.Video.FFMPEG;
using System.Timers;
namespace WebApplication1
{
    public partial class VidioEditor : System.Web.UI.Page
    {
        double totalFrames;
        double FPS;
        static int frameNo=0;
        static int speed=1;
        VideoCapture capture;
        bool isReading =true;

        double totalFrames1;
        double FPS1;
        static int frameNo1=0;
        static int speed1=1;
        VideoCapture capture1;
        bool isReading1 = true;


        string VideoPath;
        int i = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (i != 0) { Timer2.Enabled = false; }
            else { i++; }
           // margeImages();
            HttpCookie cookie = Request.Cookies["Path"];
            VideoPath = cookie["VideoPath"];
           // VideoPath = Session["Url"].ToString();
            // Timer2.Enabled = false;
            // GetVideoFrames(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\Videos\VideoEditor.mp4");
            //margeImages();
           // SaveAudio();
            //MargeAudioVideo();
            if (!IsPostBack)
            {
                //VideoPath = Request.QueryString["url"];
                ListBox1.Items.Clear();
                foreach (string i in Directory.GetFiles(Server.MapPath("~/FrameCuttingVideos/")))
                {

                    FileInfo info = new FileInfo(i);
                    ListBox1.Items.Add(info.Name);
                }
            }

            
        }
        //VideoFileReader reader = new VideoFileReader( );
        //long count = 0;
        //long count2 = 0;
        //public void initial() 
        //{
        //    reader.Open(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\Videos\" + "4KAfricanWildlifeAfricanNatureShowreel2017byRobertHofmeyr.mp4");
        //    count = reader.FrameCount;
        //}

        //public void startRading() 
        //{
        //    if (count2 < count)
        //    {
        //        Bitmap videoFrame = reader.ReadVideoFrame();
        //        // process the frame somehow
        //        // ...
        //        MemoryStream stream = new MemoryStream();
        //        videoFrame.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
        //        Byte[] bytes = stream.ToArray();

        //        Image1.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
        //        // dispose the frame when it is no longer required
        //        videoFrame.Dispose();
        //    }
        //    else
        //       // reader.Close();
        //}
        double HowManyFramRead =0.0;
        double fps;
        private void GetVideoFrames(String Filename)  //List<Image<Bgr, Byte>> 
        {
            List<Image<Bgr, Byte>> image_array = new List<Image<Bgr, Byte>>();
            VideoCapture _capture = new VideoCapture(Filename);
            double totalFrames = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
            double fps = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
            double frameNumber = 0.0;

            bool Reading = true;
            Bitmap bitmap;
            
            while (Reading)
            {
                _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, frameNumber);

                Mat m = new Mat();
                _capture.Read(m);
               

                bitmap = m.Bitmap;
                //MemoryStream stream = new MemoryStream();
                //bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                //Byte[] bytes = stream.ToArray();
                if (bitmap != null)
                {
                    Image<Bgr, Byte> frame = new Image<Bgr, Byte>(bitmap); //_capture.Read(m);
                    if (frame != null)   //frame != null
                    {
                        //image_array.Add(frame.Copy());

                        //frame.Save(OutFileLocation + "\\" + Guid.NewGuid() + ".jpg");
                        HowManyFramRead = frameNumber;
                        frame.Save(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages" + "\\" + frameNumber + ".png");
                    }
                    else
                    {
                        Reading = false;
                    }

                    frameNumber++; //+= (fps * 1000);
                }
                else { return; }
            }

            //return image_array;
        }
        
       
        public void margeImages()
        {
            FFMpeg encoder = new FFMpeg();
            //files kasy read kar rah
            List<ImageInfo> arr = new List<ImageInfo>();

            for (int i = 0; i <= HowManyFramRead; i++)
            {
                foreach (var item in ListBoxDelete.Items)
                {
                    if (item.ToString() == i.ToString())
                    {
                        int j = i;
                        j = j - 1;
                        arr.Add(ImageInfo.FromPath(@"C:\\Users\\It Complex\\Downloads\\VideoEditor\\WebApplication1\\WebApplication1\\VideoImages\\" + j + ".png"));
                    }
                    else 
                    {
                        arr.Add(ImageInfo.FromPath(@"C:\\Users\\It Complex\\Downloads\\VideoEditor\\WebApplication1\\WebApplication1\\VideoImages\\" + i + ".png"));
                    }
                }
                    
                
            }


            encoder.JoinImageSequence(
                new FileInfo(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\joined_video.mp4"),
                25,
                arr.ToArray()
                // FPS
                //ImageInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\1.png"),
                //ImageInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\2.png"),
                //ImageInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\3.png"),
                //ImageInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\4.png"),
                //ImageInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\5.png"),
                //ImageInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\6.png"),
                //ImageInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\7.png"),
                //ImageInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\8.png"),
                //ImageInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\9.png"),
                //ImageInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\10.png"),
                //ImageInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\11.png"),
                //ImageInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\12.png"),
                //ImageInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\13.png")
                );

            return;
        }

        public void SaveAudio() 
        {           
            string inputVideoFile = VideoPath,
       outputAudioFile = @"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\audioTrack1.mp3";

            new FFMpeg()
                .ExtractAudio(
                    VideoInfo.FromPath(inputVideoFile),
                    new FileInfo(outputAudioFile)
                );
            return;
        }

        public void MargeAudioVideo() 
        {
            FFMpeg encoder = new FFMpeg();

            new FFMpeg()
                .ReplaceAudio(
                    FFMpegSharp.VideoInfo.FromPath(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\joined_video.mp4"),
                    new FileInfo(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\VideoImages\audioTrack1.mp3"),
                    new FileInfo(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\FrameCuttingVideos\RemoveFrameVideo.mp4")
                );

            
            return;
        }



        protected void Timer2_Tick(object sender, EventArgs e)
        {




            //LabelFramePS.Text = System.DateTime.Now.ToString();
            //if (Timer2.Enabled == true)
            //{
            //    LabelFramePS.Text = speed.ToString();
            //    LabelFrameNo.Text = frameNo.ToString();

            //    if (capture == null)
            //    {
            //        if (frameNo > totalFrames)
            //        {
            //            LabelFrameNo.Text = totalFrames.ToString();
            //        }
            //        Timer2.Enabled = false;
            //        Label3.Text = "Video Frames has been Ended!";
            //    }
            //    else
            //    {
            //        LoadTotalFrames();
            //    }
            //}


            //FramesRead();
            //GetVideoFrames(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\Videos\VideoEditor.mp4");
        }

        protected void Timer2_Load(object sender, EventArgs e)
        {
            //GetFrames();
           
            
            //LabelFramePS.Text = System.DateTime.Now.ToString();
            //initial();
        }



        public void FramesRead() 
        {
          //  create instance of video reader
           //VideoFileReader reader = new VideoFileReader();
           // open video file
           // reader.Open(@"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\Videos\" + "4KAfricanWildlifeAfricanNatureShowreel2017byRobertHofmeyr.mp4");
           // // check some of its attributes
           // Console.WriteLine("width:  " + reader.Width);
           // Console.WriteLine("height: " + reader.Height);
           // Console.WriteLine("fps:    " + reader.FrameRate);
           // Console.WriteLine("codec:  " + reader.CodecName);
           // // read 100 video frames out of it
           // for (int i = 0; i < reader.FrameCount; i++)
           // {
           //     Bitmap videoFrame = reader.ReadVideoFrame();
           //     // process the frame somehow
           //     // ...
           //     MemoryStream stream = new MemoryStream();
           //     videoFrame.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
           //     Byte[] bytes = stream.ToArray();

           //     Image1.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
           //     // dispose the frame when it is no longer required
           //     videoFrame.Dispose();
           // }
           // reader.Close();



        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                string path = Path.GetFileName(FileUpload1.FileName);
                path = path.Replace(" ", "");
                FileUpload1.SaveAs(Server.MapPath("~/Videos/") + path);
                UpdateList();
                String link = "Videos/" + path;
                Literal1.Text = "<Video width=100% Controls><Source src=" + link + " type=video/mp4></video>";
                
                Label3.Text = "Video Uploaded Successfully";
                Thread t1 = new Thread(new ThreadStart(GetFrames));
                GetFrames();
                Timer2.Enabled = true;
            }
            catch
            {
                Label3.Text = "Fail to upload! Video size is too long!";
            }
        }

        protected void ButtonPlay_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedItem.Text == null)
            {
                Labelplay.Text = ListBox1.SelectedItem.Text;
            }
            else
            {
                String link = "FrameCuttingVideos/" + ListBox1.SelectedItem.Text;
                Literal1.Text = "<Video width=100% Controls><Source src=" + link + " type=video/mp4></video>";
               // ReadFrame();
               // GetFrames();
              
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListBox1.Items.Clear();
            //foreach (string i in Directory.GetFiles(Server.MapPath("~/videos/")))
            //{  
            //    FileInfo info = new FileInfo(i);
            //    ListBox1.Items.Add(info.Name);
            //}
        }

        

       

        public void UpdateList() 
        {
           
                ListBox1.Items.Clear();
                foreach (string i in Directory.GetFiles(Server.MapPath("~/videos/")))
                {

                    FileInfo info = new FileInfo(i);
                    ListBox1.Items.Add(info.Name);
                }
            
        }

        
        public void GetFrames()
        {

           
            Bitmap bitmap;
            //string path = Path.GetFileName(FileUpload1.FileName);
            //path = path.Replace(" ", "");
            //FileUpload1.SaveAs(Server.MapPath("~/Videos/") + path);
            //String link2 = @"C:\Users\It Complex\Downloads\VideoEditor\WebApplication1\WebApplication1\Videos\" + path;
            capture = new VideoCapture(VideoPath);
            Mat m = new Mat();
            capture.Read(m);
            
            bitmap = m.Bitmap;
            MemoryStream stream = new MemoryStream();
            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
            Byte[] bytes = stream.ToArray();
            
            Image1.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);
            
            FPS = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
            LabelFramePS.Text = FPS.ToString();
            totalFrames = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
            LabelTotal.Text = totalFrames.ToString();
        }

        public void LoadTotalFrames()
        {

           

            Bitmap bitmap;
            Mat m = new Mat();
            if (isReading == true && frameNo < totalFrames)
            {
                
                    frameNo = frameNo + speed;
                
                    capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, frameNo);
                    capture.Read(m);
                    LabelFrameNo.Text = frameNo.ToString();

                    bitmap = m.Bitmap;
                if (bitmap != null)
                {
                    MemoryStream stream = new MemoryStream();
                    bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                    Byte[] bytes = stream.ToArray();

                    Image1.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(bytes);


                    LabelFrameNo.Text = frameNo.ToString() + "/" + totalFrames.ToString();
                }
                else 
                {
                    Label3.Text = "Video Frame has been End";
                }
            }
            else { Label3.Text = "Video Frame has been End"; }
        }

        protected void ButtonStop_Click(object sender, EventArgs e)
        {

           isReading = false;
            Timer2.Enabled = false;
        }

       

     

       

        protected void ButtonPlayFram_Click(object sender, EventArgs e)
        {
            Timer2.Enabled = true;
        }

        //protected void ButtonIncrease_Click(object sender, EventArgs e)
        //{
        //    speed = speed + 1;
        //}

        //protected void ButtonDecrease_Click(object sender, EventArgs e)
        //{
        //    speed = speed - 1;
        //}

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            ListBoxDelete.Items.Add(frameNo.ToString());
           
        }

        public void DeleteFrame()
        {
            GetFramesForProcssing();
            if (capture1 == null)
            {
                return;
            }

            //  string destionpath = @"E:\PROJECTS\Development Projects\Tutorials\Emgucv\EmguCV # 21 Write video in Emgu CV\output.mp4";
            int fourcc = Convert.ToInt32(capture1.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FourCC));
            int Width = Convert.ToInt32(capture1.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth));
            int Height = Convert.ToInt32(capture1.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight));
            FPS1 = capture1.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
            string destination = Server.MapPath("~/UpdatedVideos/") + "updateVideo3.mp4";

            VideoCapture tempCapture = new VideoCapture();

            VideoWriter writer = new VideoWriter(destination, fourcc, FPS1, new Size(Width, Height), true);
            Mat m = new Mat();
            var temp = m;
            while (capture1 != null)
            {
                capture1.Read(m);
                //temp = m;
                writer.Write(m);
                
            }

            //while (frameNo1 <= totalFrames1)
            //{


            //    foreach (var item in ListBoxDelete.Items)
            //    {
            //        if (item.ToString() == frameNo1.ToString())
            //        {

            //            writer.Write(m);
            //            frameNo1++;
            //        }
            //        else
            //        {
                        
            //            capture1.Read(m);
            //            //temp = m;
            //            writer.Write(m);
            //            frameNo1++;
            //        }
            //    }
               
                
            //}

            if (writer.IsOpened)
            {
                writer.Dispose();
            }

            
        }

        public void GetFramesForProcssing()
        {
            capture1 = new VideoCapture(@"F:\updateVideo3.mp4");
            Mat m = new Mat();
            capture1.Read(m);
            FPS1 = capture1.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
            totalFrames1 = capture1.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount);
  
        }

        protected void ButtonDeleteFrames_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonRemoveFromList_Click(object sender, EventArgs e)
        {
            ListBoxDelete.Items.Remove(ListBoxDelete.SelectedItem);
        }

        

        protected void ListBoxProcessedList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonPlayProcessed_Click(object sender, EventArgs e)
        {

        }

        //protected void ButtonConfirmDeleteFrames_Click(object sender, EventArgs e)
        //{
            
        //}

        protected void ButtonDeletFrames_Click(object sender, EventArgs e)
        {
            //DeleteFrame();
            Timer2.Enabled = false;
            GetVideoFrames(VideoPath);
            margeImages();
            SaveAudio();
            MargeAudioVideo();
            UpdateVideoList();
        }

        public void UpdateVideoList() 
        {
            ListBox1.Items.Clear();
            foreach (string i in Directory.GetFiles(Server.MapPath("~/FrameCuttingVideos/")))
            {

                FileInfo info = new FileInfo(i);
                ListBox1.Items.Add(info.Name);
            }
        }

    }
}