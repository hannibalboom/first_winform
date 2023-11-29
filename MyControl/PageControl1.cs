using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControl
{
    public partial class PageControl1 : UserControl
    {
        public PageControl1()
        {
            InitializeComponent();
        }

        private int totalCount;
        /// <summary>
        /// 总记录数
        /// </summary>
        /// 
        public int TotalCount//通过数据库统计来获取
        {
            get { return totalCount; }
            set { totalCount = value;
                InitPageInfo();
            }

        }

        private int pageSize=1;
        /// <summary>
        /// 每页显示的记录数
        /// </summary>
        public int PageSize//定义控件时自己设置
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        /// <summary>
        /// 总页数
        /// </summary>
        private int pageNum;
        public int PageNum//根据数据库来获取
        {
            get {
                if (TotalCount == 0)//总记录为0，总页数也为0
                    pageNum = 0;
                //else
                //{
                //    if (TotalCount % PageSize == 0)//恰好能整除
                //        pageNum = TotalCount / PageSize;
                //    else//商+1
                //        pageSize = TotalCount / PageSize+1;
                //}
                else
                {
                    //101条   每页20    5页多一行   +1 页
                    if (TotalCount % PageSize > 0)
                    {
                        pageNum = TotalCount / PageSize + 1;
                    }
                    else
                    {
                        pageNum = TotalCount / PageSize;
                    }
                }
                return pageNum;
            }
           // set { pageNum = value; }
        }

        private int currentPage=1;
        /// <summary>
        /// 当前页索引
        /// </summary>
        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }

        /// <summary>
        /// 当前页索引：每页的第一个序号
        /// </summary>
        private int startIndex=1;
        public int StartIndex
        {
            get { return (CurrentPage-1)*PageSize+1; }
            set { startIndex = value; }
        }


    /// <summary>
    /// 初始化分页信息
    /// </summary>
        private void InitPageInfo()
        {
            //if(CurrentPage==1)
            //{
            //    btnNext.Enabled = true;
            //    btnLast.Enabled = true;
            //}
            if (TotalCount == 0 || (TotalCount > 0 && CurrentPage > PageNum))
            {
                CurrentPage = 1;
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
                btnFirst.Enabled = false;
            }

            if (PageNum == 1 )
            {
                CurrentPage = 1;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
            }
            lblPageInfo.Text = string.Format("总共{0}条记录，共{1}页，当前第{2}页", TotalCount, PageNum, CurrentPage);
            textBox1.Text = CurrentPage.ToString();
        }


        /// <summary>
        /// 翻页委托
        /// </summary>
        public delegate void PagerHandler(object sender, EventArgs e);
        //翻页事件
        public event PagerHandler PageChanged;
        //实现翻页
        private void OnPageChanged()
        {
            if(PageChanged!=null)//判断是否为空
            {
                PageChanged.Invoke(this, new EventArgs());//触发事件
                InitPageInfo();//对信息进行更新
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (TotalCount>0)
            {
                CurrentPage -=1;
                OnPageChanged();//更新数据
                if(CurrentPage==1)
                {
                    btnPrev.Enabled = false;              
                    btnFirst.Enabled = false;
                }
                else
                {
                    btnPrev.Enabled = true;
                    btnFirst.Enabled = true;
                }
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
        }


        /// <summary>
        /// 跳转到最后一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (TotalCount > 0)
            {
                CurrentPage = PageNum;
                OnPageChanged();//更新数据
                btnPrev.Enabled = true;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                btnFirst.Enabled = true;
            }
        }


        /// <summary>
        /// 跳转到第1页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(TotalCount>0)
            {
                CurrentPage = 1;
                OnPageChanged();//更新数据
                btnPrev.Enabled = false;//上一页按钮失效
                btnNext.Enabled = true;//下一页按钮有效
                btnLast.Enabled = true;//跳转最后一页按钮有效
                btnFirst.Enabled = false;//跳转到第一页按钮失效
            }
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (TotalCount > 0)
            {
                CurrentPage += 1;
                OnPageChanged();//更新数据
                if (CurrentPage == PageNum)
                {
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                }
                btnPrev.Enabled = true;
                btnFirst.Enabled = true;
            }
        }

        /// <summary>
        /// 跳转到任意页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (TotalCount > 0)
            {
                if(!string.IsNullOrEmpty(textBox1.Text)&&!Regex.IsMatch(textBox1.Text,@"^[\d]*$"))
                {
                    MessageBox.Show("请输入正确的页码！");
                    return;
                }
                int page = int.Parse(textBox1.Text);
                if(page==0||page==1)
                {
                    page = 1;
                    btnPrev.Enabled = false;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnFirst.Enabled = false;
                }
                else if(page>=PageNum)
                {
                    page = pageNum;
                    btnPrev.Enabled = true;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnFirst.Enabled = true;
                }
                else
                {
                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnFirst.Enabled = true;
                }
                CurrentPage = page;
                OnPageChanged();//更新数据
            }
        }


        private void PageControl_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.SetCellPosition(textBox1, new TableLayoutPanelCellPosition(266, 11));
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // 判断：如果输入的是回车键
            if (e.KeyCode == Keys.Enter)
            {
                // 触发btn的事件
                this.button4_Click(sender, e);
            }

        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
        //    // 判断：如果输入的是回车键
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        // 触发btn的事件
        //        this.button4_Click(sender, e);
            
        }
    }
}
