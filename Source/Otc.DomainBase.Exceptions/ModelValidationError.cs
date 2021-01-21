namespace Otc.DomainBase.Exceptions
{
    public record ModelValidationError(string Key, string Message) :
        CoreError(Key, Message);
}
