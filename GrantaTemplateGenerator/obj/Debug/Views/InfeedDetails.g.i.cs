﻿#pragma checksum "..\..\..\Views\InfeedDetails.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "11C3114183CDE70DAB4B8C606D88C4E5083BF9E5DA8322EE9F5ED628BC105519"
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
    /// InfeedDetails
    /// </summary>
    public partial class InfeedDetails : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\Views\InfeedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_GripperType;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Views\InfeedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_AmountofInfLanes;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Views\InfeedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_AmountofOutfLanes;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Views\InfeedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_OutfeedType;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\Views\InfeedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_BoxTracking;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\Views\InfeedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox bumpTurnEnabled;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\Views\InfeedDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_BumpTurnPosition;
        
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
            System.Uri resourceLocater = new System.Uri("/GrantaTemplateGenerator;component/views/infeeddetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\InfeedDetails.xaml"
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
            this.cb_GripperType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.cb_AmountofInfLanes = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cb_AmountofOutfLanes = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cb_OutfeedType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cb_BoxTracking = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.bumpTurnEnabled = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.cb_BumpTurnPosition = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

