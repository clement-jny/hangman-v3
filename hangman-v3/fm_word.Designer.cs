
namespace hangman_v3
{
    partial class fm_word
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
            this.lb_words = new System.Windows.Forms.ListBox();
            this.tb_add_word = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_words
            // 
            this.lb_words.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_words.FormattingEnabled = true;
            this.lb_words.ItemHeight = 22;
            this.lb_words.Location = new System.Drawing.Point(84, 12);
            this.lb_words.Name = "lb_words";
            this.lb_words.Size = new System.Drawing.Size(150, 246);
            this.lb_words.TabIndex = 0;
            // 
            // tb_add_word
            // 
            this.tb_add_word.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_add_word.Location = new System.Drawing.Point(84, 270);
            this.tb_add_word.Name = "tb_add_word";
            this.tb_add_word.Size = new System.Drawing.Size(150, 29);
            this.tb_add_word.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(261, 159);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 140);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_del.Location = new System.Drawing.Point(261, 12);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(91, 140);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "-";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_back
            // 
            this.btn_back.Image = global::hangman_v3.Properties.Resources.back;
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(48, 48);
            this.btn_back.TabIndex = 4;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // fm_word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(364, 311);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_add_word);
            this.Controls.Add(this.lb_words);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm_word";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman game - Manage";
            this.Load += new System.EventHandler(this.fm_word_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_words;
        private System.Windows.Forms.TextBox tb_add_word;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_back;
    }
}