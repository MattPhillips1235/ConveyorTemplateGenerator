﻿#pragma checksum "..\..\..\Views\GenerateCode.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5AA188714408210A4F162A7438953939F81B90E4EC0724FDA4AA0EDDAECF53CC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GrantaTemplateGenerator.Views;
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


namespace GrantaTemplateGenerator.Views {
    
    
    /// <summary>
    /// GenerateCode
    /// </summary>
    public partial class GenerateCode : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Views\GenerateCode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGenerateConvCode;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\GenerateCode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_GripperCodeGenerated;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\GenerateCode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_ConveyorCodeGenerated;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\GenerateCode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExitApp;
        
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
            System.Uri resourceLocater = new System.Uri("/GrantaTemplateGenerator;component/views/generatecode.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\GenerateCode.xaml"
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
            this.btnGenerateConvCode = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Views\GenerateCode.xaml"
            this.btnGenerateConvCode.Click += new System.Windows.RoutedEventHandler(this.btnGenerateConvCode_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_GripperCodeGenerated = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.tb_ConveyorCodeGenerated = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.btnExitApp = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Views\GenerateCode.xaml"
            this.btnExitApp.Click += new System.Windows.RoutedEventHandler(this.btnExitApp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

