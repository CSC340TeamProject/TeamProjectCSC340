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
    public partial class EmployeeEventsForm : Form
    {
        public int employeeId; //holds employee's id
        public List<EmployeeEvents> eventsList; //holds events

        public EmployeeEventsForm()
        {
            InitializeComponent();
            eventsList = Events.getEvents(employeeId);
        }
    }
}
