﻿#pragma checksum "..\..\..\..\..\Windows\Professor\ProfessorHomeWork.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ACABC1FADBDC56878B66640D534A0C80E2E331B"
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
using hogward.Windows.Professor;


namespace hogward.Windows.Professor {
    
    
    /// <summary>
    /// ProfessorHomeWork
    /// </summary>
    public partial class ProfessorHomeWork : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\Windows\Professor\ProfessorHomeWork.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ListLesson;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\..\Windows\Professor\ProfessorHomeWork.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DeadLine;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\Windows\Professor\ProfessorHomeWork.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Title;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Windows\Professor\ProfessorHomeWork.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Send;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\Windows\Professor\ProfessorHomeWork.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Point;
        
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
            System.Uri resourceLocater = new System.Uri("/hogward;component/windows/professor/professorhomework.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Professor\ProfessorHomeWork.xaml"
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
            this.ListLesson = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.DeadLine = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.Title = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Send = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\..\Windows\Professor\ProfessorHomeWork.xaml"
            this.Send.Click += new System.Windows.RoutedEventHandler(this.Send_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Point = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

