
namespace hangman_v3
{
    partial class fm_message
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
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_m_left = new System.Windows.Forms.Button();
            this.btn_m_middle = new System.Windows.Forms.Button();
            this.btn_m_right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_message.Location = new System.Drawing.Point(12, 9);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(428, 54);
            this.lbl_message.TabIndex = 0;
            // 
            // btn_m_left
            // 
            this.btn_m_left.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_m_left.Location = new System.Drawing.Point(12, 66);
            this.btn_m_left.Name = "btn_m_left";
            this.btn_m_left.Size = new System.Drawing.Size(85, 35);
            this.btn_m_left.TabIndex = 1;
            this.btn_m_left.UseVisualStyleBackColor = true;
            this.btn_m_left.Click += new System.EventHandler(this.btn_m_left_Click);
            // 
            // btn_m_middle
            // 
            this.btn_m_middle.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_m_middle.Location = new System.Drawing.Point(177, 66);
            this.btn_m_middle.Name = "btn_m_middle";
            this.btn_m_middle.Size = new System.Drawing.Size(85, 35);
            this.btn_m_middle.TabIndex = 2;
            this.btn_m_middle.UseVisualStyleBackColor = true;
            this.btn_m_middle.Click += new System.EventHandler(this.btn_m_middle_Click);
            // 
            // btn_m_right
            // 
            this.btn_m_right.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_m_right.Location = new System.Drawing.Point(355, 66);
            this.btn_m_right.Name = "btn_m_right";
            this.btn_m_right.Size = new System.Drawing.Size(85, 35);
            this.btn_m_right.TabIndex = 3;
            this.btn_m_right.UseVisualStyleBackColor = true;
            this.btn_m_right.Click += new System.EventHandler(this.btn_m_right_Click);
            // 
            // fm_message
            // 
            this.AcceptButton = this.btn_m_left;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_m_right;
            this.ClientSize = new System.Drawing.Size(452, 111);
            this.Controls.Add(this.btn_m_right);
            this.Controls.Add(this.btn_m_middle);
            this.Controls.Add(this.btn_m_left);
            this.Controls.Add(this.lbl_message);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fm_message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fm_message_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_m_left;
        private System.Windows.Forms.Button btn_m_middle;
        private System.Windows.Forms.Button btn_m_right;
    }
}