using br.mus.tocaaqui.domain.enums;

namespace br.mus.tocaaqui.domain.entities
{
    public interface ITone
    {
        ETone Tone { get; set; }
        int Octave { get; set; }
    }

}