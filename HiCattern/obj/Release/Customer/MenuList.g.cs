﻿#pragma checksum "..\..\..\Customer\MenuList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "500006CCA41B4EFB40599434AFBB7B399DFBC32B6B3F9FBDCE2C3232A92815FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using HiCattern.Customer;
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


namespace HiCattern.Customer {
    
    
    /// <summary>
    /// MenuList
    /// </summary>
    public partial class MenuList : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 20 "..\..\..\Customer\MenuList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ok;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Customer\MenuList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_shoppingCart;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Customer\MenuList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_return;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Customer\MenuList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_viewOrder;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Customer\MenuList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_customMssage;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Customer\MenuList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView merchantList;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Customer\MenuList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView dishes;
        
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
            System.Uri resourceLocater = new System.Uri("/HiCattern;component/customer/menulist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Customer\MenuList.xaml"
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
            this.btn_ok = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Customer\MenuList.xaml"
            this.btn_ok.Click += new System.Windows.RoutedEventHandler(this.btn_ok_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_shoppingCart = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Customer\MenuList.xaml"
            this.btn_shoppingCart.Click += new System.Windows.RoutedEventHandler(this.btn_shoppingCart_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bt_return = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Customer\MenuList.xaml"
            this.bt_return.Click += new System.Windows.RoutedEventHandler(this.bt_return_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_viewOrder = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Customer\MenuList.xaml"
            this.btn_viewOrder.Click += new System.Windows.RoutedEventHandler(this.btn_viewOrder_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_customMssage = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Customer\MenuList.xaml"
            this.btn_customMssage.Click += new System.Windows.RoutedEventHandler(this.btn_customMssage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.merchantList = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.dishes = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 44 "..\..\..\Customer\MenuList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.bt1_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

