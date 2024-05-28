using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_gimnasio
{
    public partial class Form1 : Form
    {
        BDatos bd= new BDatos();
        Form3 MPrin;
        public Form1()
        {
            InitializeComponent();
            MPrin = new Form3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Menu1.Text==bd.usuario[0,0] && Menu2.Text == bd.usuario[1,0])
            {
                this.Hide();
                MessageBox.Show("Bienvenido " + bd.usuario[0,0]);
                MPrin.ShowDialog();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
