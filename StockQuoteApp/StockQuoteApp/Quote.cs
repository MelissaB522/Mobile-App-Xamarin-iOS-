using System;
namespace StockQuoteApp
{
    public class Quote
    {
        // Properties
        public static string Name { get; set; }
        public static decimal CurrentValue { get; set; }
        public static string Change { get; set; }
        public static decimal High { get; set; }
        public static decimal Low { get; set; }

        // Default constructor
        public Quote()
        {
        }

        // Constructor
        public Quote(string name, decimal curValue, string change, decimal high, decimal low)
		{
			Name = name;
			CurrentValue = curValue;
			Change = change;
			High = high;
			Low = low;
		}
    }
}
