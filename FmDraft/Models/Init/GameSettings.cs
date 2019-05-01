using FmDraft.Models.Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Init
{
    public class GameSettings
    {
        public User Player1 { get; set; }
        public User Player2 { get; set; }

        List<Player> playerPool;
        

        public List<Player> GetPlayerPool()
        {
            return playerPool;
        }

        public void SetPlayerPool(List<string> divisionList)
        {
            PlayerPoolFactory factory = new PlayerPoolFactory(divisionList);
            playerPool = factory.GetPlayerPool();
        }

        public bool InitializeGame(InitViewModel inputData)
        {
            System.Diagnostics.Debug.WriteLine(inputData.FormationP1);
            System.Diagnostics.Debug.WriteLine(inputData.FormationP1);
            System.Diagnostics.Debug.WriteLine(inputData.FormationP2);
            System.Diagnostics.Debug.WriteLine(inputData.PlayerOne);
            System.Diagnostics.Debug.WriteLine(inputData.PlayerTwo);
            System.Diagnostics.Debug.WriteLine(inputData.Division);
            System.Diagnostics.Debug.WriteLine(inputData.divisionListItems);

            return true;


        }

        


              

    }
}