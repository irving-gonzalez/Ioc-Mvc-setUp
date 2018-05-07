using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SimpleInjector.Integration.Web;
using SimpleInjector;
using System.Configuration;

namespace ioc_tests { 
    public static class InversionOfControlConfig
    { 
        public static Container GetInitializedContainer()
        {
          var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();


            container.Register<ICar, BMW>();

            return container;
        }
     
    }
}