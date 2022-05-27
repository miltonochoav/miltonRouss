using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miltonRouss
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Pasar1(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/prod1pic.png";
        }

        private void Pasar2(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/prod2pic.jpg";
        }

        private void Pasar3(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/prod3pic.jpg";
        }

        private void Pasar4(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/prod4pic.jpg";
        }

        private void Pasar5(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/prod5pic.jpg";
        }

        private void Pasar6(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/prod6pic.jpg";
        }

        private void Pasar7(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/prod7pic.jpg";
        }

        private void Pasar8(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/prod8pic.jpeg";
        }

        private void Pasar9(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/prod9pic.png";
        }

        private void Pasar10(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/prod10pic.jpg";
        }

        private void Pasar11(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/prod11pic.jpg";
        }

        private void Salir1(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/Rouss3.jpeg";
        }

        private void Salir2(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/Rouss3.jpeg";
        }

        private void Salir3(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/Rouss3.jpeg";
        }

        private void Salir4(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/Rouss3.jpeg";
        }

        private void Salir5(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/Rouss3.jpeg";
        }

        private void Salir6(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/Rouss3.jpeg";
        }

        private void Salir7(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/Rouss3.jpeg";
        }

        private void Salir8(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/Rouss3.jpeg";
        }

        private void Salir9(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/Rouss3.jpeg";
        }

        private void Salir10(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/Rouss3.jpeg";
        }

        private void Salir11(object sender, EventArgs e)
        {
            picBox1Principal.ImageLocation = "C:/Users/OLGA/Documents/FinalHerra/miltonRouss/pics2/Rouss3.jpeg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string preFactura = "";
            
            int prod1 = 0;
            int prod2 = 0;
            int prod3 = 0;
            int prod4 = 0;
            int prod5 = 0;
            int prod6 = 0;
            int prod7 = 0;
            int prod8 = 0;
            int prod9 = 0;
            int prod10 = 0;
            int prod11 = 0;

            int disp1 = 0;
            int disp2 = 0;
            int disp3 = 0;
            int disp4 = 0;
            int disp5 = 0;
            int disp6 = 0;
            int disp7 = 0;
            int disp8 = 0;
            int disp9 = 0;
            int disp10 = 0;
            int disp11 = 0;

            int cantProd1 = 0;
            int cantProd2 = 0;
            int cantProd3 = 0;
            int cantProd4 = 0;
            int cantProd5 = 0;
            int cantProd6 = 0;
            int cantProd7 = 0;
            int cantProd8 = 0;
            int cantProd9 = 0;
            int cantProd10 = 0;
            int cantProd11 = 0;

            //int inventarioProd1 = 0;
            //int inventarioProd2 = 0;
            //int inventarioProd3 = 0;
            //int inventarioProd4 = 0;
            //int inventarioProd5 = 0;
            //int inventarioProd6 = 0;
            //int inventarioProd7 = 0;
            //int inventarioProd8 = 0;
            //int inventarioProd9 = 0;
            //int inventarioProd10 = 0;
            //int inventarioProd11 = 0;

            int valorProd1 = 0;
            int valorProd2 = 0;
            int valorProd3 = 0;
            int valorProd4 = 0;
            int valorProd5 = 0;
            int valorProd6 = 0;
            int valorProd7 = 0;
            int valorProd8 = 0;
            int valorProd9 = 0;
            int valorProd10 = 0;
            int valorProd11 = 0;

            int total = 0;

            prod1 = Convert.ToInt32(lbl1Hamburguesa.Text);
            prod2 = Convert.ToInt32(lbl2HamburguesaDoble.Text);
            prod3 = Convert.ToInt32(lbl3BistecRes.Text);
            prod4 = Convert.ToInt32(lbl4BistecCerdo.Text);
            prod5 = Convert.ToInt32(lbl5Pechuga.Text);
            prod6 = Convert.ToInt32(lbl6BurritoPollo.Text);
            prod7 = Convert.ToInt32(lbl7BurritoRes.Text);
            prod8 = Convert.ToInt32(lbl8Cocacola.Text);
            prod9 = Convert.ToInt32(lbl9Limonada.Text);
            prod10 = Convert.ToInt32(lbl10Batido.Text);
            prod11 = Convert.ToInt32(lbl11Cerveza.Text);

            disp1 = Convert.ToInt32(lbl1DispNum.Text);
            disp2 = Convert.ToInt32(lbl2DispNum.Text);
            disp3 = Convert.ToInt32(lbl3DispNum.Text);
            disp4 = Convert.ToInt32(lbl4DispNum.Text);
            disp5 = Convert.ToInt32(lbl5DispNum.Text);
            disp6 = Convert.ToInt32(lbl6DispNum.Text);
            disp7 = Convert.ToInt32(lbl7DispNum.Text);
            disp8 = Convert.ToInt32(lbl8DispNum.Text);
            disp9 = Convert.ToInt32(lbl9DispNum.Text);
            disp10 = Convert.ToInt32(lbl10DispNum.Text);
            disp11 = Convert.ToInt32(lbl11DispNum.Text);

            cantProd1 = Convert.ToInt32(numUp1Hamburguesa.Text);
            cantProd2 = Convert.ToInt32(numUp2HamburguesaDoble.Text);
            cantProd3 = Convert.ToInt32(numUp3BistecRes.Text);
            cantProd4 = Convert.ToInt32(numUp4BistecCerdo.Text);
            cantProd5 = Convert.ToInt32(numUp5Pechuga.Text);
            cantProd6 = Convert.ToInt32(numUp6BurritoPollo.Text);
            cantProd7 = Convert.ToInt32(numUp7BurritoRes.Text);
            cantProd8 = Convert.ToInt32(numUp8Cocacola.Text);
            cantProd9 = Convert.ToInt32(numUp9Limonada.Text);
            cantProd10 = Convert.ToInt32(numUp10Batido.Text);
            cantProd11 = Convert.ToInt32(numUp11Cerveza.Text);

            if (chb1Hamburguesa.Checked == true)
            {
                valorProd1 = prod1 * cantProd1;

                preFactura += "Pro. 1 " + " Cant. " + cantProd1.ToString() + " Valor: " + valorProd1.ToString() + "\r\n\n";
                                

            }
            else
            {
                txtBoxPreFactura.Text = "";
            }

            if (chb2HamburguesaDoble.Checked == true)
            {
                valorProd2 = prod2 * cantProd2;

                preFactura += "Pro. 2 " + " Cant. " + cantProd2.ToString() + " Valor: " + valorProd2.ToString() + "\r\n";
                
            }
            else
            {
                txtBoxPreFactura.Text = "";
            }

            if (chb3BistecRes.Checked == true)
            {
                valorProd3 = prod3 * cantProd3;

                preFactura += "Pro. 3 " + " Cant. " + cantProd3.ToString() + " Valor: " + valorProd3.ToString() + "\r\n";
                
            }
            else
            {
                txtBoxPreFactura.Text = "";
            }

            if (chb4BistecCerdo.Checked == true)
            {
                valorProd4 = prod4 * cantProd4;

                preFactura += "Pro. 4 " + " Cant. " + cantProd4.ToString() + " Valor: " + valorProd4.ToString() + "\r\n";
                
            }
            else
            {
                txtBoxPreFactura.Text = "";
            }

            if (chb5Pechuga.Checked == true)
            {
                valorProd5 = prod5 * cantProd5;

                preFactura += "Pro. 5 " + " Cant. " + cantProd5.ToString() + " Valor: " + valorProd5.ToString() + "\r\n";
                
            }
            else
            {
                txtBoxPreFactura.Text = "";
            }

            if (chb6BurritoPollo.Checked == true)
            {
                valorProd6 = prod6 * cantProd6;

                preFactura += "Pro. 6 " + " Cant. " + cantProd6.ToString() + " Valor: " + valorProd6.ToString() + "\r\n";
                
            }
            else
            {
                txtBoxPreFactura.Text = "";
            }

            if (chb7BurritoRes.Checked == true)
            {
                valorProd7 = prod7 * cantProd7;

                preFactura += "Pro. 7 " + " Cant. " + cantProd7.ToString() + " Valor: " + valorProd7.ToString() + "\r\n";
                
            }
            else
            {
                txtBoxPreFactura.Text = "";
            }

            if (chb8Cocacola.Checked == true)
            {
                valorProd8 = prod8 * cantProd8;

                preFactura += "Pro. 8 " + " Cant. " + cantProd8.ToString() + " Valor: " + valorProd8.ToString() + "\r\n";
                
            }
            else
            {
                txtBoxPreFactura.Text = "";
            }

            if (chb9Limonada.Checked == true)
            {
                valorProd9 = prod9 * cantProd9;

                preFactura += "Pro. 9 " + " Cant. " + cantProd9.ToString() + " Valor: " + valorProd9.ToString() + "\r\n";
                
            }
            else
            {
                txtBoxPreFactura.Text = "";
            }

            if (chb10Batido.Checked == true)
            {
                valorProd10 = prod10 * cantProd10;

                preFactura += "Pro. 10 " + " Cant. " + cantProd10.ToString() + " Valor: " + valorProd10.ToString() + "\r\n";
                
            }
            else
            {
                txtBoxPreFactura.Text = "";
            }

            if (chb11Cerveza.Checked == true)
            {
                valorProd11 = prod11 * cantProd11;

                preFactura += "Pro. 11 " + " Cant. " + cantProd11.ToString() + " Valor: " + valorProd11.ToString() + "\r\n";
                
            }

            txtB1Hamburguesa.Text = valorProd1.ToString();
            txtB2HamburguesaDoble.Text = valorProd2.ToString();
            txtB3BistecRes.Text = valorProd3.ToString();
            txtB4BistecCerdo.Text = valorProd4.ToString();
            txtB5Pechuga.Text = valorProd5.ToString();
            txtB6BurritoPollo.Text = valorProd6.ToString();
            txtB7BurritoRes.Text = valorProd7.ToString();
            txtB8Cocacola.Text = valorProd8.ToString();
            txtB9Limonada.Text = valorProd9.ToString();
            txtB10Batido.Text = valorProd10.ToString();
            txtB11Cerveza.Text = valorProd11.ToString();

            total = valorProd1 + valorProd2 + valorProd3 + valorProd4 + valorProd5 + valorProd6 + valorProd7 + valorProd8 + valorProd9 + valorProd10 + valorProd11;

            txtBoxPreFactura.Text = "\r\n" + "ESTA ES TU PREFACTURA\r\n" + "\r\n" + preFactura + "\r\n" + "EL TOTAL A PAGAR ES: \r\n" + "\r\n" + total.ToString();


            txtTotal.Text = total.ToString();

            

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 Ventana3 = new Form3();
            Ventana3.Show();

        }
    }
}
