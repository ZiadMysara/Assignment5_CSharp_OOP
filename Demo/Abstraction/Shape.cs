namespace Demo.Abstraction
{
    /// Abstract Class
    /// is a Partial Implementation for Other Classes.
    /// is a Container for Common Code [Implemented Members, Abstract Members] among many Classes.
    /// U Can't Create an Object from Abstract Class [it is not fully implemented].
    /// Abstract Class not acutally exist in business model.
    abstract class Shape
    {

        public decimal Dim01 { get; set; }

        public decimal Dim02 { get; set; }

        public decimal Perimeter { get; set; }


        // Abstract Method
        public abstract decimal CalcArea();
    }

}
