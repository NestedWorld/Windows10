﻿#pragma checksum "E:\Project\GitHub\Windows10\NestedWorld\Pages\HomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7F6C8AEF4CD28AB21E7BE1785C265ECA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NestedWorld.Pages
{
    partial class HomePage : 
        global::Windows.UI.Xaml.Controls.Page, 
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
                    global::Windows.UI.Xaml.Controls.Pivot element1 = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                    #line 58 "..\..\..\Pages\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Pivot)element1).SelectionChanged += this.Pivot_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.popupView = (global::Windows.UI.Xaml.Controls.Primitives.Popup)(target);
                }
                break;
            case 3:
                {
                    this.ShopView = (global::NestedWorld.View.ShopView)(target);
                }
                break;
            case 4:
                {
                    this.monsterListView = (global::NestedWorld.View.MonsterListView)(target);
                }
                break;
            case 5:
                {
                    this.monsterFullView = (global::NestedWorld.View.MonsterViews.MonsterFullView)(target);
                }
                break;
            case 6:
                {
                    this.homeView = (global::NestedWorld.View.HomeView)(target);
                    #line 65 "..\..\..\Pages\HomePage.xaml"
                    ((global::NestedWorld.View.HomeView)this.homeView).Tapped += this.homeView_Tapped;
                    #line default
                }
                break;
            case 7:
                {
                    this.monsterView = (global::NestedWorld.View.MonsterView)(target);
                }
                break;
            case 8:
                {
                    this.userView = (global::NestedWorld.View.UserView)(target);
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element9 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 33 "..\..\..\Pages\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element9).Click += this.AppBarButton_Click_1;
                    #line default
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element10 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 40 "..\..\..\Pages\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element10).Click += this.AppBarButton_Click;
                    #line default
                }
                break;
            case 11:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element11 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 45 "..\..\..\Pages\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element11).Click += this.AppBarButton_Click_2;
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

