using System;
using System.Collections.Generic;

namespace Otc.DomainBase.Exceptions
{
    public abstract class CoreException : Exception
    {
        public CoreException(string message)
            : base(message)
        {

        }

        [Obsolete("Utilize a propriedade Key.")]
        public virtual string TypeName => Key;

        public abstract string Key { get; }
    }

    public abstract class CoreException<T> : CoreException
        where T : CoreError
    {
        public CoreException()
            : base("Ocorreu um erro de negócio, verifique a propriedade 'errors' para obter detalhes.")
        {

        }

        public CoreException(string message)
            : base(message)
        {

        }

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
