using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranslateSubtitleVideo.controller;
using TranslateSubtitleVideo.models;

namespace TranslateSubtitleVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FirefoxController firefox = new FirefoxController();
            //firefox.Translate(@"D:\Project\BTLLLL\VideoProcessing\VideoProcessing\bin\Debug\EngSub.txt");
            CreateSubtitles.CreateFileSubtitle(306, new List<string>() { "Quang" });
            Console.WriteLine(env.Default.KeyId + ", " + env.Default.SecretKey);
        }
    }
}
