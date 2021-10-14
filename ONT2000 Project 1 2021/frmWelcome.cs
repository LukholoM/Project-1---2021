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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //-----Remove comments after adding relevant Forms-----//

           // frmSignIn frmWelcome = new frmSignIn();
            this.Hide();
            //frmWelcome.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-----Remove comments after adding relevant Forms-----//

            //frmSignUp frmWelcome = new frmWelcome();
            this.Hide();
            //frmWelcome.Show();
        }


    }
}
