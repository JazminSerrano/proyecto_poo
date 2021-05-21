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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.panel1.BackColor = Color.FromArgb(Program.fondoR, Program.fondoG, Program.fondoB); 
        }

        private void botonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void botonConfiguracion_Click(object sender, EventArgs e)
        {
            Form2 ajustes = new Form2();
            ajustes.Show();
            this.Close();
        }
    }
}
