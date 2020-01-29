using br.mus.tocaaqui.domain.entities;
using br.mus.tocaaqui.domain.enums;
using Xunit;

namespace br.mus.tocaaqui.tests.domain
{
    public class StringsInstrumentTests
    {
        [Fact]
        public void InstrumentoDeCorda_TipoViolaCaipira_NomeDoInstrumentoEhViolaCaipira()
        {
            var violaCaipira = new ViolaCaipira(EViolaCaipiraTuneType.Cebolao, ETone.E);

            Assert.Equal(violaCaipira.Name, "Viola Caipira");
        }
    }
}