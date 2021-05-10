using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hangman_v3
{
    public partial class fm_message : Form
    {
        private string title;
        private string message;
        private string btn_left;
        private string btn_middle;
        private string btn_right;

        public fm_message(string p_title, string p_message, string p_btn_left, string p_btn_middle, string p_btn_right)
        {
            InitializeComponent();

            title = p_title;
            message = p_message;
            btn_left = p_btn_left;
            btn_middle = p_btn_middle;
            btn_right = p_btn_right;
        }

        private void fm_message_Load(object sender, EventArgs e)
        {
            this.Text = title;
            lbl_message.Text = message;
            btn_m_left.Text = btn_left;
            btn_m_middle.Text = btn_middle;
            btn_m_right.Text = btn_right;
        }

        private void btn_m_left_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btn_m_middle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void btn_m_right_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}