﻿#pragma checksum "..\..\Voditel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2FE224B252A3DBD4354B38F7F9A24EC582F414EA4871E2824F843D374B4E03DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FTA;
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


namespace FTA {
    
    
    /// <summary>
    /// Voditel
    /// </summary>
    public partial class Voditel : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Voditel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Voditel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox12;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Voditel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox13;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Voditel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox14;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Voditel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox15;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Voditel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox16;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Voditel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox10;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Voditel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox11;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Voditel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Voditel.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Verstka;component/voditel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Voditel.xaml"
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
            
            #line 11 "..\..\Voditel.xaml"
            this.dg.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dg_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 16 "..\..\Voditel.xaml"
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
            
            #line 25 "..\..\Voditel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.but7_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.textbox10 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.textbox11 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 28 "..\..\Voditel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.but4_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.text1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 30 "..\..\Voditel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.but6_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 31 "..\..\Voditel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.but5_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.listofUsers = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

