﻿#pragma checksum "C:\Users\devon\Desktop\BMI_exercise\BMI_exercise\MetricPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "08BCFBA5C3381FA96A3109827489E155"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BMI_exercise
{
    partial class MetricPage : 
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
                    this.Units = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 2:
                {
                    this.MetricImput = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 3:
                {
                    this.CommandButtons = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 4:
                {
                    this.btnCalc = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 37 "..\..\..\MetricPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCalc).Click += this.btnCalcWH_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btnClear = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 38 "..\..\..\MetricPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnClear).Click += this.btnClear_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.lblBMIValue = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.lblBMIClassification = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.lblHeight = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.lblWeight = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.txtHeight = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11:
                {
                    this.txtWeight = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12:
                {
                    this.lblTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.lblUnits = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

