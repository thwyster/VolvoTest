using System;
using System.Collections.Generic;
using System.Text;
using VolvoTest.Application.Menu;
using VolvoTest.Domain.Enumerators;
using VolvoTest.Domain.Exceptions;
using VolvoTest.Domain.Interfaces;

namespace VolvoTest.Application
{
    public class ServicesApplication
    {
        private IServicesDO _services;

        public ServicesApplication(IServicesDO services)
        {
            _services = services;
            MainMenu();
        }

        public void MainMenu()
        {
            MenuWriter.MainMenu();

            try
            {
                Int32.TryParse(Console.ReadLine(), out int option);
                MenuOption menu = (MenuOption)option;

                switch (menu)
                {
                    case MenuOption.Insert:
                        MenuInsert();
                        break;
                    case MenuOption.Update:
                        MenuUpdate();
                        break;
                    case MenuOption.Delete:
                        MenuDelete();
                        break;
                    case MenuOption.ListAll:
                        MenuListAll();
                        break;
                    case MenuOption.Find:
                        MenuFind();
                        break;
                    case MenuOption.Exit:
                        MenuExit();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"[ERROR] - Invalid option, please choose one of the options below.");
                        Console.ResetColor();
                        MainMenu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR] - Invalid option, please choose one of the options below.");
                Console.ResetColor();
                MainMenu();
            }
        }

        private void MenuExit()
        {
            if (MenuWriter.Exit())
            {
                Environment.Exit(0);
            }
            else
            {
                MainMenu();
            }
        }

        private void MenuFind()
        {
            try
            {
                var objVehicle = MenuWriter.Find();
                var obj = _services.Find($"{objVehicle.ChassisSeries}-{objVehicle.ChassisNumber}");
                if (obj != null)
                {
                    List<IVehicle> listVehicle = new List<IVehicle>();
                    listVehicle.Add(obj);
                    MenuWriter.ListAll(listVehicle);
                }
                else
                    MenuWriter.ListAll(null);

                MainMenu();
            }
            catch (DomainException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR] - {ex.Message}");
                Console.ResetColor();
                MainMenu();
            }
        }

        private void MenuListAll()
        {
            try
            {
                List<IVehicle> listVehicles = _services.ListAll();
                MenuWriter.ListAll(listVehicles);
                MainMenu();
            }
            catch (DomainException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR] - {ex.Message}");
                Console.ResetColor();
                MainMenu();
            }
        }

        private void MenuDelete()
        {
            try
            {
                var objVehicle = MenuWriter.Delete();
                _services.Delete($"{objVehicle.ChassisSeries}-{objVehicle.ChassisNumber}");
                MainMenu();
            }
            catch (DomainException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR] - {ex.Message}");
                Console.ResetColor();
                MainMenu();
            }
        }

        private void MenuUpdate()
        {
            try
            {
                var objVehicle = MenuWriter.Update();
                _services.Update($"{objVehicle.ChassisSeries}-{objVehicle.ChassisNumber}", objVehicle.Color);
                MainMenu();
            }
            catch (DomainException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR] - {ex.Message}");
                Console.ResetColor();
                MainMenu();
            }
        }

        private void MenuInsert()
        {
            try
            {
                var objvehicle = MenuWriter.Insert();
                _services.Insert(objvehicle.ChassisSeries, objvehicle.ChassisNumber, objvehicle.TypeVehicle, objvehicle.Color);
                MainMenu();
            }
            catch (DomainException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR] - {ex.Message}");
                Console.ResetColor();
                MainMenu();
            }
        }
    }
}
