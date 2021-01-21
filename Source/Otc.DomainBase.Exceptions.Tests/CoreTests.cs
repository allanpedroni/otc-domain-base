using FluentAssertions;
using Xunit;

namespace Otc.DomainBase.Exceptions.Tests
{
    public class CoreTests
    {
        [Fact]
        public void Test_Contain_Key_In_Exception()
        {
            var error = new TesteCoreError("Chave", "Mensagem");

            var exception = new TesteCoreException(error);

            var expectedErrors = new TesteCoreError[]{
                new TesteCoreError("Chave", "Mensagem")
            };

            exception.Errors.Should()
                .Equal(expectedErrors);
        }

        [Fact]
        public void Test_Contain_Key_In_Error()
        {
            var error = new TesteCoreError("Chave", "Mensagem");

            error.Key.Should().Be("Chave");
            error.Message.Should().Be("Mensagem");
        }
    }
}
