namespace HW_Shape
{
    public class Rectangle : Shape
    {
        public override double GetArea(params double[] lengths)
        {
            ControlParameters(lengths);

            var l = lengths[0];
            var w = lengths[1];

            var result = l * w;
            return result;
        }

        public override double GetCircumference(params double[] lengths)
        {
            ControlParameters(lengths);

            var l = lengths[0];
            var w = lengths[1];

            var result = 2 * (l + w);
            return result;
        }
    }
}
