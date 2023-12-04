using System.Drawing;
using System.Drawing.Imaging;

namespace ConvertToGrayscale
{
    class InvertColors
    {
        static void Main(string[] args)
        {
            const int maxRgb = 255;
            using Bitmap image = new Bitmap("..\\..\\..\\image.jpg");
            
            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    Color pixel = image.GetPixel(x, y);
                    
                    Color newPixel = Color.FromArgb(maxRgb - pixel.R, maxRgb - pixel.G, maxRgb - pixel.B);
                    
                    image.SetPixel(x, y, newPixel);
                }
            }

            image.Save("..\\..\\..\\out.jpg", ImageFormat.Jpeg);
        }
    }
}
