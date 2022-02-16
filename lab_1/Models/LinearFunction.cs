using System;

namespace Lab1.Models
{
    public class LinearFunction : Function
    {
        public double Linear { get; }
        public double Constant { get; }

        public LinearFunction() { }

        public LinearFunction(double linear, double constant)
        {
            Linear = linear;
            Constant = constant;
        }

        public override double Calculate(double x)
            => Linear * x + Constant;

        public override Function GetDerivative()
            => new ConstantFunction(Linear);

        public override bool Equals(Function? obj)
        {
            if (obj is not LinearFunction f)
                return false;

            return Math.Round(Constant, 3) == Math.Round(f.Constant, 3) &&
                Math.Round(Linear, 3) == Math.Round(f.Linear, 3);
        }
    }
}
