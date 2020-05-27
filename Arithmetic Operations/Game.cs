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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        public Game(string name)
        {
            InitializeComponent();
            _name = name;
        }
        string _name;
        int _score;
        int _times;
        Random q = new Random();
        int rnd;
        int c;
        private void btn_ok_Click(object sender, EventArgs e)
        {
            btn_result.Enabled = true;
            Random qwe = new Random();
            if (tbox_result.Text == "")
            {
                tbox_result.Text = "0";
                _times++;
                lbl_result.Text = "X ... Wrong " + lbl_first_number.Text + " X " + lbl_second_number.Text + " = " + (int.Parse(lbl_first_number.Text) * int.Parse(lbl_second_number.Text));
                tbox_result.Clear();
                lbl_first_number.Text = qwe.Next(2, 10).ToString();
                lbl_second_number.Text = rnd.ToString();
                c = 10;
            }
            else
            {
                int z = int.Parse(lbl_first_number.Text) * int.Parse(lbl_second_number.Text);
                if (z == int.Parse(tbox_result.Text))
                {
                    _times++;
                    _score += 10;
                    lbl_result.Text = "√ ... Correct";
                    tbox_result.Clear();
                    lbl_first_number.Text = qwe.Next(2, 10).ToString();
                    lbl_second_number.Text = rnd.ToString();
                    c = 10;
                }
                else
                {
                    _times++;
                    lbl_result.Text = "X ... Wrong " + lbl_first_number.Text + " X " + lbl_second_number.Text + " = " + (int.Parse(lbl_first_number.Text) * int.Parse(lbl_second_number.Text));
                    tbox_result.Clear();
                    lbl_first_number.Text = qwe.Next(2, 10).ToString();
                    lbl_second_number.Text = rnd.ToString();
                    c = 10;
                }
            }
        }
        private void tbox_result_TextChanged(object sender, EventArgs e)
        {
            tbox_result.Text.Trim();
            try
            {
                int z = int.Parse(tbox_result.Text);
            }
            catch
            {
                char[] x = tbox_result.Text.ToCharArray();
                string z = "";
                for (int i = 0; i < x.Length - 1; i++)
                {
                    z = z + x[i];
                }
                tbox_result.Text = z;
            }
        }
        private void Game_Load(object sender, EventArgs e)
        {
            c = 10;
            MessageBox.Show("Welcome " + _name);
            _score = 0;
            Random z;
            z = new Random();
            lbl_first_number.Text = z.Next(2, 10).ToString();
            lbl_second_number.Text = rnd.ToString();
            timer_loop.Enabled = true;
        }
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Random qwe = new Random();
            DialogResult z = MessageBox.Show("Are you sure ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (z == DialogResult.No)
            {
                e.Cancel = true;
                c = 10;
                tbox_result.Clear();
                lbl_first_number.Text = qwe.Next(2, 10).ToString();
                lbl_second_number.Text = rnd.ToString();
                timer_loop.Start();
            }
            else
            {
                Application.OpenForms[0].Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            rnd = q.Next(2, 10);
        }
        private void btn_result_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Are you sure ?", "Result", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.No)
            {
                return;
            }
            else
            {
                timer_loop.Stop();
                MessageBox.Show("Name : " + _name + "\nPlayed : " + _times + "\nCorrect : " + (_score / 10.0).ToString() + "\nWrong : " + (_times - (_score / 10.0)).ToString() + "\nAverage : " + (100.0 * (_score / 10.0) / _times) + " %");
                DialogResult y = MessageBox.Show("Are you want to play again ?\nPress Yes to continue Or press No to exit", "End", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (y == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    c = 10;
                    _times = 0;
                    _score = 0;
                    lbl_result.Text = "";
                    btn_result.Enabled = false;
                    timer_loop.Start();
                }
            }
        }
        private void timer_loop_Tick(object sender, EventArgs e)
        {
            if (c == 10)
            {
                lbl_timer.Text = "Timer : 00:" + c.ToString();                
            }
            else
            {
                lbl_timer.Text = "Timer : 00:0" + c.ToString();
            }
            if (c == 0)
            {
                Random qwe = new Random();
                tbox_result.Text = "0";
                _times++;
                lbl_result.Text = "X ... Wrong " + lbl_first_number.Text + " X " + lbl_second_number.Text + " = " + (int.Parse(lbl_first_number.Text) * int.Parse(lbl_second_number.Text));
                tbox_result.Clear();
                lbl_first_number.Text = qwe.Next(2, 10).ToString();
                lbl_second_number.Text = rnd.ToString();
                c = 10;
            }
            else
            {
                c--;
            }
        }
    }
}