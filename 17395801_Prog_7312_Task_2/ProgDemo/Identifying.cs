using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog7312_Task1
{
    public partial class Identifying : Form
    {
        public Identifying()
        {
            InitializeComponent();
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            Button bt = ((Button)e.Data.GetData(typeof(Button)));
            bt.Parent = (Panel)sender;
            bt.Dock = DockStyle.Fill;
            bt.BringToFront();
        }
        private void label_DragDrop(object sender, DragEventArgs e)
        {
            Label lb = ((Label)e.Data.GetData(typeof(Label)));
            lb.Parent = (Panel)sender;
            lb.Dock = DockStyle.Fill;
            lb.BringToFront();
        }

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            Button bt = (sender as Button);
            bt.DoDragDrop(sender, DragDropEffects.Move);
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            Label lb = (sender as Label);
            lb.DoDragDrop(sender, DragDropEffects.Move);
        }
    }
}
