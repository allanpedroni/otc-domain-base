namespace Otc.DomainBase.Exceptions
{
    public abstract class CoreError //TODO: migrar to record com init, se não for manipulado Key e Message
    {
        public string Key { get; }
        public string Message { get; }

        protected CoreError(string key, string message)
        {
            Key = key;
            Message = message;
        }
    }
}
