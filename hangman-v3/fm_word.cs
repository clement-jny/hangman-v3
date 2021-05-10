using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace hangman_v3
{
    public partial class fm_word : Form
    {
        private string word;
        private int lenght;
        private readonly string path = AppDomain.CurrentDomain.BaseDirectory + "listWords.txt";

        public fm_word()
        {
            InitializeComponent();
        }

        public fm_word(string p_word)
        {
            word = p_word;
            lenght = word.Length;
        }

        public string GetSetWord
        {
            get { return word; }
            set { word = value; lenght = word.Length; }
        }

        public int GetLenght
        {
            get { return lenght; }
        }

        public int PositionChar(char p_char)
        {
            return word.IndexOf(p_char);
        }

        private void fm_word_Load(object sender, EventArgs e)
        {
            tb_add_word.Clear();
            tb_add_word.Focus();

            StreamReader sr = new StreamReader(path);
            lb_words.Items.Clear();
            while (!sr.EndOfStream)
            {
                lb_words.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_add_word.Text == "")
                MessageBox.Show("No word entered, plese try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine(tb_add_word.Text.ToLower());
                sw.Close();
                fm_word_Load(null, null);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (lb_words.SelectedIndex == -1)
                MessageBox.Show("No selected word, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                lb_words.Items.RemoveAt(lb_words.SelectedIndex);

                File.WriteAllText(path, string.Empty);

                StreamWriter sw = new StreamWriter(path, true);
                foreach (string w in lb_words.Items)
                {
                    sw.WriteLine(w.ToLower());
                }
                sw.Close();

                fm_word_Load(null, null);
            }
        }
    }
}