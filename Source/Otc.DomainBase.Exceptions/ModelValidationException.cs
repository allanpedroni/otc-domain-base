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
    }
}
