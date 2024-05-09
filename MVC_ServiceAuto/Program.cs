using MVC_ServiceAuto.Controller;
using MVC_ServiceAuto.Model.Language;
using System.Diagnostics;

namespace MVC_ServiceAuto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LangHelper.ChangeLanguage("ru");
            Debug.WriteLine($"{LangHelper.GetString("sig")} {LangHelper.GetString("World")}!");
            LangHelper.ChangeLanguage("fr");
            Debug.WriteLine($"{LangHelper.GetString("sig")} {LangHelper.GetString("World")}!");
            LangHelper.ChangeLanguage("en");
            Debug.WriteLine($"{LangHelper.GetString("sig")} {LangHelper.GetString("World")}!");




            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ControllerVLogin login = new ControllerVLogin(1);
            Application.Run(login.GetView());
        }
    }
}