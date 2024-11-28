namespace DesignPattern.F_Prototype.Resume
{
    internal class WorkExperience : ICloneable
    {
        private string company;
        private string timeArea;

        public string TimeArea { get => timeArea; set => timeArea = value; }
        public string Company { get => company; set => company = value; }

        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}