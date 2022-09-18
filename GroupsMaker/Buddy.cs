using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupMaker;

namespace GroupsMaker
{
    class Buddy
    {
        private GroupsMaker.Form1 form;
        private Students students;

        public Buddy(GroupsMaker.Form1 Form, Students students)
        {
            this.form = Form;
            this.students = students;
        }

        public void makeVisible()
        {
            form.buddyview.Visible = true;
            form.header1.Visible = true;
            form.header2.Visible = true;
        }

        public void showBuddies()
        {
            form.clear();
            List<Student> available = students.getPresentStudents();
            if (available.Count() > 1) {
                available = students.shuffleList(available);
                var source = new BindingSource();
                List<MyStruct> list = new List<MyStruct>();
                for (var i = 0; i < available.Count(); i++)
                {
                    MyStruct temp = new MyStruct(available[i].getWholeName(),available[i + 1].getWholeName());
                    list.Add(temp);
                    i = i + 1;
                    if (i == available.Count() - 2)
                    {
                        i = i + 1; 
                        temp = new MyStruct(available[i-2].getWholeName(), available[i -1].getWholeName() + " AND " + available[i].getWholeName());
                        list[list.Count() - 1] = temp;
                    }
                }
                source.DataSource = list;
                form.buddyview.DataSource = source;
                form.buddyLayoutPanel.Visible = true;
                form.buddyview.Columns[0].HeaderText = "Peanut Butter";
                form.buddyview.Columns[1].HeaderText = "Jelly";
                form.buddyview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                form.buddyview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; 
                form.buddyview.RowsDefaultCellStyle.BackColor = Color.Bisque;
                form.buddyview.AlternatingRowsDefaultCellStyle.BackColor =
                    Color.Beige;
            } else
            {
                MessageBox.Show("There are too few students to do buddy talk.");
            }
        }
    }
}



class MyStruct
{
    public string First { get; set; }
    public string Second { get; set; }


    public MyStruct(string First, string Second)
    {
        this.First = First;
        this.Second = Second;
    }
}
