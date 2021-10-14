using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONT2000_Project_1_2021
{
    public partial class frmSearchError : Form
    {
        public frmSearchError()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void frmSearchError_Load(object sender, EventArgs e)
        {

        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
