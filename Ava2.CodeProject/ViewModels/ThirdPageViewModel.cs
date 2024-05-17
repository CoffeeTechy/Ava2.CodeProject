using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ava2.CodeProject.ViewModels
{
    public class ThirdPageViewModel : PageArrayViewModel
    {
        public string End { get; set; }

        public ThirdPageViewModel() 
        {
            End = "This is the End";

            //NavigateNext = false;
            //NavigatePrevious = true;
        }
    }
}
