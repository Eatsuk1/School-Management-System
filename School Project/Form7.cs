using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Form7 : Form
    {
        private SqlConnection cn;
        private SqlDataReader dr;
        private ClassDB db = new ClassDB();
        private string _title = "Hệ thống quản lý";
        private MngMarks s;
        public Form7(MngMarks s)
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
            this.s = s;
        }

        public void LoadRecords()
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                dataGridView3.Rows.Clear();
                cn.Open();
                var a = new SqlCommand("select tenMonHoc, Diemso from R4 where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "' and tenLop = '" + s.comboBox1.Text + "'", cn);
                dr = a.ExecuteReader();
                while (dr.Read())
                {
                    if (Convert.ToInt32(dr["Diemso"].ToString()) >= 8)
                    {
                        dataGridView1.Rows.Add(dr["tenMonHoc"].ToString(), "Hoàn thành tốt");
                    }
                    else if (Convert.ToInt32(dr["Diemso"].ToString()) >= 5 && Convert.ToInt32(dr["Diemso"].ToString()) < 8)
                    {
                        dataGridView1.Rows.Add(dr["tenMonHoc"].ToString(), "Hoàn thành");
                    }
                    else if (Convert.ToInt32(dr["Diemso"].ToString()) < 5)
                    {
                        dataGridView1.Rows.Add(dr["tenMonHoc"].ToString(), "Cần cố gắng");
                    }
                }
                dr.Close();

                var b = new SqlCommand("select TuphucvuTuquan, Hoptac, Tuhocvagiaiquyetvande from R4 where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "' and tenLop = '" + s.comboBox1.Text + "'", cn);
                dr = b.ExecuteReader();
                dr.Read();
                dataGridView2.Rows.Add("Tự phục vụ, tự quản", dr["TuphucvuTuquan"].ToString());
                dataGridView2.Rows.Add("Hợp tác", dr["Hoptac"].ToString());
                dataGridView2.Rows.Add("Tự học và giải quyết vấn đề", dr["Tuhocvagiaiquyetvande"].ToString());
                dr.Close();

                var c = new SqlCommand("select ChamhocChamlam, TutinTrachnhiem, TrungthucKyluat, DoanketYeuthuong from R4 where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "' and tenLop = '" + s.comboBox1.Text + "'", cn);
                dr = c.ExecuteReader();
                dr.Read();
                dataGridView3.Rows.Add("Chăm học, chăm làm", dr["ChamhocChamlam"].ToString());
                dataGridView3.Rows.Add("Tự tin, trách nhiệm", dr["TutinTrachnhiem"].ToString());
                dataGridView3.Rows.Add("Trung thực, kỷ luật", dr["TrungthucKyluat"].ToString());
                dataGridView3.Rows.Add("Đoàn kết, yêu thương", dr["DoanketYeuthuong"].ToString());
                dr.Close();

                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
