﻿#pragma checksum "..\..\CommandLineWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "465A7717E2A968E100EFA0F6F38567342A8462DAD4807FAD5415E93E8A8B664D"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using CommandLine;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CommandLine {
    
    
    /// <summary>
    /// CommandLineWindow
    /// </summary>
    public partial class CommandLineWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\CommandLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bt_Close;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\CommandLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bt_Settings;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\CommandLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lb_Logo;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\CommandLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_CommandLine;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\CommandLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tb_CommandResult;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\CommandLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popup;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\CommandLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox Lstbx_Command;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\CommandLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bt_SelectCommand;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\CommandLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tb_Command;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\CommandLineWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bt_CommandHelp;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CommandLine;component/commandlinewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CommandLineWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\CommandLineWindow.xaml"
            ((CommandLine.CommandLineWindow)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.AddKeyPressed);
            
            #line default
            #line hidden
            
            #line 17 "..\..\CommandLineWindow.xaml"
            ((CommandLine.CommandLineWindow)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DragWindow);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Bt_Close = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\CommandLineWindow.xaml"
            this.Bt_Close.Click += new System.Windows.RoutedEventHandler(this.Bt_Close_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Bt_Settings = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\CommandLineWindow.xaml"
            this.Bt_Settings.Click += new System.Windows.RoutedEventHandler(this.Bt_Settings_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Lb_Logo = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Grid_CommandLine = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.Tb_CommandResult = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.popup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 8:
            this.Lstbx_Command = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.Bt_SelectCommand = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\CommandLineWindow.xaml"
            this.Bt_SelectCommand.Click += new System.Windows.RoutedEventHandler(this.Bt_SelectCommand_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Tb_Command = ((System.Windows.Controls.TextBox)(target));
            
            #line 85 "..\..\CommandLineWindow.xaml"
            this.Tb_Command.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tb_Command_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Bt_CommandHelp = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\CommandLineWindow.xaml"
            this.Bt_CommandHelp.Click += new System.Windows.RoutedEventHandler(this.Bt_CommandHelp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

