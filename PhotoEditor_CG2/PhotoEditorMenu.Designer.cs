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
            ColorReductionButton = new Button();
            SuspendLayout();
            // 
            // ColorReductionButton
            // 
            ColorReductionButton.Location = new Point(31, 36);
            ColorReductionButton.Name = "ColorReductionButton";
            ColorReductionButton.Size = new Size(500, 68);
            ColorReductionButton.TabIndex = 1;
            ColorReductionButton.Text = "Color reduction algorithms";
            ColorReductionButton.UseVisualStyleBackColor = true;
            ColorReductionButton.Click += ColorReductionButton_Click;
            // 
            // PhotoEditorMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 139);
            Controls.Add(ColorReductionButton);
            Name = "PhotoEditorMenu";
            Text = "Photo Editor Menu";
            ResumeLayout(false);
        }

        #endregion
        private Button ColorReductionButton;
    }
}
