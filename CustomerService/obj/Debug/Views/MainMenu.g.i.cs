﻿#pragma checksum "..\..\..\Views\MainMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C8E688351B2764750E4A5EC8980761CF4C101F5C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CustomerService.Views;
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


namespace CustomerService.Views {
    
    
    /// <summary>
    /// MainMenu
    /// </summary>
    public partial class MainMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClientInfo;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLineInfo;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSimulator;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReceipt;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClientStats;
        
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
            System.Uri resourceLocater = new System.Uri("/CustomerService;component/views/mainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainMenu.xaml"
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
            this.btnClientInfo = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Views\MainMenu.xaml"
            this.btnClientInfo.Click += new System.Windows.RoutedEventHandler(this.btnClientInfo_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnLineInfo = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Views\MainMenu.xaml"
            this.btnLineInfo.Click += new System.Windows.RoutedEventHandler(this.btnLineInfo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSimulator = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Views\MainMenu.xaml"
            this.btnSimulator.Click += new System.Windows.RoutedEventHandler(this.btnSimulator_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnReceipt = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Views\MainMenu.xaml"
            this.btnReceipt.Click += new System.Windows.RoutedEventHandler(this.btnReceipt_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnClientStats = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Views\MainMenu.xaml"
            this.btnClientStats.Click += new System.Windows.RoutedEventHandler(this.btnClientStats_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

