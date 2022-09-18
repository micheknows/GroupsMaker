using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Linq;

namespace GroupMaker
{
    class Students
    {
        private GroupsMaker.Form1 form;
        private string filename = "students.txt";


        public Students(GroupsMaker.Form1 Form)
        {
            this.form = Form;
            try
            {
                StudentList = new JavaScriptSerializer().Deserialize<List<Student>>(File.ReadAllText(filename));
                this.loadLists();
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }

        public void loadStudents(string wholefile)
        {
            try
            {
                List<Student> temp = new List<Student>();
                foreach (String wholename in wholefile.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    temp.Add(new Student(wholename));
                }
                if (temp.Count() > 0)
                {
                    StudentList = temp;
                } else
                {
                    MessageBox.Show("Students did not load correctly.  Keeping old list.");
                }
            }
            catch
            {
                MessageBox.Show("Students did not load correctly.  Keeping old list.");
            }
            saveStudents();
            loadLists();
        }

        private void saveStudents()
        {
            string jsonStudentList = new JavaScriptSerializer().Serialize(StudentList);
            Student[] deserializedStudentList = new JavaScriptSerializer().Deserialize<Student[]>(jsonStudentList);
            File.WriteAllText(filename, jsonStudentList);
        }

        public void markAllAbsent()
        {
            foreach (Student s in StudentList)
            {
                s.IsPresent = false;
            }
            saveStudents();
        }

        public void markAllPresent()
        {
            foreach (Student s in StudentList)
            {
                s.IsPresent = true;
            }
            saveStudents();
        }
        public void markAllAvailable()
        {
            foreach (Student s in StudentList)
            {
                s.WasCalled = false;
            }
            saveStudents();
        }

        public void markPresent(string s)
        {
            getStudentFromWholeName(s).IsPresent = true;
            saveStudents();
        }


        public void markAbsent(string s)
        {
            getStudentFromWholeName(s).IsPresent = false;
            saveStudents();
        }

        public Student getStudentFromWholeName(string wholename)
        {
            foreach (Student s in StudentList)
            {
                if (s.FirstName + " " + s.LastName == wholename)
                {
                    return s;
                }
            }
            return null;
        }

        public List<Student> getPresentStudents()
        {
            List<Student> p = new List<Student>();
            foreach (Student s in StudentList)
            {
                if (s.IsPresent)
                {
                    p.Add(s);
                }
            }
            return p;
        }

        public List<Student> getAbsentStudents()
        {
            List<Student> p = new List<Student>();
            foreach (Student s in StudentList)
            {
                if (!s.IsPresent)
                {
                    p.Add(s);
                }
            }
            return p;
        }



        public void loadLists()
        {
            loadPresent(getPresentStudents());
            loadAbsents(getAbsentStudents());
        }

        private void loadPresent(List<Student> presents)
        {
            this.form.presentStudents.Items.Clear();
            foreach (Student s in presents)
            {
                this.form.presentStudents.Items.Add(s.getWholeName());
            }
            this.form.presentStudentsLabel.Text = "Present Students:  " + presents.Count.ToString();
        }

        private void loadAbsents(List<Student> absents)
        {
            this.form.absentStudents.Items.Clear();
            foreach (Student s in absents)
            {
                this.form.absentStudents.Items.Add(s.getWholeName());
            }
            this.form.absentStudentsLabel.Text = "Absent Students:  " + absents.Count.ToString();
        }

        public List<Student> shuffleList(List<Student> students)
        {
            var rnd = new Random();
            return students.OrderBy(ItemActivation => rnd.Next()).ToList();
        }
         
        public List<Student> StudentList { get; set; }
    }
}
