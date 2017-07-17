using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Logic
{
    public class CustomerRecord: IFormattable
    {
        string name;
        string contactPhone;

        decimal revenue;

        public CustomerRecord() { }

        public string GetName()
        {
            return name;
        }

        public string GetPhone()
        {
            return contactPhone;
        }

        public decimal GetRevenue()
        {
            return revenue;
        }

        public CustomerRecord(string nameInput, string phoneinput, decimal revenueInput)
        {
            name = nameInput;
            contactPhone = phoneinput;
            revenue = revenueInput;
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (string.IsNullOrEmpty(format)) format = "G";
            if (provider == null) provider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "NPR":
                    return string.Format("Customer data: {0} , {1} , {2}", name, contactPhone, revenue);
                case "NR":
                    return string.Format("Customer data: {0} , {1} ", name, revenue);
                case "NP":
                    return string.Format("Customer data: {0} , {1} ", name, contactPhone);
                case "N":
                    return string.Format("Customer data: " + name);
                case "P":
                    return string.Format("Customer data: " + contactPhone);
                case "R":
                    return string.Format("Customer data: " + revenue);

                default:
                    throw new FormatException(String.Format("The {0} format string is not supported."));

            }

        }
    }
}
