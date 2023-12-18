using System.Drawing;
using System.Drawing.Imaging;

namespace BlurImage;

internal class BlurImage
{
    static void Main(string[] args)
    {
        string path = "..\\..\\..\\";
        using Bitmap inputImage = new(path + "image.jpg");

        int matrixSize = 15;  // Можно использовать нечетные числа
        double[,] convolutionMatrix = new double[matrixSize, matrixSize];
        double matrixElementRatio = 1.0 / (matrixSize * matrixSize);

        for (int y = 0; y < matrixSize; y++)
        {
            for (int x = 0; x < matrixSize; x++)
            {
                convolutionMatrix[x, y] = matrixElementRatio;
            }
        }

        TransformImage(inputImage, path, convolutionMatrix);
    }

    public static void TransformImage(Bitmap inputImage, string path, double[,] convolutionMatrix)
    {
        int matrixSize = convolutionMatrix.GetLength(0);
        int halfMatrixSize = matrixSize / 2;
        int imageHeight = inputImage.Height;
        int imageWidth = inputImage.Width;

        using Bitmap outputImage = new(inputImage.Width, inputImage.Height);

        for (int y = 0; y < imageHeight; y++)
        {
            for (int x = 0; x < imageWidth; x++)
            {
                double transformedR = 0;
                double transformedG = 0;
                double transformedB = 0;
                int neighborY = y - halfMatrixSize;

                for (int i = 0; i < matrixSize; i++, neighborY++)
                {
                    int neighborX = x - halfMatrixSize;

                    for (int j = 0; j < matrixSize; j++, neighborX++)
                    {
                        Color pixel;

                        if (neighborX < 0 || neighborX >= imageWidth
                            || neighborY < 0 || neighborY >= imageHeight)
                        {
                            pixel = inputImage.GetPixel(x, y);
                        }
                        else
                        {
                            pixel = inputImage.GetPixel(neighborX, neighborY);
                        }

                        transformedR += pixel.R * convolutionMatrix[i, j];
                        transformedG += pixel.G * convolutionMatrix[i, j];
                        transformedB += pixel.B * convolutionMatrix[i, j];
                    }
                }
                transformedR = Saturate(transformedR);
                transformedG = Saturate(transformedG);
                transformedB = Saturate(transformedB);

                outputImage.SetPixel(x, y, Color.FromArgb((int)transformedR, (int)transformedG, (int)transformedB));
            }
        }

        outputImage.Save(path + "out.jpg", ImageFormat.Jpeg);
    }

    public static int Saturate(double colorComponent)
    {
        if (colorComponent <= 0)
        {
            return 0;
        }

        if (colorComponent >= 255)
        {
            return 255;
        }

        return (int)Math.Round(colorComponent, MidpointRounding.AwayFromZero);
    }
}