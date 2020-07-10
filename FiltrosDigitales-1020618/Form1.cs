using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltrosDigitales_1020618
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnUploadImage_Click(object sender, EventArgs e)
        {
            //Image upload code source: https://www.youtube.com/watch?v=sGP6u68k2hc
            try
            {                
                var dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PBoriginalPic.ImageLocation = dialog.FileName;
                    PBoriginalPic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo on error", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
