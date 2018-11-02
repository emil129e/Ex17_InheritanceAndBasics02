using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_InheritanceAndBasics02
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables = new List<IValuable>();
        public void AddValuable(IValuable valuable) 
        {

        }
        public IValuable GetValuable(string id)
        {
            return valuables[0];
        }
        public double GetTotalValue()
        {
            return 1;
        }

        public double GetValue()
        {
            throw new NotImplementedException();
        }
        public int count()
        {
            return 1;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Save(string filename)
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            throw new NotImplementedException();
        }

        public void Load(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
