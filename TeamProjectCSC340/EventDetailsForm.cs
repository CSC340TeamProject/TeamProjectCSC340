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
    public partial class EventDetailsForm : Form
    {
        public EventDetailsForm(EmployeeEvents selectedEvent)
        {
            InitializeComponent();

            // 1. Set the large, bold title label
            eventTitleLabel.Text = selectedEvent.title;

            // 2. Combine the rest of the information into your single details label
            eventDetailsLabel.Text = $"Date: {selectedEvent.date.ToShortDateString()}\n" +
                                     $"Time: {selectedEvent.startTime}\n" +
                                     $"Duration: {selectedEvent.duration} mins";
        }

        // 3. Fulfills Requirement R7.2.3: "Employees can click on 'ok' button to exit out of pop up"

        private void okButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}