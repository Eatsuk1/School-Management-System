using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Form4 : Form
    {
        private SqlConnection cn;
        private SqlDataReader dr, dr1;
        private ClassDB db = new ClassDB();
        private string _title = "Hệ thống quản lý";
        private Mngclass s;

        public Form4(Mngclass s)
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
            this.s = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        var a = new SqlCommand("select maHocSinh, tenHocSinh from R2 where maHocSinh = '" + row.Cells[1].Value.ToString() + "'", cn);
                        dr = a.ExecuteReader(); dr.Read();
                        var b = new SqlCommand("insert into R10(maHocSinh, tenLop, Namhoc, tenHocSinh) values(@maHocSinh, @tenLop, @Namhoc, @tenHocSinh)", cn);
                        b.Parameters.AddWithValue("maHocSinh", dr["maHocSinh"].ToString());
                        b.Parameters.AddWithValue("tenLop", s.classbox.SelectedItem.ToString());
                        b.Parameters.AddWithValue("Namhoc", s.schoolyearbox.SelectedItem.ToString());
                        b.Parameters.AddWithValue("tenHocSinh", dr["tenHocSinh"].ToString());
                        b.ExecuteNonQuery();
                        dr.Close();
                    }
                }
                if (MessageBox.Show("Thêm học sinh đã chọn?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Lưu thông tin thành công", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            s.LoadRecordStd();
            cn.Open();
            var a = new SqlCommand("update R3 set Siso = @Siso where tenLop = '" + s.classbox.SelectedItem.ToString() + "' and Namhoc = '" + s.schoolyearbox.SelectedItem.ToString() + "'", cn);
            a.Parameters.AddWithValue("Siso", s.Siso());
            a.ExecuteNonQuery();
            cn.Close();
            s.Loadclass();
        }

        public void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("select * from R2", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(false, dr["maHocSinh"].ToString(), dr["tenHocSinh"].ToString(), dr["Gioitinh"].ToString(), dr["Tuoi"].ToString());
            }
            dr.Close();
            cn.Close();
        }
    }
}