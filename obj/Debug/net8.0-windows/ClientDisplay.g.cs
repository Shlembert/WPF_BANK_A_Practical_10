﻿#pragma checksum "..\..\..\ClientDisplay.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44807BFB999B15110853015A87533BE6D34992A7"
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
using Wpf_Bank_A;


namespace Wpf_Bank_A {
    
    
    /// <summary>
    /// ClientDisplay
    /// </summary>
    public partial class ClientDisplay : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\ClientDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TableClients;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\ClientDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangePhoneNumberButton;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\ClientDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditClientButton;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\ClientDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddClientButton;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\ClientDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoToMenuButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Wpf_Bank_A;component/clientdisplay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ClientDisplay.xaml"
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
            this.TableClients = ((System.Windows.Controls.DataGrid)(target));
            
            #line 26 "..\..\..\ClientDisplay.xaml"
            this.TableClients.Loaded += new System.Windows.RoutedEventHandler(this.LoadClientsToTable);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\ClientDisplay.xaml"
            this.TableClients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TableClients_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\ClientDisplay.xaml"
            this.TableClients.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.TableClients_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ChangePhoneNumberButton = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\ClientDisplay.xaml"
            this.ChangePhoneNumberButton.Click += new System.Windows.RoutedEventHandler(this.ChangePhoneNumber_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EditClientButton = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\ClientDisplay.xaml"
            this.EditClientButton.Click += new System.Windows.RoutedEventHandler(this.EditClient_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddClientButton = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\ClientDisplay.xaml"
            this.AddClientButton.Click += new System.Windows.RoutedEventHandler(this.AddClient_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GoToMenuButton = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\ClientDisplay.xaml"
            this.GoToMenuButton.Click += new System.Windows.RoutedEventHandler(this.GoToMenu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

