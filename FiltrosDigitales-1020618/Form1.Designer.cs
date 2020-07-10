namespace FiltrosDigitales_1020618
{
    partial class Form1
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
            this.PBoriginalPic = new System.Windows.Forms.PictureBox();
            this.PBfilteredPic = new System.Windows.Forms.PictureBox();
            this.Btnapply = new System.Windows.Forms.Button();
            this.P00 = new System.Windows.Forms.NumericUpDown();
            this.P01 = new System.Windows.Forms.NumericUpDown();
            this.P02 = new System.Windows.Forms.NumericUpDown();
            this.P10 = new System.Windows.Forms.NumericUpDown();
            this.P11 = new System.Windows.Forms.NumericUpDown();
            this.P12 = new System.Windows.Forms.NumericUpDown();
            this.P20 = new System.Windows.Forms.NumericUpDown();
            this.P21 = new System.Windows.Forms.NumericUpDown();
            this.P22 = new System.Windows.Forms.NumericUpDown();
            this.CBfilters = new System.Windows.Forms.ComboBox();
            this.BtnUploadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBoriginalPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBfilteredPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P22)).BeginInit();
            this.SuspendLayout();
            // 
            // PBoriginalPic
            // 
            this.PBoriginalPic.Location = new System.Drawing.Point(27, 28);
            this.PBoriginalPic.Name = "PBoriginalPic";
            this.PBoriginalPic.Size = new System.Drawing.Size(252, 269);
            this.PBoriginalPic.TabIndex = 0;
            this.PBoriginalPic.TabStop = false;
            // 
            // PBfilteredPic
            // 
            this.PBfilteredPic.Location = new System.Drawing.Point(813, 28);
            this.PBfilteredPic.Name = "PBfilteredPic";
            this.PBfilteredPic.Size = new System.Drawing.Size(269, 269);
            this.PBfilteredPic.TabIndex = 1;
            this.PBfilteredPic.TabStop = false;
            // 
            // Btnapply
            // 
            this.Btnapply.Location = new System.Drawing.Point(662, 242);
            this.Btnapply.Name = "Btnapply";
            this.Btnapply.Size = new System.Drawing.Size(75, 43);
            this.Btnapply.TabIndex = 11;
            this.Btnapply.Text = "Aplicar";
            this.Btnapply.UseVisualStyleBackColor = true;
            // 
            // P00
            // 
            this.P00.Location = new System.Drawing.Point(337, 28);
            this.P00.Name = "P00";
            this.P00.Size = new System.Drawing.Size(120, 20);
            this.P00.TabIndex = 13;
            // 
            // P01
            // 
            this.P01.Location = new System.Drawing.Point(490, 28);
            this.P01.Name = "P01";
            this.P01.Size = new System.Drawing.Size(120, 20);
            this.P01.TabIndex = 14;
            // 
            // P02
            // 
            this.P02.Location = new System.Drawing.Point(644, 28);
            this.P02.Name = "P02";
            this.P02.Size = new System.Drawing.Size(120, 20);
            this.P02.TabIndex = 15;
            // 
            // P10
            // 
            this.P10.Location = new System.Drawing.Point(337, 116);
            this.P10.Name = "P10";
            this.P10.Size = new System.Drawing.Size(120, 20);
            this.P10.TabIndex = 16;
            // 
            // P11
            // 
            this.P11.Location = new System.Drawing.Point(490, 116);
            this.P11.Name = "P11";
            this.P11.Size = new System.Drawing.Size(120, 20);
            this.P11.TabIndex = 17;
            // 
            // P12
            // 
            this.P12.Location = new System.Drawing.Point(644, 116);
            this.P12.Name = "P12";
            this.P12.Size = new System.Drawing.Size(120, 20);
            this.P12.TabIndex = 18;
            // 
            // P20
            // 
            this.P20.Location = new System.Drawing.Point(337, 194);
            this.P20.Name = "P20";
            this.P20.Size = new System.Drawing.Size(120, 20);
            this.P20.TabIndex = 19;
            // 
            // P21
            // 
            this.P21.Location = new System.Drawing.Point(490, 194);
            this.P21.Name = "P21";
            this.P21.Size = new System.Drawing.Size(120, 20);
            this.P21.TabIndex = 20;
            // 
            // P22
            // 
            this.P22.Location = new System.Drawing.Point(644, 194);
            this.P22.Name = "P22";
            this.P22.Size = new System.Drawing.Size(120, 20);
            this.P22.TabIndex = 21;
            // 
            // CBfilters
            // 
            this.CBfilters.Items.AddRange(new object[] {
            "Difuminado",
            "Realzar",
            "Sobel inferior",
            "Sobel superior",
            "Sobel izquierdo",
            "Sobel derecho",
            "Contorno",
            "Afilar",
            "Original",
            "Personalizado"});
            this.CBfilters.Location = new System.Drawing.Point(464, 254);
            this.CBfilters.Name = "CBfilters";
            this.CBfilters.Size = new System.Drawing.Size(173, 21);
            this.CBfilters.TabIndex = 0;
            this.CBfilters.Text = "-- SELECCIONA UN FILTRO --";
            // 
            // BtnUploadImage
            // 
            this.BtnUploadImage.Location = new System.Drawing.Point(362, 242);
            this.BtnUploadImage.Name = "BtnUploadImage";
            this.BtnUploadImage.Size = new System.Drawing.Size(75, 43);
            this.BtnUploadImage.TabIndex = 22;
            this.BtnUploadImage.Text = "Subir imagen";
            this.BtnUploadImage.UseVisualStyleBackColor = true;
            this.BtnUploadImage.Click += new System.EventHandler(this.BtnUploadImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 328);
            this.Controls.Add(this.BtnUploadImage);
            this.Controls.Add(this.CBfilters);
            this.Controls.Add(this.P22);
            this.Controls.Add(this.P21);
            this.Controls.Add(this.P20);
            this.Controls.Add(this.P12);
            this.Controls.Add(this.P11);
            this.Controls.Add(this.P10);
            this.Controls.Add(this.P02);
            this.Controls.Add(this.P01);
            this.Controls.Add(this.P00);
            this.Controls.Add(this.Btnapply);
            this.Controls.Add(this.PBfilteredPic);
            this.Controls.Add(this.PBoriginalPic);
            this.Name = "Form1";
            this.Text = "Filtros digitales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoriginalPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBfilteredPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P22)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBoriginalPic;
        private System.Windows.Forms.PictureBox PBfilteredPic;
        private System.Windows.Forms.Button Btnapply;
        private System.Windows.Forms.NumericUpDown P00;
        private System.Windows.Forms.NumericUpDown P01;
        private System.Windows.Forms.NumericUpDown P02;
        private System.Windows.Forms.NumericUpDown P10;
        private System.Windows.Forms.NumericUpDown P11;
        private System.Windows.Forms.NumericUpDown P12;
        private System.Windows.Forms.NumericUpDown P20;
        private System.Windows.Forms.NumericUpDown P21;
        private System.Windows.Forms.NumericUpDown P22;
        private System.Windows.Forms.ComboBox CBfilters;
        private System.Windows.Forms.Button BtnUploadImage;
    }
}

