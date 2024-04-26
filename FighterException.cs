namespace TurnOrder
{
    internal class FighterException(string message) : ArgumentOutOfRangeException
    {
        private readonly string _message = message;
        public override string Message => _message;
    }
}
