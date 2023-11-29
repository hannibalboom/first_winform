
namespace MyControl
{
    partial class PageControl1
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
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPageInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblPageInfo.Location = new System.Drawing.Point(3, 7);
            this.lblPageInfo.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPageInfo.Size = new System.Drawing.Size(312, 22);
            this.lblPageInfo.TabIndex = 0;
            this.lblPageInfo.Text = "总共100条记录，共4页，当前第1页";
            this.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFirst.Location = new System.Drawing.Point(372, 3);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFirst.Size = new System.Drawing.Size(120, 27);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "跳转到第1页";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrev.Location = new System.Drawing.Point(521, 3);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(73, 27);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "上一页";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Location = new System.Drawing.Point(627, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(64, 27);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLast.Location = new System.Drawing.Point(719, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(134, 27);
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = "跳转到最后一页";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(883, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.Controls.Add(this.btnPrev, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLast, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPageInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFirst, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 37);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(976, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 27);
            this.button4.TabIndex = 2;
            this.button4.Text = "跳转到";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button4_KeyDown);
            // 
            // PageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.Name = "PageControl";
            this.Size = new System.Drawing.Size(1054, 47);
            this.Load += new System.EventHandler(this.PageControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button4;
    }
}
