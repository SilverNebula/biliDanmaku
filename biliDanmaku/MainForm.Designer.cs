namespace biliDanmaku
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.RoomID = new System.Windows.Forms.TextBox();
            this.basicLink = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MainLog = new System.Windows.Forms.TextBox();
            this.textFilterForm1 = new biliDanmaku.TextFilterForm();
            this.SuspendLayout();
            // 
            // RoomID
            // 
            this.RoomID.Location = new System.Drawing.Point(288, 45);
            this.RoomID.MaxLength = 80;
            this.RoomID.Name = "RoomID";
            this.RoomID.Size = new System.Drawing.Size(100, 25);
            this.RoomID.TabIndex = 0;
            // 
            // basicLink
            // 
            this.basicLink.AutoSize = true;
            this.basicLink.Location = new System.Drawing.Point(12, 48);
            this.basicLink.Name = "basicLink";
            this.basicLink.Size = new System.Drawing.Size(103, 15);
            this.basicLink.TabIndex = 1;
            this.basicLink.Text = "liveroomLink";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LinkStart);
            // 
            // MainLog
            // 
            this.MainLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainLog.Location = new System.Drawing.Point(58, 106);
            this.MainLog.Multiline = true;
            this.MainLog.Name = "MainLog";
            this.MainLog.Size = new System.Drawing.Size(374, 447);
            this.MainLog.TabIndex = 3;
            // 
            // textFilterForm1
            // 
            this.textFilterForm1.Location = new System.Drawing.Point(462, 106);
            this.textFilterForm1.Name = "textFilterForm1";
            this.textFilterForm1.Size = new System.Drawing.Size(508, 398);
            this.textFilterForm1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.textFilterForm1);
            this.Controls.Add(this.MainLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.basicLink);
            this.Controls.Add(this.RoomID);
            this.Name = "MainForm";
            this.Text = "主界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RoomID;
        private System.Windows.Forms.Label basicLink;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MainLog;
        private TextFilterForm textFilterForm1;
    }
}

