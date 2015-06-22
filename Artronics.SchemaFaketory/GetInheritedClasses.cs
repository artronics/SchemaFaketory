using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Artronics.SchemaFaketory
{
    public static class GetInheritedClasses
    {
        static GetInheritedClasses() { }

        public static List<Type> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class
        {
            List<Type> objects = new List<Type>();
            foreach (Type type in
                Assembly.GetAssembly(typeof(T)).GetTypes()
                    .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
            {
                objects.Add(type);
            }
            //objects.Sort();
            return objects;
        }
    }
}