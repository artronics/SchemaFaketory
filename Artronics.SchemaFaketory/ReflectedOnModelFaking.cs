using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Artronics.SchemaFaketory
{
    public static class ReflectedOnModelFaking<TModel, TFakeModel>
        where TFakeModel : class,new()
    {
        public static TModel GetReflectedOnModelFaking()
        {
            var fakeModel = typeof(TFakeModel);
            var fakeModelInstance = new TFakeModel();

            var actualModel = typeof(TModel);
            var modelInstance = Activator.CreateInstance(actualModel);

            object[] paramsArray = new object[] { modelInstance };
           
            try
            {
                var createdFakeModel = fakeModel.InvokeMember("OnModelFaking",
                    BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance,
                    null, fakeModelInstance, paramsArray);

                if (createdFakeModel != null &&
                    createdFakeModel.GetType() == modelInstance.GetType())
                {
                    dynamic returnActualModel = typeof(TModel);
                    returnActualModel = createdFakeModel;
                    return returnActualModel;
                }
                throw new NullReferenceException("Reflected OnModelFaking method return null.");
            }
            catch (MissingMethodException e)
            {
                throw new MissingMethodException("There is no Method OnModelFaking inside your class. Are you sure "
                    + typeof(TFakeModel).Name + " is inherited from FakeModel?",e);
            }
        }
    }
}
