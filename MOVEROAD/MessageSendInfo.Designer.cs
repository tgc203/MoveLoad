﻿namespace MOVEROAD
{
    partial class MessageSendInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Label();
            this.labelFromtime = new System.Windows.Forms.Label();
            this.FromtextBox = new System.Windows.Forms.TextBox();
            this.FromtitleBox = new System.Windows.Forms.TextBox();
            this.FromBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.pictureBox1.BackgroundImage = global::MOVEROAD.Properties.Resources.X;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(627, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(513, 293);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(38, 12);
            this.time.TabIndex = 23;
            this.time.Text = "label3";
            // 
            // labelFromtime
            // 
            this.labelFromtime.AutoSize = true;
            this.labelFromtime.BackColor = System.Drawing.Color.White;
            this.labelFromtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFromtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.labelFromtime.Location = new System.Drawing.Point(401, 290);
            this.labelFromtime.Name = "labelFromtime";
            this.labelFromtime.Size = new System.Drawing.Size(60, 17);
            this.labelFromtime.TabIndex = 21;
            this.labelFromtime.Text = "보낸 시간";
            // 
            // FromtextBox
            // 
            this.FromtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FromtextBox.Location = new System.Drawing.Point(22, 87);
            this.FromtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromtextBox.Multiline = true;
            this.FromtextBox.Name = "FromtextBox";
            this.FromtextBox.ReadOnly = true;
            this.FromtextBox.Size = new System.Drawing.Size(598, 192);
            this.FromtextBox.TabIndex = 20;
            // 
            // FromtitleBox
            // 
            this.FromtitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FromtitleBox.Location = new System.Drawing.Point(88, 52);
            this.FromtitleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromtitleBox.Name = "FromtitleBox";
            this.FromtitleBox.ReadOnly = true;
            this.FromtitleBox.Size = new System.Drawing.Size(420, 21);
            this.FromtitleBox.TabIndex = 19;
            // 
            // FromBox
            // 
            this.FromBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FromBox.Location = new System.Drawing.Point(88, 21);
            this.FromBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromBox.Name = "FromBox";
            this.FromBox.ReadOnly = true;
            this.FromBox.Size = new System.Drawing.Size(420, 21);
            this.FromBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(34, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "제목";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "받는 사람";
            // 
            // MessageSendInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 330);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.labelFromtime);
            this.Controls.Add(this.FromtextBox);
            this.Controls.Add(this.FromtitleBox);
            this.Controls.Add(this.FromBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageSendInfo";
            this.Text = "MessageSendInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label labelFromtime;
        private System.Windows.Forms.TextBox FromtextBox;
        private System.Windows.Forms.TextBox FromtitleBox;
        private System.Windows.Forms.TextBox FromBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}