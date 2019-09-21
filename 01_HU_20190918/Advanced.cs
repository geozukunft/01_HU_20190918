using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_HU_20190918
{
    public partial class Advanced : Form
    {
        public Advanced()
        {
            InitializeComponent();
            dtpBirthdate.MaxDate = DateTime.Today;
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Advanced_Load(object sender, EventArgs e)
        {

        }

        private void lblDataOut_Click(object sender, EventArgs e)
        {

        }

        private void cmdSendData_Click(object sender, EventArgs e)
        {
            string selectedDate = dtpBirthdate.Value.ToShortDateString();
            lblDataOut.Text = selectedDate;
        }

        private void cmdAbort_Click(object sender, EventArgs e)
        {
            Hide();
            Form sm = new startmenu();
            sm.Show();
        }
    }
}
