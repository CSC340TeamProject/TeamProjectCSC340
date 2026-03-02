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
            string selectedEvent = (string) EventsLists.SelectedItem;

            if(selectedEvent == "Friday Meeting")
            {
                MessageBox.Show("Company Wide Meeting this Friday, Attendence is Mandatory.\nTime: 10:00AM\nLocation: Meeting Room 3B");
            }
            if (selectedEvent == "Tuesday Conference")
            {
                MessageBox.Show("Team COnference Tuesday. Atendence not required but highly recomended you come.\nTime: 11:00AM\nLocation: Meeting Room 3A");
            }
            if (selectedEvent == "Wednesday Mixer")
            {
                MessageBox.Show("Anual Company Mixer, Enjoy complemetary refreshments, Mingle with both clients and co workers.\nTime: 6:00PM\nLocation: Event Hall");
            }
        }
    }
}
