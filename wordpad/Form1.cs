using System;
using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace wordpad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var di = new SaveFileDialog();
            di.Filter = "text files | *.txt";
            di.FileName = "untiteld" +".txt";
            var result = di.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(di.FileName, richTextBox1.Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var di = new OpenFileDialog();
            di.Filter = "text files | *";
            di.FileName = "";
            var result = di.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(di.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (!richTextBox1.SelectionFont.Bold)
            {
                button5.FlatStyle = FlatStyle.Popup;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);

            }
            else if(richTextBox1.SelectionFont.Bold)
            {
                button5.FlatStyle = FlatStyle.Flat;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            }
                


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var box = new ColorDialog();
            var result = box.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.BackColor = box.Color;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var box = new FontDialog();
            var result = box.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.Font = box.Font;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.SelectionFont.Italic)
            {
                button7.FlatStyle = FlatStyle.Popup;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);

            }
            else if (richTextBox1.SelectionFont.Italic)
            {
                button7.FlatStyle = FlatStyle.Flat;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.SelectionFont.Underline)
            {
                button6.FlatStyle = FlatStyle.Popup;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);

            }
            else if (richTextBox1.SelectionFont.Underline)
            {
                button6.FlatStyle = FlatStyle.Flat;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var box = new ColorDialog();
            var result = box.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.ForeColor = box.Color;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var di = new OpenFileDialog();
            di.Filter = "text files | *";
            di.FileName = "";
            var result = di.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(di.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                Clipboard.SetText(richTextBox1.Text);
            }
              
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text !="")
            {
                Clipboard.SetText(richTextBox1.Text);
               richTextBox1.Text = "";
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();



          //  var pr = new PrintDialog();
         //   pr.PrintToFile = true;
         //   var result = pr.ShowDialog();
///if (result == DialogResult.OK)
          //      if (result == DialogResult.OK)
            //    {
            //        pr.Print();
            //    }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
                 e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 100,100);
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.ZoomFactor = bunifuSlider1.Value;

            }
            catch { }
        }
    }
}
