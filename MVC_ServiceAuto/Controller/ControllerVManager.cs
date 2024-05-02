using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_ServiceAuto.Controller;
using MVC_ServiceAuto.View;

namespace MVC_ServiceAuto.Controller
{
    public class ControllerVManager : ControllerView
    {
        private VManager vmManager;

        public ControllerVManager()
        {
            this.vmManager = new VManager();


        }

        private void eventsManagement()
        {
            this.vmManager;
        }

        public override void DisplayTable()
        {
            throw new NotImplementedException();
        }

        public override void FilterTable(string selectedCriterion)
        {
            throw new NotImplementedException();
        }

        public override void SearchBy(string searchedContent)
        {
            throw new NotImplementedException();
        }
    }
}
