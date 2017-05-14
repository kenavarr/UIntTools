using Microsoft.Practices.Unity;
using System;
using UIntToolsService;

namespace UIntToolsCmd
{
    class Program
    {
        private static UnityContainer _container;

        static void Main(string[] args)
        {
            RegisterUnity();

            var service = _container.Resolve<IUIntConverter>();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number to convert it to Roman Numeral");
                    string stringNumber = Console.ReadLine();
                    uint number;
                    uint.TryParse(stringNumber, out number);
                    Console.WriteLine($"Your Roman Numeral : {service.ConvertUIntToRomanNumeral(number)}");
                }
                catch (UIntConverterException)
                {
                    Console.WriteLine($"Enter a number greater than 0");
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        private static void RegisterUnity()
        {
            _container = new UnityContainer();
            _container.RegisterType<IUIntConverter, UIntConverter>();
        }
    }
}
