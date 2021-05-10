using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman_v3
{
    public partial class fm_main : Form
    {
        public fm_main()
        {
            InitializeComponent();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_game game = new fm_game();
            game.FormClosed += (s, args) => this.Show();
            game.Show();
        }

        private void btn_word_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_word word = new fm_word();
            word.FormClosed += (s, args) => this.Show();
            word.Show();
        }
    }
}