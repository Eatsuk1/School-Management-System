using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Form5 : Form
    {
        private SqlConnection cn;
        private SqlDataReader dr;
        private ClassDB db = new ClassDB();
        private string _title = "Hệ thống quản lý";
        private MngMarks s;

        public Form5()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }

        public void LoadRecords()
        {
            cn.Open();
            var a = new SqlCommand("select tenMonHoc, Diemso from R4 where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "'", cn);
            dr = a.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["tenMonHoc"].ToString(), dr["Diemso"].ToString());
            }
            dr.Close();
        }
    }
}
