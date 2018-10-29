using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_InheritanceAndBasics02
{
    public class Utility
    {
        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public static double GetValueOfAmulet(Amulet amulet)
        {
            double qualityValue;
            switch (amulet.Quality)
            {
                case Level.low:
                    qualityValue = 12.5;
                    break;
                case Level.medium:
                    qualityValue = 20;
                    break;
                default:
                    qualityValue = 27.5;
                    break;
            }
            return qualityValue;
        }
        public static double GetValueOfCourse(Course course)
        {
            double courseValue = 0;

            if (course.DurationInMinutes > 0)
            {
                course.DurationInMinutes /= 60;
                courseValue = 875 * course.DurationInMinutes + 875;
            }
            return courseValue;
        }
    }
}
