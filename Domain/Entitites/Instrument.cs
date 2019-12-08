using System.Collections.Generic;
using System.Linq;
using br.mus.tocaaqui.domain.enums;
using br.mus.tocaaqui.shared.entities;

namespace br.mus.tocaaqui.domain.entities
{
    public abstract class Instrument : Entity
    {
        public string Name { get; set; }
        public EInstrumentFamily Family { get; set; }

    }

    public class StringsInstrument : Instrument
    {
        private IList<Wire> _wires;
        private int _wiresAdded;

        public StringsInstrument(ETone tune, int stringQty)
        {
            Tune = tune;
            StringQty = stringQty;
        }

        public ETone Tune { get; private set; }
        public int StringQty { get; private set; }
        public IReadOnlyCollection<Wire> Strings { get { return _wires.ToArray(); } }

        public void addString(Wire wire)
        {
            if (_wiresAdded == StringQty)
                return;

            /**
            * TODO: Verificar se já existe uma corda na posição.
            * A ordem não pertence a Wire, pertence a StringsInstrument.
            */
            _wires.Add(wire);
        }
    }

    public class Wire
    {
        public ETone Tone { get; private set; }
        public int Octave { get; private set; }
        public int Order { get; set; }
    }

}