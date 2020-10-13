using System;
using System.Windows.Forms;

namespace Prog7312_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f2 = new Form3();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Identifying_areas f2 = new Identifying_areas();
            f2.ShowDialog();
        }
    }
}
