using br.mus.tocaaqui.domain.enums;

namespace br.mus.tocaaqui.domain.entities
{
    public class Bass : StringsInstrument
    {
        private int _stringsQty;

        public Bass(int stringsQty = 4)
            : base("Vioção", ETone.A, stringsQty)
        {
            _stringsQty = stringsQty;

            // TODO: Adicionar cordas na afinação correta para baixos de 5 ou 6 cordas.
            base.addStrings(new Wire[]
                {
                    new Wire(ETone.G, 2),
                    new Wire(ETone.D, 2),
                    new Wire(ETone.A, 2),
                    new Wire(ETone.E, 2)
                }
            );
        }
    }
}