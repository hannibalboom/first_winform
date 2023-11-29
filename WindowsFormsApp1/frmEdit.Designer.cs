namespace WindowsFormsApp1
{
    partial class frmEdit
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
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btEdit = new System.Windows.Forms.Button();
            this.txtJc_date = new System.Windows.Forms.TextBox();
            this.txtPhotoDoctor = new System.Windows.Forms.TextBox();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lable8 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(242, 70);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(73, 19);
            this.rbFemale.TabIndex = 18;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(163, 72);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 19);
            this.rbMale.TabIndex = 19;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(142, 431);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(90, 32);
            this.btEdit.TabIndex = 17;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // txtJc_date
            // 
            this.txtJc_date.Location = new System.Drawing.Point(163, 329);
            this.txtJc_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJc_date.Name = "txtJc_date";
            this.txtJc_date.Size = new System.Drawing.Size(158, 25);
            this.txtJc_date.TabIndex = 11;
            this.txtJc_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJc_date_KeyDown);
            // 
            // txtPhotoDoctor
            // 
            this.txtPhotoDoctor.Location = new System.Drawing.Point(163, 274);
            this.txtPhotoDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhotoDoctor.Name = "txtPhotoDoctor";
            this.txtPhotoDoctor.Size = new System.Drawing.Size(158, 25);
            this.txtPhotoDoctor.TabIndex = 12;
            // 
            // txtDoctor
            // 
            this.txtDoctor.Location = new System.Drawing.Point(163, 220);
            this.txtDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(158, 25);
            this.txtDoctor.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(163, 169);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(158, 25);
            this.txtId.TabIndex = 14;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(163, 113);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(158, 25);
            this.txtAge.TabIndex = 15;
            this.txtAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(163, 22);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 25);
            this.txtName.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "jc_date：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "PhotoDoctorName：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "DoctorName：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "PatientId：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "PatientAge：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "PatientSex：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "PatientName：";
            // 
            // lable8
            // 
            this.lable8.AutoSize = true;
            this.lable8.Location = new System.Drawing.Point(43, 388);
            this.lable8.Name = "lable8";
            this.lable8.Size = new System.Drawing.Size(95, 15);
            this.lable8.TabIndex = 20;
            this.lable8.Text = "LatestDate:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(169, 388);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 15);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "lblTime";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 492);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lable8);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.txtJc_date);
            this.Controls.Add(this.txtPhotoDoctor);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEdit";
            this.Text = "frmEdit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.TextBox txtJc_date;
        private System.Windows.Forms.TextBox txtPhotoDoctor;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable8;
        private System.Windows.Forms.Label lblTime;
    }
}