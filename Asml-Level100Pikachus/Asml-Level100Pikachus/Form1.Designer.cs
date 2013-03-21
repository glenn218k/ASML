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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listOfTargets = new System.Windows.Forms.ListBox();
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
            this.label_numFriends = new System.Windows.Forms.Label();
            this.label_numFoes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_z = new System.Windows.Forms.TextBox();
            this.textBox_friend = new System.Windows.Forms.TextBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version 1.0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level 100 Pikachus";
            // 
            // listOfTargets
            // 
            this.listOfTargets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfTargets.FormattingEnabled = true;
            this.listOfTargets.Location = new System.Drawing.Point(20, 262);
            this.listOfTargets.Name = "listOfTargets";
            this.listOfTargets.Size = new System.Drawing.Size(187, 134);
            this.listOfTargets.TabIndex = 2;
            this.listOfTargets.SelectedIndexChanged += new System.EventHandler(this.listOfTargets_SelectedIndexChanged);
            // 
            // video_button
            // 
            this.video_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.video_button.BackgroundImage = global::Asml_Level100Pikachus.Properties.Resources.pikachuVid;
            this.video_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.video_button.Location = new System.Drawing.Point(20, 46);
            this.video_button.Name = "video_button";
            this.video_button.Size = new System.Drawing.Size(405, 207);
            this.video_button.TabIndex = 4;
            this.video_button.UseVisualStyleBackColor = true;
            // 
            // up_button
            // 
            this.up_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.up_button.Location = new System.Drawing.Point(619, 253);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(45, 42);
            this.up_button.TabIndex = 5;
            this.up_button.Text = "Up";
            this.up_button.UseVisualStyleBackColor = true;
            this.up_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.up_button_Down);
            this.up_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.up_button_Up);
            // 
            // right_button
            // 
            this.right_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.right_button.Location = new System.Drawing.Point(676, 300);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(45, 42);
            this.right_button.TabIndex = 6;
            this.right_button.Text = "Right";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.right_button_Down);
            this.right_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.right_button_Up);
            // 
            // left_button
            // 
            this.left_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.left_button.Location = new System.Drawing.Point(561, 300);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(45, 42);
            this.left_button.TabIndex = 7;
            this.left_button.Text = "Left";
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.left_button_Down);
            this.left_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.left_button_Up);
            // 
            // down_button
            // 
            this.down_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.down_button.Location = new System.Drawing.Point(619, 347);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(45, 42);
            this.down_button.TabIndex = 8;
            this.down_button.Text = "Down";
            this.down_button.UseVisualStyleBackColor = true;
            this.down_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.down_button_Down);
            this.down_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.down_button_Up);
            // 
            // fire_button
            // 
            this.fire_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fire_button.Location = new System.Drawing.Point(619, 300);
            this.fire_button.Name = "fire_button";
            this.fire_button.Size = new System.Drawing.Size(45, 42);
            this.fire_button.TabIndex = 9;
            this.fire_button.Text = "Fire";
            this.fire_button.UseVisualStyleBackColor = true;
            this.fire_button.Click += new System.EventHandler(this.fire_button_Click);
            // 
            // searchAndDestory_button
            // 
            this.searchAndDestory_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchAndDestory_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchAndDestory_button.BackColor = System.Drawing.Color.Red;
            this.searchAndDestory_button.Location = new System.Drawing.Point(561, 144);
            this.searchAndDestory_button.Name = "searchAndDestory_button";
            this.searchAndDestory_button.Size = new System.Drawing.Size(159, 43);
            this.searchAndDestory_button.TabIndex = 10;
            this.searchAndDestory_button.Text = "Search and Destroy";
            this.searchAndDestory_button.UseVisualStyleBackColor = false;
            // 
            // timer_button
            // 
            this.timer_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timer_button.Location = new System.Drawing.Point(578, 84);
            this.timer_button.Name = "timer_button";
            this.timer_button.Size = new System.Drawing.Size(75, 23);
            this.timer_button.TabIndex = 11;
            this.timer_button.Text = "Timer";
            this.timer_button.UseVisualStyleBackColor = true;
            this.timer_button.Visible = false;
            // 
            // angle_button
            // 
            this.angle_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.angle_button.Location = new System.Drawing.Point(659, 84);
            this.angle_button.Name = "angle_button";
            this.angle_button.Size = new System.Drawing.Size(75, 23);
            this.angle_button.TabIndex = 12;
            this.angle_button.Text = "Angle";
            this.angle_button.UseVisualStyleBackColor = true;
            this.angle_button.Visible = false;
            // 
            // kill_button
            // 
            this.kill_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kill_button.Location = new System.Drawing.Point(497, 84);
            this.kill_button.Name = "kill_button";
            this.kill_button.Size = new System.Drawing.Size(75, 23);
            this.kill_button.TabIndex = 13;
            this.kill_button.Text = "Kill";
            this.kill_button.UseVisualStyleBackColor = true;
            this.kill_button.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(444, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Number of Friends: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(444, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Number of Foes: ";
            // 
            // label_numFriends
            // 
            this.label_numFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_numFriends.AutoSize = true;
            this.label_numFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_numFriends.Location = new System.Drawing.Point(447, 282);
            this.label_numFriends.Name = "label_numFriends";
            this.label_numFriends.Size = new System.Drawing.Size(13, 13);
            this.label_numFriends.TabIndex = 16;
            this.label_numFriends.Text = "0";
            // 
            // label_numFoes
            // 
            this.label_numFoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_numFoes.AutoSize = true;
            this.label_numFoes.ForeColor = System.Drawing.Color.Red;
            this.label_numFoes.Location = new System.Drawing.Point(447, 336);
            this.label_numFoes.Name = "label_numFoes";
            this.label_numFoes.Size = new System.Drawing.Size(13, 13);
            this.label_numFoes.TabIndex = 17;
            this.label_numFoes.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(43, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Video Placeholder";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Target Name:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Target X-Pos:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Target Y-Pos:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Target Z-Pos:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Friend or Foe:";
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.Location = new System.Drawing.Point(293, 270);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(132, 20);
            this.textBox_name.TabIndex = 25;
            // 
            // textBox_x
            // 
            this.textBox_x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_x.Location = new System.Drawing.Point(293, 295);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(132, 20);
            this.textBox_x.TabIndex = 26;
            // 
            // textBox_y
            // 
            this.textBox_y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_y.Location = new System.Drawing.Point(293, 320);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(132, 20);
            this.textBox_y.TabIndex = 27;
            // 
            // textBox_z
            // 
            this.textBox_z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_z.Location = new System.Drawing.Point(293, 345);
            this.textBox_z.Name = "textBox_z";
            this.textBox_z.Size = new System.Drawing.Size(132, 20);
            this.textBox_z.TabIndex = 28;
            // 
            // textBox_friend
            // 
            this.textBox_friend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_friend.Location = new System.Drawing.Point(293, 370);
            this.textBox_friend.Name = "textBox_friend";
            this.textBox_friend.Size = new System.Drawing.Size(132, 20);
            this.textBox_friend.TabIndex = 29;
            // 
            // button_reset
            // 
            this.button_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reset.Location = new System.Drawing.Point(561, 193);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(159, 43);
            this.button_reset.TabIndex = 30;
            this.button_reset.Text = "Reset Position";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // moveTimer
            // 
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // Asml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(747, 411);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.textBox_friend);
            this.Controls.Add(this.textBox_z);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_numFoes);
            this.Controls.Add(this.label_numFriends);
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
            this.Controls.Add(this.listOfTargets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Asml";
            this.Text = "ASML - Level 100 Pikachus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label_numFriends;
        private System.Windows.Forms.Label label_numFoes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        public System.Windows.Forms.ListBox listOfTargets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_z;
        private System.Windows.Forms.TextBox textBox_friend;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Timer moveTimer;
    }
}

