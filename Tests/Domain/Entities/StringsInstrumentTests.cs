using br.mus.tocaaqui.domain.entities;
using br.mus.tocaaqui.domain.enums;
using Xunit;

namespace br.mus.tocaaqui.tests.domain
{
    public class StringsInstrumentTests
    {
        [Fact]
        public void TestName()
        {
            //Given
            var stringsQty = 10;
            var violaCaipira = new ViolaCaipiraFake();

            //When

            //Then
            Assert.Equal(stringsQty, violaCaipira.StringQty);
        }
    }

    public class ViolaCaipiraFake : StringsInstrument
    {
        public ViolaCaipiraFake()
            : base("Viola Caipira", EInstrumentFamily.strings, ETone.E, 10)
        {
            base.addStrings(new Wire[]
                {
                    new Wire(ETone.E, 3),
                    new Wire(ETone.E, 4),
                    new Wire(ETone.Bsharp, 3),
                    new Wire(ETone.Bsharp, 4),
                    new Wire(ETone.G, 3),
                    new Wire(ETone.G, 4),
                    new Wire(ETone.Bsharp, 4),
                    new Wire(ETone.Bsharp, 4),
                    new Wire(ETone.E, 4),
                    new Wire(ETone.E, 4)
                }
            );
        }
    }
}