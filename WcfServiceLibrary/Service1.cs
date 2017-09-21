using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public const double PI = 3.1416;
       public const double EUR = 7.459900;

        //public double ReturnExchangeRate(string ISO)
        //{
        //    double rate;
        //    switch (ISO)
        //    {
        //        case "EUR":
        //            rate = 7.44090;
        //            break;
        //        case "USD":
        //            rate = 6.24976;
        //            break;
        //        case "GBR":
        //            rate = 8.43565;
        //            break;
        //        default:
        //            rate = 0;
        //            break;

        //    }
        //    return rate;
        //}

        //public List<string> ListOfAvailableIso()
        //{
        //   List<string> list = new List<string>();
        //    list.Add("USD");
        //    list.Add("EUR");
        //    list.Add("GBR");
        //    return list;
        //}
        //public double ConvertToEUR(double amount)
        //{
        //    double result = EUR * amount;
        //    return result;
        //}
        //public double CalcDiameter(double radius)
        //{
        //    double result = 2 * radius;
        //    return result;
        //}

        //public double CalcCircumference(double radius)
        //{
        //    double result = 2 * PI * radius;
        //    return result;
        //}
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        public CurrencyObject[] Objects()
        {
            CurrencyObject[] array = new CurrencyObject[3];
            array[0] = new CurrencyObject {Name = "American dollar", ISO = "USD", ExchangeRate = 6.24976};
            array[1] = new CurrencyObject {Name = "British pound", ISO = "GBR", ExchangeRate = 8.43565};
            array[2] = new CurrencyObject {Name = "Euro", ISO = "EUR", ExchangeRate = 7.44090};
            return array;
        }
    }
}
