﻿#pragma checksum "E:\Project\GitHub\Windows10\NestedWorld\Pages\PrepareBattlePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "80E9D42ECDDA8B87A5F7E17267C61AFA"
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
    partial class PrepareBattlePage : 
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
                    this.Show = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 2:
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.grid2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.profileEntrance = (global::NestedWorld.View.PrepareBattleView.UsersProfileEntrance)(target);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 57 "..\..\..\Pages\PrepareBattlePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.OK_click;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 60 "..\..\..\Pages\PrepareBattlePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.Reset_click;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 63 "..\..\..\Pages\PrepareBattlePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.Cancel_click;
                    #line default
                }
                break;
            case 8:
                {
                    this.userMonsterListView = (global::NestedWorld.View.PrepareBattleView.UserMonsterListView)(target);
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

