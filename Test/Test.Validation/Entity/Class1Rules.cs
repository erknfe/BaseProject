using Test.Data.Core;
using Test.Data.DTO;
using Test.Data.POCO;

namespace Test.Validation.Entity
{
    public class Class1Rules : BaseValidation<Class1>
    {
        public ValidateDTO ValidateSave(Class1 model)
        {
            var validate = new ValidateDTO { Success = true, Message = "" };

            if (!string.IsNullOrEmpty(model.Name))
            {
                validate.Success = false;
                validate.Message += "\rName cannot null";
            }
            return validate;
        }
    }
}
