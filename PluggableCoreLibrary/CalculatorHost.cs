using Pluggable.Interfaces;
using Pluggable.Calculators;

namespace Pluggable
{
    public class CalculatorHost
    {
        public CalculatorHost(ICalculator calculator)
        {
            Calculator = calculator;
        }

        public CalculatorHost() : this(new Divider()) { }

        private ICalculator Calculator
        {
            get;
            set;
        }

        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        public char Operator
        {
            get { return Calculator.GetSymbol(); }
        }

        public int Calculate()
        {
            return Calculator.Calculate(X, Y);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} = {3}",
                X.ToString(),
                Calculator.GetSymbol(),
                Y.ToString(),
                Calculator.Calculate(Y, Y));
        }
    }
}
