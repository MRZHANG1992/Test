﻿#pragma checksum "E:\NewWork\newsellinggas\s2\s2\Pages\非民用抄表任务删除.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E202EC90387189016C6C0BBC8682302A"
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
using Com.Aote.Controls;
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
    
    
    public partial class 非民用抄表任务删除 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.Behaviors.BatchExcuteAction DeleteAction;
        
        internal Com.Aote.Behaviors.HQLAction Deleteinput;
        
        internal Com.Aote.Behaviors.HQLAction Deleteinputlist;
        
        internal Com.Aote.ObjectTools.ExcelObj excel;
        
        internal Com.Aote.ObjectTools.ObjectList fgslist;
        
        internal Com.Aote.ObjectTools.GeneralObject zonggongsi;
        
        internal Com.Aote.ObjectTools.ObjectList input;
        
        internal Com.Aote.ObjectTools.PagedObjectList inputlist;
        
        internal System.Windows.Controls.Grid daninfosearch;
        
        internal System.Windows.Controls.Button dansearchbutton;
        
        internal System.Windows.Controls.ComboBox Comboxfx;
        
        internal System.Windows.Controls.TextBox biaoti;
        
        internal System.Windows.Controls.Button deletebutton;
        
        internal System.Windows.Controls.DataGrid inputtj;
        
        internal System.Windows.Controls.DataPager pager2;
        
        internal System.Windows.Controls.DataGrid daninfos;
        
        internal Com.Aote.Controls.MessageTipObj deletettip;
        
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
                        "nent/Pages/%E9%9D%9E%E6%B0%91%E7%94%A8%E6%8A%84%E8%A1%A8%E4%BB%BB%E5%8A%A1%E5%88" +
                        "%A0%E9%99%A4.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.DeleteAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("DeleteAction")));
            this.Deleteinput = ((Com.Aote.Behaviors.HQLAction)(this.FindName("Deleteinput")));
            this.Deleteinputlist = ((Com.Aote.Behaviors.HQLAction)(this.FindName("Deleteinputlist")));
            this.excel = ((Com.Aote.ObjectTools.ExcelObj)(this.FindName("excel")));
            this.fgslist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("fgslist")));
            this.zonggongsi = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("zonggongsi")));
            this.input = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("input")));
            this.inputlist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("inputlist")));
            this.daninfosearch = ((System.Windows.Controls.Grid)(this.FindName("daninfosearch")));
            this.dansearchbutton = ((System.Windows.Controls.Button)(this.FindName("dansearchbutton")));
            this.Comboxfx = ((System.Windows.Controls.ComboBox)(this.FindName("Comboxfx")));
            this.biaoti = ((System.Windows.Controls.TextBox)(this.FindName("biaoti")));
            this.deletebutton = ((System.Windows.Controls.Button)(this.FindName("deletebutton")));
            this.inputtj = ((System.Windows.Controls.DataGrid)(this.FindName("inputtj")));
            this.pager2 = ((System.Windows.Controls.DataPager)(this.FindName("pager2")));
            this.daninfos = ((System.Windows.Controls.DataGrid)(this.FindName("daninfos")));
            this.deletettip = ((Com.Aote.Controls.MessageTipObj)(this.FindName("deletettip")));
        }
    }
}

