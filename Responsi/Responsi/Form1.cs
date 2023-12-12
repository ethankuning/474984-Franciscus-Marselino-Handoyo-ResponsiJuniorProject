using Npgsql;
using System.Data;

namespace Responsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost,Port=5432,Username=postgres,Password=informatika,Database=responsiE";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                dgvKaryawan.DataSource = null;
                sql = "SELECT * FROM karyawan INNER JOIN departemen ON departemen.id_dep = karyawan.id_dep";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvKaryawan.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Loading FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"INSERT INTO karyawan (nama, id_dep) VALUES (:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDep.SelectedIndex);
                cmd.ExecuteScalar();

                MessageBox.Show("Success", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                tbNama.Text = null;
                cbDep.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Select Row", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();
                sql = @"UPDATE karyawan SET nama=:_nama, id_dep=_id_dep WHERE id=_id";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", cbDep.SelectedIndex);
                cmd.Parameters.AddWithValue("_id", r.Cells["id_dep"].Value);
                cmd.ExecuteScalar();

                MessageBox.Show("Success", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                tbNama.Text = null;
                cbDep.SelectedIndex = 0;
                r = null;
            }
            catch (Exception ex )
            {
                MessageBox.Show("Error:" + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Select Row", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Confirm delete data "+r.Cells["nama"].Value.ToString()+"?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = @"DELETE FROM karyawan WHERE id=_id";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", r.Cells["id_dep"].Value);
                    cmd.ExecuteScalar();

                    MessageBox.Show("Success", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    tbNama.Text = null;
                    cbDep.SelectedIndex = 0;
                    r = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvKaryawan.Rows[e.RowIndex];
                tbNama.Text = r.Cells["nama"].Value.ToString();
                cbDep.Text = r.Cells["nama_dep"].Value.ToString();
            }
        }
    }
}