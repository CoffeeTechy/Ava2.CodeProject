using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ava2.CodeProject.ViewModels
{
    public class SecondPageViewModel : PageArrayViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public SecondPageViewModel() 
        { 
            Title = "Second Page"; 
            Description = "This is the second page";

            //NavigateNext = true;
            //NavigatePrevious = true;
        }

        //public bool NavigateNext = true;

        //public bool NavigatePrevious = true;
    }
}
