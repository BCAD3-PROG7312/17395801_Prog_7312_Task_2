using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Prog7312_Task1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label1.Text = progressBar1.Value.ToString() + "%";
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
            lstCallNumbers.Items.AddRange(randomized.Take(10).ToArray()); //Add N amount to listbox


            /*label1.Text = CallNumbers[rand.Next(0, CallNumbers.Count)];

            string callNumbers = CallNumbers[rand.Next(9, CallNumbers.Count)];

            listBox1.Items.Add(callNumbers);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            label1.Text = progressBar1.Value.ToString() + "%";
            label2.Text = "";
            //clear the list box there is no duplicate
            lstCallNumbers.Items.Clear();
            lstResult.Items.Clear();

            //call the generate method to create the random call numbers in the list box
            Generate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Copy Call Numbers over to lstTemp1
            lstTemp1.Items.Clear();
            for (int i = 0; i < lstCallNumbers.Items.Count; i++)
            {
                lstCallNumbers.SelectedIndex = i;
                lstTemp1.Items.Add(lstCallNumbers.SelectedItem.ToString());
            }

            // While lstTemp1 has Call numbers....
            while (lstTemp1.Items.Count > 0)
            {
                // Find lowest call number in lstTemp1
                lstTemp1.SelectedIndex = 0;
                string lowest = lstTemp1.SelectedItem.ToString();
                for (int i = 0; i < lstTemp1.Items.Count; i++)
                {
                    lstTemp1.SelectedIndex = i;
                    string callNumber = lstTemp1.SelectedItem.ToString();
                    if (string.Compare(lowest, callNumber) > 0)
                    {
                        lowest = callNumber;
                    }
                }

                MessageBox.Show("lowest is " + lowest);
                //progressBar1.Value = 10;
                // Copy call numbers except lowest call number into lstTemp2.
                // Copy lowest call number(s) into lstResult

                //this.timer1.Start();

                lstTemp2.Items.Clear();
                for (int i = 0; i < lstTemp1.Items.Count; i++)
                {
                    lstTemp1.SelectedIndex = i;
                    string callNumber = lstTemp1.SelectedItem.ToString();
                    if (callNumber == lowest)
                    {
                        lstResult.Items.Add(callNumber);
                        progressBar1.Value += 10;
                        label1.Text = progressBar1.Value.ToString() + "%";

                        if (progressBar1.Value == 70)
                        {
                            label2.Text = "You Are Almost There!!!";
                        }

                        if (progressBar1.Value == 100)
                        {
                            label2.Text = "Done!!!";
                        }
                    }
                    else
                    {
                        lstTemp2.Items.Add(callNumber);
                    }
                }

                // Copy remaining call numbers from lstTemp2 back to lstTemp1
                lstTemp1.Items.Clear();
                for (int i = 0; i < lstTemp2.Items.Count; i++)
                {
                    lstTemp2.SelectedIndex = i;
                    lstTemp1.Items.Add(lstTemp2.SelectedItem.ToString());
                }
            }

            MessageBox.Show("CONGRATULATIONS!!!!!!" + "\n" + "\n" + "Call Numbers Are In The Correct Order!!!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.progressBar1.Increment(1);
            progressBar1.Increment(100 / 10);
            label1.Text = progressBar1.Value.ToString() + "%";
        }
    }
}
