namespace FirmTask
{
    public class Brigadier : BaseEmployee
    {
        public override string ToWork()
        {
            return "Purchase of materials";
        }

        public override string SpecialTask()
        {
            return "Checking workers";
        }

        public override string ToString()
        {
            return string.Format("Full name: {0}; experience: {1}; type employee: {2}", FullName, Experience, "Brigadier");
        }
    }
}
