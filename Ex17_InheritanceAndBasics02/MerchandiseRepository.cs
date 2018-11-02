using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_InheritanceAndBasics02
{
    public class MerchandiseRepository
    {
        List<Merchandise> merchandises = new List<Merchandise>();
        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }
        public Merchandise GetMerchandise(string itemId)
        {
            for (int i = 0; i < merchandises.Count; i++)
            {
                if (merchandises[i].ItemId == itemId)
                {
                    return merchandises[i];
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            int x = 0;
            if (merchandises[x] is Book)
            {
                List<Book> books = new List<Book>();
                foreach (Merchandise merchandise in merchandises)
                {                    
                    books.Add(merchandises[x] as Book);                    
                    x++;
                }
                double value = 0;
                for (int i = 0; i < books.Count; i++)
                {
                    value += books[i].Price;
                }
                return value;
            }
            else 
            {
                double value = 0;
                foreach (Merchandise merchandise in merchandises)
                {                    
                    value += Utility.GetValueOfMerchandise(merchandises[x]);
                    x++;
                }
                return value;
            }
        }
    }
}
