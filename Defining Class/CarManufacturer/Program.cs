using System.Threading.Channels;
using System.Xml.Schema;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car("BMW", "X3", 2005, 100, 2);
           
            car.Drive(10);
            Console.WriteLine(car.WhoAmI());

        }
    }
}