﻿#pragma checksum "..\..\..\..\..\UI\Registros\rCambiarContrasena.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0FF81A574821FF55BC665DD055CDCE9DCE2B8FFA"
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
using ProyectoCondominio.UI.Registros;
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


namespace ProyectoCondominio.UI.Registros {
    
    
    /// <summary>
    /// rCambiarContrasena
    /// </summary>
    public partial class rCambiarContrasena : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\UI\Registros\rCambiarContrasena.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ContrasenaPasswordBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\UI\Registros\rCambiarContrasena.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox NuevaPasswordBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\UI\Registros\rCambiarContrasena.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ConfirmarPasswordBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\UI\Registros\rCambiarContrasena.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AceptarButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\UI\Registros\rCambiarContrasena.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelarButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProyectoCondominio;V1.0.0.0;component/ui/registros/rcambiarcontrasena.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Registros\rCambiarContrasena.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ContrasenaPasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 2:
            this.NuevaPasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.ConfirmarPasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.AceptarButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\UI\Registros\rCambiarContrasena.xaml"
            this.AceptarButton.Click += new System.Windows.RoutedEventHandler(this.AceptarButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CancelarButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\..\UI\Registros\rCambiarContrasena.xaml"
            this.CancelarButton.Click += new System.Windows.RoutedEventHandler(this.CancelarButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

