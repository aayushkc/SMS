using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.Utils;
namespace SMS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudent fs = new FrmStudent();
            fs.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Gc.Role != "Admin" || Gc.Role !="admin")
            {
                adminToolStripMenuItem.Visible = false; 
            }
            toolStripStatusLabel1.Text = "User:" + Gc.Username;
            toolStripStatusLabel2.Text = "Role:" + Gc.Role;
            toolStripStatusLabel3.Text = "Date: " + DateTime.Now.ToLongDateString();

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fm = new FrmLogin();
            fm.Show();
        }
    }
}
