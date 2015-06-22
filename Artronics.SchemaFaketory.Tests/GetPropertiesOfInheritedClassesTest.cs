using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Artronics.SchemaFaketory.Tests
{
    [TestFixture]
    public class GetPropertiesOfInheritedClassesTest
    {
        [Test]
        public void Get_All_Properties_Which_Are_Classes()
        {
            var properties = PropertiesOfInheritedClasses.GetProperties<FooInh>();
            //Assert.IsInstanceOf<>(properties[0]);
        }
    }
    //stubs
    class FooInh
    {
        public string str { get; set; }
        public int number { get; set; }
        public enum AnEnum { }
    }

    class BarInh
    {
        public string SomeStr { get; set; }
        public FooInh RefToAType { get; set; }
        public struct AnStruct { }
    }

    class BazIng
    {
        public List<FooInh> AListOfTypes{ get; set; }
        public ICollection<BarInh> ACollectionOfTypes{ get; set; }
        public double DoubleNumber { get; set; }
    }
}
