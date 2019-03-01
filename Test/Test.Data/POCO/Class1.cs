using System.Collections.Generic;
using Test.Data.Core;

namespace Test.Data.POCO
{
    public class Class1 : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Class2> Class2s { get; set; }
    }
}
