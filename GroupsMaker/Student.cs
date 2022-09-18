using Newtonsoft.Json;
using System;

namespace GroupMaker
{
    class Student
    {
        public Student(String wholename)
        {
            this.FirstName = this.getFirstName(wholename);
            this.LastName = this.getLastName(wholename);
            this.IsPresent = true;
            this.WasCalled = false;
        }
        public Student()
        {

        }

        public override string ToString()
        {
            string text = "";
            text = this.FirstName + " " + this.LastName + ":  " + this.IsPresent;
            return text;
        }

        public string getWholeName()
        {
            return this.FirstName + " " + this.LastName;
        }

        private string getLastName(string wholename)
        {
            if (wholename.Split(' ').Length > 1)
            {
                return wholename.Split(' ')[1];
            } else
            {
                return " ";
            }
        }

        private string getFirstName(string wholename)
        {
            return wholename.Split(' ')[0];
        }

        [JsonProperty("FirstName")]
        public string FirstName {get; set;}
        [JsonProperty("LastName")]
        public string LastName { get; set; }
        [JsonProperty("IsPresent")]
        public bool IsPresent { get; set; }
        [JsonProperty("WasCalle")]
        public bool WasCalled { get; set; }
    }
}
