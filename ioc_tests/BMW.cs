using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ioc_tests
{
    public class BMW : ICar
    {
        public string velocity()
        {
            return "86km in bmw";
        }
    }
}