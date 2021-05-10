
namespace hangman_v3
{
    partial class fm_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_word = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_play.Location = new System.Drawing.Point(40, 25);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(100, 60);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_word
            // 
            this.btn_word.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_word.Location = new System.Drawing.Point(40, 120);
            this.btn_word.Name = "btn_word";
            this.btn_word.Size = new System.Drawing.Size(100, 60);
            this.btn_word.TabIndex = 1;
            this.btn_word.Text = "Manage words";
            this.btn_word.UseVisualStyleBackColor = true;
            this.btn_word.Click += new System.EventHandler(this.btn_word_Click);
            // 
            // fm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 231);
            this.Controls.Add(this.btn_word);
            this.Controls.Add(this.btn_play);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu du pendu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_word;
    }
}

