using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTracker.Models
{
    public enum MenuChoices
    {
        [Display(Name = "Display all the records")]
        DisplayRecords,
        [Display(Name = "Insert record into the Database")]
        InsertRecord,
        [Display(Name = "Remove record")]
        RemoveRecord,
        [Display(Name = "Edit record")]
        EditRecord,
        [Display(Name = "Exit Menu")]
        Exit

    }
}
