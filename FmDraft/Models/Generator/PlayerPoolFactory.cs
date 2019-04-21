using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Generator
{
    public class PlayerPoolFactory
    {
        private List<string> divisions;
        PlayerFactory goalkeeperFactory;
        PlayerFactory outfieldPlayerFactory;
        List<Player> playerPool;
        public PlayerPoolFactory(List<string> divisions)
        {
            playerPool = new List<Player>();
            this.divisions = divisions;

        }
        public List<Players> GetPlayerPool()
        {
            using(var db = new FMDraftEntities1())
            {
                goalkeeperFactory = new GoalkeeperFactory(db);
                outfieldPlayerFactory = new OutfieldPlayerFactory(db);
                foreach (string division in divisions)
                {
                    var players = from p in db.Players
                                  where p.Clubs.Divisions.DivisionName.Equals(division)
                                  select p;
                    foreach (var player in players)
                    {
                        if (player.Position.Equals("GK"))
                        {
                            playerPool.Add(goalkeeperFactory.GetPlayer(player));
                        }

                    }


                }
            }
            return null;
        }

    }
}