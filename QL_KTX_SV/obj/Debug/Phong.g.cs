﻿#pragma checksum "..\..\Phong.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F1A79EB706B996A20A89436629FE18047A5CF879042B87B93A9898762CDD150E"
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
    /// Phong
    /// </summary>
    public partial class Phong : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\Phong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Phong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_search;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Phong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_dangky;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Phong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_tk;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Phong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tb_tenthietbi;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Phong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_tinhtrang;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Phong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_soluong;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Phong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_sua;
        
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
            System.Uri resourceLocater = new System.Uri("/QL_KTX_SV;component/phong.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Phong.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 21 "..\..\Phong.xaml"
            this.dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_search = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\Phong.xaml"
            this.tb_search.KeyUp += new System.Windows.Input.KeyEventHandler(this.tb_search_KeyUp);
            
            #line default
            #line hidden
            
            #line 30 "..\..\Phong.xaml"
            this.tb_search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_dangky = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Phong.xaml"
            this.btn_dangky.Click += new System.Windows.RoutedEventHandler(this.btn_dangky_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 32 "..\..\Phong.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_soPhongConTrong_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_tk = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\Phong.xaml"
            this.btn_tk.Click += new System.Windows.RoutedEventHandler(this.btn_tk_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tb_tenthietbi = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\Phong.xaml"
            this.tb_tenthietbi.KeyUp += new System.Windows.Input.KeyEventHandler(this.tb_search_KeyUp);
            
            #line default
            #line hidden
            
            #line 38 "..\..\Phong.xaml"
            this.tb_tenthietbi.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tb_tenthietbi_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tb_tinhtrang = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\Phong.xaml"
            this.tb_tinhtrang.KeyUp += new System.Windows.Input.KeyEventHandler(this.tb_search_KeyUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tb_soluong = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\Phong.xaml"
            this.tb_soluong.KeyUp += new System.Windows.Input.KeyEventHandler(this.tb_search_KeyUp);
            
            #line default
            #line hidden
            
            #line 40 "..\..\Phong.xaml"
            this.tb_soluong.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_soluong_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_sua = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\Phong.xaml"
            this.btn_sua.Click += new System.Windows.RoutedEventHandler(this.btn_sua_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

