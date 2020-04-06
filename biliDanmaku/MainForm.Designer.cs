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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RoomID = new System.Windows.Forms.TextBox();
            this.basicLink = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_fold = new System.Windows.Forms.Button();
            this.textFilterForm1 = new biliDanmaku.TextFilterForm();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.logBox1 = new biliDanmaku.LogBox();
            this.infoMonitorForm1 = new biliDanmaku.infoMonitorForm();
            this.button_help = new System.Windows.Forms.Button();
            this.label_sign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RoomID
            // 
            this.RoomID.Location = new System.Drawing.Point(247, 35);
            this.RoomID.Margin = new System.Windows.Forms.Padding(2);
            this.RoomID.MaxLength = 80;
            this.RoomID.Name = "RoomID";
            this.RoomID.Size = new System.Drawing.Size(76, 25);
            this.RoomID.TabIndex = 0;
            // 
            // basicLink
            // 
            this.basicLink.AutoSize = true;
            this.basicLink.BackColor = System.Drawing.Color.Transparent;
            this.basicLink.Location = new System.Drawing.Point(9, 38);
            this.basicLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.basicLink.Name = "basicLink";
            this.basicLink.Size = new System.Drawing.Size(103, 15);
            this.basicLink.TabIndex = 1;
            this.basicLink.Text = "liveroomLink";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(339, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.LinkStartAsync);
            // 
            // btn_fold
            // 
            this.btn_fold.Location = new System.Drawing.Point(510, 29);
            this.btn_fold.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fold.Name = "btn_fold";
            this.btn_fold.Size = new System.Drawing.Size(53, 35);
            this.btn_fold.TabIndex = 7;
            this.btn_fold.Text = "rua";
            this.btn_fold.UseVisualStyleBackColor = true;
            this.btn_fold.Click += new System.EventHandler(this.btn_fold_Click);
            // 
            // textFilterForm1
            // 
            this.textFilterForm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFilterForm1.AutoScroll = true;
            this.textFilterForm1.BackColor = System.Drawing.Color.Transparent;
            this.textFilterForm1.Location = new System.Drawing.Point(399, 182);
            this.textFilterForm1.Margin = new System.Windows.Forms.Padding(2);
            this.textFilterForm1.Name = "textFilterForm1";
            this.textFilterForm1.Size = new System.Drawing.Size(538, 334);
            this.textFilterForm1.TabIndex = 4;
            this.textFilterForm1.Load += new System.EventHandler(this.textFilterForm1_Load);
            // 
            // elementHost1
            // 
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.elementHost1.BackColor = System.Drawing.Color.Transparent;
            this.elementHost1.Location = new System.Drawing.Point(50, 89);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(2);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(302, 409);
            this.elementHost1.TabIndex = 6;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.logBox1;
            // 
            // infoMonitorForm1
            // 
            this.infoMonitorForm1.BackColor = System.Drawing.Color.Transparent;
            this.infoMonitorForm1.Location = new System.Drawing.Point(569, 13);
            this.infoMonitorForm1.Margin = new System.Windows.Forms.Padding(4);
            this.infoMonitorForm1.Name = "infoMonitorForm1";
            this.infoMonitorForm1.Size = new System.Drawing.Size(368, 200);
            this.infoMonitorForm1.TabIndex = 5;
            // 
            // button_help
            // 
            this.button_help.Location = new System.Drawing.Point(510, 76);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(35, 35);
            this.button_help.TabIndex = 8;
            this.button_help.Text = "i";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // label_sign
            // 
            this.label_sign.AutoSize = true;
            this.label_sign.BackColor = System.Drawing.Color.Transparent;
            this.label_sign.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_sign.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_sign.ForeColor = System.Drawing.Color.Black;
            this.label_sign.Location = new System.Drawing.Point(0, 534);
            this.label_sign.Name = "label_sign";
            this.label_sign.Size = new System.Drawing.Size(280, 19);
            this.label_sign.TabIndex = 9;
            this.label_sign.Text = "By 花园猫救援队-绘夜SilverN QQ893325022";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(952, 553);
            this.Controls.Add(this.label_sign);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.btn_fold);
            this.Controls.Add(this.textFilterForm1);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.infoMonitorForm1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.basicLink);
            this.Controls.Add(this.RoomID);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "CatSerena 行车记录仪";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RoomID;
        private System.Windows.Forms.Label basicLink;
        private System.Windows.Forms.Button button1;
        private TextFilterForm textFilterForm1;
        private infoMonitorForm infoMonitorForm1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LogBox logBox1;
        private System.Windows.Forms.Button btn_fold;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Label label_sign;
    }
}

