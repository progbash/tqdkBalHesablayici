using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balHesablama
{
    class Result
    {

        public List<int> results;
        public int umumiBal=0;
        public Result()
        {
            results = new List<int>();
        }
        public void fennNeticeleri(int duz,int sehv,int bal)
        {
            results.Add(duz*bal-sehv*bal/4);
        }

        public int calculate()
        {
            foreach (var item in results)
            {
                umumiBal += item;
            }
            return umumiBal;
        }
    }
}
