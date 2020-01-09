using br.mus.tocaaqui.domain.enums;

namespace br.mus.tocaaqui.domain.entities
{
    public class ViolaCaipira : StringsInstrument
    {
        public EViolaCaipiraTuneType TuneType { get; set; }
        private const int _stringsQty = 10;

        public ViolaCaipira(EViolaCaipiraTuneType tuneType, ETone tune)
            : base("Viola Caipira", EInstrumentFamily.strings, tune, _stringsQty)
        {
            TuneType = tuneType;
        }

        public static readonly Wire[] Cebolao =
            new Wire[]
                {
                    // Strings from pair 1 to 5, sorted from bottom to up.
                    new Wire(ETone.E, 4),
                    new Wire(ETone.E, 4),
                    new Wire(ETone.B, 4),
                    new Wire(ETone.B, 4),
                    new Wire(ETone.Gsharp, 4),
                    new Wire(ETone.Gsharp, 3),
                    new Wire(ETone.E, 4),
                    new Wire(ETone.E, 3),
                    new Wire(ETone.B, 4),
                    new Wire(ETone.B, 3)
                };

        public static Wire[] getWires(EViolaCaipiraTuneType tuneType)
        {

            Wire[] strings;

            switch (tuneType)
            {
                case EViolaCaipiraTuneType.Cebolao:
                    strings = Cebolao;
                    break;
                case EViolaCaipiraTuneType.RioAbaixo:
                    strings = Cebolao;
                    break;
                case EViolaCaipiraTuneType.RioAcima:
                    strings = Cebolao;
                    break;
                case EViolaCaipiraTuneType.Boiadeira:
                    strings = Cebolao;
                    break;
                default:
                    strings = Cebolao;
                    break;
            }

            return strings;
        }
    }
}