using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProjectCSC340
{
    public partial class editEventForm : Form
    {
        public EmployeeEvents thisEvent;

        public editEventForm(EmployeeEvents thisEvent)
        {
            InitializeComponent();
            this.thisEvent = thisEvent;
        }


        private void nextButton1_Click(object sender, EventArgs e)
        {
            if (!isAllInfoEntered())
            {
                MessageBox.Show("Please enter all new information for the event.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //function to change event details in the database - coding phase
                MessageBox.Show("Changes Confirmed");

                //return to main menu
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        //function to check if all information has been entered
        public bool isAllInfoEntered()
        {
            if (string.IsNullOrWhiteSpace(newTitleTextBox.Text))
            {
                return false;
            }

            if (newEndTime.Value <= newStartTime.Value)
            {
                MessageBox.Show("End time must be after start time.");
                return false;
            }

            return true;
        }
    }
}
