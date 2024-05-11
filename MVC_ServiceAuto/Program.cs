using MVC_ServiceAuto.Controller;
using MVC_ServiceAuto.Model.Language;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MVC_ServiceAuto
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ControllerVLogin login = new ControllerVLogin(1);
            ControllerVStatistics statistics = new ControllerVStatistics();
            Application.Run(login.GetView());
            //Application.Run(statistics.GetView());
        }
    }
}