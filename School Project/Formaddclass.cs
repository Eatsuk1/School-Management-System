using System;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Formaddclass : Form
    {
        public Formaddclass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 _s = new Form2();
            _s.ShowDialog();
        }
    }
}