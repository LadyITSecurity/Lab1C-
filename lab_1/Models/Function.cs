using System;

namespace Lab1.Models
{
    public abstract class Function: 
        IEquatable<Function>
    {
        public abstract double Calculate(double x);
        public abstract Function GetDerivative();
        public abstract bool Equals(Function? other);
    }
}
