﻿#pragma checksum "E:\Git\nestedworld\NestedWorld\View\ShopView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "929532346872BB09E94CD8AC48AE07B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NestedWorld.View
{
    partial class ShopView : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.groupedItemsViewSource = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 2:
                {
                    this.itemGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 32 "..\..\..\View\ShopView.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.itemGridView).ItemClick += this.itemGridView_ItemClick;
                    #line default
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 58 "..\..\..\View\ShopView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.Button_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

