using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Artronics.SchemaFaketory
{
    public static class InheritedAbstractClass
    {
        static InheritedAbstractClass()
        {
        }

        public static List<Type> GetInheritedTypesFromFakeModel()
        {
            var types = new List<Type>();

            var query = (from type in Assembly.GetAssembly(typeof(BaseFakeModel)).GetTypes()
                         where type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(BaseFakeModel))
                         //typeof(FakeModel<>).MakeGenericType(type).IsClass
                         select type
                         ).ToList();
                             

            return query;
        }
    }
}
