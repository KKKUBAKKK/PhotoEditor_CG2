using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor_CG2
{
    public partial class ChromaticityDiagram : Form
    {
        private List<BezierPoint> bezierPoints = new List<BezierPoint>();
        private bool isDragging = false;
        private int selectedPointIndex = -1;
        private PictureBox bezierBox;
        private PictureBox imageBox;

        private const string cie_path = "PhotoEditor_CG2.cie2.jpg";

        public ChromaticityDiagram()
        {
            InitializeComponent();
            this.Size = new Size(1600, 800);
            SetUpPictureBoxes();
        }

        public void SetUpPictureBoxes()
        {
            // Creating table layout panel
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.ColumnCount = 2;

            // Set columns to half of the form
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

            // Create picture boxes
            bezierBox = new PictureBox();
            bezierBox.Dock = DockStyle.Fill;
            bezierBox.BackColor = Color.White;
            bezierBox.BorderStyle = BorderStyle.FixedSingle;

            imageBox = new PictureBox();
            imageBox.Dock = DockStyle.Fill;
            imageBox.BackColor = Color.White;
            imageBox.BorderStyle = BorderStyle.FixedSingle;
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;

            // Add event handlers for bezierBox
            //bezierBox.Paint += new PaintEventHandler(bezierBox_Paint);
            //bezierBox.MouseDown += new MouseEventHandler(bezierBox_MouseDown);
            //bezierBox.MouseMove += new MouseEventHandler(bezierBox_MouseMove);
            //bezierBox.MouseUp += new MouseEventHandler(bezierBox_MouseUp);

            // Add event handlers for imageBox

            // Add picture boxes to table layout panel
            tableLayoutPanel.Controls.Add(bezierBox, 0, 0);
            tableLayoutPanel.Controls.Add(imageBox, 1, 0);

            // Add table layout panel to form
            this.Controls.Add(tableLayoutPanel);

            // Load the image
            LoadHorseshoeImage();
        }

        private void LoadHorseshoeImage()
        {
            try
            {
                // Load the image from embedded resources
                Assembly assembly = Assembly.GetExecutingAssembly();
                using (Stream stream = assembly.GetManifestResourceStream(cie_path))
                {
                    if (stream != null)
                    {
                        Image image = Image.FromStream(stream);
                        // Use the image, e.g., assign to a PictureBox
                        imageBox.Image = image;
                    }
                    else
                    {
                        MessageBox.Show("Horseshoe image not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }

        private void BezierBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw Bezier curve
            if (bezierPoints.Count > 1)
            {
                DrawBezierCurve(g);
            }

            // Draw control points
            DrawControlPoints(g);
        }

        private void DrawBezierCurve(Graphics g)
        {
            if (bezierPoints.Count < 2) return;

            Point[] points = bezierPoints.Select(p => Point.Round(p.Point)).ToArray();
            using (Pen pen = new Pen(Color.Blue, 2))
            {
                g.DrawCurve(pen, points);
            }
        }

        private void DrawControlPoints(Graphics g)
        {
            // Draw connecting lines between points
            if (bezierPoints.Count > 1)
            {
                using (Pen linePen = new Pen(Color.Gray, 1))
                {
                    linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    for (int i = 0; i < bezierPoints.Count - 1; i++)
                    {
                        g.DrawLine(linePen, bezierPoints[i].Point, bezierPoints[i + 1].Point);
                    }
                }
            }

            // Draw each control point
            for (int i = 0; i < bezierPoints.Count; i++)
            {
                DrawControlPoint(g, bezierPoints[i], i);
            }
        }

        private void DrawControlPoint(Graphics g, BezierPoint point, int index)
        {
            float radius = point.IsSelected ? 7f : 5f;
            RectangleF rect = new RectangleF(
                point.Point.X - radius,
                point.Point.Y - radius,
                radius * 2,
                radius * 2
            );

            // Fill point
            using (Brush fillBrush = new SolidBrush(point.IsSelected ? Color.Red : Color.Blue))
            {
                g.FillEllipse(fillBrush, rect);
            }

            // Draw border
            using (Pen borderPen = new Pen(Color.White, 1))
            {
                g.DrawEllipse(borderPen, rect);
            }

            // Draw point index
            using (Font font = new Font("Arial", 8))
            using (Brush textBrush = new SolidBrush(Color.White))
            {
                string text = index.ToString();
                SizeF textSize = g.MeasureString(text, font);
                PointF textLocation = new PointF(
                    point.Point.X - textSize.Width / 2,
                    point.Point.Y - textSize.Height / 2
                );
                g.DrawString(text, font, textBrush, textLocation);
            }
        }

        private void BezierBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Check if clicked on existing point
                for (int i = 0; i < bezierPoints.Count; i++)
                {
                    if (IsPointNear(e.Location, bezierPoints[i].Point, 5))
                    {
                        selectedPointIndex = i;
                        bezierPoints[i].IsSelected = true;
                        isDragging = true;
                        bezierBox.Invalidate();
                        return;
                    }
                }

                // Add new point
                bezierPoints.Add(new BezierPoint
                {
                    Point = e.Location,
                    IsSelected = false
                });
                bezierBox.Invalidate();
            }
        }

        private void BezierBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && selectedPointIndex >= 0)
            {
                bezierPoints[selectedPointIndex].Point = e.Location;
                bezierBox.Invalidate();
            }
        }

        private void BezierBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedPointIndex >= 0)
            {
                bezierPoints[selectedPointIndex].IsSelected = false;
            }
            isDragging = false;
            selectedPointIndex = -1;
            bezierBox.Invalidate();
        }

        private bool IsPointNear(Point p1, PointF p2, float threshold)
        {
            return Math.Abs(p1.X - p2.X) < threshold &&
                   Math.Abs(p1.Y - p2.Y) < threshold;
        }
    }

    public class BezierPoint
    {
        public PointF Point { get; set; }
        public bool IsSelected { get; set; }
    }
}
