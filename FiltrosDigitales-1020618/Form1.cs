using FiltrosDigitales_1020618.ExtraClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltrosDigitales_1020618
{
    public partial class Form1 : Form
    {
        bool changeValue = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUploadImage_Click(object sender, EventArgs e)
        {
            //Image upload code source: https://www.youtube.com/watch?v=sGP6u68k2hc
            try
            {                
                var dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png";
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

        private void P00_ValueChanged(object sender, EventArgs e)
        {
            if (changeValue)
            {
                CBfilters.SelectedIndex = 9;
            }
        }

        private void P01_ValueChanged(object sender, EventArgs e)
        {
            if (changeValue)
            {
                CBfilters.SelectedIndex = 9;
            }
        }

        private void P02_ValueChanged(object sender, EventArgs e)
        {
            if (changeValue)
            {
                CBfilters.SelectedIndex = 9;
            }
        }

        private void P10_ValueChanged(object sender, EventArgs e)
        {
            if (changeValue)
            {
                CBfilters.SelectedIndex = 9;
            }
        }

        private void P11_ValueChanged(object sender, EventArgs e)
        {
            if (changeValue)
            {
                CBfilters.SelectedIndex = 9;
            }
        }

        private void P12_ValueChanged(object sender, EventArgs e)
        {
            if (changeValue)
            {
                CBfilters.SelectedIndex = 9;
            }
        }

        private void P20_ValueChanged(object sender, EventArgs e)
        {
            if (changeValue)
            {
                CBfilters.SelectedIndex = 9;
            }
        }
        private void P21_ValueChanged(object sender, EventArgs e)
        {
            if (changeValue)
            {
                CBfilters.SelectedIndex = 9;
            }
        }

        private void P22_ValueChanged(object sender, EventArgs e)
        {
            if (changeValue)
            {
                CBfilters.SelectedIndex = 9;
            }
        }

        private void Btnapply_Click(object sender, EventArgs e)
        {   
            
            if (PBoriginalPic.Image == null)
            {
                MessageBox.Show("Sube una imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PBoriginalPic.Image == PBoriginalPic.ErrorImage)
            {
                MessageBox.Show("Sube una imagen válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (CBfilters.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un filtro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                var filterMatrix = new double[3,3];
                if (CBfilters.SelectedIndex != 9)
                {
                    var filter = new Filters();
                    filterMatrix = filter.GetDefinedMatrix(CBfilters.SelectedIndex);
                }
                else
                {
                    filterMatrix[0, 0] = (double)P00.Value;
                    filterMatrix[0, 1] = (double)P01.Value;
                    filterMatrix[0, 2] = (double)P02.Value;
                    filterMatrix[1, 0] = (double)P10.Value;
                    filterMatrix[1, 1] = (double)P11.Value;
                    filterMatrix[1, 2] = (double)P12.Value;
                    filterMatrix[2, 0] = (double)P20.Value;
                    filterMatrix[2, 1] = (double)P21.Value;
                    filterMatrix[2, 2] = (double)P22.Value;
                }
                var main = new MainClass();
                PBfilteredPic.Image = main.ImageOperations(PBoriginalPic.Image, filterMatrix);
                int a = 5;
            }
        }

        private void CBfilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeValue = false;
            if (CBfilters.SelectedIndex != 9)
            {
                var filters = new Filters();
                var filterMatrix = filters.GetDefinedMatrix(CBfilters.SelectedIndex);
                P00.Value = (decimal)filterMatrix[0, 0];
                P01.Value = (decimal)filterMatrix[0, 1];
                P02.Value = (decimal)filterMatrix[0, 2];
                P10.Value = (decimal)filterMatrix[1, 0];
                P11.Value = (decimal)filterMatrix[1, 1];
                P12.Value = (decimal)filterMatrix[1, 2];
                P20.Value = (decimal)filterMatrix[2, 0];
                P21.Value = (decimal)filterMatrix[2, 1];
                P22.Value = (decimal)filterMatrix[2, 2];
            }
            changeValue = true;
        }
    }
}
