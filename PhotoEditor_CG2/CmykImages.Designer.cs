namespace PhotoEditor_CG2
{
    partial class CmykImages
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
            pictureBoxCyan = new PictureBox();
            pictureBoxMagenta = new PictureBox();
            pictureBoxYellow = new PictureBox();
            pictureBoxBlack = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCyan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMagenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlack).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBoxCyan, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBoxMagenta, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBoxYellow, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBoxBlack, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1806, 1144);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxCyan
            // 
            pictureBoxCyan.Dock = DockStyle.Fill;
            pictureBoxCyan.Location = new Point(3, 3);
            pictureBoxCyan.Name = "pictureBoxCyan";
            pictureBoxCyan.Size = new Size(897, 566);
            pictureBoxCyan.TabIndex = 0;
            pictureBoxCyan.TabStop = false;
            // 
            // pictureBoxMagenta
            // 
            pictureBoxMagenta.Dock = DockStyle.Fill;
            pictureBoxMagenta.Location = new Point(906, 3);
            pictureBoxMagenta.Name = "pictureBoxMagenta";
            pictureBoxMagenta.Size = new Size(897, 566);
            pictureBoxMagenta.TabIndex = 1;
            pictureBoxMagenta.TabStop = false;
            // 
            // pictureBoxYellow
            // 
            pictureBoxYellow.Dock = DockStyle.Fill;
            pictureBoxYellow.Location = new Point(3, 575);
            pictureBoxYellow.Name = "pictureBoxYellow";
            pictureBoxYellow.Size = new Size(897, 566);
            pictureBoxYellow.TabIndex = 2;
            pictureBoxYellow.TabStop = false;
            // 
            // pictureBoxBlack
            // 
            pictureBoxBlack.Dock = DockStyle.Fill;
            pictureBoxBlack.Location = new Point(906, 575);
            pictureBoxBlack.Name = "pictureBoxBlack";
            pictureBoxBlack.Size = new Size(897, 566);
            pictureBoxBlack.TabIndex = 3;
            pictureBoxBlack.TabStop = false;
            // 
            // CmykImages
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1806, 1144);
            Controls.Add(tableLayoutPanel1);
            Name = "CmykImages";
            Text = "CmykImages";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCyan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMagenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBoxCyan;
        private PictureBox pictureBoxMagenta;
        private PictureBox pictureBoxYellow;
        private PictureBox pictureBoxBlack;
    }
}