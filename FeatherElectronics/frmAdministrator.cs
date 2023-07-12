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
    public partial class frmAdministrator : Form
    {
        DBConnect dbCon = new DBConnect();
        public frmAdministrator()
        {
            InitializeComponent();
        }

        private void frmAdministrator_Load(object sender, EventArgs e)
        {
            lblAdminID.Visible = false;
            btnActualizeaza.Visible = false;
            btnSterge.Visible = false;
            btnAdauga.Visible = true;
            txtNumeAdmin.Focus();
            BindAdmin();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeAdmin.Text == String.Empty || txtIDAdmin.Text == String.Empty || txtParola.Text == String.Empty)
                {
                    MessageBox.Show("Toate campurile trebuie sa fie completate", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clrbtn();
                }
                else
                {
                    //check duplicate record
                    SqlCommand cmd = new SqlCommand("select AdminID from tblAdmin where AdminID=@ID", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@ID", txtIDAdmin.Text);
                    dbCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Id-ul de admin este deja inregistrat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clrbtn();
                    }
                    else
                    {
                        cmd = new SqlCommand("adaugaAdmin", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@AdminID", txtIDAdmin.Text);
                        cmd.Parameters.AddWithValue("@Password", txtParola.Text);
                        cmd.Parameters.AddWithValue("@FullName", txtNumeAdmin.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Admin adaugat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clrbtn();
                            BindAdmin();
                        }
                    }
                    dbCon.CloseCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BindAdmin()
        {

            SqlCommand cmd = new SqlCommand("select * from tblAdmin", dbCon.GetCon());
            dbCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dbCon.CloseCon();
        }
        private void clrbtn()
        {
            txtIDAdmin.Clear();
            txtNumeAdmin.Clear();
            txtParola.Clear();
            txtNumeAdmin.Focus();
        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeAdmin.Text == String.Empty || txtIDAdmin.Text == String.Empty || txtParola.Text == String.Empty || lblAdminID.Text == String.Empty)
                {
                    MessageBox.Show("Toate campurile trebuie sa fie completate", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clrbtn();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("actualizeazaAdmin", dbCon.GetCon());
                    dbCon.OpenCon();
                    cmd.Parameters.AddWithValue("@AdminID", lblAdminID.Text);
                    cmd.Parameters.AddWithValue("@Password", txtParola.Text);
                    cmd.Parameters.AddWithValue("@FullName", txtNumeAdmin.Text);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Admin actualizat cu succes...", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clrbtn();
                        BindAdmin();
                    }
                    dbCon.CloseCon();
                }
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
                if (lblAdminID.Text == String.Empty)
                {
                    MessageBox.Show("Selecteaza cel putin un admin", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Esti sigur ca vrei sa stergi?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("stergeAdmin", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@AdminID", lblAdminID.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        dbCon.OpenCon();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Vanzator sters", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clrbtn();
                            BindAdmin();
                            btnActualizeaza.Visible = false;
                            btnSterge.Visible = false;
                            btnAdauga.Visible = true;
                            lblAdminID.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Stergerea nu a putut fi efectuata", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clrbtn();
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
            try
            {
                btnActualizeaza.Visible = true;
                btnSterge.Visible = true;
                lblAdminID.Visible = true;
                btnAdauga.Visible = false;

                lblAdminID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtIDAdmin.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtParola.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtNumeAdmin.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
