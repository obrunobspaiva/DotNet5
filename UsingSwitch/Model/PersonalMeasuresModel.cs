namespace UsingSwitch.Model
{
    public class PersonalMeasuresModel
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public ClassificationIMCModel State { get; set; }
        public double IMC => Weight / (Height * Height);
    }
}