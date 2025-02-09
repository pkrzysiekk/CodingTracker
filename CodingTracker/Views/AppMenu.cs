using CodingTracker.Controllers;
using CodingTracker.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodingTracker.Views
{
   public static class AppMenu
    {
        

        public static void Show()
        {
            var choice = UserInput.GetUserChoice();

            switch (choice)
            {
                case MenuChoices.DisplayRecords:
                    Console.WriteLine("Eyeyeye");
                    break;
                case MenuChoices.InsertRecord:
                    Console.WriteLine("Insert");
                    break;
                case MenuChoices.RemoveRecord:
                    Console.WriteLine("Remove");
                    break;
                case MenuChoices.EditRecord:
                    Console.WriteLine("Edit");
                    break;
                
            }

        }
    }
}
