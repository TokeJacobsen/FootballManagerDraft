using FmDraft.Models.DAO;
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
        public List<SelectListItem> valutas;
        string[] valutaArray;


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
            valutaArray = new string[] { "British Pound", "Danish Krone" };

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


            valutas = new List<SelectListItem>();
            for (int i = 0; i < valutaArray.Length; i++)
            {
                valutas.Add(new SelectListItem { Text = valutaArray[i], Value = valutaArray[i] });
            }

        }

        [DisplayName("Player 1")]
        public string PlayerOne { get; set; }
        [DisplayName("Player 2")]
        public string PlayerTwo { get; set; }

        public string FormationP1 { get; set; }
        public string FormationP2 { get; set; }
        [DisplayName("Budget")]
        public long Budget { get; set; }
        public string Valuta { get; set; }




    }
}
    