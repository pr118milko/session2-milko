﻿#pragma checksum "..\..\..\Views\ProductsListPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47F9A726B69A5384A0F227ABDCE89C9D19BA77B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Session2.Views;
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


namespace Session2.Views {
    
    
    /// <summary>
    /// ProductsListPage
    /// </summary>
    public partial class ProductsListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Views\ProductsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\ProductsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboSort;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\ProductsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboProductsTypes;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Views\ProductsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView productsList;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\Views\ProductsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel paginator;
        
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
            System.Uri resourceLocater = new System.Uri("/Session2;component/views/productslistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ProductsListPage.xaml"
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
            this.search = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\Views\ProductsListPage.xaml"
            this.search.KeyUp += new System.Windows.Input.KeyEventHandler(this.Search_KeyUp);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\Views\ProductsListPage.xaml"
            this.search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\..\Views\ProductsListPage.xaml"
            this.ComboSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ComboProductsTypes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 53 "..\..\..\Views\ProductsListPage.xaml"
            this.ComboProductsTypes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboProductsTypes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.productsList = ((System.Windows.Controls.ListView)(target));
            
            #line 65 "..\..\..\Views\ProductsListPage.xaml"
            this.productsList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ProductsList_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.paginator = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            
            #line 188 "..\..\..\Views\ProductsListPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

