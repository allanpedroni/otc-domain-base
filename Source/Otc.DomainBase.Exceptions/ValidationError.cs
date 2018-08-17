namespace Otc.DomainBase.Exceptions
{
    public class ValidationError : CoreError
    {
        public ValidationError(string key, string message) : base(key, message)
        {
        }
    }
}
