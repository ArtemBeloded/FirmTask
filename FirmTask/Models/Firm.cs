using FirmTask.Containers;

namespace FirmTask
{
    public class Firm
    {
        public MyCollection<BaseEmployee> Employees;

        public Firm()
        {
            Employees = new MyCollection<BaseEmployee>();
        }
    }
}
