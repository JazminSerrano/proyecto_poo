using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOO
{
    static class Program
    {
        public static byte fondoR = 247;
        public static byte fondoG = 245;
        public static byte fondoB = 232;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 main = new Form1();
            main.Show();
            Application.Run();
        }
    }
}
