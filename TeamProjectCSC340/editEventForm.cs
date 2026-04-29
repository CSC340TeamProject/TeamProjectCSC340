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
            if (newEndTime.Value.TimeOfDay <= newStartTime.Value.TimeOfDay)
            {
                MessageBox.Show("End time must be after start time.");
                return;
            }

            //edit event
            updateEvent();

            this.Close();
            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        //function to check if all information has been entered
        public bool isAllInfoEntered()
        {
            if (string.IsNullOrWhiteSpace(newTitleTextBox.Text))
                return false;
            return true;
        }

        //function to update event
        public void updateEvent()
        {
            string connStr =
                "server=csitmariadb.eku.edu; user=student; database=csc340_db; port=3306; password=Maroon@21?;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql =
                    "UPDATE bbwlcalendarevents SET title = @title, startTime = @startTime, endTime = @endTime, date = @date WHERE eventId = @eventId";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@title", newTitleTextBox.Text);
                    cmd.Parameters.AddWithValue("@startTime", newStartTime.Value);
                    cmd.Parameters.AddWithValue("@endTime", newEndTime.Value);
                    cmd.Parameters.AddWithValue("@date", newDate.Value.Date);

                    // existing event ID
                    cmd.Parameters.AddWithValue("@eventID", thisEvent.eventId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
