namespace PhotoEditor_CG2
{
    partial class ColorReduction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            algorithmsGroupBox = new GroupBox();
            buttonRefresh = new Button();
            radioButtonPopularityAlgorithm = new RadioButton();
            radioButtonOrderedDitheringRelative = new RadioButton();
            radioButtonOrderedDitheringRandom = new RadioButton();
            radioButtonErrorDiffusionDithering = new RadioButton();
            radioButtonAverageDithering = new RadioButton();
            groupBoxParamsForDithering = new GroupBox();
            textBoxKb = new TextBox();
            textBoxKg = new TextBox();
            textBoxKr = new TextBox();
            labelKb = new Label();
            labelKg = new Label();
            labelKr = new Label();
            groupBoxParamsForPopularityAlgorithm = new GroupBox();
            labelK = new Label();
            textBoxK = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelOriginalImage = new Label();
            labelChangedImage = new Label();
            pictureBoxOriginalImage = new PictureBox();
            pictureBoxChangedImage = new PictureBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            chooseImageToolStripMenuItem = new ToolStripMenuItem();
            saveImageToolStripMenuItem = new ToolStripMenuItem();
            createImageToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            algorithmsGroupBox.SuspendLayout();
            groupBoxParamsForDithering.SuspendLayout();
            groupBoxParamsForPopularityAlgorithm.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginalImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChangedImage).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.3463211F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.65368F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 42);
            tableLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1924, 903);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(algorithmsGroupBox);
            flowLayoutPanel1.Controls.Add(groupBoxParamsForDithering);
            flowLayoutPanel1.Controls.Add(groupBoxParamsForPopularityAlgorithm);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(4, 2);
            flowLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(383, 899);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // algorithmsGroupBox
            // 
            algorithmsGroupBox.Controls.Add(buttonRefresh);
            algorithmsGroupBox.Controls.Add(radioButtonPopularityAlgorithm);
            algorithmsGroupBox.Controls.Add(radioButtonOrderedDitheringRelative);
            algorithmsGroupBox.Controls.Add(radioButtonOrderedDitheringRandom);
            algorithmsGroupBox.Controls.Add(radioButtonErrorDiffusionDithering);
            algorithmsGroupBox.Controls.Add(radioButtonAverageDithering);
            algorithmsGroupBox.Location = new Point(4, 2);
            algorithmsGroupBox.Margin = new Padding(4, 2, 4, 2);
            algorithmsGroupBox.Name = "algorithmsGroupBox";
            algorithmsGroupBox.Padding = new Padding(4, 2, 4, 2);
            algorithmsGroupBox.Size = new Size(399, 305);
            algorithmsGroupBox.TabIndex = 0;
            algorithmsGroupBox.TabStop = false;
            algorithmsGroupBox.Text = "Algorithms";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(230, 247);
            buttonRefresh.Margin = new Padding(4, 2, 4, 2);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(150, 47);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += refreshButton_Click;
            // 
            // radioButtonPopularityAlgorithm
            // 
            radioButtonPopularityAlgorithm.AutoSize = true;
            radioButtonPopularityAlgorithm.Location = new Point(9, 207);
            radioButtonPopularityAlgorithm.Margin = new Padding(4, 2, 4, 2);
            radioButtonPopularityAlgorithm.Name = "radioButtonPopularityAlgorithm";
            radioButtonPopularityAlgorithm.Size = new Size(263, 36);
            radioButtonPopularityAlgorithm.TabIndex = 4;
            radioButtonPopularityAlgorithm.TabStop = true;
            radioButtonPopularityAlgorithm.Text = "popularity algorithm";
            radioButtonPopularityAlgorithm.UseVisualStyleBackColor = true;
            radioButtonPopularityAlgorithm.CheckedChanged += radioButtonPopularityAlgorithm_CheckedChanged;
            // 
            // radioButtonOrderedDitheringRelative
            // 
            radioButtonOrderedDitheringRelative.AutoSize = true;
            radioButtonOrderedDitheringRelative.Location = new Point(9, 164);
            radioButtonOrderedDitheringRelative.Margin = new Padding(4, 2, 4, 2);
            radioButtonOrderedDitheringRelative.Name = "radioButtonOrderedDitheringRelative";
            radioButtonOrderedDitheringRelative.Size = new Size(318, 36);
            radioButtonOrderedDitheringRelative.TabIndex = 3;
            radioButtonOrderedDitheringRelative.TabStop = true;
            radioButtonOrderedDitheringRelative.Text = "ordered dithering relative";
            radioButtonOrderedDitheringRelative.UseVisualStyleBackColor = true;
            radioButtonOrderedDitheringRelative.CheckedChanged += radioButtonOrderedDitheringRelative_CheckedChanged;
            // 
            // radioButtonOrderedDitheringRandom
            // 
            radioButtonOrderedDitheringRandom.AutoSize = true;
            radioButtonOrderedDitheringRandom.Location = new Point(9, 122);
            radioButtonOrderedDitheringRandom.Margin = new Padding(4, 2, 4, 2);
            radioButtonOrderedDitheringRandom.Name = "radioButtonOrderedDitheringRandom";
            radioButtonOrderedDitheringRandom.Size = new Size(323, 36);
            radioButtonOrderedDitheringRandom.TabIndex = 2;
            radioButtonOrderedDitheringRandom.TabStop = true;
            radioButtonOrderedDitheringRandom.Text = "ordered dithering random";
            radioButtonOrderedDitheringRandom.UseVisualStyleBackColor = true;
            radioButtonOrderedDitheringRandom.CheckedChanged += radioButtonOrderedDitheringRandom_CheckedChanged;
            // 
            // radioButtonErrorDiffusionDithering
            // 
            radioButtonErrorDiffusionDithering.AutoSize = true;
            radioButtonErrorDiffusionDithering.Location = new Point(9, 81);
            radioButtonErrorDiffusionDithering.Margin = new Padding(4, 2, 4, 2);
            radioButtonErrorDiffusionDithering.Name = "radioButtonErrorDiffusionDithering";
            radioButtonErrorDiffusionDithering.Size = new Size(301, 36);
            radioButtonErrorDiffusionDithering.TabIndex = 1;
            radioButtonErrorDiffusionDithering.TabStop = true;
            radioButtonErrorDiffusionDithering.Text = "error diffusion dithering";
            radioButtonErrorDiffusionDithering.UseVisualStyleBackColor = true;
            radioButtonErrorDiffusionDithering.CheckedChanged += radioButtonErrorDiffusionDithering_CheckedChanged;
            // 
            // radioButtonAverageDithering
            // 
            radioButtonAverageDithering.AutoSize = true;
            radioButtonAverageDithering.Location = new Point(9, 38);
            radioButtonAverageDithering.Margin = new Padding(4, 2, 4, 2);
            radioButtonAverageDithering.Name = "radioButtonAverageDithering";
            radioButtonAverageDithering.Size = new Size(233, 36);
            radioButtonAverageDithering.TabIndex = 0;
            radioButtonAverageDithering.TabStop = true;
            radioButtonAverageDithering.Text = "average dithering";
            radioButtonAverageDithering.UseVisualStyleBackColor = true;
            radioButtonAverageDithering.CheckedChanged += radioButtonAverageDithering_CheckedChanged;
            // 
            // groupBoxParamsForDithering
            // 
            groupBoxParamsForDithering.Controls.Add(textBoxKb);
            groupBoxParamsForDithering.Controls.Add(textBoxKg);
            groupBoxParamsForDithering.Controls.Add(textBoxKr);
            groupBoxParamsForDithering.Controls.Add(labelKb);
            groupBoxParamsForDithering.Controls.Add(labelKg);
            groupBoxParamsForDithering.Controls.Add(labelKr);
            groupBoxParamsForDithering.Location = new Point(4, 311);
            groupBoxParamsForDithering.Margin = new Padding(4, 2, 4, 2);
            groupBoxParamsForDithering.Name = "groupBoxParamsForDithering";
            groupBoxParamsForDithering.Padding = new Padding(4, 2, 4, 2);
            groupBoxParamsForDithering.Size = new Size(399, 201);
            groupBoxParamsForDithering.TabIndex = 1;
            groupBoxParamsForDithering.TabStop = false;
            groupBoxParamsForDithering.Text = "Params for dithering";
            // 
            // textBoxKb
            // 
            textBoxKb.Location = new Point(160, 147);
            textBoxKb.Margin = new Padding(4, 2, 4, 2);
            textBoxKb.Name = "textBoxKb";
            textBoxKb.Size = new Size(201, 39);
            textBoxKb.TabIndex = 5;
            textBoxKb.Text = "2";
            textBoxKb.TextChanged += textBoxKb_TextChanged;
            // 
            // textBoxKg
            // 
            textBoxKg.Location = new Point(160, 100);
            textBoxKg.Margin = new Padding(4, 2, 4, 2);
            textBoxKg.Name = "textBoxKg";
            textBoxKg.Size = new Size(201, 39);
            textBoxKg.TabIndex = 4;
            textBoxKg.Text = "2";
            textBoxKg.TextChanged += textBoxKg_TextChanged;
            // 
            // textBoxKr
            // 
            textBoxKr.Location = new Point(160, 51);
            textBoxKr.Margin = new Padding(4, 2, 4, 2);
            textBoxKr.Name = "textBoxKr";
            textBoxKr.Size = new Size(201, 39);
            textBoxKr.TabIndex = 3;
            textBoxKr.Text = "2";
            textBoxKr.TextChanged += textBoxKr_TextChanged;
            // 
            // labelKb
            // 
            labelKb.AutoSize = true;
            labelKb.Location = new Point(28, 149);
            labelKb.Margin = new Padding(4, 0, 4, 0);
            labelKb.Name = "labelKb";
            labelKb.Size = new Size(42, 32);
            labelKb.TabIndex = 2;
            labelKb.Text = "Kb";
            // 
            // labelKg
            // 
            labelKg.AutoSize = true;
            labelKg.Location = new Point(28, 102);
            labelKg.Margin = new Padding(4, 0, 4, 0);
            labelKg.Name = "labelKg";
            labelKg.Size = new Size(42, 32);
            labelKg.TabIndex = 1;
            labelKg.Text = "Kg";
            // 
            // labelKr
            // 
            labelKr.AutoSize = true;
            labelKr.Location = new Point(28, 51);
            labelKr.Margin = new Padding(4, 0, 4, 0);
            labelKr.Name = "labelKr";
            labelKr.Size = new Size(36, 32);
            labelKr.TabIndex = 0;
            labelKr.Text = "Kr";
            // 
            // groupBoxParamsForPopularityAlgorithm
            // 
            groupBoxParamsForPopularityAlgorithm.Controls.Add(labelK);
            groupBoxParamsForPopularityAlgorithm.Controls.Add(textBoxK);
            groupBoxParamsForPopularityAlgorithm.Location = new Point(4, 516);
            groupBoxParamsForPopularityAlgorithm.Margin = new Padding(4, 2, 4, 2);
            groupBoxParamsForPopularityAlgorithm.Name = "groupBoxParamsForPopularityAlgorithm";
            groupBoxParamsForPopularityAlgorithm.Padding = new Padding(4, 2, 4, 2);
            groupBoxParamsForPopularityAlgorithm.Size = new Size(399, 124);
            groupBoxParamsForPopularityAlgorithm.TabIndex = 2;
            groupBoxParamsForPopularityAlgorithm.TabStop = false;
            groupBoxParamsForPopularityAlgorithm.Text = "Params for popularity algorithm";
            // 
            // labelK
            // 
            labelK.AutoSize = true;
            labelK.Location = new Point(28, 55);
            labelK.Margin = new Padding(4, 0, 4, 0);
            labelK.Name = "labelK";
            labelK.Size = new Size(28, 32);
            labelK.TabIndex = 1;
            labelK.Text = "K";
            // 
            // textBoxK
            // 
            textBoxK.Location = new Point(160, 53);
            textBoxK.Margin = new Padding(4, 2, 4, 2);
            textBoxK.Name = "textBoxK";
            textBoxK.Size = new Size(201, 39);
            textBoxK.TabIndex = 0;
            textBoxK.Text = "1015";
            textBoxK.TextChanged += textBoxK_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.84911F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.1508942F));
            tableLayoutPanel2.Controls.Add(labelOriginalImage, 0, 0);
            tableLayoutPanel2.Controls.Add(labelChangedImage, 1, 0);
            tableLayoutPanel2.Controls.Add(pictureBoxOriginalImage, 0, 1);
            tableLayoutPanel2.Controls.Add(pictureBoxChangedImage, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(395, 2);
            tableLayoutPanel2.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.49627256F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 93.50373F));
            tableLayoutPanel2.Size = new Size(1525, 899);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // labelOriginalImage
            // 
            labelOriginalImage.AutoSize = true;
            labelOriginalImage.Dock = DockStyle.Fill;
            labelOriginalImage.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOriginalImage.Location = new Point(4, 0);
            labelOriginalImage.Margin = new Padding(4, 0, 4, 0);
            labelOriginalImage.Name = "labelOriginalImage";
            labelOriginalImage.Size = new Size(736, 58);
            labelOriginalImage.TabIndex = 0;
            labelOriginalImage.Text = "Original Image:";
            // 
            // labelChangedImage
            // 
            labelChangedImage.AutoSize = true;
            labelChangedImage.Dock = DockStyle.Fill;
            labelChangedImage.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChangedImage.Location = new Point(748, 0);
            labelChangedImage.Margin = new Padding(4, 0, 4, 0);
            labelChangedImage.Name = "labelChangedImage";
            labelChangedImage.Size = new Size(773, 58);
            labelChangedImage.TabIndex = 1;
            labelChangedImage.Text = "Reduced Image:";
            // 
            // pictureBoxOriginalImage
            // 
            pictureBoxOriginalImage.Dock = DockStyle.Fill;
            pictureBoxOriginalImage.Location = new Point(4, 60);
            pictureBoxOriginalImage.Margin = new Padding(4, 2, 4, 2);
            pictureBoxOriginalImage.Name = "pictureBoxOriginalImage";
            pictureBoxOriginalImage.Size = new Size(736, 837);
            pictureBoxOriginalImage.TabIndex = 2;
            pictureBoxOriginalImage.TabStop = false;
            // 
            // pictureBoxChangedImage
            // 
            pictureBoxChangedImage.Dock = DockStyle.Fill;
            pictureBoxChangedImage.Location = new Point(748, 60);
            pictureBoxChangedImage.Margin = new Padding(4, 2, 4, 2);
            pictureBoxChangedImage.Name = "pictureBoxChangedImage";
            pictureBoxChangedImage.Size = new Size(773, 837);
            pictureBoxChangedImage.TabIndex = 3;
            pictureBoxChangedImage.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1924, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStripColorReduction";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chooseImageToolStripMenuItem, saveImageToolStripMenuItem, createImageToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(97, 38);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // chooseImageToolStripMenuItem
            // 
            chooseImageToolStripMenuItem.Name = "chooseImageToolStripMenuItem";
            chooseImageToolStripMenuItem.Size = new Size(359, 44);
            chooseImageToolStripMenuItem.Text = "Choose Image";
            chooseImageToolStripMenuItem.Click += chooseImageToolStripMenuItem_Click;
            // 
            // saveImageToolStripMenuItem
            // 
            saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            saveImageToolStripMenuItem.Size = new Size(359, 44);
            saveImageToolStripMenuItem.Text = "Save Image";
            saveImageToolStripMenuItem.Click += saveImageToolStripMenuItem_Click;
            // 
            // createImageToolStripMenuItem
            // 
            createImageToolStripMenuItem.Name = "createImageToolStripMenuItem";
            createImageToolStripMenuItem.Size = new Size(359, 44);
            createImageToolStripMenuItem.Text = "Create Image";
            createImageToolStripMenuItem.Click += createImageToolStripMenuItem_Click;
            // 
            // ColorReduction
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 945);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 2, 4, 2);
            Name = "ColorReduction";
            Text = "ColorReduction";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            algorithmsGroupBox.ResumeLayout(false);
            algorithmsGroupBox.PerformLayout();
            groupBoxParamsForDithering.ResumeLayout(false);
            groupBoxParamsForDithering.PerformLayout();
            groupBoxParamsForPopularityAlgorithm.ResumeLayout(false);
            groupBoxParamsForPopularityAlgorithm.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginalImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChangedImage).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox algorithmsGroupBox;
        private RadioButton radioButtonPopularityAlgorithm;
        private RadioButton radioButtonOrderedDitheringRelative;
        private RadioButton radioButtonOrderedDitheringRandom;
        private RadioButton radioButtonErrorDiffusionDithering;
        private RadioButton radioButtonAverageDithering;
        private Button buttonRefresh;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBoxParamsForDithering;
        private TextBox textBoxKb;
        private TextBox textBoxKg;
        private TextBox textBoxKr;
        private Label labelKb;
        private Label labelKg;
        private Label labelKr;
        private GroupBox groupBoxParamsForPopularityAlgorithm;
        private Label labelK;
        private TextBox textBoxK;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelOriginalImage;
        private Label labelChangedImage;
        private PictureBox pictureBoxOriginalImage;
        private PictureBox pictureBoxChangedImage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem chooseImageToolStripMenuItem;
        private ToolStripMenuItem saveImageToolStripMenuItem;
        private ToolStripMenuItem createImageToolStripMenuItem;
    }
}