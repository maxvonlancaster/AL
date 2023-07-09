using AL.Features.Interfaces;
using AL.Models;
using AL.Services.Interfaces;
using System.Reflection;

namespace AL.Services
{
    public class InputParser : IInputParser
    {
        private IArduinoService _arduinoService;

        public InputParser(IArduinoService arduinoService)
        {
            _arduinoService = arduinoService;
        }

        public void Parse(string? input) 
        {
            if (String.IsNullOrEmpty(input)) 
            {
                Console.WriteLine($"Empty input;");
                return;
            }

            Console.WriteLine($"Started parsing {input}; UTC: {DateTime.UtcNow};");

            if (input?.Split(" ")[0].ToLower() == "features") 
            {
                ParseFeatures(input);
            }
            if (input?.Split(" ")[0].ToLower() == "arduino")
            {
                _arduinoService.Write(input?.Split(" ")[1]!);
            }
        }

        private void ParseFeatures(string input)
        {
            if (input?.Split(" ").Length == 1) 
            { 
                Console.WriteLine("No Args;");
                return;
            }

            string typeName = char.ToUpper(
                input.Split(" ")[1].ToLower()[0]) + input.Split(" ")[1].ToLower().Substring(1);

            var type = Assembly.GetAssembly(typeof(SampleModel))?
                .GetType("AL.Features." + typeName + "Features");

            if (type != null) 
            {
                IFeatures service = (IFeatures)Activator.CreateInstance(type);
                service?.Main();
            }
        }
    }
}
