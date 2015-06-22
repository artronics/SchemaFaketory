using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Artronics.SchemaFaketory
{
    public static class For<TModel>
        where TModel : class
    {


        public static List<TModel> Create<TFakeModel>(int numberOfObjects)
            where TFakeModel : class,new()
        {
            var count = new RandomNumber(numberOfObjects).Get();
            return CreateModels<TFakeModel>(count);
        }

        //overload with max and min
        public static List<TModel> Create<TFakeModel>(int minNumberOfObjects,int maxNumberOfObjects)
            where TFakeModel : class,new()
        {
            var count = new RandomNumber(minNumberOfObjects,maxNumberOfObjects).Get();
            return CreateModels<TFakeModel>(count);
        }

        private static List<TModel> CreateModels<TFakeModel>(int count) where TFakeModel : class, new()
        {
            var models = new List<TModel>();
            for (int i = 0; i < count; i++)
            {
                var model = ReflectedOnModelFaking<TModel, TFakeModel>.GetReflectedOnModelFaking();
                models.Add(model);
            }
            return models;
        }
    }
}
