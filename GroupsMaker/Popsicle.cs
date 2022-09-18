using GroupMaker;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupsMaker
{

    class Popsicle
    {
        private GroupsMaker.Form1 form;
        private Students students;
        private bool replaceS;

        public Popsicle(GroupsMaker.Form1 Form, Students students)
        {
            this.form = Form;
            this.students = students;
            this.replaceS = false;
        }

        public void replaceSticks(bool rep)
        {
            this.replaceS = rep;
            if (rep)
            {
                this.students.markAllAvailable();
                form.replaceSticksToolStripMenuItem.Text = "&Don't Replace Sticks";
            } else
            {
                form.replaceSticksToolStripMenuItem.Text = "&Replace Sticks";
            }
        }

        internal void nextPopsicleStick()
        {
            form.clear();
            if (this.students.getPresentStudents().Count > 0)
            {
                List<Student> available = new List<Student>();
                while (available.Count() < 1)
                {
                    available = getAvailable(students.StudentList);
                    available = students.shuffleList(available);
                    if (available.Count() < 1)
                    {
                        this.students.markAllAvailable();
                    }
                    else
                    {
                        this.form.popsicleStickPulled.Text = available[0].getWholeName();
                        lastCalled = available[0];
                    }
                }
                if (!replaceS)
                {
                    available[0].WasCalled = true;
                }
            } else
            {
                this.form.popsicleStickPulled.Text = "No students available";
            }
            this.form.popLayoutPanel.Visible = true;
            this.form.popsicleStickPulled.BackColor = Color.Transparent;
            this.form.popsicleStickPulled.Size = new Size(850, 150);
        }

        public void showLastCalled()
        {
            form.clear();
            if (lastCalled == null)
            {
                this.form.popsicleStickPulled.Text = "No student saved";
            }
            else
            {
                this.form.popsicleStickPulled.Text = lastCalled.getWholeName();
            }
            this.form.popsicleStickPulled.Visible = true;
            this.form.popsicleStickPulled.BackColor = Color.Transparent;
            this.form.popsicleStickPulled.Size = new Size(850, 150);
        }

        private List<Student> getAvailable(List<Student> students)
        {
            List<Student> avail = new List<Student>();
            foreach(Student s in students){
                if (s.IsPresent)
                {
                    if (!s.WasCalled)
                    {
                        avail.Add(s);
                    }
                }
            }
            return avail;
        }

        private Student lastCalled { get; set; }
    }
}
