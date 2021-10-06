
namespace WinFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pboxCodigoBarras = new System.Windows.Forms.PictureBox();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.labelIntrucciones = new System.Windows.Forms.Label();
            this.labelProductos = new System.Windows.Forms.Label();
            this.pboxProducto = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pboxError = new System.Windows.Forms.PictureBox();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCodigoBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxError)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxCodigoBarras
            // 
            this.pboxCodigoBarras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxCodigoBarras.BackgroundImage")));
            this.pboxCodigoBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxCodigoBarras.Location = new System.Drawing.Point(305, 334);
            this.pboxCodigoBarras.Name = "pboxCodigoBarras";
            this.pboxCodigoBarras.Size = new System.Drawing.Size(251, 165);
            this.pboxCodigoBarras.TabIndex = 1;
            this.pboxCodigoBarras.TabStop = false;
            // 
            // pboxLogo
            // 
            this.pboxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxLogo.BackgroundImage")));
            this.pboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxLogo.Location = new System.Drawing.Point(354, 48);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(202, 188);
            this.pboxLogo.TabIndex = 2;
            this.pboxLogo.TabStop = false;
            // 
            // labelIntrucciones
            // 
            this.labelIntrucciones.AutoSize = true;
            this.labelIntrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIntrucciones.Location = new System.Drawing.Point(127, 260);
            this.labelIntrucciones.Name = "labelIntrucciones";
            this.labelIntrucciones.Size = new System.Drawing.Size(633, 38);
            this.labelIntrucciones.TabIndex = 3;
            this.labelIntrucciones.Text = "Pase el codigo de barras por el escaner";
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProductos.Location = new System.Drawing.Point(154, 405);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(212, 38);
            this.labelProductos.TabIndex = 4;
            this.labelProductos.Text = "labelProductos";
            // 
            // pboxProducto
            // 
            this.pboxProducto.Location = new System.Drawing.Point(58, 132);
            this.pboxProducto.Name = "pboxProducto";
            this.pboxProducto.Size = new System.Drawing.Size(231, 244);
            this.pboxProducto.TabIndex = 5;
            this.pboxProducto.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pboxError
            // 
            this.pboxError.Image = ((System.Drawing.Image)(resources.GetObject("pboxError.Image")));
            this.pboxError.Location = new System.Drawing.Point(58, 12);
            this.pboxError.Name = "pboxError";
            this.pboxError.Size = new System.Drawing.Size(250, 245);
            this.pboxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxError.TabIndex = 6;
            this.pboxError.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelError.Location = new System.Drawing.Point(76, 383);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(444, 45);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "No se encontro el producto";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(884, 523);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.pboxError);
            this.Controls.Add(this.pboxProducto);
            this.Controls.Add(this.labelProductos);
            this.Controls.Add(this.labelIntrucciones);
            this.Controls.Add(this.pboxLogo);
            this.Controls.Add(this.pboxCodigoBarras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCodigoBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxCodigoBarras;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Label labelIntrucciones;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.PictureBox pboxProducto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pboxError;
        private System.Windows.Forms.Label labelError;
    }
}

