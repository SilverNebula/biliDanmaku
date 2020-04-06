namespace SCcapture
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label_roomid = new System.Windows.Forms.Label();
            this.label_picture = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Picture = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.label_min = new System.Windows.Forms.Label();
            this.tb_min = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_findpic = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_default = new System.Windows.Forms.Button();
            this.label_sound = new System.Windows.Forms.Label();
            this.tb_sound = new System.Windows.Forms.TextBox();
            this.btn_findsound = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.info1 = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.info3 = new System.Windows.Forms.Label();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.label_msg = new System.Windows.Forms.Label();
            this.info4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_roomid
            // 
            this.label_roomid.AutoSize = true;
            this.label_roomid.Location = new System.Drawing.Point(48, 38);
            this.label_roomid.Name = "label_roomid";
            this.label_roomid.Size = new System.Drawing.Size(55, 15);
            this.label_roomid.TabIndex = 0;
            this.label_roomid.Text = "RoomID";
            // 
            // label_picture
            // 
            this.label_picture.AutoSize = true;
            this.label_picture.Location = new System.Drawing.Point(48, 213);
            this.label_picture.Name = "label_picture";
            this.label_picture.Size = new System.Drawing.Size(63, 15);
            this.label_picture.TabIndex = 1;
            this.label_picture.Text = "Picture";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(48, 80);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(71, 15);
            this.label_time.TabIndex = 2;
            this.label_time.Text = "TimeSpan";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(270, 35);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(100, 25);
            this.tb_ID.TabIndex = 3;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            // 
            // tb_Picture
            // 
            this.tb_Picture.Location = new System.Drawing.Point(157, 210);
            this.tb_Picture.Name = "tb_Picture";
            this.tb_Picture.Size = new System.Drawing.Size(213, 25);
            this.tb_Picture.TabIndex = 4;
            this.tb_Picture.TextChanged += new System.EventHandler(this.tb_Picture_TextChanged);
            this.tb_Picture.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Picture_KeyDown);
            this.tb_Picture.Validated += new System.EventHandler(this.tb_Picture_Validated);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(134, 70);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(270, 77);
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(100, 25);
            this.tb_time.TabIndex = 5;
            this.tb_time.TextChanged += new System.EventHandler(this.tb_time_TextChanged);
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(48, 123);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(79, 15);
            this.label_min.TabIndex = 7;
            this.label_min.Text = "Min Value";
            // 
            // tb_min
            // 
            this.tb_min.Location = new System.Drawing.Point(270, 120);
            this.tb_min.Name = "tb_min";
            this.tb_min.Size = new System.Drawing.Size(100, 25);
            this.tb_min.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(51, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_findpic
            // 
            this.btn_findpic.Location = new System.Drawing.Point(410, 210);
            this.btn_findpic.Name = "btn_findpic";
            this.btn_findpic.Size = new System.Drawing.Size(75, 25);
            this.btn_findpic.TabIndex = 11;
            this.btn_findpic.Text = "find";
            this.btn_findpic.UseVisualStyleBackColor = true;
            this.btn_findpic.Click += new System.EventHandler(this.btn_findpic_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(646, 35);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 50);
            this.btn_OK.TabIndex = 12;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(646, 100);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 50);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_default
            // 
            this.btn_default.Location = new System.Drawing.Point(646, 165);
            this.btn_default.Name = "btn_default";
            this.btn_default.Size = new System.Drawing.Size(100, 50);
            this.btn_default.TabIndex = 14;
            this.btn_default.Text = "Default";
            this.btn_default.UseVisualStyleBackColor = true;
            this.btn_default.Click += new System.EventHandler(this.btn_default_Click);
            // 
            // label_sound
            // 
            this.label_sound.AutoSize = true;
            this.label_sound.Location = new System.Drawing.Point(48, 167);
            this.label_sound.Name = "label_sound";
            this.label_sound.Size = new System.Drawing.Size(47, 15);
            this.label_sound.TabIndex = 15;
            this.label_sound.Text = "Sound";
            // 
            // tb_sound
            // 
            this.tb_sound.Location = new System.Drawing.Point(157, 162);
            this.tb_sound.Name = "tb_sound";
            this.tb_sound.Size = new System.Drawing.Size(213, 25);
            this.tb_sound.TabIndex = 16;
            this.tb_sound.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btn_findsound
            // 
            this.btn_findsound.Location = new System.Drawing.Point(410, 162);
            this.btn_findsound.Name = "btn_findsound";
            this.btn_findsound.Size = new System.Drawing.Size(75, 25);
            this.btn_findsound.TabIndex = 17;
            this.btn_findsound.Text = "find";
            this.btn_findsound.UseVisualStyleBackColor = true;
            this.btn_findsound.Click += new System.EventHandler(this.btn_findsound_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(270, 256);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(100, 46);
            this.btn_play.TabIndex = 18;
            this.btn_play.Text = "Play sound";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Location = new System.Drawing.Point(407, 38);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(142, 15);
            this.info1.TabIndex = 19;
            this.info1.Text = "要连接的直播间编号";
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Location = new System.Drawing.Point(407, 80);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(121, 15);
            this.info2.TabIndex = 20;
            this.info2.Text = "动画显示时长(s)";
            // 
            // info3
            // 
            this.info3.AutoSize = true;
            this.info3.Location = new System.Drawing.Point(410, 122);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(158, 15);
            this.info3.TabIndex = 21;
            this.info3.Text = "触发动画的最小SC价格";
            // 
            // tb_Message
            // 
            this.tb_Message.Location = new System.Drawing.Point(424, 296);
            this.tb_Message.MaxLength = 1000;
            this.tb_Message.Multiline = true;
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.Size = new System.Drawing.Size(322, 53);
            this.tb_Message.TabIndex = 22;
            this.tb_Message.Text = "ID：{0}  金额：{1}   {2}";
            // 
            // label_msg
            // 
            this.label_msg.AutoSize = true;
            this.label_msg.Location = new System.Drawing.Point(422, 265);
            this.label_msg.Name = "label_msg";
            this.label_msg.Size = new System.Drawing.Size(63, 15);
            this.label_msg.TabIndex = 23;
            this.label_msg.Text = "Message";
            // 
            // info4
            // 
            this.info4.AutoSize = true;
            this.info4.Location = new System.Drawing.Point(421, 365);
            this.info4.Name = "info4";
            this.info4.Size = new System.Drawing.Size(328, 45);
            this.info4.TabIndex = 24;
            this.info4.Text = "收到SC时显示的文字,关键字{0}{1}{2}分别会被\r\n替换为用户ID，SC金额，消息内容。\r\n若不希望显示消息，该项请留空。";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info4);
            this.Controls.Add(this.label_msg);
            this.Controls.Add(this.tb_Message);
            this.Controls.Add(this.info3);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_findsound);
            this.Controls.Add(this.tb_sound);
            this.Controls.Add(this.label_sound);
            this.Controls.Add(this.btn_default);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_findpic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_min);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.tb_Picture);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_picture);
            this.Controls.Add(this.label_roomid);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_roomid;
        private System.Windows.Forms.Label label_picture;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Picture;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.TextBox tb_min;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_findpic;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_default;
        private System.Windows.Forms.Label label_sound;
        private System.Windows.Forms.TextBox tb_sound;
        private System.Windows.Forms.Button btn_findsound;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label info1;
        private System.Windows.Forms.Label info2;
        private System.Windows.Forms.Label info3;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.Label label_msg;
        private System.Windows.Forms.Label info4;
    }
}