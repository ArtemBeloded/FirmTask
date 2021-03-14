namespace FirmTask
{
    public abstract class BaseEmployee
    {
        public double Experience { get; set; }

        public string FullName { get; set; }

        public virtual string ToWork() { return null; }

        public virtual string SpecialTask() { return null; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
