namespace Asml_Level100Pikachus
{
    partial class Asml
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listOfTargets = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.video_button = new System.Windows.Forms.Button();
            this.up_button = new System.Windows.Forms.Button();
            this.right_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.fire_button = new System.Windows.Forms.Button();
            this.searchAndDestory_button = new System.Windows.Forms.Button();
            this.timer_button = new System.Windows.Forms.Button();
            this.angle_button = new System.Windows.Forms.Button();
            this.kill_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numFriends = new System.Windows.Forms.Label();
            this.numFoes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version 1.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level 100 Pikachus";
            // 
            // listOfTargets
            // 
            this.listOfTargets.FormattingEnabled = true;
            this.listOfTargets.Location = new System.Drawing.Point(81, 268);
            this.listOfTargets.Name = "listOfTargets";
            this.listOfTargets.Size = new System.Drawing.Size(187, 134);
            this.listOfTargets.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(294, 268);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(192, 134);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Target Name:\t\n\nX Position:\t\n\nY Position:\t\n\nZ Position:\t\n\nFriend or Foe:\t";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // video_button
            // 
            this.video_button.BackgroundImage = global::Asml_Level100Pikachus.Properties.Resources.pikachuVid;
            this.video_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.video_button.Location = new System.Drawing.Point(81, 46);
            this.video_button.Name = "video_button";
            this.video_button.Size = new System.Drawing.Size(405, 207);
            this.video_button.TabIndex = 4;
            this.video_button.UseVisualStyleBackColor = true;
            // 
            // up_button
            // 
            this.up_button.Location = new System.Drawing.Point(685, 268);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(45, 42);
            this.up_button.TabIndex = 5;
            this.up_button.Text = "Up";
            this.up_button.UseVisualStyleBackColor = true;
            // 
            // right_button
            // 
            this.right_button.Location = new System.Drawing.Point(742, 315);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(45, 42);
            this.right_button.TabIndex = 6;
            this.right_button.Text = "Right";
            this.right_button.UseVisualStyleBackColor = true;
            // 
            // left_button
            // 
            this.left_button.Location = new System.Drawing.Point(627, 315);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(45, 42);
            this.left_button.TabIndex = 7;
            this.left_button.Text = "Left";
            this.left_button.UseVisualStyleBackColor = true;
            // 
            // down_button
            // 
            this.down_button.Location = new System.Drawing.Point(685, 360);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(45, 42);
            this.down_button.TabIndex = 8;
            this.down_button.Text = "Down";
            this.down_button.UseVisualStyleBackColor = true;
            // 
            // fire_button
            // 
            this.fire_button.Location = new System.Drawing.Point(685, 315);
            this.fire_button.Name = "fire_button";
            this.fire_button.Size = new System.Drawing.Size(45, 42);
            this.fire_button.TabIndex = 9;
            this.fire_button.Text = "Fire";
            this.fire_button.UseVisualStyleBackColor = true;
            // 
            // searchAndDestory_button
            // 
            this.searchAndDestory_button.BackColor = System.Drawing.Color.Red;
            this.searchAndDestory_button.Location = new System.Drawing.Point(603, 46);
            this.searchAndDestory_button.Name = "searchAndDestory_button";
            this.searchAndDestory_button.Size = new System.Drawing.Size(122, 30);
            this.searchAndDestory_button.TabIndex = 10;
            this.searchAndDestory_button.Text = "Search and Destroy";
            this.searchAndDestory_button.UseVisualStyleBackColor = false;
            this.searchAndDestory_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer_button
            // 
            this.timer_button.Location = new System.Drawing.Point(603, 92);
            this.timer_button.Name = "timer_button";
            this.timer_button.Size = new System.Drawing.Size(75, 23);
            this.timer_button.TabIndex = 11;
            this.timer_button.Text = "Timer";
            this.timer_button.UseVisualStyleBackColor = true;
            this.timer_button.Visible = false;
            // 
            // angle_button
            // 
            this.angle_button.Location = new System.Drawing.Point(603, 138);
            this.angle_button.Name = "angle_button";
            this.angle_button.Size = new System.Drawing.Size(75, 23);
            this.angle_button.TabIndex = 12;
            this.angle_button.Text = "Angle";
            this.angle_button.UseVisualStyleBackColor = true;
            this.angle_button.Visible = false;
            // 
            // kill_button
            // 
            this.kill_button.Location = new System.Drawing.Point(603, 196);
            this.kill_button.Name = "kill_button";
            this.kill_button.Size = new System.Drawing.Size(75, 23);
            this.kill_button.TabIndex = 13;
            this.kill_button.Text = "Kill";
            this.kill_button.UseVisualStyleBackColor = true;
            this.kill_button.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(505, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Number of Friends: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(505, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Number of Foes: ";
            // 
            // numFriends
            // 
            this.numFriends.AutoSize = true;
            this.numFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numFriends.Location = new System.Drawing.Point(508, 295);
            this.numFriends.Name = "numFriends";
            this.numFriends.Size = new System.Drawing.Size(13, 13);
            this.numFriends.TabIndex = 16;
            this.numFriends.Text = "0";
            // 
            // numFoes
            // 
            this.numFoes.AutoSize = true;
            this.numFoes.ForeColor = System.Drawing.Color.Red;
            this.numFoes.Location = new System.Drawing.Point(508, 349);
            this.numFoes.Name = "numFoes";
            this.numFoes.Size = new System.Drawing.Size(13, 13);
            this.numFoes.TabIndex = 17;
            this.numFoes.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(104, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Video Placeholder";
            // 
            // Asml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(809, 424);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numFoes);
            this.Controls.Add(this.numFriends);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kill_button);
            this.Controls.Add(this.angle_button);
            this.Controls.Add(this.timer_button);
            this.Controls.Add(this.searchAndDestory_button);
            this.Controls.Add(this.fire_button);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.left_button);
            this.Controls.Add(this.right_button);
            this.Controls.Add(this.up_button);
            this.Controls.Add(this.video_button);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listOfTargets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Asml";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Asml_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listOfTargets;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button video_button;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Button fire_button;
        private System.Windows.Forms.Button searchAndDestory_button;
        private System.Windows.Forms.Button timer_button;
        private System.Windows.Forms.Button angle_button;
        private System.Windows.Forms.Button kill_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label numFriends;
        private System.Windows.Forms.Label numFoes;
        private System.Windows.Forms.Label label5;
    }
}

