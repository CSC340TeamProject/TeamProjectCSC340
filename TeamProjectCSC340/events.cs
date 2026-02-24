using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectCSC340
{
    public class events
    {
        //attributes of an event
        public string title; //holds the title of the meeting
        public DateTime date { get; set; }  //holds the date of the meeting
        public TimeSpan startTime { get; set; } //holds the start time of the meeting
        public TimeSpan endTime { get; set; } //holds the end time of the meeting
        public TimeSpan duration => endTime - startTime; //holds the duration of the meeting 
        public int employeeId; //foreign key to access all of the employee's events

        //function to display the employee's events
        public static List<events> getEvents(int employeeId)
        {
            //initalize an empty list of events
            List<events> events = new List<events>();

            //connect to the database
            string connStr =
                    "server=csitmariadb.eku.edu;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                //query to return the employee's event details
                string sql = "SELECT * FROM bbwlcalenderemployees WHERE employeeId = @thisemployeeId";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@thisemployeeId", employeeId);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    //add the events to the events list
                    events.Add(new events
                    {
                        employeeId = myReader.GetInt32("employeeId"),
                        title = myReader.GetString("title"),
                        startTime = myReader.GetTimeSpan("startTime"),
                        endTime = myReader.GetTimeSpan("endTime"),
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");

            //return the list of events
            return events;
        }
    }
}
