using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arithmetic_Operations
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (tbox_name.Text != "")
            {
                Game a = new Game(tbox_name.Text);
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Insert name");
            }
        }
        private void tbox_name_TextChanged(object sender, EventArgs e)
        {
            tbox_name.Text = tbox_name.Text.Trim();
        }
    }
}