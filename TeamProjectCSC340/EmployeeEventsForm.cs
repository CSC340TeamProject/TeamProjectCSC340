using Mysqlx;
using MySqlX.XDevAPI.Common;
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
        public string action; //holds the action the employee wants to do

        public EmployeeEventsForm(string action)
        {
            InitializeComponent();
            this.action = action;
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

                //open a form corresponding to the action the employee wants to complete
                if(action == "edit")
                {
                    //open edit form
                    editEventForm edit = new editEventForm(selectedEvent);
                    edit.Show();
                    this.Hide();
                }else if(action == "delete")
                {
                    //display a pop-up to ensure the employee wants to delete the selected event
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + selectedEvent, "Save Error", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    //determine which button the employee pressed
                    if (result == DialogResult.Yes)
                    {
                        //employee clicked yes 
                        //delete the event - coding phase
                        MessageBox.Show(selectedEvent + " has been deleted.");
                        //return to main menu
                        Form1 form = new Form1();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        //Employee clicked no
                        return;
                    }

                }//do the same as above for the other menu options 
            }
            else
            {
                //display an error
                MessageBox.Show("Please select an event before contining.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
