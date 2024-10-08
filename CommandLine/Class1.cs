﻿using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Diagnostics;
using System;
using System.Security.Principal;
using System.Windows.Interop;
using System.Windows;
using System.Data.Common;
using System.Windows.Input;

namespace CommandLine
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class Class1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            CommandLineWindow commandWindow = new CommandLineWindow();
            commandWindow.Height = 30;
            WindowInteropHelper mainUi = new WindowInteropHelper(commandWindow);
            mainUi.Owner = Process.GetCurrentProcess().MainWindowHandle;
            commandWindow.Show();

            return Result.Succeeded;
        }
    }
}
