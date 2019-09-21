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
    public partial class basic : Form
    {
        string department;

        public basic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void numMonth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gpoDepartment_Enter(object sender, EventArgs e)
        {

        }

        private void cmdSendData_Click(object sender, EventArgs e)
        {
            if (rdoCS.Checked == true || rdoMechanicalEng.Checked == true || rdoMechatronics.Checked == true || rdoElectricalEng.Checked == true)
            {
                if(rdoCS.Checked == true)
                {
                    department = "Informatik";
                }
                else if(rdoMechanicalEng.Checked == true)
                {
                    department = "Maschinenbau";
                }
                else if(rdoMechatronics.Checked == true)
                {
                    department = "Mechatronik";
                }
                else if(rdoElectricalEng.Checked == true)
                {
                    department = "Elektrotechnik";
                }
                else
                {
                    department = "Error Code: 0x001";
                }
                if(txtFirstName.Text != "" && txtLastname.Text != "")
                {
                    lblDataOut.Text = "Folgende Daten wurden zur Anmeldung übertragen:\n" + "Name: " + txtFirstName.Text + " " + txtLastname.Text + "\n" +
                        "Geburtstag: " + numDay.Value + "." + numMonth.Value + "." + numYear.Value + "\n" +
                        "Wunschabteilung: " + department;
                }
            }
        }

        private void cmdAbort_Click(object sender, EventArgs e)
        {
            Hide();
            Form sm = new startmenu();
            sm.Show();
        }

        private void rdoMechatronics_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoElectricalEng_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoMechanicalEng_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblBirthdate_Click(object sender, EventArgs e)
        {
            
        }

        private void numYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numDay_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
