using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControl
{
    //继承于UserControl库
    public partial class SexControl: UserControl
    {
        public SexControl()
        {
            InitializeComponent();
        }

        
        [Browsable(true)]//可以让这个属性在右下显示出来
        [Description("默认选中的复选框，int型，索引从0开始，0则是第一个复选框"),Category("自定义属性")]
        public int CheckIndex { get; set; }

        private void SexControl_Load(object sender, EventArgs e)
        {
            if(CheckIndex==0)
            {
                cBoxman.Checked = true;
                cBoxwoman.Checked = false;
            }
            else if(CheckIndex==1)
            {
                cBoxwoman.Checked = true;
                cBoxman.Checked = false;
            }
            else
            {
                cBoxwoman.Checked = false;
                cBoxman.Checked = false;
            }
        }

        //CheckedChanged是指选项改变时需要执行的事件
        private void cBoxman_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxman.Checked==true)
            {
                cBoxwoman.Checked = false;
            }
            else
            {
                cBoxwoman.Checked = true;
            }
        }

        private void cBoxwoman_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxwoman.Checked==true)
            {
                cBoxman.Checked = false;
            }
            else
            {
                cBoxman.Checked = true;
            }
        }
    }
}
