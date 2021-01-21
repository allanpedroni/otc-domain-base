using System;
using System.Runtime.Serialization;

namespace Otc.DomainBase.Exceptions.Tests
{
    [Serializable]
    public class TesteCoreException : CoreException<TesteCoreError>
    {
        public TesteCoreException(
            TesteCoreError buscarFilmesCoreError)
        {
            AddError(buscarFilmesCoreError);
        }

        public TesteCoreException(string message) : base(message)
        {
        }

        protected TesteCoreException(SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }

        public override string Key => "BuscarFilmesCoreException";
    }
}
