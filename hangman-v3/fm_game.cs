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
    public partial class fm_game : Form
    {
        private fm_word full_word;
        private string masked_word;
        private List<fm_word> list_words;
        private List<char> list_char_yes;
        private List<char> list_char_no;
        private char letter;
        private readonly int number_fail = 10;
        private int counter;
        private readonly string path = AppDomain.CurrentDomain.BaseDirectory + "listWords.txt";

        public fm_game()
        {
            InitializeComponent();
        }

        private string Mask(fm_word p_word)
        {
            char symbol = '_';
            string mask = "";
            string word = p_word.GetSetWord;

            for (int i = 0; i < p_word.GetLenght; i++)
            {
                if (list_char_yes.Contains(word[i]))
                    mask += word[i];
                else
                    mask += symbol + " ";
            }
            return mask;
        }

        private void fm_game_Load(object sender, EventArgs e)
        {
            list_words = new List<fm_word>();
            list_words.Clear();

            list_char_yes = new List<char>();
            lbl_char_yes.Text = "";

            list_char_no = new List<char>();
            lbl_char_no.Text = "";

            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                fm_word word = new fm_word(sr.ReadLine());
                list_words.Add(word);
            }
            sr.Close();

            Random random = new Random();
            full_word = list_words[random.Next(0, list_words.Count)];

            masked_word = Mask(full_word);
            lbl_word.Text = masked_word;

            counter = 0;
            lbl_tries.Text = $"Tries : {counter + 1}/{number_fail}.";
            pb_image.Image = null;
        }

        private void fm_game_KeyPress(object sender, KeyPressEventArgs e)
        {
            letter = e.KeyChar;
            if (char.IsLetter(e.KeyChar))
            {
                if (full_word.PositionChar(letter) == -1)
                {
                    if (list_char_no.Count == 0)
                    {
                        pb_image.Load(string.Format("../../../Resources/images/hangman{0}.png", counter));

                        list_char_no.Add(letter);
                        lbl_char_no.Text += letter + " ";

                        counter++;
                        lbl_tries.Text = $"Tries : {counter + 1}/{number_fail}.";
                    }
                    else
                    {
                        for (int i = 0; i < list_char_no.Count; i++)
                        {
                            if (!list_char_no.Contains(letter))
                            {
                                pb_image.Load(string.Format("../../../Resources/images/hangman{0}.png", counter));

                                list_char_no.Add(letter);
                                lbl_char_no.Text += letter + " ";

                                counter++;
                                lbl_tries.Text = $"Tries : {counter + 1}/{number_fail}.";
                            }
                        }
                    }
                }
                else
                {
                    if (list_char_yes.Count == 0)
                    {
                        list_char_yes.Add(letter);
                        lbl_char_yes.Text += letter + " ";

                        masked_word = Mask(full_word);
                        lbl_word.Text = masked_word;
                    }
                    else
                    {
                        for (int i = 0; i < list_char_yes.Count; i++)
                        {
                            if (!list_char_yes.Contains(letter))
                            {
                                list_char_yes.Add(letter);
                                lbl_char_yes.Text += letter + " ";

                                masked_word = Mask(full_word);
                                lbl_word.Text = masked_word;
                            }
                        }
                    }
                }
            }

            if (full_word.GetSetWord == masked_word)
            {
                fm_message message = new fm_message("Victory !", "Congratulations, you found the word masked.\nDo you want to replay?", "Replay", "Menu", "Quit");
                DialogResult result = message.ShowDialog();
                if (result == DialogResult.Yes)
                    fm_game_Load(null, null);
                else if (result == DialogResult.No)
                    this.Close();
                else if (result == DialogResult.Cancel)
                    Application.Exit();
            }
            else if (counter == number_fail)
            {
                fm_message message = new fm_message("Defeat !", "Too bad. The word was \"" + full_word.GetSetWord + "\"\nDo you want to replay?", "Replay", "Menu", "Quit");
                DialogResult result = message.ShowDialog();
                if (result == DialogResult.Yes)
                    fm_game_Load(null, null);
                else if (result == DialogResult.No)
                    this.Close();
                else if (result == DialogResult.Cancel)
                    Application.Exit();
            }
        }
    }
}