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
    public partial class EmployeeEventsForm : Form
    {
        public int employeeId; //holds employee's id
        public List<EmployeeEvents> eventsList; //holds events

        public EmployeeEventsForm()
        {
            InitializeComponent();
            //gets the employee's events and adds them to the eventsList
            eventsList = EmployeeEvents.getEvents(this.employeeId);

            //check if the list is empty
            if(eventsList.Count == 0)
            {
                //display an error
                MessageBox.Show("You do not have any events to edit.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); //close this form
                return;
            }

            //add each event to the list box for the employee to choose from
            foreach (EmployeeEvents events in eventsList)
            {
                eventsListBox.Items.Add($"Event {events.title}");
            }
        }     
    }
}
