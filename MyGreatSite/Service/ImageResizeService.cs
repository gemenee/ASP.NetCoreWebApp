using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkiaSharp;
using System.IO;


namespace MyGreatSite.Service
{
    public static class ImageResizeService
    {
        //public static void resizeTo1080(string fileName)
        //{
        //    var oldImage = SKBitmap.Decode(fileName);
           
        //    SKImageInfo info = oldImage.Info;
            
        //    if (info.Width > 1080)
        //    {
        //        info.Width = 1080;
        //        info.Height = info.Height * (Int32)Math.Ceiling((double)(oldImage.Width / 1080));
        //    }

        //    if (info.Height > 1080)
        //    {
        //        info.Height = 1080;
        //        info.Width = info.Width * (Int32)Math.Ceiling((double)(oldImage.Height / 1080));
        //    }

        //    using (FileStream file = File.Create(fileName))
        //    {
        //        file.Write(oldImage.Resize(info, SKFilterQuality.High).Encode(SKEncodedImageFormat.Jpeg, 1).AsSpan());
        //    }
        //}

        public static Stream resizeTo1080(Stream stream)
        {
            var oldImage = SKBitmap.Decode(stream);
            bool isPortrait = oldImage.Height >= oldImage.Width;

            SKImageInfo info = oldImage.Info;

            if (info.Width > 1080)
            {
                info.Width = 1080;
                info.Height = (int)Math.Ceiling(info.Height * (1080.0 / oldImage.Width));
            }

            if (info.Height > 1080)
            {
                info.Height = 1080;
                info.Width = (int)Math.Ceiling(info.Width * (1080.0 / oldImage.Height));
            }
            
            return oldImage.Resize(info, SKFilterQuality.High).Encode(SKEncodedImageFormat.Jpeg, 100).AsStream();

        }
    }
}
