using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Artronics.SchemaFaketory.Tests
{
    [TestFixture]
    public class RandomNumberTest
    {
        [Test]
        public void RandomNumberTests()
        {
            var random = new RandomNumber(1);
            Assert.AreEqual(1,random.Get());

        }
    }
}
