using System;

namespace Otc.DomainBase.Exceptions
{
    public class ModelValidationException : CoreException<ModelValidationError>
    {
        public ModelValidationException()
        {

        }

        public ModelValidationException(params ModelValidationError[] errors)
        {
            AddError(errors);
        }

        [Obsolete("Utilize a propriedade Key. Na proxima versao esta propriedade pode deixar de existir.")]
        public override string TypeName => "ModelValidationException";
        public override string Key => "ModelValidationException";
    }
}
