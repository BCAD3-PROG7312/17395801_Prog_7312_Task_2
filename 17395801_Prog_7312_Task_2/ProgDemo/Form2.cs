using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Prog7312_Task1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear the list box there is no duplicate
            listBox1.Items.Clear();

            //call the generate method to create the random call numbers in the list box
            Generate();

            /*listBox1.Items.Clear();
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(rnd.Next(1, 100));
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        void Generate()
        {
            List<string> CallNumbers = new List<string>();

            Random rand = new Random();
            var r = new Random();

            StreamReader CNReader = new StreamReader("CallNumbers.txt");

            string line = "";

            while (!CNReader.EndOfStream)
            {
                line = CNReader.ReadLine();
                CallNumbers.Add(line);
            }

            var randomized = CallNumbers.OrderBy(item => r.Next()); //randomize the list
            listBox1.Items.AddRange(randomized.Take(10).ToArray()); //Add N amount to listbox


            /*label1.Text = CallNumbers[rand.Next(0, CallNumbers.Count)];

            string callNumbers = CallNumbers[rand.Next(9, CallNumbers.Count)];

            listBox1.Items.Add(callNumbers);*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            foreach (var item in listBox1.Items)
            {
                list.Add(item);
            }
            list.Sort();
            //list.Reverse();

            listBox1.Items.Clear();

            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }

            MessageBox.Show("THE CALL NUMBERS ARE IN CORRECT ORDER");
        }
    }
}
