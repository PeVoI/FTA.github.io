﻿#pragma checksum "..\..\Prepodovateli.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1B57527AF49C1015FEE8A0CB3D397123953621CE8EAEB53A1A899031DA402065"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using Verstka;


namespace Verstka {
    
    
    /// <summary>
    /// Prepodovateli
    /// </summary>
    public partial class Prepodovateli : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Prepodovateli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Prepodovateli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox12;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Prepodovateli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox13;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Prepodovateli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox14;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Prepodovateli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox15;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Prepodovateli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox16;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Prepodovateli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox17;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Prepodovateli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox18;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Prepodovateli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox10;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Prepodovateli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox11;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Prepodovateli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text1;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Prepodovateli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listofUsers;
        
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
            System.Uri resourceLocater = new System.Uri("/Verstka;component/prepodovateli.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Prepodovateli.xaml"
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
            this.dg = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\Prepodovateli.xaml"
            this.dg.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dg_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 19 "..\..\Prepodovateli.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Back_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textbox12 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textbox13 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textbox14 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.textbox15 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.textbox16 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.textbox17 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.textbox18 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 30 "..\..\Prepodovateli.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.but6_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.textbox10 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.textbox11 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 33 "..\..\Prepodovateli.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.but3_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.text1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            
            #line 35 "..\..\Prepodovateli.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.but1_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 36 "..\..\Prepodovateli.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.but2_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.listofUsers = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

