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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Yaned" && txtPass.Text == "123")
            {
                this.Hide();
                
                Form2 Ventana2 = new Form2();
                Ventana2.Show();
            }
            else
            {
                lblError.Text = "Error en usuario o contraseña";
                txtUser.Text = "";
                txtPass.Text = "";
            } 
        }
    }
}
