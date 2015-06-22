using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artronics.SchemaFaketory.Tests.Stubs;
using NUnit.Framework;

namespace Artronics.SchemaFaketory.Tests
{
    [TestFixture]
    public class ForTest
    {
        [Test]
        public void ReflectionTestOnCreate()
        {
            var expected = For<Foo>.Create<FakeFoo>(2);
            var actual = new List<Foo>();
            Assert.IsInstanceOf<Foo>(expected[0]);
        }

        [Test]
        [ExpectedException(typeof(MissingMethodException),
        ExpectedMessage = "There is no Method OnModelFaking inside your class. Are you sure MyClass is inherited from FakeModel?")]
        public void ExceptionOnNonProperCalss()
        {
            For<Foo>.Create<MyClass>(1);
        }
    }
    public class MyClass { }
}
