using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeatherElectronics
{
    public partial class frmVanzare : Form
    {
        DBConnect dbCon = new DBConnect();
        public frmVanzare()
        {
            InitializeComponent();
        }
        double total = 0.0;
        int n = 0;
        private void frmVanzare_Load(object sender, EventArgs e)
        {
            BindCategorie();
            lblDate.Text = DateTime.Now.ToShortDateString();
            BindFactura();
        }
        private void getListaProduse()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getProduse_DupaCategorie", dbCon.GetCon());
                cmd.Parameters.AddWithValue("@IdCatProdus", cmbCategorie.SelectedValue);
                cmd.CommandType = CommandType.StoredProcedure;
                dbCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2_Produs.DataSource = dt;
                dbCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BindCategorie()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getCategorie", dbCon.GetCon());
                cmd.CommandType = CommandType.StoredProcedure;
                dbCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbCategorie.DataSource = dt;
                cmbCategorie.DisplayMember = "NumeCategorie";
                cmbCategorie.ValueMember = "IDCategorie";
                dbCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getListaProduse();
        }

        private void dataGridView2_Produs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Clear();
                txtId.Text = dataGridView2_Produs.SelectedRows[0].Cells[0].Value.ToString();
                txtNumeProdus.Clear();
                txtNumeProdus.Text = dataGridView2_Produs.SelectedRows[0].Cells[1].Value.ToString();
                txtPret.Clear();
                txtPret.Text = dataGridView2_Produs.SelectedRows[0].Cells[4].Value.ToString();
                txtCantitate.Clear();
                txtCantitate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdaugaComanda_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPret.Text == "" || txtCantitate.Text == "")
                {
                    MessageBox.Show("Introdu o cantitate si valoare valida", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double pret = Convert.ToDouble(txtPret.Text) * Convert.ToInt32(txtCantitate.Text);
                    DataGridViewRow addrow = new DataGridViewRow();
                    addrow.CreateCells(dataGridView1_Comanda);
                    addrow.Cells[0].Value = ++n;
                    addrow.Cells[1].Value = txtNumeProdus.Text;
                    addrow.Cells[2].Value = txtPret.Text;
                    addrow.Cells[3].Value = txtCantitate.Text;
                    addrow.Cells[4].Value = pret;
                    dataGridView1_Comanda.Rows.Add(addrow);
                    total += pret;
                    lblTotal.Text = total.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNrFactura.Text == "")
                {
                    MessageBox.Show("Introdu un numar de factura valid", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("adaugaFactura", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@IdFactura", txtNrFactura.Text);
                    cmd.Parameters.AddWithValue("@IdVanzator", Form1.loginname);
                    cmd.Parameters.AddWithValue("@DataVanzare", lblDate.Text);
                    cmd.Parameters.AddWithValue("@Total", lblTotal.Text);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dbCon.OpenCon();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        BindFactura();
                        if (DialogResult.Yes == MessageBox.Show("Vrei sa printezi factura?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            btnPrintare_Click(null, null);
                        }
                        MessageBox.Show("Factura adaugata", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clrtext();
                    }
                    dbCon.CloseCon();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clrtext()
        {
            txtNrFactura.Clear();
            dataGridView1_Comanda.DataSource = null;
            txtPret.Clear();
            txtId.Clear();
            txtNumeProdus.Clear();
            txtCantitate.Clear();
            lblTotal.Text = "0.0";
        }
        private void BindFactura()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getFactura", dbCon.GetCon());
                cmd.CommandType = CommandType.StoredProcedure;
                dbCon.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dbCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnReimprospatare_Click(object sender, EventArgs e)
        {
            dataGridView1_Comanda.Rows.Clear();
            dataGridView1_Comanda.Refresh();
        }
        Bitmap bitmap;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bitmap = new Bitmap(dataGridView1_Comanda.Width, dataGridView1_Comanda.Height);
            dataGridView1_Comanda.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1_Comanda.Width, dataGridView1_Comanda.Height));
            e.Graphics.DrawString("Factura fiscala", new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            e.Graphics.DrawString("Total " + lblTotal.Text, new Font("Verdana", 18, FontStyle.Bold), Brushes.Black, new Point(500, 800));
            e.Graphics.DrawImage(bitmap, 120, 90);
        }
        private void btnPrintare_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.1;
            printPreviewDialog1.ShowDialog();
        }

        
    }
}
