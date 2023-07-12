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
    public partial class frmVanzator : Form
    {
        DBConnect dbCon = new DBConnect();
        public frmVanzator()
        {
            InitializeComponent();
        }
        private void frmVanzator_Load(object sender, EventArgs e)
        {
            lblIDVanzator.Visible = false;
            btnActualizeaza.Visible = false;
            btnSterge.Visible = false;
            btnAdauga.Visible = true;
            BindVanzator();
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnActualizeaza.Visible = true;
            btnSterge.Visible = true;
            lblIDVanzator.Visible = true;
            btnAdauga.Visible = false;

            lblIDVanzator.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtNumeVanzator.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtVarsta.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtParola.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblIDVanzator.Text == String.Empty)
                {
                    MessageBox.Show("Selecateaza un vanzator", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (lblIDVanzator.Text != String.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show("Vrei sa stergi acest vanzator?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("stergeVanzator", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@IDVanzator", Convert.ToInt32(lblIDVanzator.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        dbCon.OpenCon();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Vanzator sters", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindVanzator();
                            btnActualizeaza.Visible = false;
                            btnSterge.Visible = false;
                            btnAdauga.Visible = true;
                            lblIDVanzator.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Stergerea nu s-a finalizat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblIDVanzator.Text == String.Empty)
                {
                    MessageBox.Show("Selecteaza un vanzator", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (txtNumeVanzator.Text == String.Empty)
                {
                    MessageBox.Show("Introdu un nume", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumeVanzator.Focus();
                    return;
                }
                else if (txtParola.Text == String.Empty)
                {
                    MessageBox.Show("Introdu o parola", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtParola.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select NumeVanzator from tblVanzator where NumeVanzator=@NumeVanzator", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@NumeVanzator", txtNumeVanzator.Text);

                    dbCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Vanzatorul exista deja in baza de date", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClear();
                    }
                    else
                    {
                        cmd = new SqlCommand("actualizareVanzator", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@IDVanzator", Convert.ToInt32(lblIDVanzator.Text));
                        cmd.Parameters.AddWithValue("@NumeVanzator", txtNumeVanzator.Text);
                        cmd.Parameters.AddWithValue("@VarstaVanzator", Convert.ToInt32(txtVarsta.Text));
                        cmd.Parameters.AddWithValue("@TelefonVanzator", txtTelefon.Text);
                        cmd.Parameters.AddWithValue("@ParolaVanzator", txtParola.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        dbCon.CloseCon();
                        if (i > 0)
                        {
                            MessageBox.Show("Vanzator actualizat", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindVanzator();
                            btnActualizeaza.Visible = false;
                            btnSterge.Visible = false;
                            btnAdauga.Visible = true;
                            lblIDVanzator.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Actualizare esuata", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (txtNumeVanzator.Text == String.Empty)
            {
                MessageBox.Show("Introdu numele vanzatorului", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeVanzator.Focus();
                return;
            }
            else if (txtParola.Text == String.Empty)
            {
                MessageBox.Show("Introdu parola", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtParola.Focus();
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select NumeVanzator from tblVanzator where NumeVanzator=@NumeVanzator", dbCon.GetCon());
                cmd.Parameters.AddWithValue("@NumeVanzator", txtNumeVanzator.Text);
                dbCon.OpenCon();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Numele vanzatorului exista deja in baza de date", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClear();
                }
                else
                {
                    cmd = new SqlCommand("adaugareVanzator", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@NumeVanzator", txtNumeVanzator.Text);
                    cmd.Parameters.AddWithValue("@VarstaVanzator", Convert.ToInt32(txtVarsta.Text));
                    cmd.Parameters.AddWithValue("@TelefonVanzator", txtTelefon.Text);
                    cmd.Parameters.AddWithValue("@ParolaVanzator", txtParola.Text);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Vanzatorul exista deja in baza de date", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClear();
                        BindVanzator();
                    }
                }
                dbCon.CloseCon();
            }
        }
        private void txtClear()
        {
            txtNumeVanzator.Clear();
            txtVarsta.Clear();
            txtParola.Clear();
            txtTelefon.Clear();
        }
        private void BindVanzator()
        {
            SqlCommand cmd = new SqlCommand("select * from tblVanzator", dbCon.GetCon());
            dbCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dbCon.CloseCon();
        }
    }
}
