using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BUTTON.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TEXTBOX_TextChanged(object sender, EventArgs e)
        {
            if(TEXTBOX.TextLength > 0)
            {
                BUTTON.Text = TEXTBOX.Text;
            }
        }

        private void CHECKBOX_CheckedChanged(object sender, EventArgs e)
        {
            BUTTON.Enabled = CHECKBOX.Checked;
        }

        private void BUTTON_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 Form2 = new Form2(TEXTBOX.Text);
            Form2.Show();
        }
    }
}
