using UsingSwitch.Model;

namespace UsingSwitch.Domain
{
    public static class CalculationIMCDomain
    {
        public static ClassificationIMCModel WeightAnalysis(double imc) =>
            imc switch
            {
                < 18.5 => ClassificationIMCModel.Thinness,
                < 25.0 => ClassificationIMCModel.Normal,
                < 29.9 => ClassificationIMCModel.Overweight,
                < 40.0 => ClassificationIMCModel.Obesity,
                _ => ClassificationIMCModel.SevereObesity
            };
    }

}