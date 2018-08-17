using System;
using System.Collections.Generic;

namespace Otc.DomainBase.Exceptions
{
    public abstract class CoreException : Exception
    {
        private const string DefaultMessage = "Ocorreu um erro de negócio, verifique a propriedade 'errors' para obter mais detalhes.";

        public CoreException()
            : base(DefaultMessage)
        {

        }

        public CoreException(string message)
            : base(message)
        {

        }

        public virtual string TypeName => GetType().Name;
    }

    public abstract class CoreException<T> : CoreException
        where T : CoreError
    {
        public ICollection<T> Errors = new List<T>();

        public CoreException<T> AddError(params T[] errors)
        {
            foreach (var error in errors)
            {
                Errors.Add(error);
            }

            return this;
        }
    }
}
