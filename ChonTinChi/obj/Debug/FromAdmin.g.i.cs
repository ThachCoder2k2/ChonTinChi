﻿#pragma checksum "..\..\FromAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0CE8C8AA4EC0CE6876DD5752655122713A37A63F7C01BEC3C29A4D58B5D75130"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ChonTinChi;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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


namespace ChonTinChi {
    
    
    /// <summary>
    /// FromAdmin
    /// </summary>
    public partial class FromAdmin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 61 "..\..\FromAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton HomePage_ToggleButton;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\FromAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PANEL2;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\FromAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Tg_Btn2;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\FromAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard HideStackPanel2;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\FromAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard ShowStackPanel2;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\FromAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Subject_ToggleButton;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\FromAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Class_ToggleButton;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\FromAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Student_ToggleButton;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\FromAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 265 "..\..\FromAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FromDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/ChonTinChi;component/fromadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FromAdmin.xaml"
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
            this.HomePage_ToggleButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 62 "..\..\FromAdmin.xaml"
            this.HomePage_ToggleButton.Click += new System.Windows.RoutedEventHandler(this.ToggleButton_Click_Home_Page);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PANEL2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Tg_Btn2 = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 82 "..\..\FromAdmin.xaml"
            this.Tg_Btn2.Click += new System.Windows.RoutedEventHandler(this.Manage_ToggleButton_CLick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.HideStackPanel2 = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 5:
            this.ShowStackPanel2 = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 6:
            this.Subject_ToggleButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 145 "..\..\FromAdmin.xaml"
            this.Subject_ToggleButton.Click += new System.Windows.RoutedEventHandler(this.ToggleButton_Click_Subject);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Class_ToggleButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 155 "..\..\FromAdmin.xaml"
            this.Class_ToggleButton.Click += new System.Windows.RoutedEventHandler(this.ToggleButton_Click_Class);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Student_ToggleButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 170 "..\..\FromAdmin.xaml"
            this.Student_ToggleButton.Click += new System.Windows.RoutedEventHandler(this.ToggleButton_Click_Student);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 185 "..\..\FromAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Logout_click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 250 "..\..\FromAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.App_Maximize_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 259 "..\..\FromAdmin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.App_Minimize_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.FromDataGrid = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
