using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeChecker
{
    class Pantallas
    {
        public static layout_principal Principal = new layout_principal();
        public static layout_comparar Comparar = new layout_comparar();
        public static layout_generar Generar = new layout_generar();
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(Pantallas.Principal);
        }
    }
}
