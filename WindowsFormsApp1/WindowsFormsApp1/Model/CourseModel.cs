using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class CourseModel
    {
        public CourseModel(int courseID, string chapter, string name)
        {
            this.CourseID = courseID;
            this.Chapter = chapter;
            this.Name = name;
        }

        public int CourseID { get; set; }
        public string Chapter { get; set; }
        public string Name { get; set; }
    }
}
