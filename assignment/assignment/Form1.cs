using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 100;
            numericUpDown1.Value = 50;
        }


        private void MainForm1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("apple");
            comboBox1.Items.Add("banana");
            comboBox1.Items.Add("mango");
            comboBox1.Items.Add("orange");
            comboBox1.Items.Add("grapes");


            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELLO WORLD", "HELP", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.google.com") { UseShellExecute = true });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            textBox1.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Font old_font = this.richTextBox1.SelectionFont;
            if (old_font != null)
            {
                Font new_font;
                if (old_font.Italic)
                    new_font = new Font(old_font, old_font.Style & ~FontStyle.Italic);
                else
                    new_font = new Font(old_font, old_font.Style | FontStyle.Italic);

                this.richTextBox1.SelectionFont = new_font;
            }
            this.richTextBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Font oldfont = this.richTextBox1.SelectionFont;
            if (oldfont != null)
            {
                Font newfont;
                if (oldfont.Bold)
                    newfont = new Font(oldfont, oldfont.Style & ~FontStyle.Bold);
                else
                    newfont = new Font(oldfont, oldfont.Style | FontStyle.Bold);

                this.richTextBox1.SelectionFont = newfont;
            }
            this.richTextBox1.Focus();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string items = String.Empty;
            if (checkBox2.Checked)
            {
                items += "\n Pencil";
            }
            if (checkBox3.Checked)
            {
                items += "\n Sharpener";
            }
            if (checkBox4.Checked)
            {
                items += "\n Pen.";
            }
            MessageBox.Show("You have bought: " + items);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Gender;
            if (radioButton1.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            MessageBox.Show(Gender.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected: " + comboBox1.SelectedItem.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Text = "Value: " + numericUpDown1.Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = "DateTimePicker Date: " + dateTimePicker1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label2.Text = "Month Calender Date : " + monthCalendar1.SelectionStart.ToLongDateString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(o.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
