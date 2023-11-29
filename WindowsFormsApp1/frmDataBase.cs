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
    public partial class frmDataBase : Form
    {
       public  DataTable dt { get; set; }
        public frmDataBase()
        {
            InitializeComponent();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //dgv1.DataSource =;
        }

        private void frmDataBase_Load(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)this.MdiParent;
            dgv1.DataSource = dt;

        }
    }
}
