using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Reflection.Metadata;

namespace PhotoEditor_CG2
{
    public partial class ColorReduction : Form
    {
        string path;
        Bitmap originalImage;
        Bitmap reducedImage;
        int Kr;
        int Kg;
        int Kb;
        int K;
        Random random = new Random(5);

        public ColorReduction()
        {
            InitializeComponent();

            path = "";
            Kr = int.Parse(textBoxKr.Text);
            Kg = int.Parse(textBoxKg.Text);
            Kb = int.Parse(textBoxKb.Text);
            K = int.Parse(textBoxK.Text);

            originalImage = new Bitmap(1, 1);
            reducedImage = new Bitmap(1, 1);
        }

        // LAB
        private void createImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buildImage();
            reduceColors();
            drawOriginalImage();
            drawChangedImage();
        }

        // Build the image
        private void buildImage()
        {
            var width = pictureBoxOriginalImage.Width;
            var height = pictureBoxOriginalImage.Height;

            Bitmap image = new Bitmap(width, height);
            for (int x = 0; x < width/2; x++)
            {
                var c = stripeColor(x, width);
                

                for (int y = 0; y < height; y++)
                {
                    image.SetPixel(x, y, c);
                }
            }

            for (int x = width / 2; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    float h = (x - width / 2) * 360f / (width / 2);
                    float s = 1 - y / (float)height;

                    var (r, g, b) = HsvToRgb(h, s, 1);
                    image.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            originalImage = image;

        }

        public static Color stripeColor(int x, int width)
        {
            if (x < width * 1 / 12)
            {
                return Color.Black;
            }
            else if (x < width * 2 / 12)
            {
                return Color.White;
            }
            else if (x < width * 3 / 12)
            {
                return Color.Black;
            }
            else if (x < width * 7 / 24)
            {
                return Color.White;
            }
            else if (x < width * 8 / 24)
            {
                return Color.Black;
            }
            else if (x < width * 9 / 24)
            {
                return Color.White;
            }
            else if (x < width * 10 / 24)
            {
                return Color.Black;
            }
            else if (x < width * 21 / 48)
            {
                return Color.White;
            }
            else if (x < width * 22 / 48)
            {
                return Color.Black;
            }
            else if (x < width * 23 / 48)
            {
                return Color.White;
            }
            else
            {
                return Color.Black;
            }
        }

        public static (int R, int G, int B) HsvToRgb(float h, float s, float v)
        {
            int r, g, b;

            if (s == 0)
            {
                r = g = b = (int)(v * 255);
            }
            else
            {
                float sector = h / 60;  
                int i = (int)Math.Floor(sector);
                float f = sector - i; 

                float p = v * (1 - s);
                float q = v * (1 - s * f);
                float t = v * (1 - s * (1 - f));

                switch (i)
                {
                    case 0:
                        r = (int)(v * 255);
                        g = (int)(t * 255);
                        b = (int)(p * 255);
                        break;
                    case 1:
                        r = (int)(q * 255);
                        g = (int)(v * 255);
                        b = (int)(p * 255);
                        break;
                    case 2:
                        r = (int)(p * 255);
                        g = (int)(v * 255);
                        b = (int)(t * 255);
                        break;
                    case 3:
                        r = (int)(p * 255);
                        g = (int)(q * 255);
                        b = (int)(v * 255);
                        break;
                    case 4:
                        r = (int)(t * 255);
                        g = (int)(p * 255);
                        b = (int)(v * 255);
                        break;
                    default:
                        r = (int)(v * 255);
                        g = (int)(p * 255);
                        b = (int)(q * 255);
                        break;
                }
            }

            return (r, g, b);
        }
        // LAB

        private void chooseImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set file dialog properties
                openFileDialog.Title = "Select an image";
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
                string projectDirectory = Application.StartupPath;
                string dataFolderPath = Path.Combine(projectDirectory, "data");
                openFileDialog.InitialDirectory = dataFolderPath;

                // Show the dialog and check if the user clicked OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file's path
                    path = openFileDialog.FileName;

                    originalImage = new Bitmap(path);
                    reducedImage = new Bitmap(path);

                    reduceColors();

                    // Use the selected file path (e.g., display the file name in a Label or TextBox)
                    MessageBox.Show($"You selected: {path}");
                }
            }
            drawOriginalImage();
            drawChangedImage();
            this.Invalidate();
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Set the save dialog properties
                saveFileDialog.Title = "Save the image";
                saveFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
                string dataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog.InitialDirectory = dataFolderPath;
                saveFileDialog.FileName = "reduced_image.jpg";

                // Show the dialog and check if the user clicked OK
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the image to the selected file path
                    reducedImage.Save(saveFileDialog.FileName);
                    MessageBox.Show($"The image has been saved to: {saveFileDialog.FileName}");
                }
            }
        }

        // Draw the image on the the pictureBoxOriginalImage
        private void drawOriginalImage()
        {
            // Check if the path is empty
            if (originalImage == null)
            {
                MessageBox.Show("Please select an image");
                return;
            }

            // Set the originalPictureBox's image to the selected image
            pictureBoxOriginalImage.Image = originalImage;
        }

        // Draw the image on the the pictureBoxChangedImage
        private void drawChangedImage()
        {
            // Set the changedPictureBox's image to the selected image
            pictureBoxChangedImage.Image = reducedImage;
        }

        // REduce the number of colors in the image using average dithering algorithm
        private void refreshButton_Click(object sender, EventArgs e)
        {
            // Check if the path is empty
            if (originalImage == null)
            {
                MessageBox.Show("Please select an image");
                return;
            }

            // Reduce the number of colors in the image using average dithering algorithm
            reduceColors();

            // Draw the changed image
            drawOriginalImage();
            drawChangedImage();
            this.Invalidate();
        }

        private void reduceColors()
        {
            if (radioButtonAverageDithering.Checked)
            {
                reducedImage = averageDithering(originalImage, Kr, Kg, Kb);
            }
            else if (radioButtonErrorDiffusionDithering.Checked)
            {
                reducedImage = errorDiffusionDithering(originalImage, Kr, Kg, Kb);
            }
            else if (radioButtonOrderedDitheringRandom.Checked)
            {
                reducedImage = orderedDitheringRandom(originalImage, Kr, Kg, Kb);
            }
            else if (radioButtonOrderedDitheringRelative.Checked)
            {
                reducedImage = orderedDitheringRelative(originalImage, Kr, Kg, Kb);
            }
            else if (radioButtonPopularityAlgorithm.Checked)
            {
                reducedImage = popularityAlgorithm(originalImage, K);
            }
        }

        public Bitmap averageDithering(Bitmap bitmap, int Kr, int Kg, int Kb)
        {
            if (bitmap == null) return null;

            int width = bitmap.Width;
            int height = bitmap.Height;

            Bitmap result = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            BitmapData sourceData = bitmap.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            BitmapData resultData = result.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb);

            try
            {
                unsafe
                {
                    byte* sourcePtr = (byte*)sourceData.Scan0;
                    byte* resultPtr = (byte*)resultData.Scan0;

                    int stride = sourceData.Stride;
                    int padding = stride - (width * 4);

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            byte b = sourcePtr[0];
                            byte g = sourcePtr[1];
                            byte r = sourcePtr[2];
                            byte a = sourcePtr[3];

                            byte newR = (byte)((r * (Kr - 1) + 128) / 255 * (255 / (Kr - 1)));
                            byte newG = (byte)((g * (Kg - 1) + 128) / 255 * (255 / (Kg - 1)));
                            byte newB = (byte)((b * (Kb - 1) + 128) / 255 * (255 / (Kb - 1)));

                            resultPtr[0] = newB;
                            resultPtr[1] = newG;
                            resultPtr[2] = newR;
                            resultPtr[3] = a;

                            sourcePtr += 4;
                            resultPtr += 4;
                        }

                        sourcePtr += padding;
                        resultPtr += padding;
                    }
                }
            }
            finally
            {
                bitmap.UnlockBits(sourceData);
                result.UnlockBits(resultData);
            }

            return result;
        }

        public Bitmap errorDiffusionDithering(Bitmap bitmap, int Kr, int Kg, int Kb)
        {
            if (bitmap == null) return null;

            int width = bitmap.Width;
            int height = bitmap.Height;

            Bitmap result = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            float[,] errorR = new float[height, width];
            float[,] errorG = new float[height, width];
            float[,] errorB = new float[height, width];

            float stepR = 255f / (Kr - 1);
            float stepG = 255f / (Kg - 1);
            float stepB = 255f / (Kb - 1);

            BitmapData sourceData = bitmap.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            BitmapData resultData = result.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb);

            try
            {
                unsafe
                {
                    byte* sourcePtr = (byte*)sourceData.Scan0;
                    byte* resultPtr = (byte*)resultData.Scan0;

                    int stride = sourceData.Stride;
                    int padding = stride - (width * 4);

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            float oldB = Math.Min(255, Math.Max(0, sourcePtr[0] + errorB[y, x]));
                            float oldG = Math.Min(255, Math.Max(0, sourcePtr[1] + errorG[y, x]));
                            float oldR = Math.Min(255, Math.Max(0, sourcePtr[2] + errorR[y, x]));
                            byte alpha = sourcePtr[3];

                            byte newR = (byte)(Math.Round(oldR / stepR) * stepR);
                            byte newG = (byte)(Math.Round(oldG / stepG) * stepG);
                            byte newB = (byte)(Math.Round(oldB / stepB) * stepB);

                            float errorR_val = oldR - newR;
                            float errorG_val = oldG - newG;
                            float errorB_val = oldB - newB;

                            // Floyd and Steinberg filter:
                            //   0     0     0
                            //   0     0    7/16
                            //  3/16  5/16  1/16

                            if (x + 1 < width)
                            {
                                errorR[y, x + 1] += errorR_val * 7f / 16f;
                                errorG[y, x + 1] += errorG_val * 7f / 16f;
                                errorB[y, x + 1] += errorB_val * 7f / 16f;
                            }

                            if (y + 1 < height)
                            {
                                if (x > 0)
                                {
                                    errorR[y + 1, x - 1] += errorR_val * 3f / 16f;
                                    errorG[y + 1, x - 1] += errorG_val * 3f / 16f;
                                    errorB[y + 1, x - 1] += errorB_val * 3f / 16f;
                                }

                                errorR[y + 1, x] += errorR_val * 5f / 16f;
                                errorG[y + 1, x] += errorG_val * 5f / 16f;
                                errorB[y + 1, x] += errorB_val * 5f / 16f;

                                if (x + 1 < width)
                                {
                                    errorR[y + 1, x + 1] += errorR_val * 1f / 16f;
                                    errorG[y + 1, x + 1] += errorG_val * 1f / 16f;
                                    errorB[y + 1, x + 1] += errorB_val * 1f / 16f;
                                }
                            }

                            resultPtr[0] = newB;
                            resultPtr[1] = newG;
                            resultPtr[2] = newR;
                            resultPtr[3] = alpha;

                            sourcePtr += 4;
                            resultPtr += 4;
                        }

                        sourcePtr += padding;
                        resultPtr += padding;
                    }
                }
            }
            finally
            {
                bitmap.UnlockBits(sourceData);
                result.UnlockBits(resultData);
            }

            return result;
        }

        public unsafe Bitmap orderedDitheringRandom(Bitmap originalImage, int Kr, int Kg, int Kb)
        {
            if (Kr < 2) throw new ArgumentException("Kr must be at least 2", nameof(Kr));
            if (Kg < 2) throw new ArgumentException("Kg must be at least 2", nameof(Kg));
            if (Kb < 2) throw new ArgumentException("Kb must be at least 2", nameof(Kb));

            int nR = BayerMatrixCalculator.CalculateOptimalBayerSize(Kr);
            int nG = BayerMatrixCalculator.CalculateOptimalBayerSize(Kg);
            int nB = BayerMatrixCalculator.CalculateOptimalBayerSize(Kb);

            var bayerR = BayerMatrixCalculator.GenerateBayerMatrix(Kr);
            var bayerG = BayerMatrixCalculator.GenerateBayerMatrix(Kg);
            var bayerB = BayerMatrixCalculator.GenerateBayerMatrix(Kb);

            Bitmap result = new Bitmap(originalImage.Width, originalImage.Height);

            BitmapData originalData = originalImage.LockBits(
                new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            BitmapData resultData = result.LockBits(
                new Rectangle(0, 0, result.Width, result.Height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb);

            try
            {
                byte* originalPtr = (byte*)originalData.Scan0;
                byte* resultPtr = (byte*)resultData.Scan0;

                // Calculate quantization steps
                float stepR = 255.0f / (Kr - 1);
                float stepG = 255.0f / (Kg - 1);
                float stepB = 255.0f / (Kb - 1);

                // Process each pixel
                for (int y = 0; y < originalImage.Height; y++)
                {
                    for (int x = 0; x < originalImage.Width; x++)
                    {
                        int pixelOffset = (y * originalData.Stride) + (x * 4);

                        // Get original color values
                        byte b = originalPtr[pixelOffset];
                        byte g = originalPtr[pixelOffset + 1];
                        byte r = originalPtr[pixelOffset + 2];
                        byte a = originalPtr[pixelOffset + 3];

                        // Get random thresholds from Bayer matrices
                        float thresholdR = GetRandomBayerValue(bayerR, nR) / (float)(nR * nR);
                        float thresholdG = GetRandomBayerValue(bayerG, nG) / (float)(nG * nG);
                        float thresholdB = GetRandomBayerValue(bayerB, nB) / (float)(nB * nB);

                        // Apply dithering to each channel
                        byte newR = QuantizeWithDithering(r, Kr, stepR, thresholdR);
                        byte newG = QuantizeWithDithering(g, Kg, stepG, thresholdG);
                        byte newB = QuantizeWithDithering(b, Kb, stepB, thresholdB);

                        // Write result
                        resultPtr[pixelOffset] = newB;
                        resultPtr[pixelOffset + 1] = newG;
                        resultPtr[pixelOffset + 2] = newR;
                        resultPtr[pixelOffset + 3] = a; // Preserve alpha
                    }
                }
            }
            finally
            {
                // Unlock the bits
                originalImage.UnlockBits(originalData);
                result.UnlockBits(resultData);
            }

            return result;
        }

        public unsafe Bitmap orderedDitheringRelative(Bitmap originalImage, int Kr, int Kg, int Kb)
        {
            // Validate input parameters
            if (Kr < 2) throw new ArgumentException("Kr must be at least 2", nameof(Kr));
            if (Kg < 2) throw new ArgumentException("Kg must be at least 2", nameof(Kg));
            if (Kb < 2) throw new ArgumentException("Kb must be at least 2", nameof(Kb));

            // Calculate matrix sizes and generate Bayer matrices
            int nR = BayerMatrixCalculator.CalculateOptimalBayerSize(Kr);
            int nG = BayerMatrixCalculator.CalculateOptimalBayerSize(Kg);
            int nB = BayerMatrixCalculator.CalculateOptimalBayerSize(Kb);

            var bayerR = BayerMatrixCalculator.GenerateBayerMatrix(Kr);
            var bayerG = BayerMatrixCalculator.GenerateBayerMatrix(Kg);
            var bayerB = BayerMatrixCalculator.GenerateBayerMatrix(Kb);

            // Create output bitmap
            Bitmap result = new Bitmap(originalImage.Width, originalImage.Height);

            // Lock bits for faster processing
            BitmapData originalData = originalImage.LockBits(
                new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            BitmapData resultData = result.LockBits(
                new Rectangle(0, 0, result.Width, result.Height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb);

            try
            {
                byte* originalPtr = (byte*)originalData.Scan0;
                byte* resultPtr = (byte*)resultData.Scan0;

                // Calculate quantization steps for each channel
                float stepR = 255.0f / (Kr - 1);
                float stepG = 255.0f / (Kg - 1);
                float stepB = 255.0f / (Kb - 1);

                // Process each pixel
                for (int y = 0; y < originalImage.Height; y++)
                {
                    for (int x = 0; x < originalImage.Width; x++)
                    {
                        int pixelOffset = (y * originalData.Stride) + (x * 4);

                        // Get original color values
                        byte b = originalPtr[pixelOffset];
                        byte g = originalPtr[pixelOffset + 1];
                        byte r = originalPtr[pixelOffset + 2];
                        byte a = originalPtr[pixelOffset + 3];

                        // Get threshold values from Bayer matrices using pixel position
                        float thresholdR = GetBayerThreshold(bayerR, x % nR, y % nR, nR);
                        float thresholdG = GetBayerThreshold(bayerG, x % nG, y % nG, nG);
                        float thresholdB = GetBayerThreshold(bayerB, x % nB, y % nB, nB);

                        // Apply dithering to each channel
                        byte newR = QuantizeWithDithering(r, Kr, stepR, thresholdR);
                        byte newG = QuantizeWithDithering(g, Kg, stepG, thresholdG);
                        byte newB = QuantizeWithDithering(b, Kb, stepB, thresholdB);

                        // Write result
                        resultPtr[pixelOffset] = newB;
                        resultPtr[pixelOffset + 1] = newG;
                        resultPtr[pixelOffset + 2] = newR;
                        resultPtr[pixelOffset + 3] = a; // Preserve alpha
                    }
                }
            }
            finally
            {
                // Unlock the bits
                originalImage.UnlockBits(originalData);
                result.UnlockBits(resultData);
            }

            return result;
        }

        private float GetRandomBayerValue(int[,] bayerMatrix, int n)
        {
            // Get random position in the matrix
            int i = random.Next(n);
            int j = random.Next(n);
            return bayerMatrix[i, j];
        }

        private byte QuantizeWithDithering(byte value, int k, float step, float threshold)
        {
            // Normalize value to 0-1 range
            float normalizedValue = value / 255.0f;

            // Add threshold
            float ditheredValue = normalizedValue + (threshold - 0.5f) * (step / 255.0f);

            // Quantize to k levels
            int level = (int)Math.Round(ditheredValue * (k - 1));
            level = Math.Max(0, Math.Min(k - 1, level));

            // Convert back to byte
            return (byte)(level * step);
        }

        private float GetBayerThreshold(int[,] bayerMatrix, int x, int y, int n)
        {
            // Convert Bayer matrix value to normalized threshold (0-1 range)
            return (bayerMatrix[y, x] + 0.5f) / (n * n);
        }

        public unsafe Bitmap popularityAlgorithm(Bitmap originalImage, int K)
        {
            int width = originalImage.Width;
            int height = originalImage.Height;

            // Lock the original bitmap in memory
            BitmapData originalData = originalImage.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            // Create and lock the result bitmap
            Bitmap reducedImage = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            BitmapData resultData = reducedImage.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format32bppArgb);

            try
            {
                // Use a concurrent dictionary for thread-safe color counting
                var colorHistogram = new ConcurrentDictionary<int, int>();

                // Get pointers to the image data
                byte* ptr = (byte*)originalData.Scan0;
                int stride = originalData.Stride;

                // Step 1: Build color histogram in parallel
                Parallel.For(0, height, y =>
                {
                    byte* row = ptr + (y * stride);
                    for (int x = 0; x < width; x++)
                    {
                        int offset = x * 4;
                        // Pack RGB values into a single integer (ignore alpha)
                        int color = (row[offset + 2] << 16) | // R
                                   (row[offset + 1] << 8) | // G
                                   (row[offset]);            // B

                        colorHistogram.AddOrUpdate(color, 1, (_, count) => count + 1);
                    }
                });

                // Step 2: Select top K colors
                var topColors = colorHistogram
                    .OrderByDescending(kv => kv.Value)
                    .Take(K)
                    .Select(kv => new Color32(
                        (byte)((kv.Key >> 16) & 0xFF),  // R
                        (byte)((kv.Key >> 8) & 0xFF),   // G
                        (byte)(kv.Key & 0xFF)))         // B
                    .ToArray();

                // Step 3: Create lookup table for faster color mapping
                var lookupTable = CreateColorLookupTable(topColors);

                // Step 4: Map colors in parallel
                byte* resultPtr = (byte*)resultData.Scan0;
                Parallel.For(0, height, y =>
                {
                    byte* sourceRow = ptr + (y * stride);
                    byte* targetRow = resultPtr + (y * stride);

                    for (int x = 0; x < width; x++)
                    {
                        int offset = x * 4;
                        byte b = sourceRow[offset];
                        byte g = sourceRow[offset + 1];
                        byte r = sourceRow[offset + 2];
                        byte a = sourceRow[offset + 3];

                        // Find nearest color using lookup table
                        Color32 nearest = FindNearestColorFast(r, g, b, lookupTable);

                        targetRow[offset] = nearest.B;
                        targetRow[offset + 1] = nearest.G;
                        targetRow[offset + 2] = nearest.R;
                        targetRow[offset + 3] = a;
                    }
                });

                return reducedImage;
            }
            finally
            {
                originalImage.UnlockBits(originalData);
                reducedImage.UnlockBits(resultData);
            }
        }

        // Struct for faster color operations
        private struct Color32
        {
            public byte R, G, B;

            public Color32(byte r, byte g, byte b)
            {
                R = r;
                G = g;
                B = b;
            }
        }

        // Create color lookup table for faster nearest color finding
        private Color32[] CreateColorLookupTable(Color32[] palette)
        {
            const int TABLE_SIZE = 64; // Reduced precision for lookup table
            var table = new Color32[TABLE_SIZE * TABLE_SIZE * TABLE_SIZE];

            Parallel.For(0, TABLE_SIZE, r =>
            {
                for (int g = 0; g < TABLE_SIZE; g++)
                {
                    for (int b = 0; b < TABLE_SIZE; b++)
                    {
                        byte actualR = (byte)(r * 255 / (TABLE_SIZE - 1));
                        byte actualG = (byte)(g * 255 / (TABLE_SIZE - 1));
                        byte actualB = (byte)(b * 255 / (TABLE_SIZE - 1));

                        int index = (r * TABLE_SIZE * TABLE_SIZE) + (g * TABLE_SIZE) + b;
                        table[index] = FindNearestColorBruteForce(actualR, actualG, actualB, palette);
                    }
                }
            });

            return table;
        }

        // Fast nearest color lookup using the lookup table
        private Color32 FindNearestColorFast(byte r, byte g, byte b, Color32[] lookupTable)
        {
            const int TABLE_SIZE = 64;
            int ri = r * (TABLE_SIZE - 1) / 255;
            int gi = g * (TABLE_SIZE - 1) / 255;
            int bi = b * (TABLE_SIZE - 1) / 255;

            int index = (ri * TABLE_SIZE * TABLE_SIZE) + (gi * TABLE_SIZE) + bi;
            return lookupTable[index];
        }

        // Brute force nearest color finding (used only for building lookup table)
        private Color32 FindNearestColorBruteForce(byte r, byte g, byte b, Color32[] palette)
        {
            int minDistance = int.MaxValue;
            Color32 nearest = palette[0];

            foreach (var color in palette)
            {
                int dr = r - color.R;
                int dg = g - color.G;
                int db = b - color.B;
                int distance = (dr * dr) + (dg * dg) + (db * db);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearest = color;
                }
            }

            return nearest;
        }

        private void radioButtonAverageDithering_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAverageDithering.Checked)
            {
                // Set all other radio buttons to unchecked
                radioButtonErrorDiffusionDithering.Checked = false;
                radioButtonOrderedDitheringRandom.Checked = false;
                radioButtonOrderedDitheringRelative.Checked = false;
                radioButtonPopularityAlgorithm.Checked = false;
            }
        }

        private void radioButtonErrorDiffusionDithering_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonErrorDiffusionDithering.Checked)
            {
                // Set all other radio buttons to unchecked
                radioButtonAverageDithering.Checked = false;
                radioButtonOrderedDitheringRandom.Checked = false;
                radioButtonOrderedDitheringRelative.Checked = false;
                radioButtonPopularityAlgorithm.Checked = false;
            }
        }

        private void radioButtonOrderedDitheringRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOrderedDitheringRandom.Checked)
            {
                // Set all other radio buttons to unchecked
                radioButtonAverageDithering.Checked = false;
                radioButtonErrorDiffusionDithering.Checked = false;
                radioButtonOrderedDitheringRelative.Checked = false;
                radioButtonPopularityAlgorithm.Checked = false;
            }
        }

        private void radioButtonOrderedDitheringRelative_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOrderedDitheringRelative.Checked)
            {
                // Set all other radio buttons to unchecked
                radioButtonAverageDithering.Checked = false;
                radioButtonErrorDiffusionDithering.Checked = false;
                radioButtonOrderedDitheringRandom.Checked = false;
                radioButtonPopularityAlgorithm.Checked = false;
            }
        }

        private void radioButtonPopularityAlgorithm_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPopularityAlgorithm.Checked)
            {
                // Set all other radio buttons to unchecked
                radioButtonAverageDithering.Checked = false;
                radioButtonErrorDiffusionDithering.Checked = false;
                radioButtonOrderedDitheringRandom.Checked = false;
                radioButtonOrderedDitheringRelative.Checked = false;
            }
        }

        private void textBoxKr_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKr.Text != "")
                Kr = int.Parse(textBoxKr.Text);
        }

        private void textBoxKg_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKg.Text != "")
                Kg = int.Parse(textBoxKg.Text);
        }

        private void textBoxKb_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKb.Text != "")
                Kb = int.Parse(textBoxKb.Text);
        }

        private void textBoxK_TextChanged(object sender, EventArgs e)
        {
            if (textBoxK.Text != "")
                K = int.Parse(textBoxK.Text);
        }
    }

    public static class BayerMatrixCalculator
    {
        // Available Bayer matrix sizes
        private static readonly int[] ValidSizes = { 2, 3, 4, 6, 8, 12, 16 };

        public static int CalculateOptimalBayerSize(int k)
        {
            if (k <= 1)
                throw new ArgumentException("k must be greater than 1");

            // Calculate minimum n from the inequality: n²(k-1) >= 256
            // n² >= 256/(k-1)
            // n >= sqrt(256/(k-1))
            double minN = Math.Sqrt(256.0 / (k - 1));

            // Round up to the next valid size
            foreach (int size in ValidSizes)
            {
                if (size >= minN)
                    return size;
            }

            // If no valid size found (shouldn't happen with given valid sizes up to 16)
            return 16;
        }

        // Helper method to verify if the calculated size meets the requirement
        public static bool VerifySize(int n, int k)
        {
            return (n * n * (k - 1)) >= 256;
        }

        // Example usage with matrix generation
        public static int[,] GenerateBayerMatrix(int k)
        {
            int size = CalculateOptimalBayerSize(k);
            return GenerateBayerMatrixOfSize(size);
        }

        private static int[,] GenerateBayerMatrixOfSize(int size)
        {
            int[,] matrix = new int[size, size];

            if (size % 3 != 0)
            {
                // Start with 2x2 base matrix
                int[,] baseMatrix = new int[,] {
                    { 0, 2 },
                    { 3, 1 }
                };

                if (size == 2)
                    return baseMatrix;

                // Scale up the matrix to desired size
                int[,] currentMatrix = baseMatrix;
                for (int currentSize = 2; currentSize < size; currentSize *= 2)
                {
                    currentMatrix = ScaleUpMatrix(currentMatrix);
                }

                return currentMatrix;
            }
            else
            {
                int[,] baseMatrix = new int[,]
                {
                    { 6, 8, 4 },
                    { 1, 0, 3 },
                    { 5, 2, 7 }
                };

                if (size == 3)
                    return baseMatrix;

                // Scale up the matrix to desired size
                int[,] currentMatrix = baseMatrix;
                for (int currentSize = 3; currentSize < size; currentSize *= 2)
                {
                    currentMatrix = ScaleUpMatrix(currentMatrix);
                }

                return currentMatrix;
            }
        }

        private static int[,] ScaleUpMatrix(int[,] source)
        {
            int oldSize = source.GetLength(0);
            int newSize = oldSize * 2;
            int[,] result = new int[newSize, newSize];

            for (int y = 0; y < oldSize; y++)
            {
                for (int x = 0; x < oldSize; x++)
                {
                    int value = source[y, x] * 4;
                    result[y, x] = value;
                    result[y, x + oldSize] = value + 2;
                    result[y + oldSize, x] = value + 3;
                    result[y + oldSize, x + oldSize] = value + 1;
                }
            }

            return result;
        }
    }
}
