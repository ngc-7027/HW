using System;

namespace HW_Shape
{
    public class Triangle : Shape
    {
        public override double GetArea(params double[] lengths)
        {
            ControlParameters(lengths);

            var a = lengths[0];
            var b = lengths[1];
            var c = lengths[2];

            var s = (a + b + c) / 2;
            var result = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return result;
        }

        public override double GetCircumference(params double[] lengths)
        {
            ControlParameters(lengths);

            var a = lengths[0];
            var b = lengths[1];
            var c = lengths[2];

            var result = a + b + c;
            return result;
        }
    }
}
