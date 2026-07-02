using LigaDeportiva.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LigaDeportiva.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIrEquipos_Click(object sender, EventArgs e)
        {
            form1 frm1 = new form1();
            frm1.Show();
        }
        private void btnIrJugadores_Click(object sender, EventArgs j)
        {
            frmJugadores frmJ = new frmJugadores();
            frmJ.Show();
        }
        private void btnIrEstadisticasOfensivas_Click (object sender, EventArgs e)
        {
            frmEstadisticasOfensivas frmE = new frmEstadisticasOfensivas();
            frmE.Show();
        }
    }
}