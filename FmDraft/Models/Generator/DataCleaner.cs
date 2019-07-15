using System;

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
                price = Convert.ToDouble(value, System.Globalization.CultureInfo.InvariantCulture);
                price *= 1000;
            }
            else if (value.EndsWith("M"))
            {
                if (value.Contains("."))
                {
                    value = value.Replace("M", "").Replace("£", "");
                    price = Convert.ToDouble(value, System.Globalization.CultureInfo.InvariantCulture);
                    price *= 100000;
                }
                else
                {
                    value = value.Replace("M", "").Replace("£", "");
                    price = Convert.ToDouble(value, System.Globalization.CultureInfo.InvariantCulture);
                    price *= 1000000;
                }
            }

            return price;
        }
    }
}