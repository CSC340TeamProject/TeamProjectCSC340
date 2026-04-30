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
            // 1. Capture inputs from your visual interface
            string eventTitle = titleTextBox.Text;
            DateTime eventDate = datePicker.Value.Date;
            TimeSpan startTime = startTimePicker.Value.TimeOfDay;
            TimeSpan endTime = endTimePicker.Value.TimeOfDay;

            // Calculate duration as required by your database schema
            TimeSpan duration = endTime - startTime;

            string connectionString = "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 2. REQUIREMENT R2.2: Check for existing event conflicts on the same date
                    string checkConflictQuery = @"SELECT eventId FROM bbwlcalendarevents 
                                          WHERE employeeId = @employeeId 
                                          AND date = @date 
                                          AND (startTime < @endTime AND endTime > @startTime)";

                    using (MySqlCommand checkCmd = new MySqlCommand(checkConflictQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@employeeId", Form1.loggedInEmployeeId);
                        checkCmd.Parameters.AddWithValue("@date", eventDate);
                        checkCmd.Parameters.AddWithValue("@startTime", startTime);
                        checkCmd.Parameters.AddWithValue("@endTime", endTime);

                        using (MySqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // R2.2.2.1: Conflict detected
                                MessageBox.Show("Event Overlap. Please adjust the date or time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return; // Stop execution here so it doesn't save
                            }
                        }
                    }

                    // 3. REQUIREMENT R2.2.3: No conflict exists, commit the event to the database
                    string insertQuery = @"INSERT INTO bbwlcalendarevents (employeeId, title, startTime, endTime, duration, date) 
                                   VALUES (@employeeId, @title, @startTime, @endTime, @duration, @date)";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@employeeId", Form1.loggedInEmployeeId);
                        insertCmd.Parameters.AddWithValue("@title", eventTitle);
                        insertCmd.Parameters.AddWithValue("@startTime", startTime);
                        insertCmd.Parameters.AddWithValue("@endTime", endTime);
                        insertCmd.Parameters.AddWithValue("@duration", duration);
                        insertCmd.Parameters.AddWithValue("@date", eventDate);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Event successfully added to your calendar!");

                        // Return to the main menu
                        this.Close();


                        // 2. Find the hidden Form1 and make it visible again
                        Application.OpenForms["Form1"].Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
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
    }
}
