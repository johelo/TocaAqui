using br.mus.tocaaqui.domain.enums;

namespace br.mus.tocaaqui.domain.entities
{
    public class Wire : ITone
    {
        public Wire(ETone tone, int octave)
        {
            Tone = tone;
            Octave = octave;
        }

        public ETone Tone { get; set; }
        public int Octave { get; set; }
    }

}