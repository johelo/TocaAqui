using br.mus.tocaaqui.domain.entities;
using br.mus.tocaaqui.shared.entities;
using br.mus.tocaaqui.domain.enums;
using Xunit;

namespace br.mus.tocaaqui.tests.domain
{
    public class StringsInstrumentTests : Entity, IInstrument
    {
        public string Name { get; set; }
        public EInstrumentFamily Family { get; set; }

        [Fact]
        public void DadoViolaCaipira_QuantidadeDeCordasIgualADez()
        {
            var violaCaipira = new ViolaCaipira(EViolaCaipiraTuneType.Cebolao, ETone.E);
            var stringQty = violaCaipira.StringsQty;

            Assert.Equal(10, stringQty);
        }

        [Fact]
        public void DadoSeiLaOQue_AQuintaCordaDeveSerSol()
        {
            var violaCaipira = new ViolaCaipira(EViolaCaipiraTuneType.Cebolao, ETone.E);
            var octave = violaCaipira.Strings[4].Octave;

            Assert.Equal(4, octave);
        }

        // [Fact]
        // public void EncordoamentoCebolao()
        // {
        //     var violaCaipira = new ViolaCaipira(EViolaCaipiraTuneType.Cebolao, ETone.E);
        //     var cebolaoStringsExpected = ViolaCaipiraStrings.getStrings(EViolaCaipiraTuneType.Cebolao, ETone.E);

        //     Assert.Equal(cebolaoStringsExpected, violaCaipira.Strings[]);
        // }
    }
}