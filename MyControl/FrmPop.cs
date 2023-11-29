using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControl
{
    public partial class FrmPop : Form
    {
        //构造函数
        public FrmPop(int PopWidth,int PopHeight,string PopText)
        {
            InitializeComponent();
            //初始化窗体的时候，改变窗体的大小
            this.Size = new System.Drawing.Size(PopWidth, PopHeight);
            this.Text = PopText;
        }
    }
}
