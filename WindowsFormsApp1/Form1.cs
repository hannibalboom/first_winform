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
    public partial class Form1 : Form
    {
        // 定义委托
        public delegate void DataTransferHandler(object sender, DataTable data);

        // 定义事件
        public event DataTransferHandler DataTransfer;

        // 主窗体中的DataGridView数据
        private DataTable f1FormData;

        private bool button_state = false;

        public Form1()
        {
            InitializeComponent();
            f1FormData = new DataTable();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            FindDataList();
            
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {

        }

        private void ucControlBase1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            //button_state = true;
            //if (button_state)
            //{
            //    button1.BackColor = Color.Green; //设置按下时的背景颜色为绿色
            //}
            //else
            //    button1.BackColor = SystemColors.Control; //恢复默认的背景颜色
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 
        #region 数据库中查找数据
        public void FindDataList()
        {
            string keywords = txtkeywords.Text.Trim();//关键词转换
            //string category = this.cbSort.Text.Trim();//选择类别
            int startIndex = pagecontrol1.StartIndex;//开始索引
            int endIndex = startIndex + pagecontrol1.PageSize - 1;//结束索引

            SQLite s1 = new SQLite();
            DataSet dr = s1.GetDataSetByPage(keywords, startIndex, endIndex);

            int totalCount = Convert.ToInt32(dr.Tables["TotalCount"].Rows[0][0]);//总记录数
            //DataTable dt = ds.Tables[1];//数据列表
            dataGridView1.DataSource = dr.Tables[1];
            pagecontrol1.TotalCount = totalCount;
        }
        #endregion

        private void pagecontrol1_PageChanged(object sender, EventArgs e)
        {
            FindDataList();
        }

        #region Query按钮
        private void btQuery_Click(object sender, EventArgs e)
        {
            pagecontrol1.CurrentPage = 1;
            FindDataList();
        }
        #endregion

        #region Reset按钮
        private void btReset_Click(object sender, EventArgs e)
        {
            pagecontrol1.CurrentPage = 1;
            //清空关键词
            txtkeywords.Text = "";
            FindDataList();
        }
        #endregion

        #region Del按钮
        private void btDel_Click(object sender, EventArgs e)
        {
            //获取选中的行
            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
            DataGridViewRow dr = dataGridView1.CurrentRow;

            if (selectedRows.Count > 0)
            {
                //添加是否确定删除的对话框
                DialogResult result = MessageBox.Show("确定要删除选中的记录吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)//撤销删除
                    return;

                //按表修改
                string StudentID = dr.Cells["StudentID"].Value.ToString();
                string strSql = "delete from Student1 where StudentID=@StudentID";
                //"delete from patient_detail where PatientID=@PatientID";

                SQLite.PrepareSql(strSql);
                SQLite.SetParameter("StudentID", StudentID);
                int rowCount = SQLite.ExecNonQuery();
                if (rowCount == 1)
                    MessageBox.Show("删除成功!");
                else
                    MessageBox.Show("删除失败!");
            }
            else
            {
                //未选中任何行，提示要先选择需要删除的记录
                MessageBox.Show("请先选择要删除的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void btQuery_KeyDown(object sender, KeyEventArgs e)
        {
            // 判断：如果输入的是回车键
            if (e.KeyCode == Keys.Enter)
            {
                // 触发btn的事件
                this.btQuery_Click(sender, e);
            }
        }


        private void btEdit_Click(object sender, EventArgs e)
        {
            string PatientID = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            frmEdit frm = new frmEdit();
            frm.PatientID = PatientID;
            frm.Show();
        }

        public DataTable dt;
        private void btDataBase_Click(object sender, EventArgs e)
        {
            frmDataBase frm = new frmDataBase();
            string sql = "select * from patient_detail order by datetime(latestdate) desc";
            SQLite.PrepareSql(sql);
            DataTable dt = new DataTable();
            dt = SQLite.ExecQuery();
            frm.dt = dt;
            frm.Show();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            string sql = "select * from patient_detail order by datetime(latestdate) desc";
            SQLite.PrepareSql(sql);
            DataTable dt = new DataTable();
            dt = SQLite.ExecQuery();
            string columnName = "PatientID";
            int columnIndex = -1;

            // 查找列的索引
            foreach (DataColumn column in dt.Columns)
            {
                if (column.ColumnName == columnName)
                {
                    columnIndex = column.Ordinal;
                    break;
                }
            }

            if (columnIndex != -1)
            {
                int maxPatientID = int.MinValue; // 假设 PatientID 是整数型的

                // 遍历行，找到最大值
                foreach (DataRow row in dt.Rows)
                {
                    if (row[columnIndex] != DBNull.Value &&
                        int.TryParse(row[columnIndex].ToString(), out int cellValue))
                    {
                        // 如果当前单元格的值是有效的整数
                        if (cellValue > maxPatientID)
                        {
                            maxPatientID = cellValue;
                        }
                    }
                }
                frmNew frm = new frmNew();
                frm.MaxPatientID = maxPatientID;
                frm.Show();


            }
            else
            {
                return;
            }


            //int LastPatientID =int.Parse ( this.dataGridView1.Rows[dataGridView1.RowCount - 1].Cells["PatientID"].Value.ToString());

        }
    }
}
