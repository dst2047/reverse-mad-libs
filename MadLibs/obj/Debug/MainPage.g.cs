﻿

#pragma checksum "C:\Users\d\Documents\Visual Studio 2012\Projects\MadLibs\MadLibs\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "34DE25EF385DE0CBA42D28B48D17BA52"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MadLibs
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 23 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyDown += this.TextBox_1_KeyDown;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 24 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.place_Adjective;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 25 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.place_Noun;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 26 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.place_Verb;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 27 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Clear_TextBox1;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 28 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Toggle_Visibility_About;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 45 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.copy_text_box_1;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 46 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Save_text_box_1_data;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


