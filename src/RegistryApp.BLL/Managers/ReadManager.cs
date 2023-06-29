using Microsoft.Win32;
using RegistryApp.BLL.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistryApp.BLL.Managers
{
    public class ReadManager
    {
        public string GetValueFromRegistry()
        {
            var registryKey = Registry.LocalMachine
                                .OpenSubKey(RegistryConstants.RegistryDirectory)
                                .OpenSubKey(RegistryConstants.RegistryTag);

            string regKey = registryKey.GetValue(RegistryConstants.RegistryVariable).ToString();
            return regKey;
        }


    }
}
