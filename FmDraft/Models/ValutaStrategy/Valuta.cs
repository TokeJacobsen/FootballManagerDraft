using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FmDraft.Models.ValutaStrategy
{
    public interface Valuta
    {
        double Convert(double originalAmount);

        string GetSymbol();
    }


}
