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

namespace _01_HU_20190918
{
    public partial class startmenu : Form
    {
        public startmenu()
        {
            InitializeComponent();
        }

        private void startmenu_Load(object sender, EventArgs e)
        {

        }

        private void cmdAdvanced_Click(object sender, EventArgs e)
        {

        }

        private void cmdBasic_Click(object sender, EventArgs e)
        {
            Form basic = new basic();
            basic.Show();
            Hide();
            //Thread.Sleep(1000);
            //Visible = true;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
