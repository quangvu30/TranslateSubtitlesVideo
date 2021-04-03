using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslateSubtitleVideo.functions;

namespace TranslateSubtitleVideo.controller
{
    class VideoController
    {
        string folderFrames;
        public async Task GetSubtitlesFromVideo()
        {
            string[] Images = Directory.GetFiles(folderFrames);

            foreach (string image in Images)
            {
                string fileName = Path.GetFileName(image);
                Bitmap b = (Bitmap)Bitmap.FromFile(image);
                DetectText detectText = new DetectText(env.Default.KeyId, env.Default.SecretKey);
                List<string> contents = await detectText.TextDetection(b);
                CreateSubtitles.CreateFileSubtitle(int.Parse(fileName), contents);
            }
        }

        void SplitFrames()
        {

        }
    }
}
