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
    public partial class layout_comparar : Form
    {
        List<Schedule> teamMembers = new List<Schedule>();
        Stack<Schedule> selectedMembers = new Stack<Schedule>(); 

        public layout_comparar()
        {
            InitializeComponent();
        }
        private void layout_comparar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Pantallas.Principal.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pantallas.Principal.Show();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            new ImportExcel().importExcel(ref teamMembers);
        }

        private void btnActualizarCmb_Click(object sender, EventArgs e)
        {
            cmb_nombres.Items.Clear();
            for (int i = 0; i < teamMembers.Count; i++)
            {
                // MessageBox.Show(teamMembers.ElementAt(i).person, i.ToString());
                cmb_nombres.Items.Add(teamMembers.ElementAt(i).person);
            }
            MessageBox.Show("Lista actualizada", "Éxito");
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < teamMembers.Count; i++)
            {
                if (teamMembers.ElementAt(i).person == cmb_nombres.Items[cmb_nombres.SelectedIndex].ToString())
                {
                    selectedMembers.Push(teamMembers.ElementAt(i));
                    grd.Rows.Add(selectedMembers.First().person);
                    // MessageBox.Show("Se ha seleccionado a " + selectedMembers.First().person);
                    break;
                }
            }
        }

        private void btn_comparar_Click(object sender, EventArgs e)
        {

            new ImportExcel().generateShared(ref selectedMembers);
        }
    }
}
