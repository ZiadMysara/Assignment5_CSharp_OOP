namespace Demo.Abstraction
{
    internal class Rect : Shape
    {
        public override decimal Perimeter
        {
            get
            {
                return 2 * (Dim01 + Dim02);
            }
        }

        public override decimal CalcArea()
        {
            throw new NotImplementedException();
        }
    }
}
