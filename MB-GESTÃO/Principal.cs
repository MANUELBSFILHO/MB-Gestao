using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MB_GESTÃO
{
    public partial class Frprincipal : Form
    {
        public Frprincipal()
        {
            InitializeComponent();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clieteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frcliente frcliente = new Frcliente();
            frcliente.Show();
        }
    }
}
