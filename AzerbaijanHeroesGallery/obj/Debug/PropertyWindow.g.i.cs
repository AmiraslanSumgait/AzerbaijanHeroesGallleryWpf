﻿#pragma checksum "..\..\PropertyWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0C0B9A0103B96E2CFBBC87EB22A9E7C860AECB4CC8D3B54C524A5EAB8BA03F1D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AzerbaijanHeroesGallery;
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


namespace AzerbaijanHeroesGallery {
    
    
    /// <summary>
    /// PropertyWindow
    /// </summary>
    public partial class PropertyWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\PropertyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nameTxtBlk;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\PropertyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock dateTxtBlk;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\PropertyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image mainImage;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\PropertyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock descriptionTxtb;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\PropertyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock priceTxtb;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\PropertyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button prevBtn;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\PropertyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pauseBtn;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\PropertyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button autoPlayBtn;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\PropertyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/AzerbaijanHeroesGallery;component/propertywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PropertyWindow.xaml"
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
            
            #line 10 "..\..\PropertyWindow.xaml"
            ((AzerbaijanHeroesGallery.PropertyWindow)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 22 "..\..\PropertyWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nameTxtBlk = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.dateTxtBlk = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.mainImage = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.descriptionTxtb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.priceTxtb = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.prevBtn = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\PropertyWindow.xaml"
            this.prevBtn.Click += new System.Windows.RoutedEventHandler(this.prevBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.pauseBtn = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\PropertyWindow.xaml"
            this.pauseBtn.Click += new System.Windows.RoutedEventHandler(this.pauseBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.autoPlayBtn = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\PropertyWindow.xaml"
            this.autoPlayBtn.Click += new System.Windows.RoutedEventHandler(this.autoPlayBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.nextBtn = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\PropertyWindow.xaml"
            this.nextBtn.Click += new System.Windows.RoutedEventHandler(this.nextBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
