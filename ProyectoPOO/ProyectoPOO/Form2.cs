using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void botonExit_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }

        

        private void radioOscuro_CheckedChanged_1(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.FromArgb(89, 86, 95);
            Program.fondoR = 89;
            Program.fondoG = 86;
            Program.fondoB = 95;
        }

        private void radioClaro_CheckedChanged(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.FromArgb(247, 245, 232);
            Program.fondoR = 247;
            Program.fondoG = 245;
            Program.fondoB = 232;
        }

        private void botonExit_Click_1(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Close();
        }
    }
}
