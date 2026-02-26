using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProjectCSC340
{
    public partial class EmployeeEventsForm : Form
    {
        public int employeeId; //holds employee's id
        public List<EmployeeEvents> eventsList; //holds events
        public string eventAction; //holds the action the employee wants to do

        public EmployeeEventsForm()
        {
            InitializeComponent();
            //gets the employee's events and adds them to the eventsList
            eventsList = EmployeeEvents.getEvents(1);

            Console.WriteLine(eventsList);

            //check if the list is empty
            if(eventsList.Count == 0)
            {
                //display an error
                MessageBox.Show("You do not have any events to edit.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); //close this form
                return;
            }

            //add each event to the list box for the employee to choose from
            eventsListBox.DataSource = eventsList;
            eventsListBox.ClearSelected(); //unselected index 0 after datasource
            eventsListBox.DisplayMember = "title";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eventsListBox.SelectedItem != null)
            {
                //get the selected event
                EmployeeEvents selectedEvent = (EmployeeEvents)eventsListBox.SelectedItem;

                //open editEventForm
                editEventForm edit = new editEventForm(selectedEvent.eventId);
            }
            else
            {
                //display an error
                MessageBox.Show("Please select an event before contining.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
