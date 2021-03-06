using System;

namespace Lab1.Models
{
    public class ConstantFunction : Function
    {
        public double Constant { get; }
        public ConstantFunction() { }

        public ConstantFunction(double constant)
        {
            Constant = constant;
        }

        public override double Calculate(double x)
            => Constant;

        public override Function GetDerivative()
            => new ConstantFunction();

        public override bool Equals(Function? obj)
        {
            if (obj is not ConstantFunction f)
                return false;

            return Math.Round(Constant, 3) == Math.Round(f.Constant, 3);
        }
    }
}
