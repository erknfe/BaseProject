using Test.Data.ORM;

namespace Test.Data.Core
{
    public class BaseValidation<T>
    {
        public DatabaseContext Repository { get; set; }
    }
}
