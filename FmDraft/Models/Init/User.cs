using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Init
{
    public class User
    {
        public string Name { get; set; }
        public Formation Formation { get; set; }
        List<Player> players = new List<Player>();

        public void PickPlayer(Player player)
        {
            players.Add(player);
        }
        public int SquadSize()
        {
            return players.Count;
        }

    }
}