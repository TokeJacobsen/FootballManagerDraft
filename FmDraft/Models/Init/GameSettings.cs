using FmDraft.Models.Generator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Init
{
    public class GameSettings
    {
        Drafter drafter;
        private static GameSettings instance = null;
        private static readonly object padlock = new object();
        private GameSettings()
        {

        }
        public static GameSettings Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new GameSettings();
                    }
                    return instance;
                }
            }
        }
    
        public Drafter GetDrafter()
        {
            return drafter;
        }

        public User Player1 { get; set; }
        public User Player2 { get; set; }

        List<Player> playerPool;
        List<String> divisionList;

        public List<String> DivisionList {
            get {return divisionList;}
            set {divisionList = value;}
        }


        public void SetPlayerPool()
        {
            PlayerPoolFactory factory = new PlayerPoolFactory(divisionList);
            playerPool = factory.GetPlayerPool();
            drafter = new Drafter(playerPool);
        }

        public bool InitializeGame(InitViewModel inputData)
        {
            Player1 = new User();
            if (inputData.PlayerOne != null)
                Player1.Name = inputData.PlayerOne;
            else
                return false;

            if (inputData.FormationP1 != null)
                Player1.Formation = inputData.FormationsDictionary[inputData.FormationP1];
            else
                return false;


            Player2 = new User();
            if (inputData.PlayerTwo != null)
                Player2.Name = inputData.PlayerTwo;
            else
                return false;

            if (inputData.FormationP2 != null)
                Player2.Formation = inputData.FormationsDictionary[inputData.FormationP2];
            else
                return false;

            if (inputData.ChosenDivisions != null)
                divisionList = inputData.ChosenDivisions;
            else
                return false;

            SetPlayerPool();
            if(playerPool.Count < 22)
            {
                return false;
            }

            foreach (var item in playerPool)
            {
                Debug.WriteLine(item.Name);

            }

            return true;
        }

    }
}