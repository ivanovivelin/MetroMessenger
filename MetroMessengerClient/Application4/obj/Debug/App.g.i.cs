﻿

#pragma checksum "c:\users\mitko\documents\visual studio 11\Projects\Application4\Application4\App.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "663F8BA5CF2B59D1EF166C8C7C98E58C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace Application4
{
#if !DISABLE_XAML_GENERATED_MAIN
    public class Program
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        static void Main(string[] args)
        {
            Application.Start((p) => new App());
        }
    }
#endif

    public partial class App : Windows.UI.Xaml.Application
    {
        private bool _contentLoaded;

        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
#if DEBUG && !DISABLE_XAML_GENERATED_BREAK_ON_UNHANDLED_EXCEPTION
            UnhandledException += (sender, e) =>
            {
                if (Debugger.IsAttached) Debugger.Break();
            };
#endif
        }
    }
}

