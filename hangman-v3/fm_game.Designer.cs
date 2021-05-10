
namespace hangman_v3
{
    partial class fm_game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_word = new System.Windows.Forms.Label();
            this.lbl_list = new System.Windows.Forms.Label();
            this.lbl_char_yes = new System.Windows.Forms.Label();
            this.lbl_char_no = new System.Windows.Forms.Label();
            this.lbl_tries = new System.Windows.Forms.Label();
            this.lbl_key = new System.Windows.Forms.Label();
            this.pb_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(117, 22);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Word to find:";
            // 
            // lbl_word
            // 
            this.lbl_word.AutoSize = true;
            this.lbl_word.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_word.Location = new System.Drawing.Point(146, 9);
            this.lbl_word.Name = "lbl_word";
            this.lbl_word.Size = new System.Drawing.Size(0, 22);
            this.lbl_word.TabIndex = 1;
            // 
            // lbl_list
            // 
            this.lbl_list.AutoSize = true;
            this.lbl_list.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_list.Location = new System.Drawing.Point(12, 117);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(197, 22);
            this.lbl_list.TabIndex = 2;
            this.lbl_list.Text = "List of letters requested:";
            // 
            // lbl_char_yes
            // 
            this.lbl_char_yes.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_char_yes.ForeColor = System.Drawing.Color.Lime;
            this.lbl_char_yes.Location = new System.Drawing.Point(58, 139);
            this.lbl_char_yes.Name = "lbl_char_yes";
            this.lbl_char_yes.Size = new System.Drawing.Size(50, 140);
            this.lbl_char_yes.TabIndex = 3;
            // 
            // lbl_char_no
            // 
            this.lbl_char_no.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_char_no.ForeColor = System.Drawing.Color.Red;
            this.lbl_char_no.Location = new System.Drawing.Point(134, 139);
            this.lbl_char_no.Name = "lbl_char_no";
            this.lbl_char_no.Size = new System.Drawing.Size(50, 140);
            this.lbl_char_no.TabIndex = 4;
            // 
            // lbl_tries
            // 
            this.lbl_tries.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tries.Location = new System.Drawing.Point(12, 338);
            this.lbl_tries.Name = "lbl_tries";
            this.lbl_tries.Size = new System.Drawing.Size(127, 35);
            this.lbl_tries.TabIndex = 5;
            this.lbl_tries.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_key.Location = new System.Drawing.Point(423, 351);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(158, 22);
            this.lbl_key.TabIndex = 6;
            this.lbl_key.Text = "Please press a key..";
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(372, 12);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(209, 216);
            this.pb_image.TabIndex = 7;
            this.pb_image.TabStop = false;
            // 
            // fm_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 382);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.lbl_tries);
            this.Controls.Add(this.lbl_char_no);
            this.Controls.Add(this.lbl_char_yes);
            this.Controls.Add(this.lbl_list);
            this.Controls.Add(this.lbl_word);
            this.Controls.Add(this.lbl_title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman game - Play";
            this.Load += new System.EventHandler(this.fm_game_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fm_game_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_word;
        private System.Windows.Forms.Label lbl_list;
        private System.Windows.Forms.Label lbl_char_yes;
        private System.Windows.Forms.Label lbl_char_no;
        private System.Windows.Forms.Label lbl_tries;
        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.PictureBox pb_image;
    }
}