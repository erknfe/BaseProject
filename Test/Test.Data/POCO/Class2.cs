using Test.Data.Core;

namespace Test.Data.POCO
{
    public class Class2 : BaseEntity
    {
        public string Title { get; set; }
        public string Img { get; set; }

        public int Class1Id { get; set; }
        public virtual Class1 Class1 { get; set; }
    }
}
