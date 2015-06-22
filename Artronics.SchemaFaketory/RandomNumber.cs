using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artronics.SchemaFaketory
{
    public class RandomNumber
    {
        private readonly int _generatedNumber;

        public RandomNumber(int exactNumber)
        {
            _generatedNumber = exactNumber;

        }

        public RandomNumber(int minNumber, int maxNumber)
        {
            var rnd = new Random();
            _generatedNumber = rnd.Next(minNumber, maxNumber + 1);
        }

        public int Get()
        {
            return _generatedNumber;
        }
    }
}
