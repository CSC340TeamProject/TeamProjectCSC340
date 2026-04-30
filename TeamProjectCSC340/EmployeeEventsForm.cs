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

                if (action == "edit")
                {
                    editEventForm edit = new editEventForm(selectedEvent);
                    edit.Show();
                    this.Hide();
                }
                else if (action == "delete")
                {
                    // Confirmation pop-up before deleting
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + selectedEvent.title + "?", "Confirm Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // 3. Deletes the selected event from the database
                        string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            try
                            {
                                conn.Open();
                                string deleteQuery = "DELETE FROM bbwlcalendarevents WHERE eventId = @eventId";
                                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@eventId", selectedEvent.eventId);
                                    cmd.ExecuteNonQuery();
                                }
                                MessageBox.Show(selectedEvent.title + " has been deleted.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Database Error: " + ex.Message);
                            }
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
                MessageBox.Show("Please select an event before continuing.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // 1. Close or hide the current screen
            this.Close();

            // 2. Find the hidden Form1 and make it visible again
            Application.OpenForms["Form1"].Show();
        }
    }
}