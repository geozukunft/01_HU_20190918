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
using System.IO;

namespace _01_HU_20190918
{
    public partial class Advanced : Form
    {
        string department;
        string filepath = Directory.GetCurrentDirectory() + "\\data.csv";
        public Advanced()
        {
            InitializeComponent();
            dtpBirthdate.MaxDate = DateTime.Today; //You can't be born in the future
            int percent = (int)(((double)pgbSenden.Value / (double)pgbSenden.Maximum) * 100);
            pgbSenden.Visible = false; //Make progressbar invisible at startup
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
            writeToCSV(); //Write data to csv

            pgbSenden.Visible = true;
            pgbSenden_Load(); //Start the "sending" data progress bar 
            pgbSenden.Visible = false;

            txtFirstName.ResetText(); //Reset all values to allow for the next data set to be entered
            txtLastname.ResetText();
            dtpBirthdate.Value = DateTime.Today;
            resetRDO();
            pgbSenden.Value = 0;

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

        private void pgbSenden_Load()
        {
            double counterTimer = 0;
            while (pgbSenden.Value < 100)
            {
                pgbSenden.Value = Convert.ToInt32(100 * (1 - Math.Exp(-counterTimer / 5))); //Mathematic expression to go slower every time the loop repeats
                counterTimer += 0.1;
                Thread.Sleep(100);
                int percent = (int)(((double)pgbSenden.Value / (double)pgbSenden.Maximum) * 100);
                pgbSenden.Refresh();
                pgbSenden.CreateGraphics().DrawString(percent.ToString() + "%", //Print the current percentage
                    new Font("Arial", (float)8.25, FontStyle.Regular),
                    Brushes.Black,
                    new PointF(pgbSenden.Width / 2 - 10, pgbSenden.Height / 2 - 7));

            }
        }

        private void writeToCSV() //Write data to csv
        {
            var csv = new StringBuilder();

            if (rdoCS.Checked == true)
            {
                department = "Informatik";
            }
            else if (rdoMechanicalEng.Checked == true)
            {
                department = "Maschinenbau";
            }
            else if (rdoMechatronics.Checked == true)
            {
                department = "Mechatronik";
            }
            else if (rdoElectricalEng.Checked == true)
            {
                department = "Elektrotechnik";
            }
            else
            {
                department = "Error Code: 0x001";
            }
            var firstCSV = txtFirstName.Text;
            var secondCSV = txtLastname.Text;
            var thirdCSV = dtpBirthdate.Value.ToShortDateString();
            var fourthCSV = department;
            var newLineCSV = string.Format("{0},{1},{2},{3}", firstCSV, secondCSV, thirdCSV, fourthCSV);
            csv.AppendLine(newLineCSV);
            File.AppendAllText(filepath, csv.ToString());
        }

        private void resetRDO() //Reset RDO buttons
        {
            rdoCS.Checked = false;
            rdoElectricalEng.Checked = false;
            rdoMechanicalEng.Checked = false;
            rdoMechatronics.Checked = false;
        }
    }
}
