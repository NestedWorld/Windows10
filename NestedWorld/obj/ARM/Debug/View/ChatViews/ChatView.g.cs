﻿#pragma checksum "E:\Git\nestedworld\NestedWorld\View\ChatViews\ChatView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "00D12684CA4B2D9AB3350E3F88A26577"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NestedWorld.View.ChatViews
{
    partial class ChatView : 
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
                    this.ShowInfo = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.TextBox element2 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 59 "..\..\..\..\View\ChatViews\ChatView.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)element2).KeyDown += this.TextBox_KeyDown;
                    #line default
                }
                break;
            case 3:
                {
                    this.chatList = (global::Windows.UI.Xaml.Controls.ItemsControl)(target);
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

