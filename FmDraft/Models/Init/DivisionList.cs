using FmDraft.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Init
{
    public class DivisionList
    {


        public static List<Division> GetDivisionList()
        {
            List<Division> divisions = new List<Division>();
            using (FMDraftEntities1 db = new FMDraftEntities1())
            {
                var divisionQuery = from c in db.Divisions
                                 select c;
                foreach (var d in divisionQuery)
                {

                    Division division = new Division
                    {
                        Name = d.DivisionName,
                        Nation = d.Based
                    };
                        
                    
                    divisions.Add(division);
                }
            }
            return divisions;
        }
    }
}