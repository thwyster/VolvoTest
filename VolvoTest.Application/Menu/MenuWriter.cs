using System;
using System.Collections.Generic;
using System.Text;
using VolvoTest.Application.DTO;
using VolvoTest.Domain.Enumerators;

namespace VolvoTest.Application.Menu
{
    public class MenuWriter
    {
        public static void MainMenu()
        {
            Console.WriteLine("FLEET MANAGEMENT");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("    ╔═════════════════ MENU ════════════════╗    ");
            Console.WriteLine("    ║ 1) Insert a new vehicle               ║    ");
            Console.WriteLine("    ║ 2) Edit an existing vehicle           ║    ");
            Console.WriteLine("    ║ 3) Delete an existing vehicle         ║    ");
            Console.WriteLine("    ║ 4) List all vehicles                  ║    ");
            Console.WriteLine("    ║ 5) Find a vehicle by Chassis ID       ║    ");
            Console.WriteLine("    ║ 6) Exit                               ║    ");
            Console.WriteLine("    ╚═══════════════════════════════════════╝    ");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Choose your option and press ENTER!");
        }

        public static VehicleDTO Insert()
        {
            Console.WriteLine("INSERT A NEW VEHICLE");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Insert a Chassis Series: (Example: XXX)");
            var chassisSeries = Console.ReadLine().ToUpper();

            Console.WriteLine("Insert a Chassis ID: (Example: 12345678)");
            if (!int.TryParse(Console.ReadLine(), out int chassisNumber))
            {
                throw new Exception("Chassis number must be numerical");
            }

            Console.WriteLine("Select a <TYPE> Vehicle Below:");

            Console.WriteLine("+------+-------------+----------------------+");
            Console.WriteLine("| Type | Description | Number of Passengers |");
            Console.WriteLine("+------+-------------+----------------------+");
            Console.WriteLine("| 1    | Bus         | 42                   |");
            Console.WriteLine("+------+-------------+----------------------+");
            Console.WriteLine("| 2    | Truck       | 1                    |");
            Console.WriteLine("+------+-------------+----------------------+");
            Console.WriteLine("| 3    | Car         | 4                    |");
            Console.WriteLine("+------+-------------+----------------------+");

            if (!int.TryParse(Console.ReadLine(), out int type))
            {
                throw new Exception("Chassis number must be numerical");
            }
            else if (type < 1 || type > 3)
            {
                throw new Exception("Type must be 1,2 or 3");
            }

            Console.WriteLine("Insert a Color of Vehicle: (Example: Red)");
            var color = Console.ReadLine().ToUpper();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Your Vehicle:");

            Console.WriteLine("+------------+------+-------------+-------+");
            Console.WriteLine("| Chassis ID | Type | Description | Color |");
            Console.WriteLine("+------------+------+-------------+-------+");
            Console.WriteLine($"|{chassisSeries}-{chassisNumber} | {type}    | Car         | {color}   |");
            Console.WriteLine("+------------+------+-------------+-------+");

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Confirm?      <Y> - YES | <N> - NO");

            string confirm = Console.ReadLine().ToUpper(); ;
            if (confirm == "Y")
            {
                VehicleDTO objVehicle = new VehicleDTO();

                objVehicle.ChassisSeries = chassisSeries;
                objVehicle.ChassisNumber = chassisNumber;
                objVehicle.TypeVehicle = (TypeVehicle)type;
                objVehicle.Color = color;

                return objVehicle;
            }
            else
            {
                return null;
            }
        }
    }
}
