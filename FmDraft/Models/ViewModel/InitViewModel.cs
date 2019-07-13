﻿using FmDraft.Models.DAO;
using FmDraft.Models.Init;
using FmDraft.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FmDraft.Models
{
    public class InitViewModel
    {
        Dictionary<string, Formation> formationsDictionary;
        public List<SelectListItem> formationListItems;
        public List<SelectListItem> divisionListItems;
        List<String> chosenDivisions;

        [DisplayName("Division")]
        public List<String> ChosenDivisions
        {
            get { return chosenDivisions; }
            set { chosenDivisions = value; }
        }
        public Dictionary<string, Formation> FormationsDictionary
        {
            get { return formationsDictionary; }
            set { formationsDictionary = value; }
        }


        public InitViewModel()
        {

            formationsDictionary = FormationsList.GetFormations();


            formationListItems = new List<SelectListItem>();
          foreach (string key in formationsDictionary.Keys)
          {
                formationListItems.Add(new SelectListItem { Text = key, Value = key });
          }

          List<Division> divisions = DivisionList.GetDivisionList();
            

            divisionListItems = new List<SelectListItem>();
          foreach (Division div in divisions)
          {
              divisionListItems.Add(new SelectListItem { Text = $"{div.Name} ({div.Nation})", Value = div.Name });
          }

        }

        [DisplayName("Name of player 1")]
        public string PlayerOne { get; set; }
        [DisplayName("Name of player 2")]
        public string PlayerTwo { get; set; }

        public string FormationP1 { get; set; }
        public string FormationP2 { get; set; }
        public long Budget { get; set; }





    }
}
    