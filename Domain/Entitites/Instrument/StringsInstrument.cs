using br.mus.tocaaqui.domain.enums;

namespace br.mus.tocaaqui.domain.entities
{
    public abstract class StringsInstrument : Instrument
    {
        public StringsInstrument(string name, EInstrumentFamily instrumentFamily, ETone tune, int stringQty)
            : base(name, EInstrumentFamily.strings)
        {
            Tune = tune;
            StringQty = stringQty;
            Wire = new Wire[StringQty];
        }

        public ETone Tune { get; private set; }
        public int StringQty { get; private set; }
        public Wire[] Wire { get { return Wire; } private set { } }

        public void addString(Wire wire, int position)
        {
            if (position > 0 && position <= StringQty)
            {
                Wire[position - 1] = wire;
            }
        }

        public void addStrings(Wire[] wires)
        {
            if (wires.Length == StringQty)
            {
                Wire = wires;
            }
        }
    }
}