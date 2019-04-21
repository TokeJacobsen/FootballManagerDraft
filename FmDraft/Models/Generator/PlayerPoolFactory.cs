using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Generator
{
    public class PlayerFactory
    {
        private List<string> divisions;
        public PlayerFactory(List<string> divisons)
        {
        }
        public List<Players> GetPlayerPool()
        {
            List<Player> PlayerPool = new List<Player>();
            using(var db = new FMDraftEntities())
            {
                foreach (string division in divisions)
                {
                    var players = from p in db.Players
                                  where p.Clubs.Divisions.DivisionName.Equals(division)
                                  select p;
                    foreach (var player in players)
                    {
                        if (player.Position.Equals("GK"))
                        {

                        }

                    }


                }
            }
            return null;
        }

    }
}