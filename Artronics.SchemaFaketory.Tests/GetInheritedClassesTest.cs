using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Artronics.SchemaFaketory.Tests.Mocks;
using Artronics.SchemaFaketory.Tests.Stubs;
using Artronics.SchemaFaketory;
using NUnit.Framework;

namespace Artronics.SchemaFaketory.Tests
{
    [TestFixture]
    public class GetInheritedClassesTest
    {
        
        [Test]
        public void GetAllInheritedClasses()
        {
            //var classes= new List<FakeModel>();
            var actualClasses = GetInheritedClasses.GetEnumerableOfType<BaseFakeModelMock>();
            //var expectedClasses = new List<FakeModelMock<FooInherited>>{new FooInherited(),new BarInherited(),new BazInherited()};
            //Assert.is
            Assert.AreEqual(actualClasses[0], typeof(FooInherited));
            //Assert.AreEqual(actualClasses[1], typeof(BarInherited));
            //Assert.AreEqual(actualClasses[2], typeof(BazInherited));
            //Assert.IsInstanceOf<FooInherited>(actualClasses[0]);
            //Assert.IsInstanceOf<BarInherited>(actualClasses[1]);
            //Assert.IsInstanceOf<BazInherited>(actualClasses[2]);
            //Assert.Contains(new FakeFoo(), expectedClasses);//(List<FakeModelMock>)actualClasses);
            //CollectionAssert.AreEquivalent(expectedClasses,actualClasses);
        }
    }
    abstract class BaseFakeModelMock { }
    abstract class FakeModelMock<T>:BaseFakeModelMock
    {
        protected abstract void kir();
    }
    class FooInherited:FakeModelMock<Foo> {
        protected override void kir()
        {
            
        }
    }
    class BarInherited:FakeModelMock<Bar> {
        protected override void kir()
        {
            
        }
    }
    class BazInherited : FakeModelMock<Baz> {
        protected override void kir()
        {
            
        }
    }
}
