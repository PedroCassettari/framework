using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IOC.FW.Core.Abstraction.Binding;
using SimpleInjector;

namespace %NAME_REPLACE%.Binding.SimpleInjector
{
    public class DAOModule : IModule
    {
        public void SetBinding(Container container)
        {
            // container.Register<AbstractPersonBusiness, PersonBusiness>(Lifestyle.Singleton);
        }
    }
}
