﻿#pragma checksum "E:\NewWork\newsellinggas\s2\s2\Pages\民用抄表核查下账.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "81695FDED735B251B615F3B6E482D0B9"
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
    
    
    public partial class 民用抄表核查下账 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.ObjectList usertypelist;
        
        internal Com.Aote.ObjectTools.ExcelObj excel;
        
        internal Com.Aote.ObjectTools.ObjectList fgslist;
        
        internal Com.Aote.ObjectTools.GeneralObject zonggongsi;
        
        internal Com.Aote.ObjectTools.PagedObjectList jichalist;
        
        internal Com.Aote.ObjectTools.PagedObjectList handplanlist;
        
        internal Com.Aote.Behaviors.PageAction trans;
        
        internal Com.Aote.ObjectTools.PagedObjectList handplanlist2;
        
        internal Com.Aote.ObjectTools.ObjectList sellgaslist2;
        
        internal Com.Aote.ObjectTools.GeneralObject sourceObj2;
        
        internal Com.Aote.ObjectTools.GeneralObject toObj2;
        
        internal Com.Aote.Behaviors.BatchExcuteAction SaveAction;
        
        internal System.Windows.Controls.Grid daninfosearch;
        
        internal System.Windows.Controls.Button dansearchbutton;
        
        internal System.Windows.Controls.ComboBox usertype;
        
        internal System.Windows.Controls.DockPanel jiezhi;
        
        internal System.Windows.Controls.DataPager pager2;
        
        internal System.Windows.Controls.DatePicker tj4;
        
        internal System.Windows.Controls.Button xiaButton;
        
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
                        "nent/Pages/%E6%B0%91%E7%94%A8%E6%8A%84%E8%A1%A8%E6%A0%B8%E6%9F%A5%E4%B8%8B%E8%B4" +
                        "%A6.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.usertypelist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("usertypelist")));
            this.excel = ((Com.Aote.ObjectTools.ExcelObj)(this.FindName("excel")));
            this.fgslist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("fgslist")));
            this.zonggongsi = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("zonggongsi")));
            this.jichalist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("jichalist")));
            this.handplanlist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("handplanlist")));
            this.trans = ((Com.Aote.Behaviors.PageAction)(this.FindName("trans")));
            this.handplanlist2 = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("handplanlist2")));
            this.sellgaslist2 = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("sellgaslist2")));
            this.sourceObj2 = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("sourceObj2")));
            this.toObj2 = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("toObj2")));
            this.SaveAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("SaveAction")));
            this.daninfosearch = ((System.Windows.Controls.Grid)(this.FindName("daninfosearch")));
            this.dansearchbutton = ((System.Windows.Controls.Button)(this.FindName("dansearchbutton")));
            this.usertype = ((System.Windows.Controls.ComboBox)(this.FindName("usertype")));
            this.jiezhi = ((System.Windows.Controls.DockPanel)(this.FindName("jiezhi")));
            this.pager2 = ((System.Windows.Controls.DataPager)(this.FindName("pager2")));
            this.tj4 = ((System.Windows.Controls.DatePicker)(this.FindName("tj4")));
            this.xiaButton = ((System.Windows.Controls.Button)(this.FindName("xiaButton")));
            this.daninfos = ((System.Windows.Controls.DataGrid)(this.FindName("daninfos")));
            this.deletettip = ((Com.Aote.Controls.MessageTipObj)(this.FindName("deletettip")));
        }
    }
}

