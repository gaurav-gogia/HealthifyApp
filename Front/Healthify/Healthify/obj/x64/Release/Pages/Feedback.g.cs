﻿#pragma checksum "C:\Users\Desmond\Documents\Visual Studio 2017\Projects\UWP Native\Healthify\Healthify\Pages\Feedback.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0943397C84DFEF8026BDCC0D82AB0178"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Healthify.Pages
{
    partial class Feedback : 
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
                    this.splitHam = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.feedbox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.feedbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4:
                {
                    this.listHam = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 35 "..\..\..\Pages\Feedback.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.listHam).SelectionChanged += this.listHam_SelectionChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.homeListItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6:
                {
                    this.medicalHistoryListItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 7:
                {
                    this.bloodListItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 8:
                {
                    this.suggestionsListItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 9:
                {
                    this.SponsorsListItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 10:
                {
                    this.feedListItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 11:
                {
                    this.bBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.xBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.aBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.cBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.eBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.pBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.HamBut = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\Pages\Feedback.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamBut).Click += this.HamBut_Click;
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

