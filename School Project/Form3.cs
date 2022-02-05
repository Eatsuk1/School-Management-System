using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Form3 : Form
    {
        private SqlConnection cn;
        private SqlDataReader dr, dr1;
        private ClassDB db = new ClassDB();
        private string _title = "Hệ thống quản lý";
        private Mngclass s;

        public Form3(Mngclass s)
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
            this.s = s;
        }

        public void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("select * from R1", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(false, dr["maGiaoVien"].ToString(), dr["tenGiaoVien"].ToString(), dr["Chuyenmon"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            s.LoadRecordsTch();
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
                            var a = new SqlCommand("select maGiaoVien, tenGiaoVien from R1 where maGiaoVien = '" + row.Cells[1].Value.ToString() + "'", cn);
                            dr = a.ExecuteReader(); dr.Read();
                            var b = new SqlCommand("insert into R9(maGiaoVien, tenLop, Namhoc, tenGiaoVien) values(@maGiaoVien, @tenLop, @Namhoc, @tenGiaoVien)", cn);
                            b.Parameters.AddWithValue("maGiaoVien", dr["maGiaoVien"].ToString());
                            b.Parameters.AddWithValue("tenLop", s.classbox.SelectedItem.ToString());
                            b.Parameters.AddWithValue("Namhoc", s.schoolyearbox.SelectedItem.ToString());
                            b.Parameters.AddWithValue("tenGiaoVien", dr["tenGiaoVien"].ToString());
                            b.ExecuteNonQuery();
                            dr.Close();

                    }
                }
                if (MessageBox.Show("Thêm giáo viên đã chọn?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
    }
}