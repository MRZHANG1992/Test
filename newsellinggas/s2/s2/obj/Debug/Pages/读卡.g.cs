﻿#pragma checksum "E:\NewWork\newsellinggas\s2\s2\Pages\读卡.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7410258B0CDE1243845BA2BF6284CE18"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Com.Aote.ObjectTools;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Com.Aote.Pages {
    
    
    public partial class 读卡 : System.Windows.Controls.UserControl {
        
        internal Com.Aote.ObjectTools.NewGeneralICCard card;
        
        internal Com.Aote.ObjectTools.GeneralObject userfiles;
        
        internal System.Windows.Controls.Grid userfile1;
        
        internal System.Windows.Controls.Button readcard;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/%E5%A5%A5%E6%9E%AB%E7%87%83%E6%B0%94%E8%90%A5%E6%94%B6%E7%B3%BB%E7%BB%9FV3;compo" +
                        "nent/Pages/%E8%AF%BB%E5%8D%A1.xaml", System.UriKind.Relative));
            this.card = ((Com.Aote.ObjectTools.NewGeneralICCard)(this.FindName("card")));
            this.userfiles = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("userfiles")));
            this.userfile1 = ((System.Windows.Controls.Grid)(this.FindName("userfile1")));
            this.readcard = ((System.Windows.Controls.Button)(this.FindName("readcard")));
        }
    }
}

