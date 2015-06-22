using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Artronics.SchemaFaketory
{
    public static class PropertiesOfInheritedClasses
    {
        static PropertiesOfInheritedClasses()
        {
        }

        public static List<Type> GetProperties<T>()
        {
            var inheritedClassesFromFakeModel = GetInheritedClasses.GetEnumerableOfType<FakeModel<object>>();
            var query = from propertyType in typeof(T).GetProperties()
                        from type in inheritedClassesFromFakeModel
                        where propertyType == type
                            select propertyType;
            foreach (var VARIABLE in query)
            {
                Console.WriteLine(VARIABLE);
            }

            var properties = new List<Type>();
            foreach (PropertyInfo property in typeof(T).GetProperties())
            {
                
                properties.Add(property.PropertyType);
            }

            return properties;
        }
    }
}
