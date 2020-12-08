using System;

namespace tvCallSign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter channel number:");
            int channel = Convert.ToInt32(Console.ReadLine());
            string callsign = "";

            switch (channel)
            {
                case 1:
                    callsign = "undesignated in your area";
                    break;
                case 2:
                    callsign = "wtwo";
                    break;
                case 3:
                    callsign = "wthree";
                    break;
                case 4:
                    callsign = "wfour";
                    break;
                case 5:
                    callsign = "wfive";
                    break;
                case 6:
                    callsign = "wsix";
                    break;
                case 7:
                    callsign = "wsev";
                    break;
                case 8:
                    callsign = "wate";
                    break;
                case 9:
                    callsign = "wnine";
                    break;
                case 10:
                    callsign = "wten";
                    break;
                default:
                    Console.WriteLine("Please enter a channel between 1 and 10");
                    break;
            }

            if (channel <= 10)
            {
                string callsign1 = callsign.ToUpper();
                Console.WriteLine("Callsign for channel " + channel + " is " + callsign1 + ".");
            }
        }
    }
}
