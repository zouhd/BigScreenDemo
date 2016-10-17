namespace FenXingFormDemo
{
    partial class ConsoleScreen
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
            this.button_bigscreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_bigscreen
            // 
            this.button_bigscreen.Location = new System.Drawing.Point(123, 190);
            this.button_bigscreen.Name = "button_bigscreen";
            this.button_bigscreen.Size = new System.Drawing.Size(75, 23);
            this.button_bigscreen.TabIndex = 0;
            this.button_bigscreen.Text = "大屏";
            this.button_bigscreen.UseVisualStyleBackColor = true;
            this.button_bigscreen.Click += new System.EventHandler(this.button_bigscreen_Click);
            // 
            // ConsoleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_bigscreen);
            this.Name = "ConsoleScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_bigscreen;
    }
}

