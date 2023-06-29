using RegistryApp.BLL.Constants;
using System.Security.AccessControl;

namespace RegistryApp.BLL.Managers
{
    public class WriteManager
    {
        public bool CreateRegistryValue(string regKey, string regValue)
        {
            bool result = false;

            try
            {
                string user = Environment.UserDomainName + "\\" + Environment.UserName;
                RegistryAccessRule rule = new RegistryAccessRule(user, RegistryRights.FullControl, AccessControlType.Allow);
                RegistrySecurity security = new RegistrySecurity();
                security.AddAccessRule(rule);
                string path = string.Format("{0}\\{1}", RegistryConstants.RegistryDirectory, RegistryConstants.RegistryTag);
                var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(path, true);
                key.SetAccessControl(security);
                key.SetValue(regKey, regValue);
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Inner Exception: " + ex.InnerException);
            }
            return result;
        }
    }
}
