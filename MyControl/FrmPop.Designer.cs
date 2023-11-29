
namespace MyControl
{
    partial class FrmPop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxguid = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxguid
            // 
            this.listBoxguid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxguid.FormattingEnabled = true;
            this.listBoxguid.ItemHeight = 15;
            this.listBoxguid.Location = new System.Drawing.Point(0, 0);
            this.listBoxguid.Name = "listBoxguid";
            this.listBoxguid.Size = new System.Drawing.Size(800, 450);
            this.listBoxguid.TabIndex = 0;
            // 
            // FrmPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxguid);
            this.Name = "FrmPop";
            this.Text = "FrmPop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxguid;
    }
}