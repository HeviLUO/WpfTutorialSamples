﻿#pragma checksum "..\..\..\..\TabControl\ControllingTheTabControlSample.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1DE2D6B2526351B15DA0A85FEBED8A58"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
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


namespace WpfTutorialSamples.Misc_controls {
    
    
    /// <summary>
    /// ControllingTheTabControlSample
    /// </summary>
    public partial class ControllingTheTabControlSample : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\TabControl\ControllingTheTabControlSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPreviousTab;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\..\TabControl\ControllingTheTabControlSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNextTab;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\TabControl\ControllingTheTabControlSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelectedTab;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\..\TabControl\ControllingTheTabControlSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tcSample;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfTutorialSamples;component/tabcontrol/controllingthetabcontrolsample.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\TabControl\ControllingTheTabControlSample.xaml"
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
            this.btnPreviousTab = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\..\..\TabControl\ControllingTheTabControlSample.xaml"
            this.btnPreviousTab.Click += new System.Windows.RoutedEventHandler(this.btnPreviousTab_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnNextTab = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\..\..\TabControl\ControllingTheTabControlSample.xaml"
            this.btnNextTab.Click += new System.Windows.RoutedEventHandler(this.btnNextTab_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSelectedTab = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\..\TabControl\ControllingTheTabControlSample.xaml"
            this.btnSelectedTab.Click += new System.Windows.RoutedEventHandler(this.btnSelectedTab_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tcSample = ((System.Windows.Controls.TabControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
