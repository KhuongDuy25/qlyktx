﻿#pragma checksum "..\..\Khoa.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CC5A8962C29D4E565DA0121C951BC3296D51E162AC45A7E4413A579FE5129E29"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QL_KTX_SV;
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


namespace QL_KTX_SV {
    
    
    /// <summary>
    /// Khoa
    /// </summary>
    public partial class Khoa : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Khoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Khoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_mk;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Khoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_tk;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Khoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_them;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Khoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_sua;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Khoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_xoa;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Khoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_search;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Khoa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_tk;
        
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
            System.Uri resourceLocater = new System.Uri("/QL_KTX_SV;component/khoa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Khoa.xaml"
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
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\Khoa.xaml"
            this.dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_mk = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_tk = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btn_them = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Khoa.xaml"
            this.btn_them.Click += new System.Windows.RoutedEventHandler(this.btn_them_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_sua = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Khoa.xaml"
            this.btn_sua.Click += new System.Windows.RoutedEventHandler(this.btn_sua_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_xoa = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Khoa.xaml"
            this.btn_xoa.Click += new System.Windows.RoutedEventHandler(this.btn_xoa_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tb_search = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\Khoa.xaml"
            this.tb_search.KeyUp += new System.Windows.Input.KeyEventHandler(this.tb_search_KeyUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_tk = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Khoa.xaml"
            this.btn_tk.Click += new System.Windows.RoutedEventHandler(this.btn_tk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

