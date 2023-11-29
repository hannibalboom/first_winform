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
    public partial class PopControl : UserControl
    {
        public PopControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPop pop = new FrmPop(PopWidth, PopHeight, PopText);
            pop.ShowDialog();
        }

        //定义“自定义控件”的属性
        /// <summary>
        /// 定义窗体打开时的宽度
        /// </summary>
        [Browsable(true)]
        [Description("点击按钮，打开窗体的宽度，单位是像素"),Category("自定义属性")]
        public int PopWidth { get; set; }

        /// 定义窗体打开时的高度
        /// </summary>
        [Browsable(true)]
        [Description("点击按钮，打开窗体的高度，单位是像素"), Category("自定义属性")]
        public int PopHeight { get; set; }

        /// 窗体的Text属性
        /// </summary>
        [Browsable(true)]
        [Description("窗体的Text属性"), Category("自定义属性")]
        public string PopText { get; set; }
    }
}
