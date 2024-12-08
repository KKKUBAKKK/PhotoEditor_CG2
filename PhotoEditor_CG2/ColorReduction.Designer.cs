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
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1036, 419);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(algorithmsGroupBox);
            flowLayoutPanel1.Controls.Add(groupBoxParamsForDithering);
            flowLayoutPanel1.Controls.Add(groupBoxParamsForPopularityAlgorithm);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(2, 1);
            flowLayoutPanel1.Margin = new Padding(2, 1, 2, 1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(206, 417);
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
            algorithmsGroupBox.Location = new Point(2, 1);
            algorithmsGroupBox.Margin = new Padding(2, 1, 2, 1);
            algorithmsGroupBox.Name = "algorithmsGroupBox";
            algorithmsGroupBox.Padding = new Padding(2, 1, 2, 1);
            algorithmsGroupBox.Size = new Size(215, 143);
            algorithmsGroupBox.TabIndex = 0;
            algorithmsGroupBox.TabStop = false;
            algorithmsGroupBox.Text = "Algorithms";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(124, 116);
            buttonRefresh.Margin = new Padding(2, 1, 2, 1);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(81, 22);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += refreshButton_Click;
            // 
            // radioButtonPopularityAlgorithm
            // 
            radioButtonPopularityAlgorithm.AutoSize = true;
            radioButtonPopularityAlgorithm.Location = new Point(5, 97);
            radioButtonPopularityAlgorithm.Margin = new Padding(2, 1, 2, 1);
            radioButtonPopularityAlgorithm.Name = "radioButtonPopularityAlgorithm";
            radioButtonPopularityAlgorithm.Size = new Size(134, 19);
            radioButtonPopularityAlgorithm.TabIndex = 4;
            radioButtonPopularityAlgorithm.TabStop = true;
            radioButtonPopularityAlgorithm.Text = "popularity algorithm";
            radioButtonPopularityAlgorithm.UseVisualStyleBackColor = true;
            radioButtonPopularityAlgorithm.CheckedChanged += radioButtonPopularityAlgorithm_CheckedChanged;
            // 
            // radioButtonOrderedDitheringRelative
            // 
            radioButtonOrderedDitheringRelative.AutoSize = true;
            radioButtonOrderedDitheringRelative.Location = new Point(5, 77);
            radioButtonOrderedDitheringRelative.Margin = new Padding(2, 1, 2, 1);
            radioButtonOrderedDitheringRelative.Name = "radioButtonOrderedDitheringRelative";
            radioButtonOrderedDitheringRelative.Size = new Size(158, 19);
            radioButtonOrderedDitheringRelative.TabIndex = 3;
            radioButtonOrderedDitheringRelative.TabStop = true;
            radioButtonOrderedDitheringRelative.Text = "ordered dithering relative";
            radioButtonOrderedDitheringRelative.UseVisualStyleBackColor = true;
            radioButtonOrderedDitheringRelative.CheckedChanged += radioButtonOrderedDitheringRelative_CheckedChanged;
            // 
            // radioButtonOrderedDitheringRandom
            // 
            radioButtonOrderedDitheringRandom.AutoSize = true;
            radioButtonOrderedDitheringRandom.Location = new Point(5, 57);
            radioButtonOrderedDitheringRandom.Margin = new Padding(2, 1, 2, 1);
            radioButtonOrderedDitheringRandom.Name = "radioButtonOrderedDitheringRandom";
            radioButtonOrderedDitheringRandom.Size = new Size(162, 19);
            radioButtonOrderedDitheringRandom.TabIndex = 2;
            radioButtonOrderedDitheringRandom.TabStop = true;
            radioButtonOrderedDitheringRandom.Text = "ordered dithering random";
            radioButtonOrderedDitheringRandom.UseVisualStyleBackColor = true;
            radioButtonOrderedDitheringRandom.CheckedChanged += radioButtonOrderedDitheringRandom_CheckedChanged;
            // 
            // radioButtonErrorDiffusionDithering
            // 
            radioButtonErrorDiffusionDithering.AutoSize = true;
            radioButtonErrorDiffusionDithering.Location = new Point(5, 38);
            radioButtonErrorDiffusionDithering.Margin = new Padding(2, 1, 2, 1);
            radioButtonErrorDiffusionDithering.Name = "radioButtonErrorDiffusionDithering";
            radioButtonErrorDiffusionDithering.Size = new Size(151, 19);
            radioButtonErrorDiffusionDithering.TabIndex = 1;
            radioButtonErrorDiffusionDithering.TabStop = true;
            radioButtonErrorDiffusionDithering.Text = "error diffusion dithering";
            radioButtonErrorDiffusionDithering.UseVisualStyleBackColor = true;
            radioButtonErrorDiffusionDithering.CheckedChanged += radioButtonErrorDiffusionDithering_CheckedChanged;
            // 
            // radioButtonAverageDithering
            // 
            radioButtonAverageDithering.AutoSize = true;
            radioButtonAverageDithering.Location = new Point(5, 18);
            radioButtonAverageDithering.Margin = new Padding(2, 1, 2, 1);
            radioButtonAverageDithering.Name = "radioButtonAverageDithering";
            radioButtonAverageDithering.Size = new Size(117, 19);
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
            groupBoxParamsForDithering.Location = new Point(2, 146);
            groupBoxParamsForDithering.Margin = new Padding(2, 1, 2, 1);
            groupBoxParamsForDithering.Name = "groupBoxParamsForDithering";
            groupBoxParamsForDithering.Padding = new Padding(2, 1, 2, 1);
            groupBoxParamsForDithering.Size = new Size(215, 94);
            groupBoxParamsForDithering.TabIndex = 1;
            groupBoxParamsForDithering.TabStop = false;
            groupBoxParamsForDithering.Text = "Params for dithering";
            // 
            // textBoxKb
            // 
            textBoxKb.Location = new Point(86, 69);
            textBoxKb.Margin = new Padding(2, 1, 2, 1);
            textBoxKb.Name = "textBoxKb";
            textBoxKb.Size = new Size(110, 23);
            textBoxKb.TabIndex = 5;
            textBoxKb.Text = "2";
            textBoxKb.TextChanged += textBoxKb_TextChanged;
            // 
            // textBoxKg
            // 
            textBoxKg.Location = new Point(86, 47);
            textBoxKg.Margin = new Padding(2, 1, 2, 1);
            textBoxKg.Name = "textBoxKg";
            textBoxKg.Size = new Size(110, 23);
            textBoxKg.TabIndex = 4;
            textBoxKg.Text = "2";
            textBoxKg.TextChanged += textBoxKg_TextChanged;
            // 
            // textBoxKr
            // 
            textBoxKr.Location = new Point(86, 24);
            textBoxKr.Margin = new Padding(2, 1, 2, 1);
            textBoxKr.Name = "textBoxKr";
            textBoxKr.Size = new Size(110, 23);
            textBoxKr.TabIndex = 3;
            textBoxKr.Text = "2";
            textBoxKr.TextChanged += textBoxKr_TextChanged;
            // 
            // labelKb
            // 
            labelKb.AutoSize = true;
            labelKb.Location = new Point(15, 70);
            labelKb.Margin = new Padding(2, 0, 2, 0);
            labelKb.Name = "labelKb";
            labelKb.Size = new Size(21, 15);
            labelKb.TabIndex = 2;
            labelKb.Text = "Kb";
            // 
            // labelKg
            // 
            labelKg.AutoSize = true;
            labelKg.Location = new Point(15, 48);
            labelKg.Margin = new Padding(2, 0, 2, 0);
            labelKg.Name = "labelKg";
            labelKg.Size = new Size(21, 15);
            labelKg.TabIndex = 1;
            labelKg.Text = "Kg";
            // 
            // labelKr
            // 
            labelKr.AutoSize = true;
            labelKr.Location = new Point(15, 24);
            labelKr.Margin = new Padding(2, 0, 2, 0);
            labelKr.Name = "labelKr";
            labelKr.Size = new Size(18, 15);
            labelKr.TabIndex = 0;
            labelKr.Text = "Kr";
            // 
            // groupBoxParamsForPopularityAlgorithm
            // 
            groupBoxParamsForPopularityAlgorithm.Controls.Add(labelK);
            groupBoxParamsForPopularityAlgorithm.Controls.Add(textBoxK);
            groupBoxParamsForPopularityAlgorithm.Location = new Point(2, 242);
            groupBoxParamsForPopularityAlgorithm.Margin = new Padding(2, 1, 2, 1);
            groupBoxParamsForPopularityAlgorithm.Name = "groupBoxParamsForPopularityAlgorithm";
            groupBoxParamsForPopularityAlgorithm.Padding = new Padding(2, 1, 2, 1);
            groupBoxParamsForPopularityAlgorithm.Size = new Size(215, 58);
            groupBoxParamsForPopularityAlgorithm.TabIndex = 2;
            groupBoxParamsForPopularityAlgorithm.TabStop = false;
            groupBoxParamsForPopularityAlgorithm.Text = "Params for popularity algorithm";
            // 
            // labelK
            // 
            labelK.AutoSize = true;
            labelK.Location = new Point(15, 26);
            labelK.Margin = new Padding(2, 0, 2, 0);
            labelK.Name = "labelK";
            labelK.Size = new Size(14, 15);
            labelK.TabIndex = 1;
            labelK.Text = "K";
            // 
            // textBoxK
            // 
            textBoxK.Location = new Point(86, 25);
            textBoxK.Margin = new Padding(2, 1, 2, 1);
            textBoxK.Name = "textBoxK";
            textBoxK.Size = new Size(110, 23);
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
            tableLayoutPanel2.Location = new Point(212, 1);
            tableLayoutPanel2.Margin = new Padding(2, 1, 2, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.49627256F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 93.50373F));
            tableLayoutPanel2.Size = new Size(822, 417);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // labelOriginalImage
            // 
            labelOriginalImage.AutoSize = true;
            labelOriginalImage.Dock = DockStyle.Fill;
            labelOriginalImage.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOriginalImage.Location = new Point(2, 0);
            labelOriginalImage.Margin = new Padding(2, 0, 2, 0);
            labelOriginalImage.Name = "labelOriginalImage";
            labelOriginalImage.Size = new Size(397, 27);
            labelOriginalImage.TabIndex = 0;
            labelOriginalImage.Text = "Original Image:";
            // 
            // labelChangedImage
            // 
            labelChangedImage.AutoSize = true;
            labelChangedImage.Dock = DockStyle.Fill;
            labelChangedImage.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChangedImage.Location = new Point(403, 0);
            labelChangedImage.Margin = new Padding(2, 0, 2, 0);
            labelChangedImage.Name = "labelChangedImage";
            labelChangedImage.Size = new Size(417, 27);
            labelChangedImage.TabIndex = 1;
            labelChangedImage.Text = "Reduced Image:";
            // 
            // pictureBoxOriginalImage
            // 
            pictureBoxOriginalImage.Dock = DockStyle.Fill;
            pictureBoxOriginalImage.Location = new Point(2, 28);
            pictureBoxOriginalImage.Margin = new Padding(2, 1, 2, 1);
            pictureBoxOriginalImage.Name = "pictureBoxOriginalImage";
            pictureBoxOriginalImage.Size = new Size(397, 388);
            pictureBoxOriginalImage.TabIndex = 2;
            pictureBoxOriginalImage.TabStop = false;
            // 
            // pictureBoxChangedImage
            // 
            pictureBoxChangedImage.Dock = DockStyle.Fill;
            pictureBoxChangedImage.Location = new Point(403, 28);
            pictureBoxChangedImage.Margin = new Padding(2, 1, 2, 1);
            pictureBoxChangedImage.Name = "pictureBoxChangedImage";
            pictureBoxChangedImage.Size = new Size(417, 388);
            pictureBoxChangedImage.TabIndex = 3;
            pictureBoxChangedImage.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(1036, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStripColorReduction";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chooseImageToolStripMenuItem, saveImageToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 22);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // chooseImageToolStripMenuItem
            // 
            chooseImageToolStripMenuItem.Name = "chooseImageToolStripMenuItem";
            chooseImageToolStripMenuItem.Size = new Size(150, 22);
            chooseImageToolStripMenuItem.Text = "Choose Image";
            chooseImageToolStripMenuItem.Click += chooseImageToolStripMenuItem_Click;
            // 
            // saveImageToolStripMenuItem
            // 
            saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            saveImageToolStripMenuItem.Size = new Size(150, 22);
            saveImageToolStripMenuItem.Text = "Save Image";
            saveImageToolStripMenuItem.Click += saveImageToolStripMenuItem_Click;
            // 
            // ColorReduction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 443);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 1, 2, 1);
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
    }
}