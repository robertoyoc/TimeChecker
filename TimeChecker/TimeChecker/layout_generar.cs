using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeChecker
{
    public partial class layout_generar : Form
    {
        public layout_generar()
        {
            InitializeComponent();
        }
        private void layout_generar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Pantallas.Principal.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pantallas.Principal.Show();
        }
    }
}
