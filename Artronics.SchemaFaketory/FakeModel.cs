using System.Text;
using System.Threading.Tasks;

namespace Artronics.SchemaFaketory
{
    //The perpose of this class is later with
    //reflection we can find child classes
    public abstract class BaseFakeModel { }
    public abstract class FakeModel<TModel>:BaseFakeModel
        where TModel:class
    {
        protected abstract TModel OnModelFaking(TModel model);

    }
  
}
