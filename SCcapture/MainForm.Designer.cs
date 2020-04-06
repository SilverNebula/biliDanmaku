namespace SCcapture
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.logBox1 = new biliDanmaku.LogBox();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Start.Location = new System.Drawing.Point(267, 29);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(128, 48);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "LinkStart";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Setting.Location = new System.Drawing.Point(267, 168);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(128, 48);
            this.btn_Setting.TabIndex = 1;
            this.btn_Setting.Text = "Setting";
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Open.Location = new System.Drawing.Point(267, 98);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(128, 48);
            this.btn_Open.TabIndex = 2;
            this.btn_Open.Text = "OpenPicture";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_test
            // 
            this.btn_test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_test.Location = new System.Drawing.Point(249, 223);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 4;
            this.btn_test.Text = "test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(229, 253);
            this.elementHost1.TabIndex = 3;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.logBox1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.btn_Start);
            this.Name = "MainForm";
            this.Text = "SCcapture";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private biliDanmaku.LogBox logBox1;
        private System.Windows.Forms.Button btn_test;
    }
}

