﻿#pragma checksum "..\..\..\View\menu_principal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0B19E96BA74FA753EB6510A40276D3EE"
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
using WpfApplication9;


namespace WpfApplication9 {
    
    
    /// <summary>
    /// menu_principal
    /// </summary>
    public partial class menu_principal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\View\menu_principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid bar_top_container;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\View\menu_principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image bar_top;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\View\menu_principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bnt_min;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\View\menu_principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bnt_res;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\View\menu_principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bnt_close;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\..\View\menu_principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cad_new_user;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\View\menu_principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cad_new_cli;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\..\View\menu_principal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication9;component/view/menu_principal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\menu_principal.xaml"
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
            this.bar_top_container = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.bar_top = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.bnt_min = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\View\menu_principal.xaml"
            this.bnt_min.Click += new System.Windows.RoutedEventHandler(this.bnt_min_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bnt_res = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\View\menu_principal.xaml"
            this.bnt_res.Click += new System.Windows.RoutedEventHandler(this.bnt_res_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bnt_close = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\..\View\menu_principal.xaml"
            this.bnt_close.Click += new System.Windows.RoutedEventHandler(this.bnt_close_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_cad_new_user = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btn_cad_new_cli = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.button = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

