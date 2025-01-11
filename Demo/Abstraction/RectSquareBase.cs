namespace Demo.Abstraction
{
    internal abstract class RectSquareBase : Shape
    {
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
}
