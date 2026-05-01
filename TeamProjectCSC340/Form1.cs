using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {

        // Global variable to store the logged-in employee's ID for use in other forms
        public static int loggedInEmployeeId;
        //Enables scheduling meeting
        public static int isManager;
        //Pulls meetings for all users
        //public static int isMeeting;

        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
        }

        // This method is for opening the edit event form.
        private void button1_Click(object sender, EventArgs e)
        {
            //open events 
            EmployeeEventsForm employeeEventForm = new EmployeeEventsForm("edit");
            employeeEventForm.Show();
            this.Hide();
        }

        // This method is for opening the delete event form.
        private void button2_Click(object sender, EventArgs e)
        {
            //open events 
            EmployeeEventsForm employeeEventForm = new EmployeeEventsForm("delete");
            employeeEventForm.Show();
            this.Hide();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1. Capture user input from the text boxes
            string userEmail = emailTextBox.Text;
            string userPassword = passwordTextBox.Text;

            // Include firstName in the SELECT so we can read it.
            string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            string query = "SELECT employeeId, firstName, isManager FROM bbwlcalenderemployees WHERE email = @email AND password = @password";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", userEmail);
                        cmd.Parameters.AddWithValue("@password", userPassword);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                // Store the employeeId globally here if you need it for the next panel!
                                loggedInEmployeeId = reader.GetInt32("employeeId");
                                // Fix: firstName is a string, so use string type
                                string employeeName = reader.GetString("firstName");
                                //Pulling manager status for addEvent usage
                                isManager = reader.GetInt32("isManager");

                                // Set label to welcome the user
                                welcomeLabel.Text = $"Welcome, {employeeName}!";
                                // Simply toggle the panels instead of opening a new form
                                ReturnToMainMenu();
                            }
                            else
                            {
                                MessageBox.Show("Authentication Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Connection Error: " + ex.Message);
                }
            }

        }

        // This method is for opening the add event form.
        private void addEventButton_Click(object sender, EventArgs e)
        {
            // Open the addEvent page
            addEvent addEventPage = new addEvent();
            addEventPage.Show();

            // Hide the main menu
            this.Hide();
        }

        // Returning to the logged in main menu
        public void ReturnToMainMenu()
        {
            // Show the main menu panel and hide the others
            panel1.Visible = false;
            panel2.Visible = true;
            this.Show();

            // 2. Fetch the real events for the logged-in user from the database
            List<EmployeeEvents> eventsList = EmployeeEvents.getEvents(loggedInEmployeeId);

            // 3. Populate the list box directly on Form1
            if (upcomingEventsListBox != null)
            {
                // STEP A: Temporarily turn off the click event so it doesn't auto-trigger
                upcomingEventsListBox.SelectedIndexChanged -= upcomingEventsListBox_SelectedIndexChanged;

                // STEP B: Load your data
                upcomingEventsListBox.DataSource = null;
                upcomingEventsListBox.DataSource = eventsList;
                upcomingEventsListBox.DisplayMember = "displayFormat";

                // STEP C: Force the list to have NOTHING selected
                upcomingEventsListBox.ClearSelected();

                // STEP D: Turn the click event back on so it waits for the user's physical click
                upcomingEventsListBox.SelectedIndexChanged += upcomingEventsListBox_SelectedIndexChanged;
            }
        }

        // This method is for logging out and returning to the login screen.
        private void logoutButton_Click(object sender, EventArgs e)
        {
            // 1. Clear the employee's logged-in information (Requirement R8.3)
            loggedInEmployeeId = 0;

            // 2. Clear the login text boxes so the next person doesn't see the credentials
            emailTextBox.Clear();
            passwordTextBox.Clear();

            // 3. Return to the initial login page (Requirement R8.4)
            panel2.Visible = false; // Hides the calendar menu
            panel1.Visible = true;  // Shows the login panel

            // Optional: Give the user feedback that they successfully logged out
            MessageBox.Show("You have successfully logged out.");
        }

        private void upcomingEventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (upcomingEventsListBox.SelectedItem != null)
            {
                // Grab the real event the user clicked on
                EmployeeEvents selectedEvent = (EmployeeEvents)upcomingEventsListBox.SelectedItem;

                // Open your slim, professional custom pop-out!
                EventDetailsForm customPopUp = new EventDetailsForm(selectedEvent);
                customPopUp.ShowDialog(); // ShowDialog forces them to click 'OK' before clicking the calendar again

                // Clear the selection so the blue highlight disappears after they close the pop-up
                upcomingEventsListBox.ClearSelected();
            }
        }
    }
}
