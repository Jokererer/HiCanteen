// Updated by XamlIntelliSenseFileGenerator 2020/12/12 20:27:29
#pragma checksum "..\..\..\Customer\Canteen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E2F0E90C65283DDBAD8FF4B77F1EF0CBC7F148694D0E7EB702C92E69A407CA02"
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


namespace HiCattern.Customer
{


    /// <summary>
    /// Canteen
    /// </summary>
    public partial class Canteen : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 19 "..\..\..\Customer\Canteen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_return;

#line default
#line hidden


#line 20 "..\..\..\Customer\Canteen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_viewOrder;

#line default
#line hidden


#line 21 "..\..\..\Customer\Canteen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_changePasswd;

#line default
#line hidden


#line 22 "..\..\..\Customer\Canteen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Message;

#line default
#line hidden


#line 26 "..\..\..\Customer\Canteen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox catternList;

#line default
#line hidden


#line 28 "..\..\..\Customer\Canteen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button canteen4;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HiCattern;component/customer/canteen.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Customer\Canteen.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.btn_return = ((System.Windows.Controls.Button)(target));

#line 19 "..\..\..\Customer\Canteen.xaml"
                    this.btn_return.Click += new System.Windows.RoutedEventHandler(this.btn_return_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.btn_viewOrder = ((System.Windows.Controls.Button)(target));

#line 20 "..\..\..\Customer\Canteen.xaml"
                    this.btn_viewOrder.Click += new System.Windows.RoutedEventHandler(this.btn_viewOrder_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.btn_changePasswd = ((System.Windows.Controls.Button)(target));

#line 21 "..\..\..\Customer\Canteen.xaml"
                    this.btn_changePasswd.Click += new System.Windows.RoutedEventHandler(this.btn_changePasswd_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.btn_Message = ((System.Windows.Controls.Button)(target));

#line 22 "..\..\..\Customer\Canteen.xaml"
                    this.btn_Message.Click += new System.Windows.RoutedEventHandler(this.btn_Message_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.catternList = ((System.Windows.Controls.ListBox)(target));
                    return;
                case 6:
                    this.canteen4 = ((System.Windows.Controls.Button)(target));

#line 28 "..\..\..\Customer\Canteen.xaml"
                    this.canteen4.Click += new System.Windows.RoutedEventHandler(this.canteen4_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button canteen5;
        internal System.Windows.Controls.Button canteen8;
        internal System.Windows.Controls.Button canteen10;
    }
}

