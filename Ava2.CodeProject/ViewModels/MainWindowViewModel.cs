using Avalonia.Controls;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Security.AccessControl;

namespace Ava2.CodeProject.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
#pragma warning disable CA1822 // Mark members as static
        //public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static

        [ObservableProperty]
        private bool _paneOpen = false;

        [ObservableProperty]
        private string? _isOpen = "+";

        [ObservableProperty]
        private int _index;

        [ObservableProperty]
        private bool _nextPage;

        [ObservableProperty]
        private bool _prevPage;

        [ObservableProperty]
        private int _pageNum;

        public void OpenPane() //handles both open and closing pane as well as arrow direction
        {
            PaneOpen = !PaneOpen;

            if (PaneOpen)
                IsOpen = "<-";

            else if (!PaneOpen)
                IsOpen = "+";
        }

        [ObservableProperty]
        private PageArrayViewModel _currentPage;

        public PageArrayViewModel[] Pages =
        {
            new FirstPageViewModel(),
            new SecondPageViewModel(),
            new ThirdPageViewModel()
        };

        public MainWindowViewModel() 
        {
            Index = 0;
            CurrentPage = Pages[Index];
            PageNum = Index + 1;
        }

        //SplitView buttons have to say the page number specifically
        public void SetIndexBtn1()
        {
            Index = 0;
            CurrentPage = Pages[Index];
            PageNum = 1;
        }

        public void SetIndexBtn2()
        {
            Index = 1;
            CurrentPage = Pages[Index];
            PageNum = 2;
        }

        public void SetIndexBtn3()
        {
            Index = 2;
            CurrentPage = Pages[Index];
            PageNum = 3;
        }

        //the bottom buttons increase and descrease the page number and index by 1 
        public void Next()
        {
            if (Index < Pages.Length - 1)
            {
                Index++;
                CurrentPage = Pages[Index];
                PageNum++;
            }     
        }

        public void Previous()
        {
            if (Index > 0)
            {
                Index--;
                CurrentPage = Pages[Index];
                PageNum--;
            }
        }

        //public void StartExcel()
        //{
        //    var excelApp = new Microsoft.Office.Interop.Excel.Application();
        //    Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Microsoft Office 2013");
        //}
    }
}
