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
    public partial class Advanced : Form
    {
        public Advanced()
        {
            InitializeComponent();
            dtpBirthdate.MaxDate = DateTime.Today;
            int percent = (int)(((double)pgbSenden.Value / (double)pgbSenden.Maximum) * 100);
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
            double counterTimer = 0;
            
            
            while (pgbSenden.Value < 100)
            {
                pgbSenden.Value = Convert.ToInt32(100*(1-Math.Exp(-counterTimer/5)));
                counterTimer += 0.1;
                Thread.Sleep(100);
                int percent = (int)(((double)pgbSenden.Value / (double)pgbSenden.Maximum) * 100);
                pgbSenden.Refresh();
                pgbSenden.CreateGraphics().DrawString(percent.ToString() + "%",
                    new Font("Arial", (float)8.25, FontStyle.Regular),
                    Brushes.Black,
                    new PointF(pgbSenden.Width / 2 - 10, pgbSenden.Height / 2 - 7));

            }
        }

        private void cmdAbort_Click(object sender, EventArgs e)
        {
            Hide();
            Form sm = new startmenu();
            sm.Show();
        }

        private void pgbSenden_Click(object sender, EventArgs e)
        {
            
        }
    }
}
