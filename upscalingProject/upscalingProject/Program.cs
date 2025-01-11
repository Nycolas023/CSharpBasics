using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Carregar a imagem original
        Mat src = Cv2.ImRead("caminho/para/sua/imagem.jpg");

        // Definir o novo tamanho
        int newWidth = 1920;
        int newHeight = 1080;

        // Criar um novo Mat para a imagem redimensionada
        Mat dst = new Mat();

        // Redimensionar a imagem usando interpolação cúbica
        Cv2.Resize(src, dst, new Size(newWidth, newHeight), 0, 0, InterpolationFlags.Cubic);

        // Salvar a imagem redimensionada
        Cv2.ImWrite("caminho/para/sua/imagem_upscaled_hd.jpg", dst);

        Console.WriteLine("Imagem redimensionada e salva com sucesso!");
    }
}
