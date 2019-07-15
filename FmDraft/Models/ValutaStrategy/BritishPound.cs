using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.ValutaStrategy
{
    public class BritishPound : Valuta
    {
        public double Convert(double originalAmount)
        {
            return originalAmount;
        }

        public string GetSymbol()
        {
            return "£";
        }
    }
}