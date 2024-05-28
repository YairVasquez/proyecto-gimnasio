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
    public partial class Form3 : Form
    {
        Perfil PerfilUsuario;
        Rutina RutinaUsuario;
        public Form3()
        {
            InitializeComponent();
            PerfilUsuario = new Perfil();
            RutinaUsuario = new Rutina();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PerfilUsuario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RutinaUsuario.ShowDialog();
        }
    }
}
