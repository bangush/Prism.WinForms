﻿using System.Windows.Forms;
using Prism.Modularity;
using Prism.Unity;
using Microsoft.Practices.Unity;

namespace HeloWorldUnity
{
    internal class Bootstraper: UnityBootstrapper
    {
        protected override Form CreateShell()
        {
            return this.Container.Resolve<Shell>();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(HelloWorldModule.HelloWorldModule));
        }
    }
}
