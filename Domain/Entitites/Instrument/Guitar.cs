using br.mus.tocaaqui.domain.enums;

namespace br.mus.tocaaqui.domain.entities
{
    public class Guitar : StringsInstrument
    {
        private const int _stringsQty = 6;

        public Guitar()
            : base("Vioção", ETone.A, _stringsQty)
        {
            base.addStrings(new Wire[]
                {
                    new Wire(ETone.E, 3),
                    new Wire(ETone.B, 3),
                    new Wire(ETone.G, 3),
                    new Wire(ETone.D, 4),
                    new Wire(ETone.A, 4),
                    new Wire(ETone.E, 4)
                }
            );
        }
    }
}