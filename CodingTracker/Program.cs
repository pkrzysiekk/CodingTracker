using Spectre.Console;
using System.Configuration;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using CodingTracker.Models;
using CodingTracker.Views;
using CodingTracker.Controllers;
namespace CodingTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppMenu appMenu = new AppMenu();
            appMenu.Show();

        }
    }
}
