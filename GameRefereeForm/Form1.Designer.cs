namespace GameRefereeForm
{
    partial class GameRefereeController
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_add1 = new System.Windows.Forms.Button();
            this.label_team1 = new System.Windows.Forms.Label();
            this.label_team2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_team1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_team1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_team2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_team2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_add1
            // 
            this.button_add1.Location = new System.Drawing.Point(140, 231);
            this.button_add1.Name = "button_add1";
            this.button_add1.Size = new System.Drawing.Size(75, 23);
            this.button_add1.TabIndex = 0;
            this.button_add1.Text = "添加球员";
            this.button_add1.UseVisualStyleBackColor = true;
            this.button_add1.Click += new System.EventHandler(this.button_add1_Click);
            // 
            // label_team1
            // 
            this.label_team1.AutoSize = true;
            this.label_team1.Location = new System.Drawing.Point(23, 39);
            this.label_team1.Name = "label_team1";
            this.label_team1.Size = new System.Drawing.Size(52, 15);
            this.label_team1.TabIndex = 1;
            this.label_team1.Text = "球队名";
            // 
            // label_team2
            // 
            this.label_team2.AutoSize = true;
            this.label_team2.Location = new System.Drawing.Point(19, 39);
            this.label_team2.Name = "label_team2";
            this.label_team2.Size = new System.Drawing.Size(67, 15);
            this.label_team2.TabIndex = 2;
            this.label_team2.Text = "球队名称";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_team1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_add1);
            this.groupBox1.Controls.Add(this.textBox_team1);
            this.groupBox1.Controls.Add(this.label_team1);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 291);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listBox_team1
            // 
            this.listBox_team1.FormattingEnabled = true;
            this.listBox_team1.ItemHeight = 15;
            this.listBox_team1.Location = new System.Drawing.Point(95, 74);
            this.listBox_team1.Name = "listBox_team1";
            this.listBox_team1.Size = new System.Drawing.Size(120, 94);
            this.listBox_team1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "球员";
            // 
            // textBox_team1
            // 
            this.textBox_team1.Location = new System.Drawing.Point(95, 29);
            this.textBox_team1.Name = "textBox_team1";
            this.textBox_team1.Size = new System.Drawing.Size(100, 25);
            this.textBox_team1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_team2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_team2);
            this.groupBox2.Controls.Add(this.label_team2);
            this.groupBox2.Location = new System.Drawing.Point(270, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 291);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // listBox_team2
            // 
            this.listBox_team2.FormattingEnabled = true;
            this.listBox_team2.ItemHeight = 15;
            this.listBox_team2.Location = new System.Drawing.Point(94, 74);
            this.listBox_team2.Name = "listBox_team2";
            this.listBox_team2.Size = new System.Drawing.Size(120, 94);
            this.listBox_team2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "球员";
            // 
            // textBox_team2
            // 
            this.textBox_team2.Location = new System.Drawing.Point(94, 28);
            this.textBox_team2.Name = "textBox_team2";
            this.textBox_team2.Size = new System.Drawing.Size(100, 25);
            this.textBox_team2.TabIndex = 3;
            // 
            // GameRefereeController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GameRefereeController";
            this.Text = "控制台";
            this.Load += new System.EventHandler(this.GameRefereeController_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add1;
        private System.Windows.Forms.Label label_team1;
        private System.Windows.Forms.Label label_team2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_team1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_team1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox_team2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_team2;
    }
}

