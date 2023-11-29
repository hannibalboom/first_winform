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

namespace WinformPager.UControls
{
    public partial class PageControl : UserControl
    {
        public PageControl()
        {
            InitializeComponent();
        }


        //总记录数
        private int totalCount;
        public int TotalCount
        {
            get { return totalCount; }
            set
            {
                totalCount = value;
                InitPageInfo();//刷新数据
            }
        }


        //每页显示的记录数
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }


        //总页数
        private int pageNum;
        public int PageNum
        {
            get
            {
                if (TotalCount == 0)
                    pageNum = 0;
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
        }


        //当前页页码
        private int currentPage = 1;
        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }


        //当前页第一条数据的number值
        private int startIndex = 1;
        public int StartIndex
        {
            get { return (CurrentPage - 1) * PageSize + 1; }
            set { startIndex = value; }
        }


        //初始化分页信息
        public void InitPageInfo()
        {
            //已到最后一页，重置到第一页
            if (TotalCount == 0 || (TotalCount > 0 && CurrentPage > PageNum))
            {
                //此时TotalCount默认为0，要给程序留个出口，即Next可用
                CurrentPage = 1;
                btnLast.Enabled = false;
                btnNext.Enabled = true;
            }

            //结果只有一页时
            if (PageNum == 1)
            {
                CurrentPage = 1;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }

            //结果大于1页且当前页大于1,小于PageNum时
            else if(PageNum>1&&CurrentPage>1&&CurrentPage<PageNum)
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }

            else if(PageNum>1&&CurrentPage==1)
            {
                btnNext.Enabled = true;
                btnLast.Enabled = false;
            }

            else if(PageNum>1&&CurrentPage==PageNum)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = true;
            }
            lblPageInfo.Text = string.Format("{0} pages, {1} records   {2}/{3}", PageNum,TotalCount, CurrentPage, PageNum);
            txtPage.Text = CurrentPage.ToString();
        }


        //翻页委托
        public delegate void PagerHandler(object sender, EventArgs e);
        //翻页事件
        public event PagerHandler PageChanged;
        //实现翻页
        private void OnPageChanged()
        {
            if (PageChanged != null)//判断是否为空
            {
                PageChanged.Invoke(this, new EventArgs());//触发事件
                InitPageInfo();//对信息进行更新
            }
        }


        //Last按钮
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (TotalCount > 0)
            {
                CurrentPage -= 1;
                OnPageChanged();//更新数据
                if (CurrentPage == 1)
                {
                    btnLast.Enabled = false;
                }
                else
                {
                    btnLast.Enabled = true;
                }
                btnNext.Enabled = true;
            }
        }


        //Next按钮
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (TotalCount > 0)
            {
                CurrentPage += 1;
                OnPageChanged();//更新数据
                if (CurrentPage == PageNum)
                {
                    btnNext.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                }
                btnLast.Enabled = true;
            }
        }


        //Goto按钮
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (TotalCount > 0)
            {
                //检测输入内容是否非空、是否为纯数字
                if (!string.IsNullOrEmpty(txtPage.Text) && !Regex.IsMatch(txtPage.Text, @"^[\d]*$"))
                {
                    MessageBox.Show("请输入正确的页码！");
                    return;
                }
                int page = int.Parse(txtPage.Text);
                if (page == 0 || page == 1)
                {
                    page = 1;
                    btnLast.Enabled = false;
                    btnNext.Enabled = true;
                }
                else if (page >= PageNum)
                {
                    page = pageNum;
                    btnLast.Enabled = true;
                    btnNext.Enabled = false;
                }
                else//非边缘页数
                {
                    btnLast.Enabled = true;
                    btnNext.Enabled = true;
                }
                CurrentPage = page;
                OnPageChanged();//更新数据
            }
        }

        private void btnGo_KeyDown(object sender, KeyEventArgs e)
        {
            // 判断：如果输入的是回车键
            if (e.KeyCode == Keys.Enter)
            {
                // 触发btn的事件
                this.btnGo_Click(sender, e);
            }
        }
    }
}
