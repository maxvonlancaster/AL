namespace AL.Services.Interfaces
{
    public interface IArduinoService
    {
        void Write(string message, string? ledPin);
    }
}