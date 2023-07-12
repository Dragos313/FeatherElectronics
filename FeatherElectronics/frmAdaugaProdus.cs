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
    public partial class frmAdaugaProdus : Form
    {
        DBConnect dbCon = new DBConnect();
        public frmAdaugaProdus()
        {
            InitializeComponent();
        }

        private void frmAdaugaProdus_Load(object sender, EventArgs e)
        {
            BindCategorie();
            BindProduse();
            lblIdProd.Visible = false;
            btnActualizeaza.Visible = false;
            btnSterge.Visible = false;
            btnAdauga.Visible = true;
            CautaDupaCategorie();
        }

        private void BindCategorie()
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
        private void CautaDupaCategorie()
        {
            SqlCommand cmd = new SqlCommand("getCategorie", dbCon.GetCon());
            cmd.CommandType = CommandType.StoredProcedure;
            dbCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCauta.DataSource = dt;
            cmbCauta.DisplayMember = "NumeCategorie";
            cmbCauta.ValueMember = "IDCategorie";
            dbCon.CloseCon();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeProdus.Text == String.Empty)
                {
                    MessageBox.Show("Introdu numele produsului", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumeProdus.Focus();
                    return;
                }
                else if (Convert.ToInt32(txtPret.Text) < 0 || txtPret.Text == String.Empty)
                {
                    MessageBox.Show("Introdu pretul produsului", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPret.Focus();
                    return;
                }
                else if (txtCantitate.Text == String.Empty || Convert.ToInt32(txtCantitate.Text) < 0)
                {
                    MessageBox.Show("Introdu cantitatea produsului", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCantitate.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("verificaDublareProdus", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@NumeProdus", txtNumeProdus.Text);
                    cmd.Parameters.AddWithValue("@IdCatProdus", cmbCategorie.SelectedValue);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dbCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Numele produsilui exista deja in baza de date", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClear();
                    }
                    else
                    {
                        cmd = new SqlCommand("adaugareProdus", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@NumeProdus", txtNumeProdus.Text);
                        cmd.Parameters.AddWithValue("@IdCatProdus", cmbCategorie.SelectedValue);
                        cmd.Parameters.AddWithValue("@PretProdus", Convert.ToDecimal(txtPret.Text));
                        cmd.Parameters.AddWithValue("@CantitateProdus", Convert.ToInt32(txtCantitate.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Produs adaugat", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindProduse();
                        }
                    }
                    dbCon.CloseCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindProduse()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getToateProdusele", dbCon.GetCon());
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

        private void txtClear()
        {
            txtNumeProdus.Clear();
            txtPret.Clear();
            txtCantitate.Clear();
        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblIdProd.Text == "" && txtNumeProdus.Text == String.Empty)
                {
                    MessageBox.Show("Introdu numele produsului", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumeProdus.Focus();
                    return;
                }
                else if (txtPret.Text == String.Empty && Convert.ToInt32(txtPret.Text) >= 0)
                {
                    MessageBox.Show("Introdu pretul produsului", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPret.Focus();
                    return;
                }
                else if (txtCantitate.Text == String.Empty && Convert.ToInt32(txtCantitate.Text) >= 0)
                {
                    MessageBox.Show("Introdu catitatea produsului", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCantitate.Focus();
                    return;
                }
                else
                {

                    SqlCommand cmd = new SqlCommand("ActualizareProdus", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@NumeProdus", txtNumeProdus.Text);
                    cmd.Parameters.AddWithValue("@IdCatProdus", cmbCategorie.SelectedValue);
                    cmd.Parameters.AddWithValue("@PretProdus", Convert.ToDecimal(txtPret.Text));
                    cmd.Parameters.AddWithValue("@CantitateProdus", Convert.ToInt32(txtCantitate.Text));
                    cmd.Parameters.AddWithValue("@IdProdus", Convert.ToInt32(lblIdProd.Text));
                    cmd.CommandType = CommandType.StoredProcedure;
                    dbCon.OpenCon();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Produs actualizat", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClear();
                        BindProduse();
                        lblIdProd.Visible = false;
                        btnAdauga.Visible = true;
                        btnActualizeaza.Visible = false;
                        btnSterge.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Actualizare esuata", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dbCon.CloseCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                btnActualizeaza.Visible = true;
                btnSterge.Visible = true;
                lblIdProd.Visible = true;
                btnAdauga.Visible = false;

                lblIdProd.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtNumeProdus.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                cmbCategorie.SelectedValue = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtPret.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtCantitate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblIdProd.Text == String.Empty)
                {
                    MessageBox.Show("Selecteaza un produs", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (lblIdProd.Text != String.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show("Esti sigur ca vrei sa stergi acest produs?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("stergeProdus", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@IdProdus", Convert.ToInt32(lblIdProd.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        dbCon.OpenCon();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Produs sters", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindProduse();
                            btnActualizeaza.Visible = false;
                            btnSterge.Visible = false;
                            btnAdauga.Visible = true;
                            lblIdProd.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Stergere esuata", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClear();
                        }
                        dbCon.CloseCon();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RezultateProduse()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getProduse_DupaCategorie", dbCon.GetCon());
                cmd.Parameters.AddWithValue("@IdCatProdus", cmbCauta.SelectedValue);
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

        private void button2_Click(object sender, EventArgs e)
        {
            RezultateProduse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindProduse();
        }
    }
}
