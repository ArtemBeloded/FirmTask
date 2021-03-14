namespace FirmTask
{
    public class Manager : BaseEmployee
    {
        public override string ToWork()
        {
            return "Сollecting orders";
        }

        public override string SpecialTask() 
        {
            return "Task issued";
        }

        public override string ToString()
        {
            return string.Format("Full name: {0}; experience: {1}; type employee: {2}", FullName, Experience, "Manager");
        }
    }
}
