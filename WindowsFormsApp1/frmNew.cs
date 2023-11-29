using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmNew : Form
    {

        public int MaxPatientID { get; set; }//最后一条记录的编号
        public frmNew()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
            string sql = "insert into patient_detail(PatientName,PatientAge,PatientSex,DoctorName,PhotoDoctorName,jc_date,latestdate,PatientID) values(@PatientName,@PatientAge,@PatientSex,@DoctorName,@PhotoDoctorName,@jc_date,@latestdate,@PatientID)";
            SQLite.PrepareSql(sql);
            SQLite.SetParameter("PatientName", this.txtName.Text);
            SQLite.SetParameter("PatientAge", this.txtAge.Text);
            //性别处理
            string sex = "";
            if (this.rbMale.Checked == true) sex = this.rbMale.Text;
            if (this.rbFemale.Checked == true) sex = this.rbFemale.Text;
            SQLite.SetParameter("PatientSex", sex);
            SQLite.SetParameter("DoctorName", this.txtDoctor.Text);
            SQLite.SetParameter("PhotoDoctorName", this.txtPhotoDoctor.Text);
            SQLite.SetParameter("jc_date", this.txtJc_date.Text);
            SQLite.SetParameter("latestdate", this.lblTime.Text);
            SQLite.SetParameter("PatientID", this.txtId.Text);
            int rowCount = SQLite.ExecNonQuery();
            if (rowCount == 1)
            {
                MessageBox.Show("Add successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Add unsuccessfully!");
            }
        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            MaxPatientID = MaxPatientID + 1;
            this.txtId.Text = MaxPatientID.ToString();
        }
    }
}
