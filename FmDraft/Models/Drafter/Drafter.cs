using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models
{
    public class Drafter
    {
        List<Player> pool;
        public Drafter(List<Player> players)
        {
            this.pool = players;
        }

        public void Shuffle(List<Player> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Player player = list[k];
                list[k] = list[n];
                list[n] = player;
            }
        }

        public List<Player> GetFive(string position)
        {
            System.Diagnostics.Debug.WriteLine(pool.Count);

            List<Player> players = pool.FindAll(p => p.Position.Equals(position));
            if (players.Count < 5)
            {
                int playerDeficit = 5 - players.Count;
                Shuffle(pool);
                players.AddRange(pool.Take(playerDeficit));
                
            }
            Shuffle(players);
            players = players.Take(5).ToList();
            System.Diagnostics.Debug.WriteLine(players.Count +"!");


            foreach (Player p in players)
                System.Diagnostics.Debug.WriteLine(p.Name + " " + p.Club.Name + " " + p.Position);

            pool.Remove(players.First());

            return players;

        }

    }
}