using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MVC_ServiceAuto.Model.Language
{
    public static class LangHelper
    {
        private static ResourceManager rm;

        static LangHelper()
        {
            rm = new ResourceManager("MVC_ServiceAuto.Model.Language.string", Assembly.GetExecutingAssembly());
        }

        public static string GetString(string name)
        {
            return rm.GetString(name);
        }

        public static void ChangeLanguage(string language)
        {
            var cultureInfo = new CultureInfo(language);

            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;
        }
    }
}
