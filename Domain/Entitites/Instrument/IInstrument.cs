using br.mus.tocaaqui.domain.enums;

namespace br.mus.tocaaqui.domain.entities
{
    public interface IInstrument
    {
        public string Name { get; set; }
        public EInstrumentFamily Family { get; set; }
    }
}