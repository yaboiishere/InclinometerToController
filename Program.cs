using System;
using Windows.Devices.Sensors;

namespace InclineometerToController {
    class Program {
        static void Main(string[] args) {
            Inclinometer _inclinometer = Inclinometer.GetDefault();
            if(_inclinometer != null) {
                // Establish the report interval
                _inclinometer.ReportInterval = 10;
                int start = 0;
                while(start < 1000000) {
                    Console.WriteLine(_inclinometer.GetCurrentReading());
                    start++;
                }

            }
            else {
                Console.WriteLine("No inclinometer found");
            }
            Console.ReadLine();
        }
    }
}
