﻿#pragma checksum "..\..\..\MerchantAdmin\增加商家.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC8C06E1E76AFE16380C99940863595AC7AC82F2071D21A9123561789106F426"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Hi_食堂.MerchantAdmin;
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


namespace Hi_食堂.MerchantAdmin {
    
    
    /// <summary>
    /// 增加商家
    /// </summary>
    public partial class 增加商家 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\MerchantAdmin\增加商家.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combox_Canteen;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\MerchantAdmin\增加商家.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_MerName;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MerchantAdmin\增加商家.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_MerPh;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MerchantAdmin\增加商家.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk_AddMer;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MerchantAdmin\增加商家.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel_AddMer;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MerchantAdmin\增加商家.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_MerPwd;
        
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
            System.Uri resourceLocater = new System.Uri("/HiCattern;component/merchantadmin/%e5%a2%9e%e5%8a%a0%e5%95%86%e5%ae%b6.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MerchantAdmin\增加商家.xaml"
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
            this.combox_Canteen = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.txt_MerName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_MerPh = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnOk_AddMer = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\MerchantAdmin\增加商家.xaml"
            this.btnOk_AddMer.Click += new System.Windows.RoutedEventHandler(this.btnOk_AddMer_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCancel_AddMer = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\MerchantAdmin\增加商家.xaml"
            this.btnCancel_AddMer.Click += new System.Windows.RoutedEventHandler(this.btnCancel_AddMer_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt_MerPwd = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

