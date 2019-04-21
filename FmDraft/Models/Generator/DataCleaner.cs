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
            Regex regex = new Regex(@"\d*\.?\d*");
            if (value.EndsWith("K"))
            {
                var tempValue = regex.Match(value).Value;

                System.Diagnostics.Debug.WriteLine(tempValue + " !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" );

                price = Convert.ToDouble(tempValue) * 1000;
            }
            else if (value.EndsWith("M"))
            {
                var tempValue = regex.Match(value).Value;
                price = Convert.ToDouble(tempValue) * 1000000;
            }

            return price;
        }
    }
}