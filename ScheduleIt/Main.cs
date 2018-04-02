using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleIt
{
    public partial class formMain : Form
    {
        private Rooms roomForm;
        
        public formMain()
        {
            InitializeComponent();
        }

        //About button
        private void BAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.ShowDialog();
        }

        //Room button
        private void BRooms_Click(object sender, EventArgs e)
        {
            roomForm = new Rooms();  //New Form for list of Rooms
            roomForm.ShowDialog();
        }

        //Class button
        private void BClasses_Click(object sender, EventArgs e)
        {

        }

        //Instructor button
        private void BInstructors_Click(object sender, EventArgs e)
        {

        }
    }
}
