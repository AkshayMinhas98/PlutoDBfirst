using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoDBfirst
{
    public enum Level:byte
    {
        Beginer=1,
        Intermediate=2,
        Advanced=3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContextEntities();
            //var data = context.GetCourses();
            var x = new Course()
            {
                Level = Level.Beginer,
                CourseID=5,
                AuthorID=4,
                Title="asas",
                FullPrice=44,
                Description="asdasdasdasdasd"
                
            };

            context.Courses.Add(x);
            context.SaveChanges();
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.FullPrice);
            //}
            ////Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}