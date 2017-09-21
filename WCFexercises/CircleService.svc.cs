using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFexercises
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CircleService : ICircleService
    {
        public const double PI = 3.1416;
        public double CalcDiameter(double radius)
        {
            double result = 2 * radius;
            return result;
        }

        public double CalcCircumference(double radius)
        {
            double result = 2 * PI * radius;
            return result;
        }
    }
}
