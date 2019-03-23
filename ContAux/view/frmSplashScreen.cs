using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContAux.view
{
    public partial class frmSplashScreen : Form
    {
        private int count = 0;
        public frmSplashScreen()
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml("#44B3AD");
            this.timer1.Start();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            prgBar.Increment(2);
            if (count == 78) {
                timer1.Stop();
                timer1.Enabled=false;
                this.Hide();
                frmLogin screenLogin = new frmLogin();
                screenLogin.Show();
            }
        }

    }
}
