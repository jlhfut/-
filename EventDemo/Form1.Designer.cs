namespace EventDemo
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIssueComputer = new System.Windows.Forms.Button();
            this.btnIssueLife = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkComputerZs = new System.Windows.Forms.CheckBox();
            this.chkLifeZs = new System.Windows.Forms.CheckBox();
            this.chkLifeLs = new System.Windows.Forms.CheckBox();
            this.chkComputerLs = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIssueLife);
            this.groupBox1.Controls.Add(this.btnIssueComputer);
            this.groupBox1.Location = new System.Drawing.Point(44, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "出版社";
            // 
            // btnIssueComputer
            // 
            this.btnIssueComputer.Location = new System.Drawing.Point(26, 45);
            this.btnIssueComputer.Name = "btnIssueComputer";
            this.btnIssueComputer.Size = new System.Drawing.Size(176, 49);
            this.btnIssueComputer.TabIndex = 0;
            this.btnIssueComputer.Text = "发行刊物《电脑》";
            this.btnIssueComputer.UseVisualStyleBackColor = true;
            this.btnIssueComputer.Click += new System.EventHandler(this.btnIssueComputer_Click);
            // 
            // btnIssueLife
            // 
            this.btnIssueLife.Location = new System.Drawing.Point(351, 45);
            this.btnIssueLife.Name = "btnIssueLife";
            this.btnIssueLife.Size = new System.Drawing.Size(167, 49);
            this.btnIssueLife.TabIndex = 1;
            this.btnIssueLife.Text = "发行刊物《生活》";
            this.btnIssueLife.UseVisualStyleBackColor = true;
            this.btnIssueLife.Click += new System.EventHandler(this.btnIssueLife_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkLifeZs);
            this.groupBox2.Controls.Add(this.chkComputerZs);
            this.groupBox2.Location = new System.Drawing.Point(64, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户张三";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkLifeLs);
            this.groupBox3.Controls.Add(this.chkComputerLs);
            this.groupBox3.Location = new System.Drawing.Point(395, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 153);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "用户李四";
            // 
            // chkComputerZs
            // 
            this.chkComputerZs.AutoSize = true;
            this.chkComputerZs.Location = new System.Drawing.Point(20, 43);
            this.chkComputerZs.Name = "chkComputerZs";
            this.chkComputerZs.Size = new System.Drawing.Size(149, 19);
            this.chkComputerZs.TabIndex = 0;
            this.chkComputerZs.Text = "订阅刊物《电脑》";
            this.chkComputerZs.UseVisualStyleBackColor = true;
            this.chkComputerZs.CheckedChanged += new System.EventHandler(this.chkComputerZs_CheckedChanged);
            // 
            // chkLifeZs
            // 
            this.chkLifeZs.AutoSize = true;
            this.chkLifeZs.Location = new System.Drawing.Point(20, 93);
            this.chkLifeZs.Name = "chkLifeZs";
            this.chkLifeZs.Size = new System.Drawing.Size(149, 19);
            this.chkLifeZs.TabIndex = 1;
            this.chkLifeZs.Text = "订阅刊物《生活》";
            this.chkLifeZs.UseVisualStyleBackColor = true;
            this.chkLifeZs.CheckedChanged += new System.EventHandler(this.chkLifeZs_CheckedChanged);
            // 
            // chkLifeLs
            // 
            this.chkLifeLs.AutoSize = true;
            this.chkLifeLs.Location = new System.Drawing.Point(31, 92);
            this.chkLifeLs.Name = "chkLifeLs";
            this.chkLifeLs.Size = new System.Drawing.Size(149, 19);
            this.chkLifeLs.TabIndex = 3;
            this.chkLifeLs.Text = "订阅刊物《生活》";
            this.chkLifeLs.UseVisualStyleBackColor = true;
            this.chkLifeLs.CheckedChanged += new System.EventHandler(this.chkLifeLs_CheckedChanged);
            // 
            // chkComputerLs
            // 
            this.chkComputerLs.AutoSize = true;
            this.chkComputerLs.Location = new System.Drawing.Point(31, 42);
            this.chkComputerLs.Name = "chkComputerLs";
            this.chkComputerLs.Size = new System.Drawing.Size(149, 19);
            this.chkComputerLs.TabIndex = 2;
            this.chkComputerLs.Text = "订阅刊物《电脑》";
            this.chkComputerLs.UseVisualStyleBackColor = true;
            this.chkComputerLs.CheckedChanged += new System.EventHandler(this.chkComputerLs_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIssueLife;
        private System.Windows.Forms.Button btnIssueComputer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkLifeZs;
        private System.Windows.Forms.CheckBox chkComputerZs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkLifeLs;
        private System.Windows.Forms.CheckBox chkComputerLs;
    }
}

