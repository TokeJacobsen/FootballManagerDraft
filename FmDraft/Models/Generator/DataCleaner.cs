using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace FmDraft.Models.Generator
{
    public class DataCleaner
    {
        public static double ConvertValueToNumber(string value)
        {
            double price = 0;
            if (value.EndsWith("K"))
            {
                value = value.Replace("K", "").Replace("£", "");
                price = Convert.ToDouble(value) * 1000;
            }
            else if (value.EndsWith("M"))
            {
                value = value.Replace("M", "").Replace("£", "");
                price = Convert.ToDouble(value) * 1000000;
            }

            return price;
        }
    }
}