namespace Otc.DomainBase.Exceptions
{
    public class ValidationException : CoreException<ValidationError>
    {
        public ValidationException()
        {

        }

        public ValidationException(params ValidationError[] errors)
        {
            AddError(errors);
        }
    }
}
