using System.Data.Entity.ModelConfiguration;
using Test.Data.POCO;

namespace Test.Data.Mapping
{
    internal class Class2Mapping : EntityTypeConfiguration<Class2>
    {
        internal Class2Mapping()
        {
            ToTable("Class2", "dbo");
            HasKey(x => x.Id);

            HasRequired(x => x.Class1).WithMany(x => x.Class2s).HasForeignKey(x => x.Class1Id).WillCascadeOnDelete(true);
        }
    }
}
