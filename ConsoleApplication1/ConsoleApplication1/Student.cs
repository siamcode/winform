using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Student
    {
        private int id;
        private string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int ID { get; set; }
        public string NAME { get; set; }

    }
}
