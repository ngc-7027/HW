using System; // Ble bla ... zkouska

namespace HW_Shape
{
    public class Circle : Shape
    {
        public override double GetArea(params double[] lengths)
        {
            ControlParameters(lengths);

            var r = lengths[0];

            var result = Math.PI * Math.Pow(r, 2);
            return result;
        }

        public override double GetCircumference(params double[] lengths)
        {
            ControlParameters(lengths);

            var r = lengths[0];

            var result = 2 * Math.PI * r;
            return result;
        }
    }
}
