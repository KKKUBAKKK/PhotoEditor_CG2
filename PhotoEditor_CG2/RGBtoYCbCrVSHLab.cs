using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor_CG2
{
    public partial class RGBtoYCbCrVSHLab : Form
    {
        string path;

        Bitmap originalImage;
        Bitmap firstImage;
        Bitmap secondImage;
        Bitmap thirdImage;

        public RGBtoYCbCrVSHLab()
        {
            InitializeComponent();
            path = "";
            radioButtonYCbCr.Checked = true;
        }

        private void chooseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set file dialog properties
                openFileDialog.Title = "Select a file";
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
                string projectDirectory = Application.StartupPath;
                string dataFolderPath = Path.Combine(projectDirectory, "data");
                openFileDialog.InitialDirectory = dataFolderPath;
                //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Show the dialog and check if the user clicked OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file's path
                    path = openFileDialog.FileName;

                    originalImage = new Bitmap(path);
                    pictureBoxOriginal.Image = originalImage;

                    radioButtonYCbCr_CheckedChanged(null, null);

                    // Use the selected file path (e.g., display the file name in a Label or TextBox)
                    MessageBox.Show($"You selected: {path}");
                }
            }
        }

        private void radioButtonHSV_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHSV.Checked)
            {
                radioButtonLab.Checked = false;
                radioButtonYCbCr.Checked = false;
            }

            if (path != "")
            {
                (firstImage, secondImage, thirdImage) = HSVChannelConverter.ConvertToHSVChannels(originalImage);
                pictureBoxOne.Image = firstImage;
                pictureBoxTwo.Image = secondImage;
                pictureBoxThree.Image = thirdImage;
            }
        }

        private void radioButtonYCbCr_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYCbCr.Checked)
            {
                radioButtonLab.Checked = false;
                radioButtonHSV.Checked = false;
            }

            if (path != "")
            {
                (firstImage, secondImage, thirdImage) = YCbCrChannelConverter.ConvertToYCbCrChannels(originalImage);
                pictureBoxOne.Image = firstImage;
                pictureBoxTwo.Image = secondImage;
                pictureBoxThree.Image = thirdImage;
            }
        }

        private void radioButtonLab_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLab.Checked)
            {
                radioButtonHSV.Checked = false;
                radioButtonYCbCr.Checked = false;
            }
        }
    }

    public class YCbCrChannelConverter
    {
        public static (Bitmap Y, Bitmap Cb, Bitmap Cr) ConvertToYCbCrChannels(Bitmap originalBitmap)
        {
            // Создаем новые битмапы того же размера
            Bitmap yBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);
            Bitmap cbBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);
            Bitmap crBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            // Проходим по всем пикселям
            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    // Получаем цвет пикселя
                    Color pixelColor = originalBitmap.GetPixel(x, y);

                    // Конвертация RGB в YCbCr
                    byte Y = (byte)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                    byte Cb = (byte)((pixelColor.B - Y) * 0.565 + 128);
                    byte Cr = (byte)((pixelColor.R - Y) * 0.713 + 128);

                    // Устанавливаем пиксели для каждого канала
                    yBitmap.SetPixel(x, y, Color.FromArgb(Y, Y, Y));

                    // Интерполяция цветов для Cb
                    Color cbColor = InterpolateCbColor(Cb);
                    cbBitmap.SetPixel(x, y, cbColor);

                    // Интерполяция цветов для Cr
                    Color crColor = InterpolateCrColor(Cr);
                    crBitmap.SetPixel(x, y, crColor);
                }
            }

            return (yBitmap, cbBitmap, crBitmap);
        }

        private static Color InterpolateCbColor(byte cb)
        {
            // Interpolacja między (127,255,0) a (127,0,255)
            double t = cb / 255.0;
            int r = 127;
            int g = (int)(255 * (1 - t));
            int b = (int)(255 * t);

            return Color.FromArgb(r, g, b);
        }

        private static Color InterpolateCrColor(byte cr)
        {
            // Interpolacja między (0,255,127) a (255,0,127)
            double t = cr / 255.0;
            int r = (int)(255 * t);
            int g = (int)(255 * (1 - t));
            int b = 127;

            return Color.FromArgb(r, g, b);
        }

        // Dodatkowa metoda dla bardziej wydajnego przetwarzania dużych obrazów
        public static (Bitmap Y, Bitmap Cb, Bitmap Cr) ConvertToYCbCrChannelsFaster(Bitmap originalBitmap)
        {
            // Tworzy kopie bitmap z zachowaniem pikseli
            Bitmap yBitmap = new Bitmap(originalBitmap);
            Bitmap cbBitmap = new Bitmap(originalBitmap);
            Bitmap crBitmap = new Bitmap(originalBitmap);

            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color pixelColor = originalBitmap.GetPixel(x, y);

                    byte Y = (byte)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                    byte Cb = (byte)((pixelColor.B - Y) * 0.565 + 128);
                    byte Cr = (byte)((pixelColor.R - Y) * 0.713 + 128);

                    yBitmap.SetPixel(x, y, Color.FromArgb(Y, Y, Y));
                    cbBitmap.SetPixel(x, y, InterpolateCbColor(Cb));
                    crBitmap.SetPixel(x, y, InterpolateCrColor(Cr));
                }
            }

            return (yBitmap, cbBitmap, crBitmap);
        }
    }

    public class HSVChannelConverter
    {
        public static (Bitmap H, Bitmap S, Bitmap V) ConvertToHSVChannels(Bitmap originalBitmap)
        {
            // Создаем новые битмапы того же размера
            Bitmap hBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);
            Bitmap sBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);
            Bitmap vBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color pixelColor = originalBitmap.GetPixel(x, y);

                    // Konwersja RGB do HSV
                    (double h, double s, double v) = RgbToHsv(pixelColor.R, pixelColor.G, pixelColor.B);

                    // Konwersja wartości do zakresu 0-255
                    byte H = (byte)((h / 360.0) * 255);
                    byte S = (byte)(s * 255);
                    byte V = (byte)(v * 255);

                    // Ustawienie pikseli w odcieniach szarości
                    hBitmap.SetPixel(x, y, Color.FromArgb(H, H, H));
                    sBitmap.SetPixel(x, y, Color.FromArgb(S, S, S));
                    vBitmap.SetPixel(x, y, Color.FromArgb(V, V, V));
                }
            }

            return (hBitmap, sBitmap, vBitmap);
        }

        private static (double H, double S, double V) RgbToHsv(byte r, byte g, byte b)
        {
            double rNorm = r / 255.0;
            double gNorm = g / 255.0;
            double bNorm = b / 255.0;

            double cmax = Math.Max(rNorm, Math.Max(gNorm, bNorm));
            double cmin = Math.Min(rNorm, Math.Min(gNorm, bNorm));
            double diff = cmax - cmin;

            double h = -1;
            double s = 0;

            // Obliczenie Hue
            if (diff == 0)
                h = 0;
            else if (cmax == rNorm)
                h = (60 * ((gNorm - bNorm) / diff) + 360) % 360;
            else if (cmax == gNorm)
                h = (60 * ((bNorm - rNorm) / diff) + 120);
            else if (cmax == bNorm)
                h = (60 * ((rNorm - gNorm) / diff) + 240);

            // Obliczenie Saturation
            if (cmax == 0)
                s = 0;
            else
                s = (diff / cmax);

            // Obliczenie Value
            double v = cmax;

            return (h, s, v);
        }

        // Alternatywna metoda dla dużych obrazów
        public static (Bitmap H, Bitmap S, Bitmap V) ConvertToHSVChannelsFaster(Bitmap originalBitmap)
        {
            Bitmap hBitmap = new Bitmap(originalBitmap);
            Bitmap sBitmap = new Bitmap(originalBitmap);
            Bitmap vBitmap = new Bitmap(originalBitmap);

            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color pixelColor = originalBitmap.GetPixel(x, y);

                    (double h, double s, double v) = RgbToHsv(pixelColor.R, pixelColor.G, pixelColor.B);

                    byte H = (byte)((h / 360.0) * 255);
                    byte S = (byte)(s * 255);
                    byte V = (byte)(v * 255);

                    hBitmap.SetPixel(x, y, Color.FromArgb(H, H, H));
                    sBitmap.SetPixel(x, y, Color.FromArgb(S, S, S));
                    vBitmap.SetPixel(x, y, Color.FromArgb(V, V, V));
                }
            }

            return (hBitmap, sBitmap, vBitmap);
        }
    }
}
