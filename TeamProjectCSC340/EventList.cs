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
    public partial class EventList : Form
    {
        public EventList()
        {
            InitializeComponent();
        }

        private void EventsLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEvent = (string) MeetingList.SelectedItem;

            if (selectedEvent == "Friday Meeting")
            {
                MessageBox.Show("Company Wide Meeting this Friday, Attendence is Mandatory.\nTime: 10:00AM\nLocation: Meeting Room 3B");
            }
        }

        private void ConferenceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEvent2 = (string)ConferenceList.SelectedItem;
            if (selectedEvent2 == "Tuesday Conference")
            {
                MessageBox.Show("Team Conference Tuesday. Atendence not required but highly recomended you come.\nDate: March 3rd\nTime: 11:00AM\nLocation: Meeting Room 3A");
            }
        }

        private void MixerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEvent3 = (string)MixerList.SelectedItem;
            if (selectedEvent3 == "Wednesday Mixer")
            {
                MessageBox.Show("Anual Company Mixer, Enjoy complemetary refreshments, Mingle with both clients and co workers.\nDate: March 4th\nTime: 6:00PM\nLocation: Event Hall");
            }
        }

        private void SeminarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEvent4 = (string)SeminarList.SelectedItem;
            if (selectedEvent4 == "Monday Seminar" || selectedEvent4 == "(Delayed)")
            {
                MessageBox.Show("The Monday Seminar has Been moved to next Monday, March 9th\nTime: 6:00PM\nLocation: Event Hall");
            }
        }
    }
}
