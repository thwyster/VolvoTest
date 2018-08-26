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
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid option, please choose one of the options below.");
                MainMenu();
            }
        }

        private void MenuExit()
        {

        }

        private void MenuFind()
        {
            try
            {

            }
            catch (DomainException ex)
            {
                Console.WriteLine(ex.Message);
                MainMenu();
            }
        }

        private void MenuListAll()
        {
            try
            {

            }
            catch (DomainException ex)
            {
                Console.WriteLine(ex.Message);
                MainMenu();
            }
        }

        private void MenuDelete()
        {
            try
            {

            }
            catch (DomainException ex)
            {
                Console.WriteLine(ex.Message);
                MainMenu();
            }
        }

        private void MenuUpdate()
        {
            try
            {

            }
            catch (DomainException ex)
            {
                Console.WriteLine(ex.Message);
                MainMenu();
            }
        }

        private void MenuInsert()
        {
            try
            {
                var objvehicle = MenuWriter.Insert();
                _services.Insert(objvehicle.ChassisSeries, objvehicle.ChassisNumber, objvehicle.TypeVehicle, objvehicle.Color);
            }
            catch (DomainException ex)
            {
                Console.WriteLine(ex.Message);
                MainMenu();
            }
        }
    }
}
