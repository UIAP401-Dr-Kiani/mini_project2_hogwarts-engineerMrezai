﻿#pragma checksum "..\..\..\..\..\Windows\Dumbledore\DumbledoreMassageSender.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87A210B6BE82368A5207B37E963B6FC4AA5DBC27"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using hogward;


namespace hogward {
    
    
    /// <summary>
    /// DumbledoreMassageSender
    /// </summary>
    public partial class DumbledoreMassageSender : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\..\Windows\Dumbledore\DumbledoreMassageSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePicker;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\..\Windows\Dumbledore\DumbledoreMassageSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Hour;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\..\Windows\Dumbledore\DumbledoreMassageSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Min;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\Windows\Dumbledore\DumbledoreMassageSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Time;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\Windows\Dumbledore\DumbledoreMassageSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Massage;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Windows\Dumbledore\DumbledoreMassageSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MassageSender;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\Windows\Dumbledore\DumbledoreMassageSender.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/hogward;V1.0.0.0;component/windows/dumbledore/dumbledoremassagesender.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Dumbledore\DumbledoreMassageSender.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.Hour = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Min = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Time = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Massage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.MassageSender = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\Windows\Dumbledore\DumbledoreMassageSender.xaml"
            this.MassageSender.Click += new System.Windows.RoutedEventHandler(this.MassageSender_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Refresh = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\Windows\Dumbledore\DumbledoreMassageSender.xaml"
            this.Refresh.Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

