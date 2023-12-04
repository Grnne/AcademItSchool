﻿using System.Drawing;
using System.Drawing.Imaging;

namespace BlurImage;

internal class BlurImage
{
    static void Main(string[] args)
    {
        string path = "..\\..\\..\\";
        using Bitmap inputImage = new(path + "image.jpg");
        inputImage.Save(path + "out.jpg", ImageFormat.Jpeg);
        using Bitmap outputImage = inputImage;
        int blurIntensity = 5;  // Можно использовать нечетные числа

        BlurWholeImage(inputImage, outputImage, blurIntensity);
        outputImage.Save(path + "out.jpg", ImageFormat.Jpeg);
    }

    // TODO стоит сделать, наверное, шарпен, тиснение и акварель

    public static Bitmap BlurWholeImage(Bitmap inputImage, Bitmap outputImage, int blurIntensity)
    {
        Color[,] convolutionMatrix = new Color[blurIntensity, blurIntensity];

        for (int y = 0; y < inputImage.Height; ++y)
        {
            for (int x = 0; x < inputImage.Width; ++x)
            {
                outputImage.SetPixel(x, y, GetBlurredPixel(x, y, inputImage, convolutionMatrix, blurIntensity));
            }
        }

        return outputImage;
    }

    public static Color GetBlurredPixel(int x, int y, Bitmap inputImage, Color[,] convolutionMatrix, int blurIntensity)
    {
        convolutionMatrix = GetConvolutionMatrix(x, y, inputImage, convolutionMatrix, blurIntensity);
        (double, double, double) rgbSum = (0, 0, 0);

        foreach (Color pixel in convolutionMatrix)
        {
            rgbSum.Item1 += pixel.R;
            rgbSum.Item2 += pixel.G;
            rgbSum.Item3 += pixel.B;
        }

        blurIntensity *= blurIntensity;

        return Color.FromArgb(
            Saturate(rgbSum.Item1 / blurIntensity),
            Saturate(rgbSum.Item2 / blurIntensity),
            Saturate(rgbSum.Item3 / blurIntensity));
    }

    public static Color[,] GetConvolutionMatrix(int x, int y, Bitmap inputImage, Color[,] convolutionMatrix, int matrixSize)
    {
        int halfMatrixSize = matrixSize / 2;

        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                int currentPositionX = x - halfMatrixSize + j;
                int currentPositionY = y - halfMatrixSize + i;

                if (currentPositionX < 0 || currentPositionX >= inputImage.Width
                    || currentPositionY < 0 || currentPositionY >= inputImage.Height)
                {
                    convolutionMatrix[i, j] = inputImage.GetPixel(x, y);
                }
                else
                {
                    convolutionMatrix[i, j] = inputImage.GetPixel(currentPositionX, currentPositionY);
                }
            }
        }

        return convolutionMatrix;
    }

    public static int Saturate(double colorComponent)
    {
        int roundedColorComponent = (int)Math.Round(colorComponent, MidpointRounding.AwayFromZero);

        if (roundedColorComponent < 0)
        {
            return 0;
        }

        if (roundedColorComponent > 255)
        {
            return 255;
        }

        return roundedColorComponent;
    }
}