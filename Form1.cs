using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Charlie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool buttonwasclicked = false;
        bool button2_clicked = true;
        private void button2_Click(object sender, EventArgs e)
        {

            int num = 0;
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter first name in the textbox");
                textBox1.BackColor = Color.Red;
                textBox1.Focus();
                return;
            }
            else if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter last name in the textbox");
                textBox2.BackColor = Color.Red;
                textBox2.Focus();
                return;
            }

            else if (int.TryParse(textBox3.Text, out num) == false)
            {
                MessageBox.Show("Enter a valid Phone number.");
                textBox3.BackColor = Color.Red;
                textBox3.Focus();
                return;
            }

            else if (textBox4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter email in the textbox");
                textBox4.BackColor = Color.Red;
                textBox4.Focus();

            }

            else if (numericUpDown1.Value == 0)
            {

                MessageBox.Show("please enter the hour of time");
            }

            else if (numericUpDown2.Value == 0)
            {

                MessageBox.Show("please enter the minute of time");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose the person you want to see");

            }
            else if (button2_clicked == false)
            {
                MessageBox.Show("please click the button");
            }

            else if (button2_clicked == true)
                {
                    listBox1.Items.Add("First name: " + textBox1.Text);
                    listBox1.Items.Add("Last name: " + textBox2.Text);
                    listBox1.Items.Add("Mobile Number: " + textBox3.Text);
                    listBox1.Items.Add("Email: " + textBox4.Text);
                    listBox1.Items.Add("Hours: " + numericUpDown1.Value + " : " + numericUpDown2.Value);
                    listBox1.Items.Add("Meeting with: " + comboBox1.SelectedItem);
                    listBox1.Items.Add("====================");
                
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.ResetText();
                numericUpDown1.ResetText();
                numericUpDown2.ResetText();
            }

        }
        private void aimbutton_Click_1(object sender, EventArgs e)
        {
            {
                Site_Visit sv = new Site_Visit();
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    if (sv.radioButton1.Checked == true)
                        aimbutton.Text = sv.radioButton1.Text;
                    else if (sv.radioButton2.Checked == true)
                        aimbutton.Text = sv.radioButton2.Text;
                    else if (sv.radioButton3.Checked == true)
                        aimbutton.Text = sv.radioButton3.Text;
                    else if (sv.radioButton4.Checked == true)
                        aimbutton.Text = sv.radioButton4.Text;
                   
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Site_Visit sv = new Site_Visit();
            sv.ShowDialog();
        }
    }
}
    


