using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artronics.SchemaFaketory.Tests.Stubs;
using NUnit.Framework;

namespace Artronics.SchemaFaketory.Tests
{
    [SetUpFixture]
    public class SetUp
    {
        public FakeFoo FakeFooInstance{get; set;}
        public FakeBar FakeBarInstance {get; set; }
        public FakeBaz FakeBazInstance { get; set; }

        [SetUp]
        public void CreateInstancesOfFakeModels()
        {
            FakeFooInstance = new FakeFoo();
            FakeBarInstance = new FakeBar();
            FakeBazInstance = new FakeBaz();
        }
    }
}
