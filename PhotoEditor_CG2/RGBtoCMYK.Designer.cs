namespace PhotoEditor_CG2
{
    partial class RGBtoCMYK
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
            pictureBoxGraph = new PictureBox();
            panel1 = new Panel();
            buttonGCR = new Button();
            buttonUCR = new Button();
            button100Cofniecia = new Button();
            button0Cofniecia = new Button();
            buttonShowAll = new Button();
            radioButtonBlack = new RadioButton();
            radioButtonYellow = new RadioButton();
            radioButtonMagenta = new RadioButton();
            radioButtonCyan = new RadioButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBoxOriginalPhoto = new PictureBox();
            pictureBoxCMYKPhoto = new PictureBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            choosePhotoToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraph).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginalPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCMYKPhoto).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.90518F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.09482F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(2046, 1256);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pictureBoxGraph, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 65.11628F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 34.88372F));
            tableLayoutPanel2.Size = new Size(790, 1250);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBoxGraph
            // 
            pictureBoxGraph.Dock = DockStyle.Fill;
            pictureBoxGraph.Location = new Point(3, 3);
            pictureBoxGraph.Name = "pictureBoxGraph";
            pictureBoxGraph.Size = new Size(784, 807);
            pictureBoxGraph.TabIndex = 0;
            pictureBoxGraph.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonGCR);
            panel1.Controls.Add(buttonUCR);
            panel1.Controls.Add(button100Cofniecia);
            panel1.Controls.Add(button0Cofniecia);
            panel1.Controls.Add(buttonShowAll);
            panel1.Controls.Add(radioButtonBlack);
            panel1.Controls.Add(radioButtonYellow);
            panel1.Controls.Add(radioButtonMagenta);
            panel1.Controls.Add(radioButtonCyan);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 816);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 431);
            panel1.TabIndex = 1;
            // 
            // buttonGCR
            // 
            buttonGCR.Location = new Point(263, 313);
            buttonGCR.Name = "buttonGCR";
            buttonGCR.Size = new Size(247, 85);
            buttonGCR.TabIndex = 8;
            buttonGCR.Text = "GCR";
            buttonGCR.UseVisualStyleBackColor = true;
            buttonGCR.Click += buttonGCR_Click;
            // 
            // buttonUCR
            // 
            buttonUCR.Location = new Point(263, 226);
            buttonUCR.Name = "buttonUCR";
            buttonUCR.Size = new Size(247, 81);
            buttonUCR.TabIndex = 7;
            buttonUCR.Text = "UCR";
            buttonUCR.UseVisualStyleBackColor = true;
            buttonUCR.Click += s_Click;
            // 
            // button100Cofniecia
            // 
            button100Cofniecia.Location = new Point(263, 127);
            button100Cofniecia.Name = "button100Cofniecia";
            button100Cofniecia.Size = new Size(247, 93);
            button100Cofniecia.TabIndex = 6;
            button100Cofniecia.Text = "100% cofniecia";
            button100Cofniecia.UseVisualStyleBackColor = true;
            button100Cofniecia.Click += button100Cofniecia_Click;
            // 
            // button0Cofniecia
            // 
            button0Cofniecia.Location = new Point(263, 34);
            button0Cofniecia.Name = "button0Cofniecia";
            button0Cofniecia.Size = new Size(252, 87);
            button0Cofniecia.TabIndex = 5;
            button0Cofniecia.Text = "0% cofniecia";
            button0Cofniecia.UseVisualStyleBackColor = true;
            button0Cofniecia.Click += button0Cofniecia_Click;
            // 
            // buttonShowAll
            // 
            buttonShowAll.Location = new Point(561, 266);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(205, 132);
            buttonShowAll.TabIndex = 4;
            buttonShowAll.Text = "Show all";
            buttonShowAll.UseVisualStyleBackColor = true;
            buttonShowAll.Click += buttonShowAll_Click;
            // 
            // radioButtonBlack
            // 
            radioButtonBlack.AutoSize = true;
            radioButtonBlack.Location = new Point(561, 210);
            radioButtonBlack.Name = "radioButtonBlack";
            radioButtonBlack.Size = new Size(165, 36);
            radioButtonBlack.TabIndex = 3;
            radioButtonBlack.TabStop = true;
            radioButtonBlack.Text = "Show Black";
            radioButtonBlack.UseVisualStyleBackColor = true;
            radioButtonBlack.CheckedChanged += radioButtonBlack_CheckedChanged;
            // 
            // radioButtonYellow
            // 
            radioButtonYellow.AutoSize = true;
            radioButtonYellow.Location = new Point(561, 149);
            radioButtonYellow.Name = "radioButtonYellow";
            radioButtonYellow.Size = new Size(177, 36);
            radioButtonYellow.TabIndex = 2;
            radioButtonYellow.TabStop = true;
            radioButtonYellow.Text = "Show Yellow";
            radioButtonYellow.UseVisualStyleBackColor = true;
            radioButtonYellow.CheckedChanged += radioButtonYellow_CheckedChanged;
            // 
            // radioButtonMagenta
            // 
            radioButtonMagenta.AutoSize = true;
            radioButtonMagenta.Location = new Point(561, 93);
            radioButtonMagenta.Name = "radioButtonMagenta";
            radioButtonMagenta.Size = new Size(205, 36);
            radioButtonMagenta.TabIndex = 1;
            radioButtonMagenta.TabStop = true;
            radioButtonMagenta.Text = "Show Magenta";
            radioButtonMagenta.UseVisualStyleBackColor = true;
            radioButtonMagenta.CheckedChanged += radioButtonMagenta_CheckedChanged;
            // 
            // radioButtonCyan
            // 
            radioButtonCyan.AutoSize = true;
            radioButtonCyan.Location = new Point(561, 34);
            radioButtonCyan.Name = "radioButtonCyan";
            radioButtonCyan.Size = new Size(163, 36);
            radioButtonCyan.TabIndex = 0;
            radioButtonCyan.TabStop = true;
            radioButtonCyan.Text = "Show Cyan";
            radioButtonCyan.UseVisualStyleBackColor = true;
            radioButtonCyan.CheckedChanged += radioButtonCyan_CheckedChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pictureBoxOriginalPhoto, 0, 0);
            tableLayoutPanel3.Controls.Add(pictureBoxCMYKPhoto, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(799, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1244, 1250);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // pictureBoxOriginalPhoto
            // 
            pictureBoxOriginalPhoto.Dock = DockStyle.Fill;
            pictureBoxOriginalPhoto.Location = new Point(3, 3);
            pictureBoxOriginalPhoto.Name = "pictureBoxOriginalPhoto";
            pictureBoxOriginalPhoto.Size = new Size(1238, 619);
            pictureBoxOriginalPhoto.TabIndex = 0;
            pictureBoxOriginalPhoto.TabStop = false;
            // 
            // pictureBoxCMYKPhoto
            // 
            pictureBoxCMYKPhoto.Dock = DockStyle.Fill;
            pictureBoxCMYKPhoto.Location = new Point(3, 628);
            pictureBoxCMYKPhoto.Name = "pictureBoxCMYKPhoto";
            pictureBoxCMYKPhoto.Size = new Size(1238, 619);
            pictureBoxCMYKPhoto.TabIndex = 1;
            pictureBoxCMYKPhoto.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2046, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { choosePhotoToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(97, 36);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // choosePhotoToolStripMenuItem
            // 
            choosePhotoToolStripMenuItem.Name = "choosePhotoToolStripMenuItem";
            choosePhotoToolStripMenuItem.Size = new Size(298, 44);
            choosePhotoToolStripMenuItem.Text = "Choose photo";
            choosePhotoToolStripMenuItem.Click += choosePhotoToolStripMenuItem_Click;
            // 
            // RGBtoCMYK
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2046, 1296);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "RGBtoCMYK";
            Text = "RGBtoCMYK";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGraph).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginalPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCMYKPhoto).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBoxGraph;
        private PictureBox pictureBoxOriginalPhoto;
        private PictureBox pictureBoxCMYKPhoto;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem choosePhotoToolStripMenuItem;
        private Panel panel1;
        private RadioButton radioButtonBlack;
        private RadioButton radioButtonYellow;
        private RadioButton radioButtonMagenta;
        private RadioButton radioButtonCyan;
        private Button buttonShowAll;
        private Button buttonUCR;
        private Button button100Cofniecia;
        private Button button0Cofniecia;
        private Button buttonGCR;
    }
}