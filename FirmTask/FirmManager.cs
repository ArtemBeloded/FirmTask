using FirmTask.Services;
using System;
using System.Collections.Generic;

namespace FirmTask
{
    class FirmManager
    {
        private static FirmServices _firmServices;
        private static int num;

        static void Main(string[] args)
        {
                _firmServices = new FirmServices();
                StartPage();
        }

        private static void StartPage() 
        {
            Printer.OutputText("------------------FirmManager----------------");
            Printer.OutputText("1 - List of employees\r\n" +
                                "2 - Count of employees\r\n" +
                                "3 - Add or remove employee\r\n" +
                                "4 - Find an employee and give task\r\n" +
                                "5 - Exit\r\n");
            if (Int32.TryParse(Printer.InputText(), out num) && num < 6 && num > 0)
            {
                if (num == 1)
                {
                    ListOfEmployees();
                }
                if (num == 2)
                {
                    CountOfEmployees();
                }
                if (num == 3)
                {
                    AddOrRemoveEmployee();
                }
                if (num == 4)
                {
                    FindAnEmployee();
                }
                if (num == 5)
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Printer.OutputText("Incorrectly entered value. Try again.\r\n");
                StartPage();
            }
        }

        private static void ListOfEmployees() 
        {
            Printer.OutputText("\r\n1 - All employees\r\n" +
                                "2 - Only workers\r\n" +
                                "3 - Only managers\r\n" +
                                "4 - Only brigadier\r\n" +
                                "5 - Back to start page\r\n");
            if (Int32.TryParse(Printer.InputText(), out num) && num < 6 && num > 0)
            {
                if (num == 1)
                {
                    var employees = _firmServices.GetEmloyee<BaseEmployee>();
                    OutputEmployees(employees);
                    ListOfEmployees();
                }
                if (num == 2)
                {
                    var employees = _firmServices.GetEmloyee<Worker>();
                    OutputEmployees(employees);
                    ListOfEmployees();
                }
                if (num == 3)
                {
                    var employees = _firmServices.GetEmloyee<Manager>();
                    OutputEmployees(employees);
                    ListOfEmployees();
                }
                if (num == 4)
                {
                    var employees = _firmServices.GetEmloyee<Brigadier>();
                    OutputEmployees(employees);
                    ListOfEmployees();
                }
                if (num == 5)
                {
                    StartPage();
                }
            }
            else
            {
                Printer.OutputText("Incorrectly entered value. Try again.\r\n");
                ListOfEmployees();
            }
        }

        private static void OutputEmployees(IEnumerable<BaseEmployee> employees) 
        {
            foreach (var item in employees)
            {
                Printer.OutputText(item.ToString());
            }
        }

        private static void CountOfEmployees() 
        {
            Printer.OutputText("\r\n1 - Count of all employees\r\n" +
                                "2 - Count of workers\r\n" +
                                "3 - Count of managers\r\n" +
                                "4 - Count of brigadier\r\n" +
                                "5 - Back to start page\r\n");
            if (Int32.TryParse(Printer.InputText(), out num) && num < 6 && num > 0)
            {
                if (num == 1)
                {
                    var count = _firmServices.GetCount<BaseEmployee>();
                    Printer.OutputText(string.Format("Count of all employees: {0}", count));
                    CountOfEmployees();
                }
                if (num == 2)
                {
                    var count = _firmServices.GetCount<Worker>();
                    Printer.OutputText(string.Format("Count of worker: {0}", count));
                    CountOfEmployees();
                }
                if (num == 3)
                {
                    var count = _firmServices.GetCount<Manager>();
                    Printer.OutputText(string.Format("Count of managers: {0}", count));
                    CountOfEmployees();
                }
                if (num == 4)
                {
                    var count = _firmServices.GetCount<Brigadier>();
                    Printer.OutputText(string.Format("Count of brigadiers: {0}", count));
                    CountOfEmployees();
                }
                if (num == 5)
                {
                    StartPage();
                }
            }
            else
            {
                Printer.OutputText("Incorrectly entered value. Try again.\r\n");
                CountOfEmployees();
            }
        }

        private static void AddOrRemoveEmployee()
        {
            Printer.OutputText("\r\n1 - Add employee\r\n" +
                                "2 - Remove employee\r\n" +
                                "3 - Back to start page\r\n");
            if (Int32.TryParse(Printer.InputText(), out num) && num < 4 && num > 0)
            {
                if (num == 1)
                {
                    AddEmployee();
                }
                if (num == 2)
                {
                    Printer.OutputText("Enter full name");
                    var fullName = Printer.InputText();
                    if (_firmServices.IsContainEmployee(fullName))
                    {
                        _firmServices.RemoveEmployee(fullName);
                        Printer.OutputText("Employee was removed");
                        AddOrRemoveEmployee();
                    }
                    else
                    {
                        Printer.OutputText("Employee not found");
                        AddOrRemoveEmployee();
                    }
                }
                if (num == 3)
                {
                    StartPage();
                }
            }
            else
            {
                Printer.OutputText("Incorrectly entered value. Try again.\r\n");
                AddOrRemoveEmployee();
            }
        }

        private static void AddEmployee() 
        {
            Printer.OutputText("\r\nSelect employee type:\r\n" +
                                "1 - Worker\r\n" +
                                "2 - Maneger\r\n" +
                                "3 - Brigadier\r\n" +
                                "4 - Back to add or remove employee\r\n");
            if (Int32.TryParse(Printer.InputText(), out num) && num < 5 && num > 0)
            {
                if (num == 1)
                {
                    var newEmployee  = new Worker();
                    CreateNewEmployee(newEmployee);
                    _firmServices.AddEmployee(newEmployee);
                    Printer.OutputText("Employee was added");
                    AddEmployee();
                }
                if (num == 2)
                {
                    var newEmployee = new Manager();
                    CreateNewEmployee(newEmployee);
                    _firmServices.AddEmployee(newEmployee);
                    Printer.OutputText("Employee was added");
                    AddEmployee();
                }
                if (num == 3)
                {
                    var newEmployee = new Brigadier();
                    CreateNewEmployee(newEmployee);
                    _firmServices.AddEmployee(newEmployee);
                    Printer.OutputText("Employee was added");
                    AddEmployee();
                }
                if (num == 4)
                {
                    AddOrRemoveEmployee();
                }
            }
            else
            {
                Printer.OutputText("\r\nIncorrectly entered value. Try again.\r\n");
                AddEmployee();
            }
        }

        private static void CreateNewEmployee(BaseEmployee employee) 
        {
            Printer.OutputText("Enter full name:");
            var fullName = Printer.InputText();
            if (!string.IsNullOrEmpty(fullName))
            {
                employee.FullName = fullName;
            }
            else 
            {
                Printer.OutputText("Incorrectly entered value. Try again.\r\n");
                CreateNewEmployee(employee);
            }
            Printer.OutputText("Enter experience:");
            int exp;
            if (Int32.TryParse(Printer.InputText(), out exp) && exp < 100 && exp > 0)
            {
                employee.Experience = exp;
            }
            else 
            {
                Printer.OutputText("Incorrectly entered value. Try again.\r\n");
                CreateNewEmployee(employee);
            }
        }

        private static void FindAnEmployee()
        {
            Printer.OutputText("\r\n1 - Find employee\r\n" +
                                "2 - Back to start page\r\n");
            if (Int32.TryParse(Printer.InputText(), out num) && num < 3 && num > 0)
            {
                if (num == 1)
                {
                    Search();
                }
                if (num == 2)
                {
                    StartPage();
                }
            }
            else
            {
                Printer.OutputText("Incorrectly entered value. Try again.\r\n");
                FindAnEmployee();
            }
        }

        private static void Search()
        {
            Printer.OutputText("\r\nEnter full name:");
            var fullName = Printer.InputText();
            if (_firmServices.IsContainEmployee(fullName))
            {
                var employee = _firmServices.GetEmployee(fullName);
                Printer.OutputText(employee.ToString());
                Printer.OutputText(employee.SpecialTask());
                Printer.OutputText(employee.ToWork());
                FindAnEmployee();
            }
            else
            {
                Printer.OutputText("Employee not found\r\n");
                Search();
            }
        }
    }
}
