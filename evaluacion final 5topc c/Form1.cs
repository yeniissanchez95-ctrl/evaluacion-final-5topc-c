using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluacion_final_5topc_c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (TextUsuario.Text == "feliciana" && TextContrasena.Text == "23")
            {
                this.Hide();
                Form2 aap = new Form2();
                aap.Show();
            }
            else
            {
                MessageBox.Show("Los Datos son invalidos");
            }
        }
    }
}

