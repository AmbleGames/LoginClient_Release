using System;
using System.Windows.Forms;

namespace BetaLoginClient_MySQL_
{
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
