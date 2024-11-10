using DN.HELPER.LIBRARY.EXTENSION;

namespace DN.HELPER.LIBRARY.TEST.EXTENSION;

public class ObjectExtensionTest
{
    [Fact]
    public void ValidaSeObjetoNuloRetornaTextoVazio()
    {
        string? texto = null;

        Assert.True(texto.ToStringOrEmpty() == string.Empty);
    }

    [Fact]
    public void ValidaSeObjetoTextoRetornaTextoIgual()
    {
        const string TEXTO = "TEXTO";
        object texto = TEXTO;

        Assert.True(texto.ToStringOrEmpty() == TEXTO);
    }
}
