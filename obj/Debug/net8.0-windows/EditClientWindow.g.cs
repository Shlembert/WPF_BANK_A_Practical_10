﻿#pragma checksum "..\..\..\EditClientWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6D0377EC651A85596AA03223988AB99C19BA89B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace Wpf_Bank_A {
    
    
    /// <summary>
    /// EditClientWindow
    /// </summary>
    public partial class EditClientWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\EditClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FullNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\EditClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneNumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\EditClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PassportSeriesTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\EditClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PassportNumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\EditClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DoneButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\EditClientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Wpf_Bank_A;component/editclientwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EditClientWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FullNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 7 "..\..\..\EditClientWindow.xaml"
            this.FullNameTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.FullNameTextBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PhoneNumberTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\EditClientWindow.xaml"
            this.PhoneNumberTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.PhoneNumberTextBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PassportSeriesTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\EditClientWindow.xaml"
            this.PassportSeriesTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.PassportSeriesTextBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PassportNumberTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\EditClientWindow.xaml"
            this.PassportNumberTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.PassportNumberTextBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DoneButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\EditClientWindow.xaml"
            this.DoneButton.Click += new System.Windows.RoutedEventHandler(this.DoneButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\EditClientWindow.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

