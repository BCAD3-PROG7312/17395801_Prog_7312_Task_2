using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Prog7312_Task1
{
    public partial class Identifying_areas : Form
    {
        int index = 0;
        int questionNumber = 1;
        //int totalQuestions;

        
        public Identifying_areas()
        {
            InitializeComponent();

            askQuestion(questionNumber);
            //totalQuestions = 3;

            progressBar1.Value = 0;
            label3.Text = progressBar1.Value.ToString() + "%";


            Dictionary<string, string> dict = new Dictionary<string, string>();

            // Add(key, value).
            dict.Add("000–099", "general works");

            dict.Add("100–199", "philosophy and psychology");

            dict.Add("200–299", "religion");

            dict.Add("300–399", "social sciences");

            dict.Add("400–499", "language");

            dict.Add("500–599", "natural sciences and mathematics");

            dict.Add("600–699", "technology");

            //dict.Add("700–799", "the arts");

            //dict.Add("800–899", "literature and rhetoric");

            //dict.Add("900–999", "history, biography, and geography");
        }

        private void askQuestion(int qnum)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            // Add(key, value).
            dict.Add("000–099", "general works");

            dict.Add("100–199", "philosophy and psychology");

            dict.Add("200–299", "religion");

            dict.Add("300–399", "social sciences");

            dict.Add("400–499", "language");

            dict.Add("500–599", "natural sciences and mathematics");

            dict.Add("600–699", "technology");

            Random rand = new Random();
            var r = new Random();

            List<string> keyList = new List<string>(dict.Keys);

            var randomized = keyList.OrderBy(item => r.Next());

            List<string> valueList = new List<string>(dict.Values);

            var randomized2 = valueList.OrderBy(item => r.Next());

            switch (qnum) 
            {
                case 1:
                    lblQuestion.Text = "Match The First Call Number With The Correct Description";

                    
                    checkedListBox1.Items.AddRange(randomized.Take(3).ToArray());

                    
                    checkedListBox2.Items.AddRange(randomized2.Take(7).ToArray());



                    break;

                case 2:
                    lblQuestion.Text = "Match The First Description With The Correct Call Number";


                    checkedListBox1.Items.AddRange(randomized.Take(3).ToArray());


                    checkedListBox2.Items.AddRange(randomized2.Take(7).ToArray());

                    break;

                case 3:
                    lblQuestion.Text = "What is the colour of the sky?";


                    checkedListBox1.Items.AddRange(randomized.Take(3).ToArray());


                    checkedListBox2.Items.AddRange(randomized2.Take(7).ToArray());

                    break;

            }
        }

            private void checkedListBox1_MouseDown(object sender, MouseEventArgs e)
        {
            CheckedListBox check1 = sender as CheckedListBox;
            index = check1.IndexFromPoint(e.X, e.Y);
            if (index >= 0 & e.Button == MouseButtons.Left)
                check1.DoDragDrop(check1.Items[index].ToString(), DragDropEffects.Move);
        }

        private void checkedListBox2_MouseDown(object sender, MouseEventArgs e)
        {
            CheckedListBox check2 = sender as CheckedListBox;
            index = check2.IndexFromPoint(e.X, e.Y);
            if (index >= 0 & e.Button == MouseButtons.Left)
                check2.DoDragDrop(check2.Items[index].ToString(), DragDropEffects.Move);
        }
        private void CheckedListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void checkedListBox3_DragDrop(object sender, DragEventArgs e)
        {
            CheckedListBox check = sender as CheckedListBox;
            check.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            checkedListBox1.Items.RemoveAt(index);
        }

        private void checkedListBox4_DragDrop(object sender, DragEventArgs e)
        {
            CheckedListBox check = sender as CheckedListBox;
            check.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            checkedListBox2.Items.RemoveAt(index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox3.CheckedItems.Contains("100–199") && checkedListBox4.CheckedItems.Contains("general works"))
            {
                MessageBox.Show("Match Correct!!!!!!!");
            }
            else
            {
                MessageBox.Show("Not Match Correct!!!!!!!");
            }

            if (checkedListBox3.CheckedItems.Contains("200–299") && checkedListBox4.CheckedItems.Contains("philosophy and psychology"))
            {
                MessageBox.Show("Match Correct!!!!!!!");
            }
            else
            {
                MessageBox.Show("Not Match Correct!!!!!!!");
            }

            if (checkedListBox3.CheckedItems.Contains("300–399") && checkedListBox4.CheckedItems.Contains("social sciences"))
            {
                MessageBox.Show("Match Correct!!!!!!!");
            }
            else
            {
                MessageBox.Show("Not Match Correct!!!!!!!");
            }

            if (checkedListBox3.CheckedItems.Contains("400–499") && checkedListBox4.CheckedItems.Contains("language"))
            {
                MessageBox.Show("Match Correct!!!!!!!");
            }
            else
            {
                MessageBox.Show("Not Match Correct!!!!!!!");
            }


            if (checkedListBox3.CheckedItems.Contains("500–599") && checkedListBox4.CheckedItems.Contains("natural sciences and mathematics"))
            {
                MessageBox.Show("Match Correct!!!!!!!");
            }
            else

            if (checkedListBox3.CheckedItems.Contains("600–699") && checkedListBox4.CheckedItems.Contains("technology"))
            {
                MessageBox.Show("Match Correct!!!!!!!");
            }
            else
            {
                MessageBox.Show("Not Match Correct!!!!!!!");
            }

            progressBar1.Value += 10;

            progressBar1.Value += 34;
            label3.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == 70)
            {
                label2.Text = "You Are Almost There!!!";
            }

            if (progressBar1.Value == 100)
            {
                label2.Text = "Done!!!";
            }

            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            checkedListBox3.Items.Clear();
            checkedListBox4.Items.Clear();
            questionNumber++;
            askQuestion(questionNumber);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.progressBar1.Increment(1);
            progressBar1.Increment(100 / 10);
            label3.Text = progressBar1.Value.ToString() + "%";
        }
    }
}
