namespace Otc.DomainBase.Exceptions.Tests
{
    public record TesteCoreError(string Key, string Message) :
        CoreError(Key, Message)
    {
        public static TesteCoreError LimiteDeRequisicoesAtingido =>
            new TesteCoreError("LimiteDeRequisicoesAtingido",
                "O limite de requisições ao provedor de filmes foi atingido, " +
                "tente novamente mais tarde.");
    }
}
