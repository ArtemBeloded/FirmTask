namespace FirmTask
{
    public class Worker : BaseEmployee
    {
        public override string ToWork() 
        {
            return "Release product";
        }

        public override string ToString()
        {
            return string.Format("Full name: {0}; experience: {1}; type employee: {2}", FullName, Experience, "Worker");
        }
    }
}
