using System.Collections.Generic;
using System.Linq;
using br.mus.tocaaqui.domain.enums;

namespace br.mus.tocaaqui.domain.entities
{
    public abstract class StringsInstrument : Instrument
    {
        private IList<Wire> _wires;
        private int _wiresAdded = 0;

        public StringsInstrument(string name, EInstrumentFamily instrumentFamily, ETone tune, int stringQty) 
            : base(name, EInstrumentFamily.strings)
        {
            Tune = tune;
            StringQty = stringQty;
        }

        public ETone Tune { get; private set; }
        public int StringQty { get; private set; }
        public IReadOnlyCollection<Wire> Wire { get { return _wires.ToArray(); } }

        public void addString(Wire wire)
        {
            if (_wiresAdded == StringQty)
                return;

            _wires.Add(wire);
            _wiresAdded++;
        }
    }

}