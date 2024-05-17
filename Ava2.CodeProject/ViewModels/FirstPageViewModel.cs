using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ava2.CodeProject.ViewModels
{
    public class FirstPageViewModel : PageArrayViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public FirstPageViewModel() 
        { 
            Title = "First Page"; 
            Description = "This is the first page of the app"; 
            
            //NavigateNext = true;
            //NavigatePrevious = false;
        }

        
        //public bool NavigateNext = true;

        //public bool NavigatePrevious = false;
        //// This is our first page, so we can navigate to the next page in any case
        //public override bool CanNavigateNext
        //{
        //    get => true;
        //    protected set => throw new NotSupportedException();
        //}

        //// You cannot go back from this page
        //public override bool CanNavigatePrevious
        //{
        //    get => false;
        //    protected set => throw new NotSupportedException();
        //}
    }
}
