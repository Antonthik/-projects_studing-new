using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_task1
{
    class Peoples
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Work { get; set; }

        public Peoples (string name,int age,string work)
        {
            Name = name;
            Age = age;
            Work = work;
        }
    }
}
