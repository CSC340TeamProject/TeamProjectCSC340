using MySql.Data.MySqlClient;
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
        public int employeeId;
        public List<EmployeeEvents> eventsList;
        public string action;

        public EmployeeEventsForm(string action)
        {
            InitializeComponent();
            this.action = action;

            // 1. Pulls events using the globally logged-in employee ID
            eventsList = EmployeeEvents.getEvents(Form1.loggedInEmployeeId);

            if (eventsList.Count == 0)
            {
                MessageBox.Show($"You do not have any events to {action}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // 2. Returns to the main menu without creating a new login screen
                this.Close();
                Form1 mainForm = (Form1)Application.OpenForms["Form1"];
                if (mainForm != null)
                {
                    mainForm.ReturnToMainMenu();
                }
                return;
            }

            eventsListBox.DataSource = eventsList;
            eventsListBox.ClearSelected();
            eventsListBox.DisplayMember = "title";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eventsListBox.SelectedItem != null)
            {
                EmployeeEvents selectedEvent = (EmployeeEvents)eventsListBox.SelectedItem;

                //open a form corresponding to the action the employee wants to complete
                if(action == "edit") //edit event
                {
                    editEventForm edit = new editEventForm(selectedEvent);
                    edit.Show();
                    this.Hide();
                }else if(action == "delete")
                {
                    //display a pop-up to ensure the employee wants to delete the selected event
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + selectedEvent, "Save Error", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

                        // 4. Returns to the main menu after successful deletion
                        this.Close();
                        Form1 mainForm = (Form1)Application.OpenForms["Form1"];
                        if (mainForm != null)
                        {
                            mainForm.ReturnToMainMenu();
                        }
                    }
                }
            }
            else
            {
                //display an error
                MessageBox.Show("Please select an event before contining.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}