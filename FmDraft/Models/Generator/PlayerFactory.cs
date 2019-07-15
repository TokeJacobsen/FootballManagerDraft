using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FmDraft.Models.ValutaStrategy;

namespace FmDraft.Models.Generator
{
    interface PlayerFactory
    {
        Player GetPlayer(Players player, Valuta valuta);

    }


}
