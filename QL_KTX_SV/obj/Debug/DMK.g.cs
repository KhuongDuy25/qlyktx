﻿#pragma checksum "..\..\DMK.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8F16B7B315F722047524A9D18820D46A5B09C1DAB1C7FF699C4363409B3260DA"
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
    /// DMK
    /// </summary>
    public partial class DMK : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\DMK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pb_mkm;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\DMK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pb_nlmk;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\DMK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ok;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\DMK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ql;
        
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
            System.Uri resourceLocater = new System.Uri("/QL_KTX_SV;component/dmk.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DMK.xaml"
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
            this.pb_mkm = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 2:
            this.pb_nlmk = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.ok = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\DMK.xaml"
            this.ok.Click += new System.Windows.RoutedEventHandler(this.ok_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ql = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\DMK.xaml"
            this.ql.Click += new System.Windows.RoutedEventHandler(this.ql_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

