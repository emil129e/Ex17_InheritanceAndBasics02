using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_InheritanceAndBasics02
{    
    public class Utility
    {        
        public static double GetValueOfMerchandise(Merchandise merchandise)
        {
            List<Merchandise> merchandises = new List<Merchandise>();
            if (merchandise is Book book)
            {                
                return book.Price;
            }
            else 
            {
                Amulet amulet = (Amulet)merchandise;
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
        }   
 
        public static double GetValueOfCourse(Course course)
        {
            double initialPrice = 875;
            double coursePrice = 0.0;
            for (int i = 0; i < course.DurationInMinutes / 60; i++)
            {
                coursePrice += 875;
            }
            if (course.DurationInMinutes == 0)
            {
                return 0;
            }
            else
            {
                return coursePrice + initialPrice;
            }
        }
    }
}
