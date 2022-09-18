using GroupMaker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupsMaker
{
    public partial class Form1 : Form
    {
        private Students students;
        private Popsicle pop;
        private Buddy buddy;

        public Form1()
        {
            InitializeComponent();
            students = new Students(this);
            pop = new Popsicle(this, students);
            buddy = new Buddy(this, students);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            popsicleStickPulled.BackColor = Color.Transparent;
        }

        private void loadStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = File.ReadAllText(filename);
            students.loadStudents(readfile);
        }

        private void markAllAbsentBtn_Click(object sender, EventArgs e)
        {
            students.markAllAbsent();
            students.loadLists();
        }

        private void markSelAbsentBtn_Click(object sender, EventArgs e)
        {
            foreach(string wholename in presentStudents.SelectedItems)
            {
                students.markAbsent(wholename);
            }
            students.loadLists();
        }

        private void markAllPresentBtn_Click(object sender, EventArgs e)
        {
            students.markAllPresent();
            students.loadLists();

        }


        private void markSelPresentBtn_Click_1(object sender, EventArgs e)
        {
            foreach (string wholename in absentStudents.SelectedItems)
            {
                students.markPresent(wholename);
            }
            students.loadLists();
        }

        private void popsicleBtn_Click(object sender, EventArgs e)
        {
            pop.nextPopsicleStick();
        }

        internal void clear()
        {
            popLayoutPanel.Visible = false;

            buddyLayoutPanel.Visible = false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void replaceSticksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (replaceSticksToolStripMenuItem.Text == "&Replace Sticks")
            {
                pop.replaceSticks(true);
            }else
            {
                pop.replaceSticks(false);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            students.markAllAvailable();
        }

        private void showLastCalledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pop.showLastCalled();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buddy.showBuddies();
        }

        private void buddyTalkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showLastPartnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.clear();
            buddy.makeVisible();
        }

        private void peanutButterJellyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            header1.Load(Application.StartupPath + "\\pb.png");
            header2.Load(Application.StartupPath + "\\jelly.png");
            buddyview.Columns[0].HeaderText = "Peanut Butter";
            buddyview.Columns[1].HeaderText = "Jelly";
        }

        private void chipsAndSalsaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            header1.Load(Application.StartupPath + "\\chips.png");
            header2.Load(Application.StartupPath + "\\salsa.png");
            buddyview.Columns[0].HeaderText = "Chips";
            buddyview.Columns[1].HeaderText = "Salsa";
        }

        private void frybreadAndStewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            header1.Load(Application.StartupPath + "\\frybread.png");
            header2.Load(Application.StartupPath + "\\stew.png");
            buddyview.Columns[0].HeaderText = "Frybread";
            buddyview.Columns[1].HeaderText = "Stew";
        }

        private void baconAndEggsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            header1.Load(Application.StartupPath + "\\bacon.png");
            header2.Load(Application.StartupPath + "\\eggs.png");
            buddyview.Columns[0].HeaderText = "Bacon";
            buddyview.Columns[1].HeaderText = "Eggs";
        }

        private void makeAlwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(makeAlwaysOnTopToolStripMenuItem.Text=="Make Always On Top")
            {
                Form.ActiveForm.TopMost = true;
                makeAlwaysOnTopToolStripMenuItem.Text = "Make Not Always On Top";
            } else
            {
                makeAlwaysOnTopToolStripMenuItem.Text = "Make Always On Top";
                Form.ActiveForm.TopMost = false;
            }
        }

        private void hideStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(hideStudentsToolStripMenuItem.Text=="Hide Students")
            {
                hideStudentsToolStripMenuItem.Text = "Show Students";
                this.Width = this.Width - 300;
            } else
            {
                hideStudentsToolStripMenuItem.Text = "Hide Students";
                this.Width = this.Width + 300;
            }

            studentLayoutPanel.Visible = !studentLayoutPanel.Visible;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
