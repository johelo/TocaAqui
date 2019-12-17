using br.mus.tocaaqui.domain.enums;
using br.mus.tocaaqui.shared.entities;

namespace br.mus.tocaaqui.domain.entities
{
    public abstract class Instrument : Entity
    {
        protected Instrument(string name, EInstrumentFamily family)
        {
            Name = name;
            Family = family;
        }

        public string Name { get; set; }
        public EInstrumentFamily Family { get; set; }

    }

}