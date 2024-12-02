using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace _496427_Luthfi_ResponsiJuniorProject
{
    public partial class MainPage : Form
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private string sql;
        public DataTable dt;
        private DataGridViewRow r;
        private Karyawan selectedKaryawan;

        public MainPage()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            MainPage_Load(null, null);
        }

        private string connectionString()
        {
            return "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi";
        }

        public void MainPage_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString());
            try
            {
                conn.Open();
                MessageBox.Show("Berhasil Terkoneksi");
                conn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private int getDepartmentId(string departmentName)
        {
            switch (departmentName)
            {
                case "HR": return 1;
                case "FIN": return 2;
                case "ENG": return 3;
                case "DEV": return 4;
                case "PM": return 5;
                default: return -1;
            }
        }

        private int getJabatanId(string NamaJabatan)
        {
            switch (NamaJabatan)
            {
                case "MGR": return 1;
                case "ASS": return 2;
                case "EXP": return 3;
                case "SEN": return 4;
                case "JUN": return 5;
                case "INT": return 6;
                default: return -1;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString());

            try
            {
                conn.Open();
                sql = "SELECT \r\n    k.id_karyawan, \r\n    k.nama AS nama_karyawan, \r\n    d.nama_departemen AS nama_departemen,\r\n    j.nama_jabatan AS nama_jabatan,\r\n    j.salary AS gaji_karyawan\r\nFROM \r\n    public.karyawan k\r\nJOIN \r\n    public.departemen d ON k.id_dep = d.id_dep\r\nJOIN \r\n    public.jabatan j ON k.id_jabatan = j.id_jabatan;\r\n";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgData.Rows[e.RowIndex];

                selectedKaryawan = new Karyawan(
                    r.Cells["nama_karyawan"].Value.ToString(),
                    r.Cells["id_karyawan"].Value.ToString(),
                    getDepartmentId(r.Cells["nama_departemen"].Value.ToString()),
                    r.Cells["nama_departemen"].Value.ToString(),
                    r.Cells["nama_jabatan"].Value.ToString(),
                    getJabatanId(r.Cells["nama_jabatan"].Value.ToString())
                );

                tbNama.Text = selectedKaryawan._nama;
                cbDep.Text = selectedKaryawan._nama_departemen;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connectionString());

            int idDep = getDepartmentId(cbDep.Text);

            int idJabatan = getJabatanId(cbJabatan.Text);

            try
            {
                conn.Open();
                if (idDep != -1)
                {
                    selectedKaryawan = new Karyawan(
                        tbNama.Text,
                        null,
                        idDep,
                        cbDep.Text,
                        null,
                        idJabatan
                    );

                    sql = "SELECT insert_data(@nama, @id_dep, @id_jabatan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nama", selectedKaryawan._nama);
                    cmd.Parameters.AddWithValue("@id_dep", selectedKaryawan._id_departemen);
                    cmd.Parameters.AddWithValue("@id_jabatan", selectedKaryawan._id_departemen);
                }
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Berhasil diinput", "Terima kasih", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLoad.PerformClick();
                    tbNama.Text = cbDep.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Insert Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idDep = getDepartmentId(cbDep.Text);
            int idJabatan = getJabatanId(cbJabatan.Text);

            if (selectedKaryawan == null)
            {
                MessageBox.Show("Mohon pilih baris yang akan diupdate", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Open();
                    // Update the Karyawan object
                    selectedKaryawan._nama = tbNama.Text;
                    selectedKaryawan._id_departemen = idDep;
                    selectedKaryawan._nama_departemen = cbDep.Text;
                    selectedKaryawan._id_jabatan = idJabatan;

                    sql = "select * from update_data(@id_karyawan, @nama, @id_dep, @id_jabatan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("id_karyawan", selectedKaryawan._id_karyawan);
                    cmd.Parameters.AddWithValue("nama", selectedKaryawan._nama);
                    cmd.Parameters.AddWithValue("id_dep", selectedKaryawan._id_departemen);
                    cmd.Parameters.AddWithValue("id_jabatan", selectedKaryawan._id_jabatan);

                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data karyawan berhasil diupdate", "Terima kasih", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLoad.PerformClick();
                        tbNama.Text = cbDep.Text = null;
                        selectedKaryawan = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "Update Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedKaryawan == null)
            {
                MessageBox.Show("Mohon pilih baris yang akan dihapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (MessageBox.Show("Apakah benar anda ingin menghapus data " + selectedKaryawan._nama + " ?",
                    "Hapus Data Terkonfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = "SELECT menghapus_data(@id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id_karyawan", selectedKaryawan._id_karyawan);

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result == 1)
                    {
                        MessageBox.Show("Data karyawan berhasil dihapus", "Terima kasih", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbNama.Text = cbDep.Text = null;
                        selectedKaryawan = null;
                        btnLoad.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message, "Delete Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}
