
using br.mus.tocaaqui.domain.enums;

namespace br.mus.tocaaqui.domain.entities
{
    public static class ViolaCaipiraStrings
    {
        private static readonly Wire[] _cebolao =
            {
                // Strings from pair 1 to 5, sorted from bottom to up. E.
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

        private static readonly Wire[] _rioAbaixo =
            {
                // Strings from pair 1 to 5, sorted from bottom to up. G.
                new Wire(ETone.D, 4),
                new Wire(ETone.D, 4),
                new Wire(ETone.B, 4),
                new Wire(ETone.B, 4),
                new Wire(ETone.G, 4),
                new Wire(ETone.G, 3),
                new Wire(ETone.D, 4),
                new Wire(ETone.D, 3),
                new Wire(ETone.G, 4),
                new Wire(ETone.G, 3)
            };

        private static readonly Wire[] _rioAcima =
            {
                // Strings from pair 1 to 5, sorted from bottom to up. C.
                new Wire(ETone.E, 4),
                new Wire(ETone.E, 4),
                new Wire(ETone.C, 4),
                new Wire(ETone.C, 4),
                new Wire(ETone.G, 4),
                new Wire(ETone.G, 3),
                new Wire(ETone.E, 4),
                new Wire(ETone.E, 3),
                new Wire(ETone.C, 4),
                new Wire(ETone.C, 3)
            };

        private static readonly Wire[] _boiadeira =
            {
                // Strings from pair 1 to 5, sorted from bottom to up.
                new Wire(ETone.D, 4),
                new Wire(ETone.D, 4),
                new Wire(ETone.A, 4),
                new Wire(ETone.A, 4),
                new Wire(ETone.Fsharp, 4),
                new Wire(ETone.Fsharp, 3),
                new Wire(ETone.D, 4),
                new Wire(ETone.D, 3),
                new Wire(ETone.G, 4),
                new Wire(ETone.G, 3)
            };

        private static readonly Wire[] _natural =
            {
                // Strings from pair 1 to 5, sorted from bottom to up.
                new Wire(ETone.E, 4),
                new Wire(ETone.E, 4),
                new Wire(ETone.B, 4),
                new Wire(ETone.B, 4),
                new Wire(ETone.G, 4),
                new Wire(ETone.G, 3),
                new Wire(ETone.D, 4),
                new Wire(ETone.D, 3),
                new Wire(ETone.A, 4),
                new Wire(ETone.A, 3)
            };

        // TODO: Implementar as afinações D# e D para o Cebolão.
        public static Wire[] getStrings(EViolaCaipiraTuneType tuneType, ETone tone)
        {

            Wire[] Strings;

            switch (tuneType)
            {
                case EViolaCaipiraTuneType.Cebolao:
                    Strings = _cebolao;
                    break;
                case EViolaCaipiraTuneType.RioAbaixo:
                    Strings = _rioAbaixo;
                    break;
                case EViolaCaipiraTuneType.RioAcima:
                    Strings = _rioAcima;
                    break;
                case EViolaCaipiraTuneType.Boiadeira:
                    Strings = _boiadeira;
                    break;
                case EViolaCaipiraTuneType.Natural:
                    Strings = _natural;
                    break;
                default:
                    Strings = _cebolao;
                    break;
            }

            return Strings;
        }
    }
}