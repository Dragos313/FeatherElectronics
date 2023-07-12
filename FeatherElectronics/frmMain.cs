using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeatherElectronics
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Form1.loginname != null)
            {
                toolStripStatusLabel2.Text = Form1.loginname;
            }
            if (Form1.logintype != null && Form1.logintype == "Vanzator")
            {
                categoriiToolStripMenuItem.Enabled = false;
                categoriiToolStripMenuItem.ForeColor = Color.Red;
                produsToolStripMenuItem.Enabled = false;
                produsToolStripMenuItem.ForeColor = Color.Red;
                adaugaUtilizatorToolStripMenuItem.Enabled = false;
                adaugaUtilizatorToolStripMenuItem.ForeColor = Color.Red;
            }
        }

        private void categoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorii fcat = new frmCategorii();
            fcat.Show();
        }

        private void produsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void adaugaProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdaugaProdus ap = new frmAdaugaProdus();
            ap.ShowDialog();
        }

        private void vanzareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVanzare fv = new frmVanzare();
            fv.ShowDialog();
        }

        private void RaportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void adaugaUtilizatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void adiministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrator fa = new frmAdministrator();
            fa.Show();
        }

        private void vanzatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVanzator vz = new frmVanzator();
            vz.ShowDialog();
        }

        private void DespreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDespre fd = new frmDespre();
            fd.Show();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Esti sigur ca vrei sa inchizi aceasta aplicatie?", "Inchide", MessageBoxButtons.YesNo, MessageBoxIcon.Stop))
            {
                Application.Exit();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Esti sigur ca vrei sa inchizi aceasta aplicatie?", "Inchide", MessageBoxButtons.YesNo, MessageBoxIcon.Stop))
            {
                Application.Exit();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
