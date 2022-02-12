using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Project
{
    public partial class Form6 : Form
    {
        private SqlConnection cn;
        private SqlDataReader dr;
        private SqlDataAdapter da;
        private ClassDB db = new ClassDB();
        private string _title = "Hệ thống quản lý";
        private MngMarks s;
        private string none = "";
        public Form6(MngMarks s)
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
            var a = new SqlCommand("select * from R4 where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "' and tenLop = '" + s.comboBox1.Text + "'", cn);
            dr = a.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["tenMonHoc"].ToString(), dr["Diemso"].ToString());
                comboBox1.Text = dr["TuphucvuTuquan"].ToString();
                comboBox2.Text = dr["Hoptac"].ToString();
                comboBox3.Text = dr["Tuhocvagiaiquyetvande"].ToString();
                comboBox4.Text = dr["ChamhocChamlam"].ToString();
                comboBox5.Text = dr["TutinTrachnhiem"].ToString();
                comboBox6.Text = dr["TrungthucKyluat"].ToString();
                comboBox7.Text = dr["DoanketYeuthuong"].ToString();

            }
            dr.Close();
            cn.Close();
            //cn.Open();
            //var a = new SqlCommand("select tenMonHoc, Diemso from R4 where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "' and tenLop = '" + s.comboBox1.Text + "'", cn);
            //DataTable dt = new DataTable();
            //da = new SqlDataAdapter(a);
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                //cn.Open();
                //var a = new SqlCommand("select tenMonHoc, Diemso from R4 where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "' and tenLop = '" + s.comboBox1.Text + "'", cn);
                //DataSet dt = new DataSet();
                //da = new SqlDataAdapter(a);
                //da.Fill(dt);
                //da.UpdateCommand = new SqlCommand("update R4 set Diemso = '" + textBox1.Text + "' where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and tenMonHoc = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "' and tenLop = '" + s.comboBox1.Text + "' and maNangluc = '" + none + "' and maPhamchat = '" + none + "'", cn);

                //da.Update(dt);


                //cn.Close();
                
                cn.Open();
                var a = new SqlCommand("update R4 set Diemso = @Diemso where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and tenMonHoc = '" +  dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "' and tenLop = '" + s.comboBox1.Text + "'", cn);
                a.Parameters.AddWithValue("@Diemso", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                a.ExecuteNonQuery();
                var b = new SqlCommand("update R4 set TuphucvuTuquan = @TuphucvuTuquan, Hoptac = @Hoptac, Tuhocvagiaiquyetvande = @Tuhocvagiaiquyetvande where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and tenMonHoc = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "' and tenLop = '" + s.comboBox1.Text + "'", cn);
                b.Parameters.AddWithValue("@TuphucvuTuquan", comboBox1.SelectedItem.ToString());
                b.Parameters.AddWithValue("@Hoptac", comboBox2.SelectedItem.ToString());
                b.Parameters.AddWithValue("@Tuhocvagiaiquyetvande", comboBox3.SelectedItem.ToString());
                b.ExecuteNonQuery();
                var c = new SqlCommand("update R4 set ChamhocChamlam = @ChamhocChamlam, TutinTrachnhiem = @TutinTrachnhiem, TrungthucKyluat = @TrungthucKyluat, DoanketYeuthuong = @DoanketYeuthuong where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and tenMonHoc = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "' and tenLop = '" + s.comboBox1.Text + "'", cn);
                c.Parameters.AddWithValue("@ChamhocChamlam", comboBox4.SelectedItem.ToString());
                c.Parameters.AddWithValue("@TutinTrachnhiem", comboBox5.SelectedItem.ToString());
                c.Parameters.AddWithValue("@TrungthucKyluat", comboBox6.SelectedItem.ToString());
                c.Parameters.AddWithValue("@DoanketYeuthuong", comboBox7.SelectedItem.ToString());
                c.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Đã cập nhật kết quả học tập", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecords();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
