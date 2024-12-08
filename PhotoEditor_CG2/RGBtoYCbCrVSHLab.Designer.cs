namespace PhotoEditor_CG2
{
    partial class RGBtoYCbCrVSHLab
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
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBoxOriginal = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBoxOne = new PictureBox();
            pictureBoxTwo = new PictureBox();
            pictureBoxThree = new PictureBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            chooseFileToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            labelModes = new Label();
            radioButtonYCbCr = new RadioButton();
            radioButtonHSV = new RadioButton();
            radioButtonLab = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThree).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1838, 1191);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.1899567F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.8100433F));
            tableLayoutPanel2.Controls.Add(pictureBoxOriginal, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1832, 589);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBoxOriginal
            // 
            pictureBoxOriginal.Dock = DockStyle.Fill;
            pictureBoxOriginal.Location = new Point(3, 3);
            pictureBoxOriginal.Name = "pictureBoxOriginal";
            pictureBoxOriginal.Size = new Size(1115, 583);
            pictureBoxOriginal.TabIndex = 0;
            pictureBoxOriginal.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.91485F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.641922F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.44323F));
            tableLayoutPanel3.Controls.Add(pictureBoxOne, 0, 1);
            tableLayoutPanel3.Controls.Add(pictureBoxTwo, 1, 1);
            tableLayoutPanel3.Controls.Add(pictureBoxThree, 2, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 598);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7.86885262F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 92.13115F));
            tableLayoutPanel3.Size = new Size(1832, 590);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // pictureBoxOne
            // 
            pictureBoxOne.Dock = DockStyle.Fill;
            pictureBoxOne.Location = new Point(3, 49);
            pictureBoxOne.Name = "pictureBoxOne";
            pictureBoxOne.Size = new Size(597, 538);
            pictureBoxOne.TabIndex = 0;
            pictureBoxOne.TabStop = false;
            // 
            // pictureBoxTwo
            // 
            pictureBoxTwo.Dock = DockStyle.Fill;
            pictureBoxTwo.Location = new Point(606, 49);
            pictureBoxTwo.Name = "pictureBoxTwo";
            pictureBoxTwo.Size = new Size(592, 538);
            pictureBoxTwo.TabIndex = 1;
            pictureBoxTwo.TabStop = false;
            // 
            // pictureBoxThree
            // 
            pictureBoxThree.Dock = DockStyle.Fill;
            pictureBoxThree.Location = new Point(1204, 49);
            pictureBoxThree.Name = "pictureBoxThree";
            pictureBoxThree.Size = new Size(625, 538);
            pictureBoxThree.TabIndex = 2;
            pictureBoxThree.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1838, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chooseFileToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(97, 36);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // chooseFileToolStripMenuItem
            // 
            chooseFileToolStripMenuItem.Name = "chooseFileToolStripMenuItem";
            chooseFileToolStripMenuItem.Size = new Size(267, 44);
            chooseFileToolStripMenuItem.Text = "Choose file";
            chooseFileToolStripMenuItem.Click += chooseFileToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButtonLab);
            panel1.Controls.Add(radioButtonHSV);
            panel1.Controls.Add(radioButtonYCbCr);
            panel1.Controls.Add(labelModes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1124, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 583);
            panel1.TabIndex = 1;
            // 
            // labelModes
            // 
            labelModes.AutoSize = true;
            labelModes.Location = new Point(17, 17);
            labelModes.Name = "labelModes";
            labelModes.Size = new Size(87, 32);
            labelModes.TabIndex = 0;
            labelModes.Text = "Modes";
            // 
            // radioButtonYCbCr
            // 
            radioButtonYCbCr.AutoSize = true;
            radioButtonYCbCr.Location = new Point(17, 120);
            radioButtonYCbCr.Name = "radioButtonYCbCr";
            radioButtonYCbCr.Size = new Size(109, 36);
            radioButtonYCbCr.TabIndex = 1;
            radioButtonYCbCr.TabStop = true;
            radioButtonYCbCr.Text = "YCbCr";
            radioButtonYCbCr.UseVisualStyleBackColor = true;
            radioButtonYCbCr.CheckedChanged += radioButtonYCbCr_CheckedChanged;
            // 
            // radioButtonHSV
            // 
            radioButtonHSV.AutoSize = true;
            radioButtonHSV.Location = new Point(17, 64);
            radioButtonHSV.Name = "radioButtonHSV";
            radioButtonHSV.Size = new Size(90, 36);
            radioButtonHSV.TabIndex = 2;
            radioButtonHSV.TabStop = true;
            radioButtonHSV.Text = "HSV";
            radioButtonHSV.UseVisualStyleBackColor = true;
            radioButtonHSV.CheckedChanged += radioButtonHSV_CheckedChanged;
            // 
            // radioButtonLab
            // 
            radioButtonLab.AutoSize = true;
            radioButtonLab.Location = new Point(17, 176);
            radioButtonLab.Name = "radioButtonLab";
            radioButtonLab.Size = new Size(82, 36);
            radioButtonLab.TabIndex = 3;
            radioButtonLab.TabStop = true;
            radioButtonLab.Text = "Lab";
            radioButtonLab.UseVisualStyleBackColor = true;
            radioButtonLab.CheckedChanged += radioButtonLab_CheckedChanged;
            // 
            // RGBtoYCbCrVSHLab
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1838, 1231);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "RGBtoYCbCrVSHLab";
            Text = "RGBtoYCbCrVSHLab";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThree).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBoxOriginal;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBoxOne;
        private PictureBox pictureBoxTwo;
        private PictureBox pictureBoxThree;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem chooseFileToolStripMenuItem;
        private Panel panel1;
        private RadioButton radioButtonLab;
        private RadioButton radioButtonHSV;
        private RadioButton radioButtonYCbCr;
        private Label labelModes;
    }
}