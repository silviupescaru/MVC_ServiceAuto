﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_ServiceAuto.Model
{
    public interface Observable
    {
        void Update(Subject obs);
    }
}
