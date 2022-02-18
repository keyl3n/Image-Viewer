using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Portable Network Graphics (*.png)|*.png|Joint Photographic Experts Group (*.jpeg, *.jpg, *.jfif, *.jpe)|*.jpeg;*.jpg;*.jfif;*.jpe|Bitmap (*.bmp)|*.bmp|Tag Image File Format (*.tif, *.tiff)|*.tif;*.tiff|High Effiency Image File Format (*.heic)|*.heic|WebP (*.webp)|*.webp";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
