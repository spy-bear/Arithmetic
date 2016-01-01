using System;

namespace 四则运算
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
            this.timeControlText = new System.Windows.Forms.TextBox();
            this.timeControlLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.operatorlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.helpBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeControlText);
            this.groupBox1.Controls.Add(this.timeControlLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "时间";
            // 
            // timeControlText
            // 
            this.timeControlText.Enabled = false;
            this.timeControlText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeControlText.Location = new System.Drawing.Point(85, 19);
            this.timeControlText.Name = "timeControlText";
            this.timeControlText.Size = new System.Drawing.Size(23, 26);
            this.timeControlText.TabIndex = 1;
            this.timeControlText.Text = "60";
            // 
            // timeControlLabel
            // 
            this.timeControlLabel.AutoSize = true;
            this.timeControlLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeControlLabel.Font = new System.Drawing.Font("宋体", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeControlLabel.Location = new System.Drawing.Point(26, 21);
            this.timeControlLabel.Name = "timeControlLabel";
            this.timeControlLabel.Size = new System.Drawing.Size(53, 19);
            this.timeControlLabel.TabIndex = 0;
            this.timeControlLabel.Text = "Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.operatorlabel);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(13, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运算区";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(251, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 21);
            this.textBox3.TabIndex = 4;
            this.textBox3.KeyPress += TextBox3_KeyPress;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(137, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 21);
            this.textBox2.TabIndex = 2;
            // 
            // operatorlabel
            // 
            this.operatorlabel.AutoSize = true;
            this.operatorlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorlabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.operatorlabel.Location = new System.Drawing.Point(115, 54);
            this.operatorlabel.Name = "operatorlabel";
            this.operatorlabel.Size = new System.Drawing.Size(16, 16);
            this.operatorlabel.TabIndex = 1;
            this.operatorlabel.Text = "+";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(30, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.helpBtn);
            this.groupBox3.Controls.Add(this.pauseBtn);
            this.groupBox3.Controls.Add(this.startBtn);
            this.groupBox3.Controls.Add(this.divBtn);
            this.groupBox3.Controls.Add(this.mulBtn);
            this.groupBox3.Controls.Add(this.subBtn);
            this.groupBox3.Controls.Add(this.addBtn);
            this.groupBox3.Location = new System.Drawing.Point(13, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作区";
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(188, 54);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(62, 32);
            this.helpBtn.TabIndex = 6;
            this.helpBtn.Text = "说明";
            this.helpBtn.UseVisualStyleBackColor = true;
            // 
            // pauseBtn
            // 
            this.pauseBtn.Enabled = false;
            this.pauseBtn.Location = new System.Drawing.Point(188, 126);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(62, 35);
            this.pauseBtn.TabIndex = 5;
            this.pauseBtn.Text = "PAUSE";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(275, 54);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(62, 107);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(118, 126);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(44, 35);
            this.divBtn.TabIndex = 3;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.Location = new System.Drawing.Point(118, 54);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(44, 32);
            this.mulBtn.TabIndex = 2;
            this.mulBtn.Text = "*";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(51, 126);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(46, 35);
            this.subBtn.TabIndex = 1;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(51, 54);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(46, 32);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 383);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "四则运算";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label operatorlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox timeControlText;
        private System.Windows.Forms.Label timeControlLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button addBtn;
    }
}

