﻿#pragma checksum "E:\GitStore\newsellinggas\s2\s2\Pages\发票分配.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EE2295C936EF9402D59B20992A66FF97"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Com.Aote.Behaviors;
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
    
    
    public partial class 发票分配 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.ObjectList fgslist;
        
        internal Com.Aote.ObjectTools.ObjectList usertypelist;
        
        internal Com.Aote.ObjectTools.GeneralObject zonggongsi;
        
        internal Com.Aote.ObjectTools.GeneralObject fenpei;
        
        internal Com.Aote.Behaviors.HQLAction InsertInvoice;
        
        internal Com.Aote.Behaviors.BatchExcuteAction SaveAction;
        
        internal Com.Aote.Behaviors.BatchExcuteAction CreateInvoices;
        
        internal System.Windows.Controls.Grid daninfosearch;
        
        internal System.Windows.Controls.Button dansearchbutton;
        
        internal System.Windows.Controls.TextBox yueshu;
        
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
                        "nent/Pages/%E5%8F%91%E7%A5%A8%E5%88%86%E9%85%8D.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.fgslist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("fgslist")));
            this.usertypelist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("usertypelist")));
            this.zonggongsi = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("zonggongsi")));
            this.fenpei = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("fenpei")));
            this.InsertInvoice = ((Com.Aote.Behaviors.HQLAction)(this.FindName("InsertInvoice")));
            this.SaveAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("SaveAction")));
            this.CreateInvoices = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("CreateInvoices")));
            this.daninfosearch = ((System.Windows.Controls.Grid)(this.FindName("daninfosearch")));
            this.dansearchbutton = ((System.Windows.Controls.Button)(this.FindName("dansearchbutton")));
            this.yueshu = ((System.Windows.Controls.TextBox)(this.FindName("yueshu")));
        }
    }
}

