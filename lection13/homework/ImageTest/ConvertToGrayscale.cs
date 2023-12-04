using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ConvertToGrayscale;

class ConvertToGrayscale
{
    static void Main(string[] args)
    {
        string path = "..\\..\\..\\";
        using Bitmap image = new Bitmap(path + "image.jpg");

        for (int y = 0; y < image.Height; ++y)
        {
            for (int x = 0; x < image.Width; ++x)
            {
                Color pixel = image.GetPixel(x, y);

                int gray = (int)Math.Round(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B, MidpointRounding.AwayFromZero);
                Color newPixel = Color.FromArgb(gray, gray, gray);

                image.SetPixel(x, y, newPixel);
            }
        }

        image.Save(path + "out.jpg", ImageFormat.Jpeg);
    }
}