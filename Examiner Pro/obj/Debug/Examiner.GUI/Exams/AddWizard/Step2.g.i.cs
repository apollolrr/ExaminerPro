﻿#pragma checksum "..\..\..\..\..\Examiner.GUI\Exams\AddWizard\Step2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EB1B4154C7D66268A596C8C259D10CD2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Examiner_Pro.Examiner.GUI.Exams.AddWizard;
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


namespace Examiner_Pro.Examiner.GUI.Exams.AddWizard {
    
    
    /// <summary>
    /// Step2
    /// </summary>
    public partial class Step2 : System.Windows.Navigation.PageFunction<Examiner_Pro.Examiner.GUI.Exams.AddWizard.StepResult>, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\..\Examiner.GUI\Exams\AddWizard\Step2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dataItem3TextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Examiner.GUI\Exams\AddWizard\Step2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\Examiner.GUI\Exams\AddWizard\Step2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\Examiner.GUI\Exams\AddWizard\Step2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Examiner.GUI\Exams\AddWizard\Step2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button finishButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Examiner Pro;component/examiner.gui/exams/addwizard/step2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Examiner.GUI\Exams\AddWizard\Step2.xaml"
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
            this.dataItem3TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\..\Examiner.GUI\Exams\AddWizard\Step2.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nextButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\Examiner.GUI\Exams\AddWizard\Step2.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.finishButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\..\Examiner.GUI\Exams\AddWizard\Step2.xaml"
            this.finishButton.Click += new System.Windows.RoutedEventHandler(this.finishButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

