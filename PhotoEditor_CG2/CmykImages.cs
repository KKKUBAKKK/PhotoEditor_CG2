using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor_CG2
{
    public partial class CmykImages : Form
    {
        Bitmap cyanImage;
        Bitmap magentaImage;
        Bitmap yellowImage;
        Bitmap blackImage;

        public CmykImages(Bitmap cyanImage, Bitmap magentaImage, Bitmap yellowImage, Bitmap blackImage)
        {
            InitializeComponent();
            this.cyanImage = cyanImage;
            this.magentaImage = magentaImage;
            this.yellowImage = yellowImage;
            this.blackImage = blackImage;

            pictureBoxCyan.Image = cyanImage;
            pictureBoxMagenta.Image = magentaImage;
            pictureBoxYellow.Image = yellowImage;
            pictureBoxBlack.Image = blackImage;
        }
    }
}
