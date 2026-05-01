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
    public partial class addEvent : Form
    {
        public addEvent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Add event button clicked
        private void button2_Click(object sender, EventArgs e)
        {
            // 1. VALIDATION: Check if any of the required fields are left blank
            if (string.IsNullOrWhiteSpace(titleTextBox.Text) ||
                string.IsNullOrWhiteSpace(startTimeCbb.Text) ||
                string.IsNullOrWhiteSpace(endTimeCbb.Text))
            {
                // Show a friendly warning instead of crashing!
                MessageBox.Show("Please enter all new information for the event, including start and end times.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // The 'return' keyword stops the method right here so it doesn't attempt the database save
                return;
            }

            // 2. If it passes validation, it is safe to parse the times and save to the database
            try
            {
                string eventTitle = titleTextBox.Text;
                DateTime eventDate = datePicker.Value.Date;
                TimeSpan parsedStartTime = DateTime.Parse(startTimeCbb.Text).TimeOfDay;
                TimeSpan parsedEndTime = DateTime.Parse(endTimeCbb.Text).TimeOfDay;
                TimeSpan eventDuration = parsedEndTime - parsedStartTime;

                if (eventDuration.TotalMinutes <= 0)
                {
                    MessageBox.Show("The End Time must be later than the Start Time.", "Time Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop the save process
                }

                string connStr = "server=csitmariadb.eku.edu; user=student; database=csc340_db; port=3306; password=Maroon@21?;";
                string sql = "INSERT INTO bbwlcalendarevents (employeeId, title, startTime, endTime, duration, date) VALUES (@employeeId, @title, @startTime, @endTime, @duration, @date)";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", Form1.loggedInEmployeeId);
                        cmd.Parameters.AddWithValue("@title", eventTitle);
                        cmd.Parameters.AddWithValue("@startTime", parsedStartTime);
                        cmd.Parameters.AddWithValue("@endTime", parsedEndTime);
                        cmd.Parameters.AddWithValue("@duration", eventDuration);
                        cmd.Parameters.AddWithValue("@date", eventDate);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Event successfully added!");

                this.Close();
                Form1 mainForm = (Form1)Application.OpenForms["Form1"];
                if (mainForm != null)
                {
                    mainForm.ReturnToMainMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding event: " + ex.Message);
            }

        }

        // Return to main menu button clicked
        private void returnButton_Click(object sender, EventArgs e)
        {
            // 1. Close or hide the current screen
            this.Close();

            // 2. Find the hidden Form1 and make it visible again
            Application.OpenForms["Form1"].Show();
        }

        private void ManagerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
