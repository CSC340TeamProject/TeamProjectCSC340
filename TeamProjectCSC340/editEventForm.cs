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
            //check if all information is entered
            if (!isAllInfoEntered())
            {
                MessageBox.Show("Please enter all new information for the event.",
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //check if endTime is after startTime
            if (DateTime.Parse(newEndTime.Text).TimeOfDay <= (DateTime.Parse(newStartTime.Text).TimeOfDay))
            {
                MessageBox.Show("End time must be after start time.");
                return;
            }

            //edit event
            updateEvent();

            // Requirement R3.11: Display confirmation message
            MessageBox.Show("Changes Confirmed");

            // Requirement R3.12: Return to the existing main menu
            this.Close();
            Form1 mainForm = (Form1)Application.OpenForms["Form1"];
            if (mainForm != null)
            {
                mainForm.ReturnToMainMenu();
            }
        }

        //function to check if all information has been entered
        public bool isAllInfoEntered()
        {
            if (string.IsNullOrWhiteSpace(newTitleTextBox.Text) ||
        string.IsNullOrWhiteSpace(newStartTime.Text) ||
        string.IsNullOrWhiteSpace(newEndTime.Text))
            {
                return false;
            }
            return true;
        }

        //function to update event
        public void updateEvent()
        {
            TimeSpan parsedStartTime = DateTime.Parse(newStartTime.Text).TimeOfDay;
            TimeSpan parsedEndTime = DateTime.Parse(newEndTime.Text).TimeOfDay;
            TimeSpan eventDuration = parsedEndTime - parsedStartTime;

            // Safety check: Don't allow negative durations (End time before start time)
            if (eventDuration.TotalMinutes <= 0)
            {
                MessageBox.Show("The End Time must be later than the Start Time.", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = "server=csitmariadb.eku.edu; user=student; database=csc340_db; port=3306; password=Maroon@21?;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // FIX 3: Added 'duration = @duration' into the middle of this SQL string
                string sql = "UPDATE bbwlcalendarevents SET title = @title, startTime = @startTime, endTime = @endTime, duration = @duration, date = @date WHERE eventId = @eventId";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@title", newTitleTextBox.Text);
                    cmd.Parameters.AddWithValue("@startTime", parsedStartTime);
                    cmd.Parameters.AddWithValue("@endTime", parsedEndTime);
                    cmd.Parameters.AddWithValue("@duration", eventDuration);
                    cmd.Parameters.AddWithValue("@date", newDate.Value.Date);

                    cmd.Parameters.AddWithValue("@eventId", thisEvent.eventId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            // 1. Close or hide the current screen
            this.Close();

            // 2. Find the hidden Form1 and make it visible again
            Application.OpenForms["Form1"].Show();
        }
    }
}
