
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btQuit = new System.Windows.Forms.Button();
            this.btSetting = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btNew = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btDataBase = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            this.btCCD = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.btInport = new System.Windows.Forms.Button();
            this.btCompare = new System.Windows.Forms.Button();
            this.btOut = new System.Windows.Forms.Button();
            this.btQuery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkeywords = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pagecontrol1 = new WinformPager.UControls.PageControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 1015);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btQuit);
            this.panel3.Controls.Add(this.btSetting);
            this.panel3.Controls.Add(this.btPrint);
            this.panel3.Location = new System.Drawing.Point(828, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 55);
            this.panel3.TabIndex = 0;
            // 
            // btQuit
            // 
            this.btQuit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQuit.Location = new System.Drawing.Point(213, 9);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(96, 38);
            this.btQuit.TabIndex = 5;
            this.btQuit.Text = "Quit";
            this.btQuit.UseVisualStyleBackColor = true;
            // 
            // btSetting
            // 
            this.btSetting.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSetting.Location = new System.Drawing.Point(111, 8);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(96, 38);
            this.btSetting.TabIndex = 6;
            this.btSetting.Text = "Setting";
            this.btSetting.UseVisualStyleBackColor = true;
            // 
            // btPrint
            // 
            this.btPrint.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPrint.Location = new System.Drawing.Point(9, 8);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(96, 38);
            this.btPrint.TabIndex = 7;
            this.btPrint.Text = "Print";
            this.btPrint.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // btNew
            // 
            this.btNew.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.Location = new System.Drawing.Point(8, 67);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(73, 33);
            this.btNew.TabIndex = 20;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView2.Location = new System.Drawing.Point(8, 712);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(326, 259);
            this.dataGridView2.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Waiting area";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(348, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(790, 997);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(249, 30);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(85, 33);
            this.btReset.TabIndex = 20;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btDataBase
            // 
            this.btDataBase.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDataBase.Location = new System.Drawing.Point(249, 69);
            this.btDataBase.Name = "btDataBase";
            this.btDataBase.Size = new System.Drawing.Size(85, 33);
            this.btDataBase.TabIndex = 20;
            this.btDataBase.Text = "DataBase";
            this.btDataBase.UseVisualStyleBackColor = true;
            this.btDataBase.Click += new System.EventHandler(this.btDataBase_Click);
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(170, 67);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(73, 33);
            this.btEdit.TabIndex = 20;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDel
            // 
            this.btDel.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Location = new System.Drawing.Point(91, 67);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(73, 33);
            this.btDel.TabIndex = 20;
            this.btDel.Text = "Del";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btIn
            // 
            this.btIn.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.Location = new System.Drawing.Point(7, 675);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(57, 31);
            this.btIn.TabIndex = 20;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            // 
            // btCCD
            // 
            this.btCCD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCCD.Location = new System.Drawing.Point(320, 12);
            this.btCCD.Name = "btCCD";
            this.btCCD.Size = new System.Drawing.Size(96, 38);
            this.btCCD.TabIndex = 4;
            this.btCCD.Text = "CCD";
            this.btCCD.UseVisualStyleBackColor = true;
            // 
            // btExport
            // 
            this.btExport.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(218, 12);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(96, 38);
            this.btExport.TabIndex = 5;
            this.btExport.Text = "Export";
            this.btExport.UseVisualStyleBackColor = true;
            // 
            // btInport
            // 
            this.btInport.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInport.Location = new System.Drawing.Point(116, 12);
            this.btInport.Name = "btInport";
            this.btInport.Size = new System.Drawing.Size(96, 38);
            this.btInport.TabIndex = 6;
            this.btInport.Text = "Inport";
            this.btInport.UseVisualStyleBackColor = true;
            // 
            // btCompare
            // 
            this.btCompare.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCompare.Location = new System.Drawing.Point(14, 13);
            this.btCompare.Name = "btCompare";
            this.btCompare.Size = new System.Drawing.Size(96, 38);
            this.btCompare.TabIndex = 7;
            this.btCompare.Text = "Compare";
            this.btCompare.UseVisualStyleBackColor = true;
            this.btCompare.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // btOut
            // 
            this.btOut.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOut.Location = new System.Drawing.Point(71, 675);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(57, 31);
            this.btOut.TabIndex = 20;
            this.btOut.Text = "Out";
            this.btOut.UseVisualStyleBackColor = true;
            // 
            // btQuery
            // 
            this.btQuery.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuery.Location = new System.Drawing.Point(170, 30);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(73, 33);
            this.btQuery.TabIndex = 20;
            this.btQuery.Text = "Query";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            this.btQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btQuery_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Patient information";
            // 
            // txtkeywords
            // 
            this.txtkeywords.Location = new System.Drawing.Point(8, 36);
            this.txtkeywords.Name = "txtkeywords";
            this.txtkeywords.Size = new System.Drawing.Size(156, 25);
            this.txtkeywords.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.pagecontrol1);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btReset);
            this.panel2.Controls.Add(this.btDataBase);
            this.panel2.Controls.Add(this.btEdit);
            this.panel2.Controls.Add(this.btNew);
            this.panel2.Controls.Add(this.btDel);
            this.panel2.Controls.Add(this.btOut);
            this.panel2.Controls.Add(this.btIn);
            this.panel2.Controls.Add(this.btQuery);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtkeywords);
            this.panel2.Location = new System.Drawing.Point(8, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 1007);
            this.panel2.TabIndex = 3;
            // 
            // pagecontrol1
            // 
            this.pagecontrol1.CurrentPage = 1;
            this.pagecontrol1.Location = new System.Drawing.Point(8, 514);
            this.pagecontrol1.Name = "pagecontrol1";
            this.pagecontrol1.PageSize = 25;
            this.pagecontrol1.Size = new System.Drawing.Size(326, 131);
            this.pagecontrol1.StartIndex = 1;
            this.pagecontrol1.TabIndex = 25;
            this.pagecontrol1.TotalCount = 0;
            this.pagecontrol1.PageChanged += new WinformPager.UControls.PageControl.PagerHandler(this.pagecontrol1_PageChanged);
            this.pagecontrol1.Load += new System.EventHandler(this.Form1_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(326, 402);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1162, 1030);
            this.Controls.Add(this.btCCD);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btInport);
            this.Controls.Add(this.btCompare);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btDataBase;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btCCD;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btInport;
        private System.Windows.Forms.Button btCompare;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkeywords;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WinformPager.UControls.PageControl pagecontrol1;
    }
}

