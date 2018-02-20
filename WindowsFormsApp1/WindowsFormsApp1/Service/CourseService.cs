using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Service
{
    public class CourseService
    {
        public IList<CourseModel> GetCourse(int userID)
        {
            return MockUpCourse();
        }


        public IList<CourseModel> MockUpCourse()
        {
            IList<CourseModel> result = new List<CourseModel>();
            result.Add(new CourseModel(1, "章節1-1", "1-1"));
            result.Add(new CourseModel(2, "章節2-1", "2-1"));
            return result;
        }


    }
}
