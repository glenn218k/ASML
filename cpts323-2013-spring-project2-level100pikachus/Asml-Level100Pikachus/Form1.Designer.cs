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
            this.up_button = new System.Windows.Forms.Button();
            this.right_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.fire_button = new System.Windows.Forms.Button();
            this.searchAndDestory_button = new System.Windows.Forms.Button();
            this.kill_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_reset = new System.Windows.Forms.Button();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.radioButton_friendandfoe = new System.Windows.Forms.RadioButton();
            this.radioButton_foe = new System.Windows.Forms.RadioButton();
            this.radioButton_friend = new System.Windows.Forms.RadioButton();
            this.label_timer = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.label_timerTime = new System.Windows.Forms.Label();
            this.label_positionPosition = new System.Windows.Forms.Label();
            this.pictureBox_videoFeed = new System.Windows.Forms.PictureBox();
            this.button_startVideo = new System.Windows.Forms.Button();
            this.imageTimer = new System.Windows.Forms.Timer(this.components);
            this.searchAndDestroyTimer = new System.Windows.Forms.Timer(this.components);
            this.button_stopVideo = new System.Windows.Forms.Button();
            this.label_live = new System.Windows.Forms.Label();
            this.label_friend = new System.Windows.Forms.Label();
            this.label_z = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_numFoes = new System.Windows.Forms.Label();
            this.label_numFriends = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listOfTargets = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_liveVideo = new System.Windows.Forms.CheckBox();
            this.button_moveTo = new System.Windows.Forms.Button();
            this.label_bullets = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_videoFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1177, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version 2.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level 100 Pikachus";
            // 
            // up_button
            // 
            this.up_button.Location = new System.Drawing.Point(1089, 475);
            this.up_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(60, 52);
            this.up_button.TabIndex = 5;
            this.up_button.Text = "Up";
            this.up_button.UseVisualStyleBackColor = true;
            this.up_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.up_button_Down);
            this.up_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.up_button_Up);
            // 
            // right_button
            // 
            this.right_button.Location = new System.Drawing.Point(1165, 533);
            this.right_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(60, 52);
            this.right_button.TabIndex = 6;
            this.right_button.Text = "Right";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.right_button_Down);
            this.right_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.right_button_Up);
            // 
            // left_button
            // 
            this.left_button.Location = new System.Drawing.Point(1012, 533);
            this.left_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(60, 52);
            this.left_button.TabIndex = 7;
            this.left_button.Text = "Left";
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.left_button_Down);
            this.left_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.left_button_Up);
            // 
            // down_button
            // 
            this.down_button.Location = new System.Drawing.Point(1089, 591);
            this.down_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(60, 52);
            this.down_button.TabIndex = 8;
            this.down_button.Text = "Down";
            this.down_button.UseVisualStyleBackColor = true;
            this.down_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.down_button_Down);
            this.down_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.down_button_Up);
            // 
            // fire_button
            // 
            this.fire_button.Cursor = System.Windows.Forms.Cursors.No;
            this.fire_button.Location = new System.Drawing.Point(1089, 533);
            this.fire_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fire_button.Name = "fire_button";
            this.fire_button.Size = new System.Drawing.Size(60, 52);
            this.fire_button.TabIndex = 9;
            this.fire_button.Text = "Fire";
            this.fire_button.UseVisualStyleBackColor = true;
            this.fire_button.Click += new System.EventHandler(this.fire_button_Click);
            // 
            // searchAndDestory_button
            // 
            this.searchAndDestory_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchAndDestory_button.BackColor = System.Drawing.Color.Red;
            this.searchAndDestory_button.Location = new System.Drawing.Point(1037, 364);
            this.searchAndDestory_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchAndDestory_button.Name = "searchAndDestory_button";
            this.searchAndDestory_button.Size = new System.Drawing.Size(213, 53);
            this.searchAndDestory_button.TabIndex = 10;
            this.searchAndDestory_button.Text = "Start Search and Destroy";
            this.searchAndDestory_button.UseVisualStyleBackColor = false;
            this.searchAndDestory_button.Click += new System.EventHandler(this.searchAndDestory_button_Click);
            // 
            // kill_button
            // 
            this.kill_button.Location = new System.Drawing.Point(1037, 420);
            this.kill_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kill_button.Name = "kill_button";
            this.kill_button.Size = new System.Drawing.Size(213, 38);
            this.kill_button.TabIndex = 13;
            this.kill_button.Text = "Stop Search and Destroy";
            this.kill_button.UseVisualStyleBackColor = true;
            this.kill_button.Click += new System.EventHandler(this.kill_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1273, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(885, 418);
            this.button_reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(127, 41);
            this.button_reset.TabIndex = 30;
            this.button_reset.Text = "Reset Position";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // moveTimer
            // 
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // radioButton_friendandfoe
            // 
            this.radioButton_friendandfoe.Location = new System.Drawing.Point(1103, 334);
            this.radioButton_friendandfoe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_friendandfoe.Name = "radioButton_friendandfoe";
            this.radioButton_friendandfoe.Size = new System.Drawing.Size(139, 23);
            this.radioButton_friendandfoe.TabIndex = 37;
            this.radioButton_friendandfoe.TabStop = true;
            this.radioButton_friendandfoe.Text = "Friend and Foe";
            this.radioButton_friendandfoe.UseVisualStyleBackColor = true;
            // 
            // radioButton_foe
            // 
            this.radioButton_foe.AutoSize = true;
            this.radioButton_foe.Checked = true;
            this.radioButton_foe.Location = new System.Drawing.Point(1183, 305);
            this.radioButton_foe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_foe.Name = "radioButton_foe";
            this.radioButton_foe.Size = new System.Drawing.Size(53, 21);
            this.radioButton_foe.TabIndex = 35;
            this.radioButton_foe.TabStop = true;
            this.radioButton_foe.Text = "Foe";
            this.radioButton_foe.UseVisualStyleBackColor = true;
            // 
            // radioButton_friend
            // 
            this.radioButton_friend.AutoSize = true;
            this.radioButton_friend.Location = new System.Drawing.Point(1103, 305);
            this.radioButton_friend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_friend.Name = "radioButton_friend";
            this.radioButton_friend.Size = new System.Drawing.Size(69, 21);
            this.radioButton_friend.TabIndex = 36;
            this.radioButton_friend.TabStop = true;
            this.radioButton_friend.Text = "Friend";
            this.radioButton_friend.UseVisualStyleBackColor = true;
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.Location = new System.Drawing.Point(1141, 114);
            this.label_timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(67, 25);
            this.label_timer.TabIndex = 38;
            this.label_timer.Text = "Timer";
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_position.Location = new System.Drawing.Point(1133, 174);
            this.label_position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(89, 25);
            this.label_position.TabIndex = 39;
            this.label_position.Text = "Position";
            // 
            // label_timerTime
            // 
            this.label_timerTime.AutoSize = true;
            this.label_timerTime.Location = new System.Drawing.Point(1147, 146);
            this.label_timerTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timerTime.Name = "label_timerTime";
            this.label_timerTime.Size = new System.Drawing.Size(64, 17);
            this.label_timerTime.TabIndex = 40;
            this.label_timerTime.Text = "00:00:00";
            // 
            // label_positionPosition
            // 
            this.label_positionPosition.AutoSize = true;
            this.label_positionPosition.Location = new System.Drawing.Point(1139, 207);
            this.label_positionPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_positionPosition.Name = "label_positionPosition";
            this.label_positionPosition.Size = new System.Drawing.Size(94, 17);
            this.label_positionPosition.TabIndex = 41;
            this.label_positionPosition.Text = "( 0.00 , 0.00 )";
            // 
            // pictureBox_videoFeed
            // 
            this.pictureBox_videoFeed.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_videoFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_videoFeed.Location = new System.Drawing.Point(27, 57);
            this.pictureBox_videoFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_videoFeed.Name = "pictureBox_videoFeed";
            this.pictureBox_videoFeed.Size = new System.Drawing.Size(851, 590);
            this.pictureBox_videoFeed.TabIndex = 42;
            this.pictureBox_videoFeed.TabStop = false;
            // 
            // button_startVideo
            // 
            this.button_startVideo.Location = new System.Drawing.Point(885, 466);
            this.button_startVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_startVideo.Name = "button_startVideo";
            this.button_startVideo.Size = new System.Drawing.Size(88, 81);
            this.button_startVideo.TabIndex = 43;
            this.button_startVideo.Text = "Start Live Video";
            this.button_startVideo.UseVisualStyleBackColor = true;
            this.button_startVideo.Click += new System.EventHandler(this.button_startVideo_Click);
            // 
            // imageTimer
            // 
            this.imageTimer.Tick += new System.EventHandler(this.imageTimer_Tick);
            // 
            // searchAndDestroyTimer
            // 
            this.searchAndDestroyTimer.Interval = 1;
            this.searchAndDestroyTimer.Tick += new System.EventHandler(this.searchAndDestoryTimer_Tick);
            // 
            // button_stopVideo
            // 
            this.button_stopVideo.Location = new System.Drawing.Point(885, 555);
            this.button_stopVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_stopVideo.Name = "button_stopVideo";
            this.button_stopVideo.Size = new System.Drawing.Size(88, 81);
            this.button_stopVideo.TabIndex = 44;
            this.button_stopVideo.Text = "Stop Live Video";
            this.button_stopVideo.UseVisualStyleBackColor = true;
            this.button_stopVideo.Click += new System.EventHandler(this.button_stopVideo_Click);
            // 
            // label_live
            // 
            this.label_live.AutoSize = true;
            this.label_live.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_live.ForeColor = System.Drawing.Color.Black;
            this.label_live.Location = new System.Drawing.Point(27, 33);
            this.label_live.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_live.Name = "label_live";
            this.label_live.Size = new System.Drawing.Size(79, 17);
            this.label_live.TabIndex = 45;
            this.label_live.Text = "NOT LIVE";
            // 
            // label_friend
            // 
            this.label_friend.AutoSize = true;
            this.label_friend.Location = new System.Drawing.Point(989, 353);
            this.label_friend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_friend.Name = "label_friend";
            this.label_friend.Size = new System.Drawing.Size(52, 17);
            this.label_friend.TabIndex = 65;
            this.label_friend.Text = " Friend";
            // 
            // label_z
            // 
            this.label_z.AutoSize = true;
            this.label_z.Location = new System.Drawing.Point(989, 322);
            this.label_z.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_z.Name = "label_z";
            this.label_z.Size = new System.Drawing.Size(50, 17);
            this.label_z.TabIndex = 64;
            this.label_z.Text = " Z-Pos";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(989, 292);
            this.label_y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(50, 17);
            this.label_y.TabIndex = 63;
            this.label_y.Text = " Y-Pos";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(989, 261);
            this.label_x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(50, 17);
            this.label_x.TabIndex = 62;
            this.label_x.Text = " X-Pos";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(989, 230);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(45, 17);
            this.label_name.TabIndex = 61;
            this.label_name.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(885, 353);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "Friend or Foe:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(885, 322);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Target Z-Pos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(885, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Target Y-Pos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(885, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "Target X-Pos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(885, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Target Name:";
            // 
            // label_numFoes
            // 
            this.label_numFoes.AutoSize = true;
            this.label_numFoes.ForeColor = System.Drawing.Color.Red;
            this.label_numFoes.Location = new System.Drawing.Point(1217, 76);
            this.label_numFoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_numFoes.Name = "label_numFoes";
            this.label_numFoes.Size = new System.Drawing.Size(16, 17);
            this.label_numFoes.TabIndex = 55;
            this.label_numFoes.Text = "0";
            // 
            // label_numFriends
            // 
            this.label_numFriends.AutoSize = true;
            this.label_numFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_numFriends.Location = new System.Drawing.Point(1233, 60);
            this.label_numFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_numFriends.Name = "label_numFriends";
            this.label_numFriends.Size = new System.Drawing.Size(16, 17);
            this.label_numFriends.TabIndex = 54;
            this.label_numFriends.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1103, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Number of Foes: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1103, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Number of Friends: ";
            // 
            // listOfTargets
            // 
            this.listOfTargets.FormattingEnabled = true;
            this.listOfTargets.ItemHeight = 16;
            this.listOfTargets.Location = new System.Drawing.Point(885, 57);
            this.listOfTargets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listOfTargets.Name = "listOfTargets";
            this.listOfTargets.Size = new System.Drawing.Size(204, 164);
            this.listOfTargets.TabIndex = 51;
            this.listOfTargets.SelectedIndexChanged += new System.EventHandler(this.listOfTargets_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1091, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 55);
            this.label5.TabIndex = 66;
            this.label5.Text = "Search and Destroy Mode";
            // 
            // checkBox_liveVideo
            // 
            this.checkBox_liveVideo.AutoSize = true;
            this.checkBox_liveVideo.Location = new System.Drawing.Point(885, 17);
            this.checkBox_liveVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_liveVideo.Name = "checkBox_liveVideo";
            this.checkBox_liveVideo.Size = new System.Drawing.Size(223, 21);
            this.checkBox_liveVideo.TabIndex = 67;
            this.checkBox_liveVideo.Text = "Acquire Targets via Live Video";
            this.checkBox_liveVideo.UseVisualStyleBackColor = true;
            // 
            // button_moveTo
            // 
            this.button_moveTo.Enabled = false;
            this.button_moveTo.Location = new System.Drawing.Point(991, 475);
            this.button_moveTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_moveTo.Name = "button_moveTo";
            this.button_moveTo.Size = new System.Drawing.Size(81, 37);
            this.button_moveTo.TabIndex = 68;
            this.button_moveTo.Text = "Move To";
            this.button_moveTo.UseVisualStyleBackColor = true;
            this.button_moveTo.Visible = false;
            this.button_moveTo.Click += new System.EventHandler(this.button_moveTo_Click);
            // 
            // label_bullets
            // 
            this.label_bullets.AutoSize = true;
            this.label_bullets.ForeColor = System.Drawing.Color.Black;
            this.label_bullets.Location = new System.Drawing.Point(1228, 95);
            this.label_bullets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_bullets.Name = "label_bullets";
            this.label_bullets.Size = new System.Drawing.Size(16, 17);
            this.label_bullets.TabIndex = 70;
            this.label_bullets.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(1103, 95);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 17);
            this.label12.TabIndex = 69;
            this.label12.Text = "Number of Bullets: ";
            // 
            // Asml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1273, 661);
            this.Controls.Add(this.label_bullets);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_moveTo);
            this.Controls.Add(this.checkBox_liveVideo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_friend);
            this.Controls.Add(this.label_z);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_numFoes);
            this.Controls.Add(this.label_numFriends);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listOfTargets);
            this.Controls.Add(this.label_live);
            this.Controls.Add(this.button_stopVideo);
            this.Controls.Add(this.button_startVideo);
            this.Controls.Add(this.pictureBox_videoFeed);
            this.Controls.Add(this.label_positionPosition);
            this.Controls.Add(this.label_timerTime);
            this.Controls.Add(this.label_position);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.radioButton_friendandfoe);
            this.Controls.Add(this.radioButton_foe);
            this.Controls.Add(this.radioButton_friend);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.kill_button);
            this.Controls.Add(this.searchAndDestory_button);
            this.Controls.Add(this.fire_button);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.left_button);
            this.Controls.Add(this.right_button);
            this.Controls.Add(this.up_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Asml";
            this.Text = "ASML - Level 100 Pikachus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_videoFeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Button fire_button;
        private System.Windows.Forms.Button searchAndDestory_button;
        private System.Windows.Forms.Button kill_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.RadioButton radioButton_friendandfoe;
        private System.Windows.Forms.RadioButton radioButton_foe;
        private System.Windows.Forms.RadioButton radioButton_friend;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label_timerTime;
        private System.Windows.Forms.Label label_positionPosition;
        private System.Windows.Forms.PictureBox pictureBox_videoFeed;
        private System.Windows.Forms.Button button_startVideo;
        private System.Windows.Forms.Timer imageTimer;
        private System.Windows.Forms.Timer searchAndDestroyTimer;
        private System.Windows.Forms.Button button_stopVideo;
        private System.Windows.Forms.Label label_live;
        private System.Windows.Forms.Label label_friend;
        private System.Windows.Forms.Label label_z;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_numFoes;
        private System.Windows.Forms.Label label_numFriends;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listOfTargets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_liveVideo;
        private System.Windows.Forms.Button button_moveTo;
        private System.Windows.Forms.Label label_bullets;
        private System.Windows.Forms.Label label12;
    }
}

