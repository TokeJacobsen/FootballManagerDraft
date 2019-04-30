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
        List<Division> divisions;
        public List<SelectListItem> formationListItems;
        public List<SelectListItem> divisionListItems;

        [DisplayName("Division")]
        public string Division { get; set; }
        public InitViewModel()
        {
            
          Formations formations = new Formations();
          formationsDictionary = formations.GetFormations();
          formationListItems = new List<SelectListItem>();
          foreach (string key in formationsDictionary.Keys)
          {
                formationListItems.Add(new SelectListItem { Text = key, Value = key });
          }


          divisions = DivisionList.GetDivisionList();
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





        

    }
}
    