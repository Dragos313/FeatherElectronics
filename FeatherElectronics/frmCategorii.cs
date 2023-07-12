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
    public partial class frmCategorii : Form
    {
        DBConnect dbCon = new DBConnect();
        public frmCategorii()
        {
            InitializeComponent();
        }

        private void frmCategorii_Load(object sender, EventArgs e)
        {
            btnActualizare.Visible = false;
            btnStergere.Visible = false;
            lblCatID.Visible = false;
            BindCategory();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            if (txtCatDen.Text == String.Empty)
            {
                MessageBox.Show("Introdu un nume pentru categori", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCatDen.Focus();
                return;
            }
            else if (rtbCatDesc.Text == String.Empty)
            {
                MessageBox.Show("Introdu o descriere pentru categorie", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbCatDesc.Focus();
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select NumeCategorie from tblCategorie where NumeCategorie=@NumeCategorie", dbCon.GetCon());
                cmd.Parameters.AddWithValue("@NumeCategorie", txtCatDen.Text);
                dbCon.OpenCon();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Nume categorie exista deja", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClear();
                }
                else
                {
                    cmd = new SqlCommand("adaugareCategorie", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@NumeCategorie", txtCatDen.Text);
                    cmd.Parameters.AddWithValue("@DescCategorie", rtbCatDesc.Text);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Categoria adaugata", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClear();
                        BindCategory();
                    }
                }
                dbCon.CloseCon();
            }
        }
        private void txtClear()
        {
            txtCatDen.Clear(); rtbCatDesc.Clear();
        }

        private void BindCategory()
        {
            SqlCommand cmd = new SqlCommand("select  IDCategorie, NumeCategorie, DescCategorie from tblCategorie", dbCon.GetCon());
            dbCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dbCon.CloseCon();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCatID.Text == String.Empty)
                {
                    MessageBox.Show("Selecteaza id-ul categoriei", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCatDen.Focus();
                    return;
                }
                if (txtCatDen.Text == String.Empty)
                {
                    MessageBox.Show("Introdu un nume", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCatDen.Focus();
                    return;
                }
                else if (rtbCatDesc.Text == String.Empty)
                {
                    MessageBox.Show("Introdu o descriere", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtbCatDesc.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select NumeCategorie from tblCategorie where NumeCategorie=@NumeCategorie", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@NumeCategorie", txtCatDen.Text);
                    dbCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Nume categorie exista deja in baza e date", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClear();
                    }
                    else
                    {
                        cmd = new SqlCommand("actalizareCategorie", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@IDCategorie", Convert.ToInt32(lblCatID.Text));
                        cmd.Parameters.AddWithValue("@NumeCategorie", txtCatDen.Text);
                        cmd.Parameters.AddWithValue("@DescCategorie", rtbCatDesc.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        dbCon.CloseCon();
                        if (i > 0)
                        {
                            MessageBox.Show("Categorie actualizata", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindCategory();
                            btnActualizare.Visible = false;
                            btnStergere.Visible = false;
                            btnAdCat.Visible = true;
                            lblCatID.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Actaulizare esuata", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClear();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCatID.Text == String.Empty)
                {
                    MessageBox.Show("Selecteaza id-ul categoriei", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (lblCatID.Text != String.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show("Esti sigur ca vrei sa stergi categoria?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("stergeCategorie", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@IDCategorie", Convert.ToInt32(lblCatID.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        dbCon.OpenCon();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Categorie stearsa", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindCategory();
                            btnActualizare.Visible = false;
                            btnStergere.Visible = false;
                            btnAdCat.Visible = true;
                            lblCatID.Visible = false;
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnActualizare.Visible = true;
            btnStergere.Visible = true;
            lblCatID.Visible = true;
            btnAdCat.Visible = false;

            lblCatID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtCatDen.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            rtbCatDesc.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
