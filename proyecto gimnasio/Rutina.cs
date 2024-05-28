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
    public partial class Rutina : Form
    {
        public Rutina()
        {
            InitializeComponent();
        }

        private void Rutina_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Extensiones de tríceps con mancuerna    (4x12)\nFlexiones de tríceps    (4x12)\nPress de tríceps con mancuerna    (4x12)");
        }

        private void Pecho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press banca    (4x12)\nPress inclinado    (4x12)\nMariposas    (4x12)");
        }

        private void Espalda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dominadas    (4x12)\nExtensiones    (4x12)\nRemo    (4x12)");
        }

        private void Pierna_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sentadillas con mancuernas    (4x12)\nZancadas    (4x12)\nElevaciones de talones    (4x12)");
        }

        private void Bicep_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Curl de bíceps martillo    (4x12)\nCurl de bíceps concentrado    (4x12)\nCurl de bíceps en banco inclinado    (4x12)");
        }

        private void Antebrazo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Curl de muñeca con mancuerna   (4x12)\nCurl de muñeca invertido con mancuerna    (4x12)\nFlexiones de muñeca con mancuerna    (4x12)");
        }
    }
}
