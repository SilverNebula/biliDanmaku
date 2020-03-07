namespace biliDanmaku
{
    partial class TextFilterForm
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.addName = new System.Windows.Forms.TextBox();
            this.TargetList = new System.Windows.Forms.ListView();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(27, 36);
            this.addName.Margin = new System.Windows.Forms.Padding(2);
            this.addName.MaxLength = 50;
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(76, 21);
            this.addName.TabIndex = 0;
            // 
            // TargetList
            // 
            this.TargetList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TargetList.HideSelection = false;
            this.TargetList.Location = new System.Drawing.Point(27, 90);
            this.TargetList.Margin = new System.Windows.Forms.Padding(2);
            this.TargetList.Name = "TargetList";
            this.TargetList.Size = new System.Drawing.Size(146, 209);
            this.TargetList.TabIndex = 1;
            this.TargetList.UseCompatibleStateImageBehavior = false;
            this.TargetList.View = System.Windows.Forms.View.List;
            this.TargetList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TargetList_Keydown);
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.Location = new System.Drawing.Point(196, 73);
            this.LogBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogBox.MaxLength = 65535;
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(157, 226);
            this.LogBox.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(116, 35);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(65, 21);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "添加监控";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(220, 35);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(132, 21);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "保存记录";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(27, 67);
            this.check1.Margin = new System.Windows.Forms.Padding(2);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(84, 16);
            this.check1.TabIndex = 5;
            this.check1.Text = "捕捉大括号";
            this.check1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(105, 67);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "捕捉ID";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TextFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.TargetList);
            this.Controls.Add(this.addName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TextFilterForm";
            this.Size = new System.Drawing.Size(381, 318);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.ListView TargetList;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
