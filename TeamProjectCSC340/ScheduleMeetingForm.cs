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
    public partial class ScheduleMeetingForm : Form
    {
        public ScheduleMeetingForm()
        {
            InitializeComponent();

            // Hiding time selection combo box until we find available times
            startTimeCbb.Visible = false;
            endTimeCbb.Visible = false;
            addMeetingBtn.Visible = false;
            addMeetingBtn.Enabled = false;
        }


        // Find Meeting Times Button Clicked
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = meetingDatePicker.Value.Date;
            TimeSpan meetingDuration = TimeSpan.FromMinutes(60); // Default 1-hour slots
            List<Tuple<TimeSpan, TimeSpan>> allExistingEvents = new List<Tuple<TimeSpan, TimeSpan>>();

            string connStr = "server=csitmariadb.eku.edu; user=student; database=csc340_db; port=3306; password=Maroon@21?;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT startTime, endTime FROM bbwlcalendarevents WHERE date = @date";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", selectedDate);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TimeSpan start = (TimeSpan)reader["startTime"];
                                TimeSpan end = (TimeSpan)reader["endTime"];
                                allExistingEvents.Add(new Tuple<TimeSpan, TimeSpan>(start, end));
                            }
                        }
                    }
                }

                // Clear previous searches
                startTimeCbb.Items.Clear();
                endTimeCbb.Items.Clear();

                TimeSpan dayStart = new TimeSpan(8, 0, 0); // 8:00 AM
                TimeSpan dayEnd = new TimeSpan(17, 0, 0); // 5:00 PM
                TimeSpan currentSlotStart = dayStart;

                // Loop through the day to find open slots
                while (currentSlotStart.Add(meetingDuration) <= dayEnd)
                {
                    TimeSpan currentSlotEnd = currentSlotStart.Add(meetingDuration);
                    bool hasConflict = false;

                    foreach (var evt in allExistingEvents)
                    {
                        if (currentSlotStart < evt.Item2 && currentSlotEnd > evt.Item1)
                        {
                            hasConflict = true;
                            break;
                        }
                    }

                    // If no conflict, add the start and end times to your combo boxes
                    if (!hasConflict)
                    {
                        startTimeCbb.Items.Add(DateTime.Today.Add(currentSlotStart).ToString("hh:mm tt"));
                        endTimeCbb.Items.Add(DateTime.Today.Add(currentSlotEnd).ToString("hh:mm tt"));
                    }
                    currentSlotStart = currentSlotStart.Add(TimeSpan.FromMinutes(30)); // Shift by 30 mins
                }

                // Reveal controls if times were found
                if (startTimeCbb.Items.Count > 0)
                {
                    startTimeCbb.SelectedIndex = 0;
                    endTimeCbb.SelectedIndex = 0;

                    startTimeCbb.Visible = true;
                    endTimeCbb.Visible = true;
                    addMeetingBtn.Visible = true;
                    addMeetingBtn.Enabled = true;

                    MessageBox.Show("Available times found! Please select your preferred slot.");
                }
                else
                {
                    // Ensure they stay hidden if there is zero availability
                    startTimeCbb.Visible = false;
                    endTimeCbb.Visible = false;
                    addMeetingBtn.Visible = false;
                    MessageBox.Show("No available times found for all employees on this date. Please pick a different day.", "No Availability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error finding times: " + ex.Message);
            }
        }

        private void addMeetingBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(startTimeCbb.Text) || string.IsNullOrWhiteSpace(endTimeCbb.Text))
            {
                MessageBox.Show("Invalid DATE or TIME", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 1. Gather meeting parameters
                string meetingTitle = "Meeting " + titleTextBox.Text;
                DateTime meetingDate = meetingDatePicker.Value.Date;

                TimeSpan startTime = DateTime.Parse(startTimeCbb.Text).TimeOfDay;
                TimeSpan endTime = DateTime.Parse(endTimeCbb.Text).TimeOfDay;
                TimeSpan duration = endTime - startTime; // Auto-calculate duration

                string connStr = "server=csitmariadb.eku.edu; user=student; database=csc340_db; port=3306; password=Maroon@21?;";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // 2. Retrieve every employeeId
                    List<int> allEmployeeIds = new List<int>();
                    string getSql = "SELECT employeeId FROM bbwlcalenderemployees";
                    using (MySqlCommand getCmd = new MySqlCommand(getSql, conn))
                    {
                        using (MySqlDataReader reader = getCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                allEmployeeIds.Add(reader.GetInt32("employeeId"));
                            }
                        }
                    }

                    // 3. Insert the meeting for every employee
                    string insertSql = "INSERT INTO bbwlcalendarevents (employeeId, isMeeting, title, startTime, endTime, duration, date) VALUES (@empId, @is, @title, @start, @end, @duration, @date)";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertSql, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@title", meetingTitle);
                        insertCmd.Parameters.AddWithValue("@is", 1);
                        insertCmd.Parameters.AddWithValue("@start", startTime);
                        insertCmd.Parameters.AddWithValue("@end", endTime);
                        insertCmd.Parameters.AddWithValue("@duration", duration);
                        insertCmd.Parameters.AddWithValue("@date", meetingDate);

                        insertCmd.Parameters.Add("@empId", MySqlDbType.Int32);

                        foreach (int empId in allEmployeeIds)
                        {
                            insertCmd.Parameters["@empId"].Value = empId;
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Meeting successfully scheduled for all employees!");
                this.Close();

                Form1 mainForm = (Form1)Application.OpenForms["Form1"];
                if (mainForm != null)
                {
                    mainForm.ReturnToMainMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error scheduling meeting: " + ex.Message);
            }
        }

        private void startTimeCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startTimeCbb.SelectedIndex >= 0 && startTimeCbb.SelectedIndex < endTimeCbb.Items.Count)
            {
                endTimeCbb.SelectedIndex = startTimeCbb.SelectedIndex;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            // 1. Close the manager scheduling tool
            this.Close();

            // 2. Safely find your main menu (Form1) and make sure it is active/refreshed
            Form1 mainForm = (Form1)Application.OpenForms["Form1"];
            if (mainForm != null)
            {
                mainForm.ReturnToMainMenu();
            }
        }
    }
}
