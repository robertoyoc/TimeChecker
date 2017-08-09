using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeChecker
{
    public partial class layout_principal : Form
    {
        public layout_principal()
        {
            InitializeComponent();
        }  
        private void btn_generar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pantallas.Generar.Show();
            

        }

        private void btn_comparar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Pantallas.Comparar.Show();

        }

        private void layout_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Pantallas.Generar.Close();
            Pantallas.Comparar.Close();
            Application.Exit();
        }

        private void layout_principal_Load(object sender, EventArgs e)
        {
          
        }
    }
}
