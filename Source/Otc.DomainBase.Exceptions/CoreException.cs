using System;
using System.Collections.Generic;

namespace Otc.DomainBase.Exceptions
{
    public abstract class CoreException : Exception
    {
        protected CoreException(string message)
            : base(message)
        {

        }

        [Obsolete("Utilize a propriedade Key. Na proxima versao esta propriedade pode deixar de existir.")]
        public virtual string TypeName => GetType().Name;

        public virtual string Key => TypeName;
    }

    public abstract class CoreException<T> : CoreException
        where T : CoreError
    {
        protected CoreException()
            : base("Ocorreu um erro de negócio, verifique a propriedade 'errors' para obter detalhes.")
        {

        }

        protected CoreException(string message)
            : base(message)
        {

        }

        public ICollection<T> Errors { get; } = new List<T>();

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
