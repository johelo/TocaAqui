using System;
using br.mus.tocaaqui.domain.enums;

namespace br.mus.tocaaqui.domain.entities
{
    public abstract class StringsInstrument : Instrument
    {
        public StringsInstrument(string name, ETone tune, int stringsQty)
            : base(name, EInstrumentFamily.strings)
        {
            Tune = tune;
            StringsQty = stringsQty;
            Strings = new Wire[StringsQty];
        }

        public ETone Tune { get; private set; }
        public int StringsQty { get; private set; }
        public Wire[] Strings { get; private set; }

        // public void setStringsQty(int stringsQty)
        // {
        //     if (stringsQty > 0)
        //     {
        //         StringsQty = stringsQty;

        //         var tmpStrings = Strings;
        //         Array.Resize(ref tmpStrings, stringsQty);
        //         Strings = tmpStrings;
        //     }
        // }

        public void addString(Wire wire, int position)
        {
            if (position > 0 && position <= StringsQty)
            {
                Strings[position - 1] = wire;
            }
        }

        public void addStrings(Wire[] strings)
        {
            if (strings.Length == StringsQty)
            {
                Strings = strings;
            }
        }

        // public abstract void getTone(int wire, int position);

        // public abstract void getTone(int[][] wire);
    }
}