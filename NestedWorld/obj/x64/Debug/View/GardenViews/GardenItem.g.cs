﻿#pragma checksum "E:\Git\nestedworld\NestedWorld\View\GardenViews\GardenItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A5F122F6AFF8185460B314CB4D448E18"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NestedWorld.View.GardenViews
{
    partial class GardenItem : 
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
                    global::Windows.UI.Xaml.Controls.Grid element1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 12 "..\..\..\..\View\GardenViews\GardenItem.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element1).Tapped += this.Grid_Tapped;
                    #line 12 "..\..\..\..\View\GardenViews\GardenItem.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element1).Holding += this.Grid_Holding;
                    #line 12 "..\..\..\..\View\GardenViews\GardenItem.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element1).RightTapped += this.Grid_RightTapped;
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

