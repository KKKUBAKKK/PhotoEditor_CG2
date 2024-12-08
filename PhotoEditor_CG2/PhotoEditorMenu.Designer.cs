namespace PhotoEditor_CG2
{
    partial class PhotoEditorMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chromaticityDiagramButton = new Button();
            ColorReductionButton = new Button();
            buttonRGBtoCMYK = new Button();
            buttonRGBtoYCbCrHSVLab = new Button();
            SuspendLayout();
            // 
            // chromaticityDiagramButton
            // 
            chromaticityDiagramButton.Location = new Point(33, 49);
            chromaticityDiagramButton.Name = "chromaticityDiagramButton";
            chromaticityDiagramButton.Size = new Size(500, 72);
            chromaticityDiagramButton.TabIndex = 0;
            chromaticityDiagramButton.Text = "Chromaticity Diagram";
            chromaticityDiagramButton.UseVisualStyleBackColor = true;
            chromaticityDiagramButton.Click += chromaticityDiagramButton_Click;
            // 
            // ColorReductionButton
            // 
            ColorReductionButton.Location = new Point(33, 127);
            ColorReductionButton.Name = "ColorReductionButton";
            ColorReductionButton.Size = new Size(500, 68);
            ColorReductionButton.TabIndex = 1;
            ColorReductionButton.Text = "Color reduction";
            ColorReductionButton.UseVisualStyleBackColor = true;
            ColorReductionButton.Click += ColorReductionButton_Click;
            // 
            // buttonRGBtoCMYK
            // 
            buttonRGBtoCMYK.Location = new Point(33, 201);
            buttonRGBtoCMYK.Name = "buttonRGBtoCMYK";
            buttonRGBtoCMYK.Size = new Size(500, 72);
            buttonRGBtoCMYK.TabIndex = 2;
            buttonRGBtoCMYK.Text = "RGB to CMYK";
            buttonRGBtoCMYK.UseVisualStyleBackColor = true;
            buttonRGBtoCMYK.Click += buttonRGBtoCMYK_Click;
            // 
            // buttonRGBtoYCbCrHSVLab
            // 
            buttonRGBtoYCbCrHSVLab.Location = new Point(33, 279);
            buttonRGBtoYCbCrHSVLab.Name = "buttonRGBtoYCbCrHSVLab";
            buttonRGBtoYCbCrHSVLab.Size = new Size(500, 75);
            buttonRGBtoYCbCrHSVLab.TabIndex = 3;
            buttonRGBtoYCbCrHSVLab.Text = "RGB to YCbCr, HSV, Lab";
            buttonRGBtoYCbCrHSVLab.UseVisualStyleBackColor = true;
            buttonRGBtoYCbCrHSVLab.Click += buttonRGBtoYCbCrHSVLab_Click;
            // 
            // PhotoEditorMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 956);
            Controls.Add(buttonRGBtoYCbCrHSVLab);
            Controls.Add(buttonRGBtoCMYK);
            Controls.Add(ColorReductionButton);
            Controls.Add(chromaticityDiagramButton);
            Name = "PhotoEditorMenu";
            Text = "Photo Editor Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button chromaticityDiagramButton;
        private Button ColorReductionButton;
        private Button buttonRGBtoCMYK;
        private Button buttonRGBtoYCbCrHSVLab;
    }
}
