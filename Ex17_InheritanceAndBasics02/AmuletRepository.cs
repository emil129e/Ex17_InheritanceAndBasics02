using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_InheritanceAndBasics02
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet Getamulet(string itemId)
        {
            for (int i = 0; i < amulets.Count; i++)
            {
                if (amulets[i].ItemId == itemId)
                {
                    return amulets[i];
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double value = 0;
            for (int i = 0; i < amulets.Count; i++)
            {
                value += Utility.GetValueOfAmulet(amulets[i]);
            }
            return value;
        }
    }
}
