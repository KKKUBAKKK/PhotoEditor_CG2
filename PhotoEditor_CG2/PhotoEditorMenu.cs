namespace PhotoEditor_CG2
{
    public partial class PhotoEditorMenu : Form
    {
        public PhotoEditorMenu()
        {
            InitializeComponent();
        }

        private void chromaticityDiagramButton_Click(object sender, EventArgs e)
        {
            ChromaticityDiagram chromaticityDiagram = new ChromaticityDiagram();
            chromaticityDiagram.Show();
            //this.Hide();
        }

        private void ColorReductionButton_Click(object sender, EventArgs e)
        {
            ColorReduction colorReduction = new ColorReduction();
            colorReduction.Show();
        }

        private void buttonRGBtoCMYK_Click(object sender, EventArgs e)
        {
            RGBtoCMYK rgbToCmyk = new RGBtoCMYK();
            rgbToCmyk.Show();
        }

        private void buttonRGBtoYCbCrHSVLab_Click(object sender, EventArgs e)
        {
            RGBtoYCbCrVSHLab rgbToYCbCrHSVLab = new RGBtoYCbCrVSHLab();
            rgbToYCbCrHSVLab.Show();
        }
    }
}
