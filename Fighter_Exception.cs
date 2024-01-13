namespace Turn_Order
{
    internal class Fighter_Exception(string message) : ArgumentOutOfRangeException
    {
        private readonly string _message = message;
        public override string Message => _message;
    }
}
