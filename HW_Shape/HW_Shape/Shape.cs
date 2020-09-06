using System;

namespace HW_Shape
{
    public abstract class Shape
    {
        protected void ControlParameters(params double[] parameters)
        {
            foreach (var parameter in parameters)
            {
                if (parameter <= 0 || parameter > double.MaxValue)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public abstract double GetArea(params double[] lengths);

        public abstract double GetCircumference(params double[] lengths);
    }
}
