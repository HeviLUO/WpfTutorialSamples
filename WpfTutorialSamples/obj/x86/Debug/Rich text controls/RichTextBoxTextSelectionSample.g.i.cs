﻿#pragma checksum "..\..\..\..\Rich text controls\RichTextBoxTextSelectionSample.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BC48706066D28175F43E5C2D4E288E82"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
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
using System.Windows.Forms.Integration;
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


namespace WpfTutorialSamples.Rich_text_controls {
    
    
    /// <summary>
    /// RichTextBoxTextSelectionSample
    /// </summary>
    public partial class RichTextBoxTextSelectionSample : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\Rich text controls\RichTextBoxTextSelectionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGetText;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\..\Rich text controls\RichTextBoxTextSelectionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSetText;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\Rich text controls\RichTextBoxTextSelectionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGetSelectedText;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\Rich text controls\RichTextBoxTextSelectionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSetSelectedText;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Rich text controls\RichTextBoxTextSelectionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStatus;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Rich text controls\RichTextBoxTextSelectionSample.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtbEditor;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfTutorialSamples;component/rich%20text%20controls/richtextboxtextselectionsamp" +
                    "le.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Rich text controls\RichTextBoxTextSelectionSample.xaml"
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
            this.btnGetText = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\..\..\Rich text controls\RichTextBoxTextSelectionSample.xaml"
            this.btnGetText.Click += new System.Windows.RoutedEventHandler(this.btnGetText_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSetText = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\..\..\Rich text controls\RichTextBoxTextSelectionSample.xaml"
            this.btnSetText.Click += new System.Windows.RoutedEventHandler(this.btnSetText_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnGetSelectedText = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\..\Rich text controls\RichTextBoxTextSelectionSample.xaml"
            this.btnGetSelectedText.Click += new System.Windows.RoutedEventHandler(this.btnGetSelectedText_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSetSelectedText = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\..\Rich text controls\RichTextBoxTextSelectionSample.xaml"
            this.btnSetSelectedText.Click += new System.Windows.RoutedEventHandler(this.btnSetSelectedText_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtStatus = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.rtbEditor = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 13 "..\..\..\..\Rich text controls\RichTextBoxTextSelectionSample.xaml"
            this.rtbEditor.SelectionChanged += new System.Windows.RoutedEventHandler(this.rtbEditor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
