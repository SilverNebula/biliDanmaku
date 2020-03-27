namespace biliDanmaku
{
    partial class infoMonitorForm
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label_target = new System.Windows.Forms.Label();
            this.label_fan = new System.Windows.Forms.Label();
            this.label_num = new System.Windows.Forms.Label();
            this.uidbox = new System.Windows.Forms.TextBox();
            this.fan_number = new System.Windows.Forms.Label();
            this.play_number = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.refresh_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_target
            // 
            this.label_target.AutoSize = true;
            this.label_target.Location = new System.Drawing.Point(29, 26);
            this.label_target.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_target.Name = "label_target";
            this.label_target.Size = new System.Drawing.Size(91, 15);
            this.label_target.TabIndex = 0;
            this.label_target.Text = "监控目标uid";
            // 
            // label_fan
            // 
            this.label_fan.AutoSize = true;
            this.label_fan.Location = new System.Drawing.Point(29, 74);
            this.label_fan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_fan.Name = "label_fan";
            this.label_fan.Size = new System.Drawing.Size(52, 15);
            this.label_fan.TabIndex = 1;
            this.label_fan.Text = "粉丝数";
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Location = new System.Drawing.Point(29, 122);
            this.label_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(52, 15);
            this.label_num.TabIndex = 2;
            this.label_num.Text = "播放量";
            // 
            // uidbox
            // 
            this.uidbox.Location = new System.Drawing.Point(255, 26);
            this.uidbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uidbox.Name = "uidbox";
            this.uidbox.Size = new System.Drawing.Size(95, 25);
            this.uidbox.TabIndex = 3;
            // 
            // fan_number
            // 
            this.fan_number.AutoSize = true;
            this.fan_number.Location = new System.Drawing.Point(113, 74);
            this.fan_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fan_number.Name = "fan_number";
            this.fan_number.Size = new System.Drawing.Size(55, 15);
            this.fan_number.TabIndex = 4;
            this.fan_number.Text = "label1";
            // 
            // play_number
            // 
            this.play_number.AutoSize = true;
            this.play_number.Location = new System.Drawing.Point(116, 122);
            this.play_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.play_number.Name = "play_number";
            this.play_number.Size = new System.Drawing.Size(55, 15);
            this.play_number.TabIndex = 5;
            this.play_number.Text = "label2";
            // 
            // uid
            // 
            this.uid.AutoSize = true;
            this.uid.Location = new System.Drawing.Point(132, 26);
            this.uid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(31, 15);
            this.uid.TabIndex = 6;
            this.uid.Text = "UID";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(255, 74);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(96, 29);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "Start!";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.UPD);
            // 
            // refresh_time
            // 
            this.refresh_time.AutoSize = true;
            this.refresh_time.Location = new System.Drawing.Point(275, 122);
            this.refresh_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refresh_time.Name = "refresh_time";
            this.refresh_time.Size = new System.Drawing.Size(39, 15);
            this.refresh_time.TabIndex = 8;
            this.refresh_time.Text = "time";
            // 
            // infoMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.refresh_time);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.uid);
            this.Controls.Add(this.play_number);
            this.Controls.Add(this.fan_number);
            this.Controls.Add(this.uidbox);
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.label_fan);
            this.Controls.Add(this.label_target);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "infoMonitorForm";
            this.Size = new System.Drawing.Size(400, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_target;
        private System.Windows.Forms.Label label_fan;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.TextBox uidbox;
        private System.Windows.Forms.Label fan_number;
        private System.Windows.Forms.Label play_number;
        private System.Windows.Forms.Label uid;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label refresh_time;
    }
}
