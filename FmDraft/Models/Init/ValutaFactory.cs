using FmDraft.Models.ValutaStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Init
{
    public class ValutaFactory
    {
        public static Valuta GetValuta(string valuta)
        {
            if (valuta.Equals("British Pound"))
            {
                return new BritishPound();
            }
            else if (valuta.Equals("Danish Krone"))
            {
                return new DanishKrone();
            }
            else return null;
        }
    }
}