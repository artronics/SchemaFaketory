using System;
using Artronics.SchemaFaketory.Tests.Mocks;

namespace Artronics.SchemaFaketory.Tests.Stubs
{
    public class FakeFoo:FakeModel<Foo>
    {
        protected override Foo OnModelFaking(Foo model)
        {
            return new Foo(){Content = "Foo content on FakeFoo"};
        }
    }

    public class FakeBar:FakeModel<Bar>
    {
        protected override Bar OnModelFaking(Bar model)
        {
            return new Bar(){Count = new Random().Next(10,100)};
        }
    }

    public class FakeBaz:FakeModel<Baz>
    {
        protected override Baz OnModelFaking(Baz model)
        {
            return new Baz();
        }
    }
}
