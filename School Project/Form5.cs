using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Data;

namespace School_Project
{
    public partial class Form5 : Form
    {
        private SqlConnection cn;
        private SqlDataReader dr;
        private SqlDataAdapter da;
        private ClassDB db = new ClassDB();
        private string _title = "Hệ thống quản lý";
        private MngMarks s;
        private string none = "";

        public Form5(MngMarks s)
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
            this.s = s;
        }

        //public void LoadRecords()
        //{
        //    //dataGridView1.Rows.Clear();
        //    //cn.Open();
        //    //var a = new SqlCommand("select tenMonHoc, Diemso from R4 where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "' and tenLop = '" + s.comboBox1.Text + "'", cn);
        //    //dr = a.ExecuteReader();
        //    //while (dr.Read())
        //    //{
        //    //    dataGridView1.Rows.Add(dr["tenMonHoc"].ToString(), dr["Diemso"].ToString());
        //    //}
        //    //dr.Close();
        //    //cn.Close();
        //    cn.Open();
        //    var a = new SqlCommand("select tenMonHoc, Diemso from R4 where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "' and tenLop = '" + s.comboBox1.Text + "'", cn);
        //    DataTable dt = new DataTable();
        //    da = new SqlDataAdapter(a);
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    cn.Close();
        //}

        public void LoadRecords2()
        {
            //dataGridView1.Rows.Clear();
            //List<string> monhoc = new List<string>();
            //cn.Open();
            //var a = new SqlCommand("select * from R16", cn);
            //dr = a.ExecuteReader();
            //while (dr.Read())
            //{
            //    monhoc.Add(dr["tenMonHoc"].ToString());
            //}
            //dr.Close(); cn.Close();

            //List<string> monmoi = new List<string>();
            //cn.Open();
            //var b = new SqlCommand("select * from R4 where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "'",cn);
            //dr = b.ExecuteReader();
            //for(int i = 0; i < monhoc.Count; i++)
            //{
            //    int k = 0;
            //    while(dr.Read())
            //    {
            //        if(dr["tenMonHoc"].ToString() == monhoc[i])
            //        {
            //            k++;
            //        }
            //    }
            //    if(k == 0)
            //    {
            //        monmoi.Add(monhoc[i]);
            //    }
            //}
            //if(monmoi.Count > 0)
            //{
            //    foreach (string monmo in monmoi)
            //    {
            //        var c = new SqlCommand("insert into R4(maHocSinh, tenMonHoc, Diemso, maNangLuc, maPhamchat, Kyhoc, Namhoc, tenLop) values(@maHocSinh, @tenMonHoc, @Diemso, @maNangLuc, @maPhamchat, @Kyhoc, @Namhoc, @tenLop)", cn);
            //        c.Parameters.AddWithValue("maHocSinh", s.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //        c.Parameters.AddWithValue("tenMonHoc", monmo);
            //        c.Parameters.AddWithValue("Diemso", none);
            //        c.Parameters.AddWithValue("maNangLuc", none);
            //        c.Parameters.AddWithValue("maPhamchat", none);
            //        c.Parameters.AddWithValue("Kyhoc", s.comboBox2.Text);
            //        c.Parameters.AddWithValue("Namhoc", s.comboBox3.Text);
            //        c.Parameters.AddWithValue("tenLop", s.comboBox1.Text);
            //        c.ExecuteNonQuery();

            //    }

            //}
            //cn.Close();
            dataGridView1.Rows.Clear();
            cn.Open();
            var a = new SqlCommand("select * from R16", cn);
            dr = a.ExecuteReader();
            while(dr.Read())
            {
                dataGridView1.Rows.Add(dr["tenMonHoc"].ToString(), "");
            }
            dr.Close();
            cn.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    var c = new SqlCommand("insert into R4(maHocSinh, tenMonHoc, Diemso, maNangLuc, maPhamchat, Kyhoc, Namhoc, tenLop) values(@maHocSinh, @tenMonHoc, @Diemso, @maNangLuc, @maPhamchat, @Kyhoc, @Namhoc, @tenLop)", cn);
                    c.Parameters.AddWithValue("maHocSinh", s.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    c.Parameters.AddWithValue("Diemso", row.Cells[1].Value.ToString());
                    c.Parameters.AddWithValue("tenMonHoc", row.Cells[0].Value.ToString());
                    c.Parameters.AddWithValue("maNangLuc", none);
                    c.Parameters.AddWithValue("maPhamchat", none);
                    c.Parameters.AddWithValue("Kyhoc", s.comboBox2.Text);
                    c.Parameters.AddWithValue("Namhoc", s.comboBox3.Text);
                    c.Parameters.AddWithValue("tenLop", s.comboBox1.Text);
                    c.ExecuteNonQuery();
                }
                cn.Close();
                MessageBox.Show("Lưu kết quả học tập thành công", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
