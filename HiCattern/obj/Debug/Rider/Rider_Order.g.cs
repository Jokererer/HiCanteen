﻿#pragma checksum "..\..\..\Rider\Rider_Order.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DD4AF5717F5CF93799D432C50A7320E5B8E71C157151D150646ECFF5DB1D9328"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using HiCattern.Rider;
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


namespace HiCattern.Rider {
    
    
    /// <summary>
    /// Rider_Order
    /// </summary>
    public partial class Rider_Order : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 21 "..\..\..\Rider\Rider_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg1;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Rider\Rider_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg2;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Rider\Rider_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg3;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Rider\Rider_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_refresh;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Rider\Rider_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_updateInfo;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Rider\Rider_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_returnLogin;
        
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
            System.Uri resourceLocater = new System.Uri("/HiCattern;component/rider/rider_order.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Rider\Rider_Order.xaml"
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
            
            #line 14 "..\..\..\Rider\Rider_Order.xaml"
            ((System.Windows.Controls.TabItem)(target)).Loaded += new System.Windows.RoutedEventHandler(this.loadOrders);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dg1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            
            #line 43 "..\..\..\Rider\Rider_Order.xaml"
            ((System.Windows.Controls.TabItem)(target)).Loaded += new System.Windows.RoutedEventHandler(this.deliveryOrder);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dg2 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            
            #line 71 "..\..\..\Rider\Rider_Order.xaml"
            ((System.Windows.Controls.TabItem)(target)).Loaded += new System.Windows.RoutedEventHandler(this.historyOrders);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dg3 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.btn_refresh = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\Rider\Rider_Order.xaml"
            this.btn_refresh.Click += new System.Windows.RoutedEventHandler(this.btn_refresh_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_updateInfo = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\Rider\Rider_Order.xaml"
            this.btn_updateInfo.Click += new System.Windows.RoutedEventHandler(this.btn_updateInfo_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_returnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\Rider\Rider_Order.xaml"
            this.btn_returnLogin.Click += new System.Windows.RoutedEventHandler(this.btn_returnLogin_Click);
            
            #line default
            #line hidden
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
            case 3:
            
            #line 34 "..\..\..\Rider\Rider_Order.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_takeOrder);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 62 "..\..\..\Rider\Rider_Order.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_FinOrder);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

