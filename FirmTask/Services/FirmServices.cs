using FirmTask.Containers;
using System.Collections.Generic;
using System.Linq;

namespace FirmTask.Services
{
    public class FirmServices
    {
        private Firm _firm;

        public FirmServices()
        {
            _firm = new Firm();
            FillingData();
        }

        public bool IsContainEmployee(string fullName) 
        {
            var employee = _firm.Employees.Where(x => x.FullName == fullName).FirstOrDefault();
            return _firm.Employees.IsContain(employee);
        }

        public void AddEmployee(BaseEmployee employee) 
        {
            _firm.Employees += employee;
        }

        public void RemoveEmployee(string fullName) 
        {
            var employee = _firm.Employees.Where(x => x.FullName == fullName).FirstOrDefault();
            _firm.Employees -= employee;
        }

        public IEnumerable<BaseEmployee> GetEmloyee<T>() where T : BaseEmployee
        {
            return _firm.Employees.GetEpm<BaseEmployee, T>();
        }

        public int GetCount<T>()  where T: BaseEmployee
        {
            return _firm.Employees.CountOfEmployee<BaseEmployee, T>();
        }

        public BaseEmployee GetEmployee(string fullName) 
        {
            return _firm.Employees.Where(x => x.FullName == fullName).FirstOrDefault();
        }

        public void FillingData()
        {
            Worker woker1 = new Worker() { FullName = "Oleg", Experience = 2.4 };
            Worker woker2 = new Worker() { FullName = "Igor", Experience = 2 };
            Worker woker3 = new Worker() { FullName = "Nikita", Experience = 1.4 };
            Brigadier brigadier1 = new Brigadier() { FullName = "Artem", Experience = 20.4 };
            Brigadier brigadier2 = new Brigadier() { FullName = "Vadim", Experience = 23.4 };
            Brigadier brigadier3 = new Brigadier() { FullName = "Kiril", Experience = 21.4 };
            Manager manager1 = new Manager() { FullName = "Tema", Experience = 24 };
            Manager manager2 = new Manager() { FullName = "Kiril", Experience = 4 };
            Manager manager3 = new Manager() { FullName = "Oleg", Experience = 14 };

            _firm.Employees += woker1;
            _firm.Employees += woker2;
            _firm.Employees += woker3;
            _firm.Employees += brigadier1;
            _firm.Employees += brigadier2;
            _firm.Employees += brigadier3;
            _firm.Employees += manager1;
            _firm.Employees += manager2;
            _firm.Employees += manager3;
        }
    }
}
