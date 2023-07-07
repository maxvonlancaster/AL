namespace AL.Services.Interfaces
{
    public interface IArduinoService
    {
        string ReadExisting();
        void Write(string message, string? ledPin);
    }
}