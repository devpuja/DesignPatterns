using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class AppConfiguration
    {
        private AppConfiguration() { }

     
        public static readonly Lazy<AppConfiguration> LazyInstance = new Lazy<AppConfiguration>(() => new AppConfiguration());

        public static AppConfiguration Instance => LazyInstance.Value;
    }
}
