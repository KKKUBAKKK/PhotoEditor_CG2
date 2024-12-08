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
    public partial class RGBtoCMYK : Form
    {
        string path;
        Bitmap originalImage;
        Bitmap cyanImage;
        Bitmap magentaImage;
        Bitmap yellowImage;
        Bitmap blackImage;
        Bitmap graphImage;

        RGBToCMYKMapper RGBToCMYKMapper = new RGBToCMYKMapper(ChannelBezierCurves);

        public static Point2D[][] ChannelBezierCurves;

        public RGBtoCMYK()
        {
            InitializeComponent();
            path = "";
        }

        private void choosePhotoToolStripMenuItem_Click(object sender, EventArgs e)
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
                    //createCmykImages();

                    s_Click(null, null);

                    // Use the selected file path (e.g., display the file name in a Label or TextBox)
                    MessageBox.Show($"You selected: {path}");
                }
            }
        }

        public static void DrawBezierCurves(PictureBox pictureBox)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                // Colors for the curves
                Color[] colors = { Color.Cyan, Color.Magenta, Color.Yellow, Color.Black };

                for (int i = 0; i < ChannelBezierCurves.Length; i++)
                {
                    Point2D[] controlPoints = ChannelBezierCurves[i];
                    if (controlPoints.Length != 4) continue; // Skip if not a cubic Bézier curve

                    // Scale the control points to the PictureBox dimensions
                    PointF[] scaledPoints = new PointF[4];
                    for (int j = 0; j < controlPoints.Length; j++)
                    {
                        scaledPoints[j] = new PointF(
                            controlPoints[j].X * pictureBox.Width,
                            (1 - controlPoints[j].Y) * pictureBox.Height // Invert Y-axis for drawing
                        );
                    }

                    // Draw the curve
                    using (Pen curvePen = new Pen(colors[i], 2))
                    {
                        g.DrawBezier(curvePen, scaledPoints[0], scaledPoints[1], scaledPoints[2], scaledPoints[3]);
                    }

                    // Draw the control points
                    foreach (PointF point in scaledPoints)
                    {
                        using (Brush pointBrush = new SolidBrush(colors[i]))
                        {
                            g.FillEllipse(pointBrush, point.X - 4, point.Y - 4, 8, 8);
                        }
                    }

                    // Draw lines between control points
                    using (Pen controlLinePen = new Pen(Color.Gray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot })
                    {
                        g.DrawLine(controlLinePen, scaledPoints[0], scaledPoints[1]);
                        g.DrawLine(controlLinePen, scaledPoints[1], scaledPoints[2]);
                        g.DrawLine(controlLinePen, scaledPoints[2], scaledPoints[3]);
                    }
                }
            }

            // Assign the bitmap to the PictureBox
            pictureBox.Image = bmp;
        }

        // Refresh function
        private void Refresh()
        {
            RGBToCMYKMapper = new RGBToCMYKMapper(ChannelBezierCurves);

            var maps = RGBToCMYKMapper.ProcessBitmap(originalImage);
            cyanImage = maps[0];
            magentaImage = maps[1];
            yellowImage = maps[2];
            blackImage = maps[3];


            pictureBoxOriginalPhoto.Image = originalImage;
            radioButtonCyan.Checked = true;
            pictureBoxCMYKPhoto.Image = cyanImage;

            DrawBezierCurves(pictureBoxGraph);
        }

        private void radioButtonCyan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCyan.Checked)
            {
                radioButtonBlack.Checked = false;
                radioButtonMagenta.Checked = false;
                radioButtonYellow.Checked = false;

                pictureBoxCMYKPhoto.Image = cyanImage;
            }
        }

        private void radioButtonMagenta_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMagenta.Checked)
            {
                radioButtonBlack.Checked = false;
                radioButtonCyan.Checked = false;
                radioButtonYellow.Checked = false;

                pictureBoxCMYKPhoto.Image = magentaImage;
            }
        }

        private void radioButtonYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYellow.Checked)
            {
                radioButtonBlack.Checked = false;
                radioButtonCyan.Checked = false;
                radioButtonMagenta.Checked = false;

                pictureBoxCMYKPhoto.Image = yellowImage;
            }
        }

        private void radioButtonBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlack.Checked)
            {
                radioButtonCyan.Checked = false;
                radioButtonMagenta.Checked = false;
                radioButtonYellow.Checked = false;

                pictureBoxCMYKPhoto.Image = blackImage;
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            CmykImages cmykImages = new CmykImages(cyanImage, magentaImage, yellowImage, blackImage);
            cmykImages.Show();
        }

        private void button0Cofniecia_Click(object sender, EventArgs e)
        {
            ChannelBezierCurves = new Point2D[][]
                {
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0.33f, 0.33f), new Point2D(0.66f, 0.66f), new Point2D(1f, 1f) },
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0.28f, 0.28f), new Point2D(0.61f, 0.61f), new Point2D(1f, 1f) },
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0.25f, 0.25f), new Point2D(0.56f, 0.56f), new Point2D(1f, 1f) },
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0f, 0f), new Point2D(0f, 0f), new Point2D(0f, 0f) }
                };

            Refresh();
        }

        private void button100Cofniecia_Click(object sender, EventArgs e)
        {
            ChannelBezierCurves = new Point2D[][]
                {
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0f, 0f), new Point2D(0f, 0f), new Point2D(1f, 1f) },
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0f, 0f), new Point2D(0f, 0f), new Point2D(1f, 1f) },
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0f, 0f), new Point2D(0f, 0f), new Point2D(1f, 1f) },
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0.33f, 0.33f), new Point2D(0.66f, 0.66f), new Point2D(1f, 1f) }
                };

            Refresh();
        }

        private void s_Click(object sender, EventArgs e)
        {
            ChannelBezierCurves = new Point2D[][]
                {
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0.2f, 0.2f), new Point2D(0.8f, 0.8f), new Point2D(1f, 1f) },
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0.2f, 0.2f), new Point2D(0.8f, 0.8f), new Point2D(1f, 1f) },
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0.2f, 0.2f), new Point2D(0.8f, 0.8f), new Point2D(1f, 1f) },
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0.4f, 0.6f), new Point2D(0.6f, 0.9f), new Point2D(1f, 1f) }
                };
            Refresh();
        }

        private void buttonGCR_Click(object sender, EventArgs e)
        {
            ChannelBezierCurves = new Point2D[][]
                {
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0.1f, 0.15f), new Point2D(0.4f, 0.7f), new Point2D(1f, 1f) },
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0.1f, 0.15f), new Point2D(0.4f, 0.7f), new Point2D(1f, 1f) },
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0.1f, 0.15f), new Point2D(0.4f, 0.7f), new Point2D(1f, 1f) },
                    new Point2D[] { new Point2D(0f, 0f), new Point2D(0.2f, 0.4f), new Point2D(0.5f, 0.85f), new Point2D(1f, 1f) }
                };
            Refresh();
        }
    }

    public class RGBToCMYKMapper
    {
        public Point2D[][] ChannelBezierCurves { get; set; }

        public RGBToCMYKMapper(Point2D[][] channelBezierCurves)
        {
            ChannelBezierCurves = channelBezierCurves;
        }

        /// <summary>
        /// Converts a bitmap from RGB to CMYK color space
        /// </summary>
        public float[,,] ConvertRGBtoCMYK(Bitmap sourceBitmap)
        {
            int width = sourceBitmap.Width;
            int height = sourceBitmap.Height;

            // Create a 3D array to store CMYK values
            float[,,] cmykChannels = new float[4, height, width];

            // Use GetPixel method
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = sourceBitmap.GetPixel(x, y);

                    // Normalize RGB values
                    float r = pixel.R / 255f;
                    float g = pixel.G / 255f;
                    float b = pixel.B / 255f;

                    // Calculate CMY
                    float c = 1 - r;
                    float m = 1 - g;
                    float y_val = 1 - b;

                    // Calculate Black (Key)
                    float k = Math.Min(1, Math.Min(c, Math.Min(m, y_val)));

                    // Adjust CMY if K is 1 (black)
                    if (k < 1)
                    {
                        c = (c - k) / (1 - k);
                        m = (m - k) / (1 - k);
                        y_val = (y_val - k) / (1 - k);
                    }
                    else
                    {
                        c = m = y_val = 0;
                    }

                    // Store CMYK values
                    cmykChannels[0, y, x] = c;  // Cyan
                    cmykChannels[1, y, x] = m;  // Magenta
                    cmykChannels[2, y, x] = y_val;  // Yellow
                    cmykChannels[3, y, x] = k;  // Black
                }
            }

            return cmykChannels;
        }

        /// <summary>
        /// Creates separate bitmap images for each CMYK channel with Bézier-mapped colors
        /// </summary>
        public Bitmap[] CreateChannelBitmaps(float[,,] cmykChannels)
        {
            int height = cmykChannels.GetLength(1);
            int width = cmykChannels.GetLength(2);
            Bitmap[] channelBitmaps = new Bitmap[4];

            // Define channel colors
            Color[] channelColors = new Color[]
            {
            Color.FromArgb(255, 0, 255, 255),   // Cyan
            Color.FromArgb(255, 255, 0, 255),   // Magenta
            Color.FromArgb(255, 255, 255, 0),   // Yellow
            Color.FromArgb(255, 0, 0, 0)        // Black
            };

            string[] channelNames = { "Cyan", "Magenta", "Yellow", "Black" };

            for (int channel = 0; channel < 4; channel++)
            {
                Bitmap channelBitmap = new Bitmap(width, height);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        // Get the original channel intensity
                        float originalIntensity = cmykChannels[channel, y, x];

                        // Apply Bézier curve mapping to the intensity
                        float mappedIntensity = BezierCurve.EvaluateCubicBezier(
                            originalIntensity,
                            ChannelBezierCurves[channel]
                        );

                        // Interpolate between white and the channel color
                        Color channelColor = InterpolateColor(
                            Color.White,
                            channelColors[channel],
                            mappedIntensity
                        );

                        channelBitmap.SetPixel(x, y, channelColor);
                    }
                }

                // Save each channel bitmap
                channelBitmap.Save($"{channelNames[channel]}Channel.png", ImageFormat.Png);
                channelBitmaps[channel] = channelBitmap;
            }

            return channelBitmaps;
        }

        /// <summary>
        /// Interpolates between two colors based on a given intensity
        /// </summary>
        private Color InterpolateColor(Color baseColor, Color targetColor, float intensity)
        {
            // Ensure intensity is between 0 and 1
            intensity = Math.Max(0, Math.Min(1, intensity));

            // Interpolate each color channel
            byte r = (byte)(baseColor.R + (targetColor.R - baseColor.R) * intensity);
            byte g = (byte)(baseColor.G + (targetColor.G - baseColor.G) * intensity);
            byte b = (byte)(baseColor.B + (targetColor.B - baseColor.B) * intensity);

            return Color.FromArgb(255, r, g, b);
        }

        /// <summary>
        /// Method to set custom Bézier curve for a specific channel
        /// </summary>
        public void SetChannelBezierCurve(int channelIndex, Point2D[] curveControlPoints)
        {
            if (channelIndex < 0 || channelIndex >= 4)
                throw new ArgumentException("Channel index must be between 0 and 3");

            if (curveControlPoints == null || curveControlPoints.Length != 4)
                throw new ArgumentException("Must provide exactly 4 control points");

            ChannelBezierCurves[channelIndex] = curveControlPoints;
        }

        /// <summary>
        /// Example usage method
        /// </summary>
        public void ProcessImage(string imagePath)
        {
            // Load source bitmap
            using (Bitmap sourceBitmap = new Bitmap(imagePath))
            {
                // Optionally, modify Bézier curves before processing
                // SetChannelBezierCurve(0, new Point2D[] {
                //     new Point2D(0f, 0f),
                //     new Point2D(0.2f, 0.4f),
                //     new Point2D(0.4f, 0.6f),
                //     new Point2D(1f, 1f)
                // });

                // Convert to CMYK
                float[,,] cmykChannels = ConvertRGBtoCMYK(sourceBitmap);

                // Create and save channel bitmaps
                Bitmap[] channelBitmaps = CreateChannelBitmaps(cmykChannels);

                // Optional: Dispose of channel bitmaps when done
                foreach (var bitmap in channelBitmaps)
                {
                    bitmap.Dispose();
                }
            }
        }

        public Bitmap[] ProcessBitmap(Bitmap sourceBitmap)
        {
            // Convert to CMYK
            float[,,] cmykChannels = ConvertRGBtoCMYK(sourceBitmap);

            // Create and save channel bitmaps
            Bitmap[] channelBitmaps = CreateChannelBitmaps(cmykChannels);

            return channelBitmaps;
        }
    }

    public class Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point2D(float x, float y)
        {
            X = x;
            Y = y;
        }
    }

    public class BezierCurve
    {
        /// <summary>
        /// Calculates a point on a 3rd-degree Bézier curve
        /// </summary>
        /// <param name="t">Interpolation parameter (0-1)</param>
        /// <param name="controlPoints">4 control points of the Bézier curve</param>
        /// <returns>Interpolated value</returns>
        public static float EvaluateCubicBezier(float t, Point2D[] controlPoints)
        {
            if (controlPoints == null || controlPoints.Length != 4)
                throw new ArgumentException("Must provide exactly 4 control points");

            // Bézier curve calculation for 3rd degree (cubic)
            float u = 1 - t;
            float tt = t * t;
            float uu = u * u;
            float uuu = uu * u;
            float ttt = tt * t;

            // Interpolate Y value based on the curve
            float result =
                uuu * controlPoints[0].Y +
                3 * uu * t * controlPoints[1].Y +
                3 * u * tt * controlPoints[2].Y +
                ttt * controlPoints[3].Y;

            // Find the correct Y value by first finding the matching X
            for (int i = 0; i < controlPoints.Length - 1; i++)
            {
                if (t >= controlPoints[i].X && t <= controlPoints[i + 1].X)
                {
                    // Remap t to the local segment
                    float localT = (t - controlPoints[i].X) /
                                   (controlPoints[i + 1].X - controlPoints[i].X);

                    return result;
                }
            }

            // Fallback if no matching segment found
            return result;
        }
    }
}
