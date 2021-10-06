using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int segundos = 0;
        private string codigo = "";
        MySqlConnection servidor;
        public Form1()
        {
            InitializeComponent();

            servidor = new MySqlConnection("server = 127.0.0.1; port= 3307; user= root; password= ; database = verificador_de_precios; SSL Mode = None;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pboxLogo.Location = new Point(this.Width / 2 - pboxLogo.Width / 2, this.Height / 2 - pboxLogo.Height-200);
            labelIntrucciones.Location = new Point(this.Width / 2 - labelIntrucciones.Width / 2, this.Height / 2 - pboxLogo.Height+100);
            pboxCodigoBarras.Location = new Point(this.Width / 2 - pboxCodigoBarras.Width / 2, this.Height / 2 );
            pboxError.Visible = false;
            labelProductos.Visible = false;
            labelError.Visible = false;

        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (codigo != "")
                {
                    try
                    {
                        if (servidor.State != ConnectionState.Open)
                        {
                            servidor.Open();
                        }
                        String query = "SELECT producto_codigo, producto_nombre, producto_cantidad, producto_precio, producto_imagen FROM productos WHERE producto_codigo =  " + codigo + ";";
                        //MessageBox.Show(query);
                        MySqlCommand consulta = new MySqlCommand(query, servidor);
                        MySqlDataReader resultado = consulta.ExecuteReader();
                        if (resultado.HasRows)
                        {
                            resultado.Read();
                            //MessageBox.Show(resultado.GetString(1));
                            labelIntrucciones.Visible = false;
                            pboxCodigoBarras.Visible = false;
                            labelProductos.Text = resultado.GetString(1) + Environment.NewLine + "Precio: " + resultado.GetString(3)
                                + Environment.NewLine + "Stock: " + resultado.GetString(2);
                            pboxProducto.ImageLocation = resultado.GetString(4);
                            pboxProducto.SizeMode = PictureBoxSizeMode.StretchImage;
                            segundos = 0;
                            timer1.Enabled = true;
                            pboxProducto.Visible = true;
                            labelProductos.Visible = true;
                            pboxError.Visible = false;
                            labelError.Visible = false;
                            pboxProducto.Location = new Point(this.Width / 2 - labelIntrucciones.Width / 2 + 50, this.Height / 2 - pboxLogo.Height + 100);
                            labelProductos.Location = new Point(this.Width / 2 - labelIntrucciones.Width / 2 + 360, this.Height / 2 - pboxLogo.Height + 110);
                        }
                        else if (Int32.Parse(codigo) < 0 || Int32.Parse(codigo) > 20)
                        {
                            labelIntrucciones.Visible = false;
                            pboxCodigoBarras.Visible = false;
                            pboxLogo.Visible = false;
                            pboxError.Visible = true;
                            labelError.Visible = true;
                            segundos = 0;
                            timer1.Enabled = true;
                            pboxError.Location = new Point(this.Width / 2 - pboxLogo.Width / 2, this.Height / 2 - pboxLogo.Height - 200);
                            labelError.Location = new Point(this.Width / 2 - labelIntrucciones.Width / 2 +110, this.Height / 2 - pboxLogo.Height + 100);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Excepción: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (servidor.State == ConnectionState.Open)
                        {
                            servidor.Close();
                        }
                    }
                }
                
                codigo = "";
            }
            else 
            {
                codigo += e.KeyChar;

            }
                
        }

        private void timer1_Tick(object sender, EventArgs e) 
        {
            segundos++;

            if (segundos == 4)
            {
                timer1.Enabled = false;
                pboxCodigoBarras.Visible = true;
                labelIntrucciones.Visible = true;
                pboxLogo.Visible = true;
                pboxProducto.Visible = false;
                pboxError.Visible = false;
                labelError.Visible = false;
                labelProductos.Text = "";
            }
        }

    }
}
