using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_task05
{
    class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public ToDo (string title, bool isdone)
        {
            Title = title;
            IsDone = isdone;
        }

        public void Getmetod()
        {
            Console.WriteLine($"Задача {this.IsDone} {this.Title}");
        }

    }
}
