﻿#pragma checksum "..\..\..\..\MVVM\View\RegisterPatientView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5F7A6F54F08915CBC43DB5337A88321FCCDD364CB27683341766671798A44CF3"
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


namespace EMR.UI.MVVM.View {
    
    
    /// <summary>
    /// RegisterPatientView
    /// </summary>
    public partial class RegisterPatientView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\..\MVVM\View\RegisterPatientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstNameText;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\MVVM\View\RegisterPatientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastNameText;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\MVVM\View\RegisterPatientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ageText;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\MVVM\View\RegisterPatientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox phoneNumberText;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\MVVM\View\RegisterPatientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addressText;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\MVVM\View\RegisterPatientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox genderText;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\MVVM\View\RegisterPatientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox heightText;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\MVVM\View\RegisterPatientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox weightText;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\MVVM\View\RegisterPatientView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listPatientListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/EMR.UI;component/mvvm/view/registerpatientview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\RegisterPatientView.xaml"
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
            this.firstNameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.lastNameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ageText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.phoneNumberText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.addressText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.genderText = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.heightText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.weightText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 57 "..\..\..\..\MVVM\View\RegisterPatientView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddPatientButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 70 "..\..\..\..\MVVM\View\RegisterPatientView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RefreshListButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.listPatientListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

