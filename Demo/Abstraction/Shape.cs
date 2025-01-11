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


        //! don't say something like this in interview
        // Abstract Property like virtual property but without implementation
        public abstract decimal Perimeter { get; }

        //! don't say something like this in interview
        // Abstract Method like virtual method but without implementation
        public abstract decimal CalcArea();
    }

}
