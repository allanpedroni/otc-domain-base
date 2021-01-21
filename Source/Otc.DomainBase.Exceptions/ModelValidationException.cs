using System;
using System.Runtime.Serialization;

namespace Otc.DomainBase.Exceptions
{
    [Serializable]
    public class ModelValidationException : CoreException<ModelValidationError>
    {
        public ModelValidationException()
        {

        }

        public ModelValidationException(params ModelValidationError[] errors)
        {
            AddError(errors);
        }

        protected ModelValidationException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
        }

        public override string Key => "ModelValidationException";
    }
}
