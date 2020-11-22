using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGreatSite.Views.Shared.Components
{
    public class Clock : ViewComponent
    {
        public string Invoke()
        {
            return DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
