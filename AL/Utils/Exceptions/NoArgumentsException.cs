namespace AL.Utils.Exceptions
{
    public class NoArgumentsException : Exception
    {
        public NoArgumentsException(string? message) : base(message)
        {
            Console.WriteLine($"No arguments given to command: {message}");
        }
    }
}
