using System.Data.Entity.ModelConfiguration;
using Test.Data.POCO;

namespace Test.Data.Mapping
{
    internal class Class1Mapping : EntityTypeConfiguration<Class1>
    {
        internal Class1Mapping()
        {
            ToTable("Class1", "dbo");
            HasKey(x => x.Id);
        }
    }
}
