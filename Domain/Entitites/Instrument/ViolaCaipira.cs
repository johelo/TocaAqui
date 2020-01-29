using br.mus.tocaaqui.domain.enums;

namespace br.mus.tocaaqui.domain.entities
{
    public class ViolaCaipira : StringsInstrument
    {
        private const int _stringsQty = 10;

        // TODO: não é necessário o tom para as afinações que não sejam cebolão.
        public ViolaCaipira(EViolaCaipiraTuneType tuneType, ETone tune)
            : base("Viola Caipira", tune, _stringsQty)
        {
            TuneType = tuneType;
            base.addStrings(ViolaCaipiraStrings.getStrings(tuneType, tune));
        }

        public EViolaCaipiraTuneType TuneType { get; set; }
    }
}