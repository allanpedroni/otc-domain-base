using System;

namespace Otc.DomainBase.Exceptions
{
    public class InternalError
    {
        public Guid LogEntryId { get; set; }
        public Exception Exception { get; set; }
    }
}
