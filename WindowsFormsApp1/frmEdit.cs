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
    public partial class frmEdit : Form
    {
        public string PatientID { get; set; }//病人编号
        public frmEdit()
        {
            InitializeComponent();
        }
        private void BindDetail()
        {
            //根据PatientID获取所有信息
            string sql = "select * from patient_detail where PatientID= " + this.PatientID;
            SQLite.PrepareSql(sql);
            DataTable dt = new DataTable();
            dt = SQLite.ExecQuery();
            this.txtName.Text = dt.Rows[0]["PatientName"].ToString();
            this.txtId.Text = dt.Rows[0]["PatientID"].ToString();
            this.txtAge.Text = dt.Rows[0]["PatientAge"].ToString();
            this.txtDoctor.Text = dt.Rows[0]["DoctorName"].ToString();
            this.txtPhotoDoctor.Text = dt.Rows[0]["PhotoDoctorName"].ToString();
            this.txtJc_date.Text = dt.Rows[0]["jc_date"].ToString();
            this.lblTime.Text = dt.Rows[0]["latestdate"].ToString();

            //性别处理
            if (dt.Rows[0]["PatientSex"].ToString().Equals("男"))
                this.rbMale.Checked = true;
            else
                this.rbFemale.Checked = true;
           

        }
        private void frmEdit_Load(object sender, EventArgs e)
        {
            BindDetail();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
           this.lblTime.Text= DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
            string sql = "update patient_detail set PatientName=@PatientName,PatientSex=@PatientSex,PatientAge=@PatientAge,DoctorName=@DoctorName,PhotoDoctorName=@PhotoDoctorName,jc_date=@jc_date,latestdate=@latestdate where PatientID=@PatientID";
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
            SQLite.SetParameter("PatientID", this.PatientID);

            int rowCount = SQLite.ExecNonQuery();
            if (rowCount == 1)
            {
                MessageBox.Show("Modified successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Modified successfully!");
            }
        }

        private void txtJc_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 触发Edit的事件
                this.btEdit_Click(sender, e);
            }
        }

        private void txtAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }
    }
}
