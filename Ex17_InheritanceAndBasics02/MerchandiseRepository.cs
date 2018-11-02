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
            if (merchandises[0] is Merchandise)
            {
                List<Book> books = new List<Book>();
                foreach (var merchandise in merchandises)
                {
                    int x = 1;
                    books[x] = (Book)merchandises[x];
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
                List<Amulet> amulets = new List<Amulet>();
                foreach (var merchandise in merchandises)
                {
                    int i = 0;
                    amulets[i] = (Amulet)merchandises[i];
                }
                double value = 0;
                //for (int i = 0; i < merchandises.Count; i++)
                //{
                //    value += amulets[i].;
                //}
                return value;
            }

        }
    }
}
