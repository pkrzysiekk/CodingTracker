using CodingTracker.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodingTracker.Controllers
{
    public static class UserInput
    {
        public static MenuChoices GetUserChoice()
        {
            var choice = AnsiConsole.Prompt(new SelectionPrompt<MenuChoices>()
               .Title("What do you want to do?")
               .AddChoices(Enum.GetValues<MenuChoices>())
                .UseConverter(c => c.GetType()
                 .GetMember(c.ToString())
                 .First()
                 .GetCustomAttribute<DisplayAttribute>()?.Name ?? c.ToString()));

            return choice;
        }
    }
}
