namespace MyControl
{
    partial class SexControl
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
            this.cBoxman = new System.Windows.Forms.CheckBox();
            this.cBoxwoman = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cBoxman
            // 
            this.cBoxman.AutoSize = true;
            this.cBoxman.Location = new System.Drawing.Point(13, 12);
            this.cBoxman.Name = "cBoxman";
            this.cBoxman.Size = new System.Drawing.Size(41, 19);
            this.cBoxman.TabIndex = 0;
            this.cBoxman.Text = "男";
            this.cBoxman.UseVisualStyleBackColor = true;
            this.cBoxman.CheckedChanged += new System.EventHandler(this.cBoxman_CheckedChanged);
            // 
            // cBoxwoman
            // 
            this.cBoxwoman.AutoSize = true;
            this.cBoxwoman.Location = new System.Drawing.Point(87, 12);
            this.cBoxwoman.Name = "cBoxwoman";
            this.cBoxwoman.Size = new System.Drawing.Size(41, 19);
            this.cBoxwoman.TabIndex = 0;
            this.cBoxwoman.Text = "女";
            this.cBoxwoman.UseVisualStyleBackColor = true;
            this.cBoxwoman.CheckedChanged += new System.EventHandler(this.cBoxwoman_CheckedChanged);
            // 
            // SexControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cBoxwoman);
            this.Controls.Add(this.cBoxman);
            this.Name = "SexControl";
            this.Size = new System.Drawing.Size(146, 43);
            this.Load += new System.EventHandler(this.SexControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cBoxman;
        private System.Windows.Forms.CheckBox cBoxwoman;
    }
}
