﻿#pragma checksum "E:\Git\nestedworld\NestedWorld\PopUp\RegisterPopUp.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "08EB7E0D07AA0E6683FD15EEBACA922D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NestedWorld.PopUp
{
    partial class RegisterPopUp : 
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
                    this.userControl = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                }
                break;
            case 2:
                {
                    this.ShowAnnimation = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 3:
                {
                    this.ErrorAnnimation = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 4:
                {
                    this.RemoveAnnimation = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 5:
                {
                    this.UserImage = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 6:
                {
                    this.FacebookButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 77 "..\..\..\PopUp\RegisterPopUp.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.FacebookButton).Click += this.FacebookButton_Click;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element7 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 116 "..\..\..\PopUp\RegisterPopUp.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element7).Click += this.backButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element8 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 123 "..\..\..\PopUp\RegisterPopUp.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element8).Click += this.OkButton_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.ErrorTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.passTwoEntry = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 11:
                {
                    this.passOneEntry = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 12:
                {
                    this.mailEntry = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    this.lastnameEntry = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14:
                {
                    this.firstnameEntry = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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

