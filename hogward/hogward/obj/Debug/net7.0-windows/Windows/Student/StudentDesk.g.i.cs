﻿#pragma checksum "..\..\..\..\..\Windows\Student\StudentDesk.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C124B0DC08FDFB75C7003D7601AC44EBAB36F9F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using hogward.Windows;


namespace hogward.Windows {
    
    
    /// <summary>
    /// StudentDesk
    /// </summary>
    public partial class StudentDesk : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\Windows\Student\StudentDesk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button email;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\Windows\Student\StudentDesk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Lesson_Selction;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\Windows\Student\StudentDesk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Train;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Windows\Student\StudentDesk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TrainTime;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\Windows\Student\StudentDesk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chart;
        
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
            System.Uri resourceLocater = new System.Uri("/hogward;component/windows/student/studentdesk.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Student\StudentDesk.xaml"
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
            this.email = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\..\..\Windows\Student\StudentDesk.xaml"
            this.email.Click += new System.Windows.RoutedEventHandler(this.email_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Lesson_Selction = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\..\Windows\Student\StudentDesk.xaml"
            this.Lesson_Selction.Click += new System.Windows.RoutedEventHandler(this.Lesson_Selction_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Train = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\..\Windows\Student\StudentDesk.xaml"
            this.Train.Click += new System.Windows.RoutedEventHandler(this.Train_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TrainTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Chart = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\..\Windows\Student\StudentDesk.xaml"
            this.Chart.Click += new System.Windows.RoutedEventHandler(this.Chart_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

