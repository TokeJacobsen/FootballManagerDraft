using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.ValutaStrategy
{
    public class DanishKrone : Valuta
    {
        public double Convert(double originalAmount)
        {
            return originalAmount * 8.5;
        }

        public string GetSymbol()
        {
            return "DKK";
        }
    }
}