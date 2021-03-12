using FirmTask.Containers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Firm f = FillingData();
        }

        public static Firm FillingData() 
        {
            Firm f = new Firm();
            Worker woker1 = new Worker() { FullName = "Oleg", Experience = 2.4};
            Worker woker2 = new Worker() { FullName = "Igor", Experience = 2 };
            Worker woker3 = new Worker() { FullName = "Nikita", Experience = 1.4 };
            Brigadier brigadier1 = new Brigadier() { FullName = "Artem", Experience = 20.4 };
            Brigadier brigadier2 = new Brigadier() { FullName = "Vadim", Experience = 23.4 };
            Brigadier brigadier3 = new Brigadier() { FullName = "Kiril", Experience = 21.4 };
            Manager manager1 = new Manager() { FullName = "Tema", Experience = 24 };
            Manager manager2 = new Manager() { FullName = "Kiril", Experience = 4 };
            Manager manager3 = new Manager() { FullName = "Oleg", Experience = 14 };

            f.employeeCollection.EpmloyeeContainer += woker1;
            f.employeeCollection.EpmloyeeContainer += woker2;
            f.employeeCollection.EpmloyeeContainer += woker3;
            f.employeeCollection.EpmloyeeContainer += brigadier1;
            f.employeeCollection.EpmloyeeContainer += brigadier2;
            f.employeeCollection.EpmloyeeContainer += brigadier3;
            f.employeeCollection.EpmloyeeContainer += manager1;
            f.employeeCollection.EpmloyeeContainer += manager2;
            f.employeeCollection.EpmloyeeContainer += manager3;

            return f;
        }
    }
}
