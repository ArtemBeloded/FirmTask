using FirmTask.Containers;
using FirmTask.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask
{
    class FirmManager
    {
        private static FirmServices _firmServices;
        static void Main(string[] args)
        {
            while (true) 
            {
                _firmServices = new FirmServices();
                var t = _firmServices.GetEmloyee<Worker>();
                var e = _firmServices.GetCount<Brigadier>();
            }
            
        }

        
    }
}
