﻿#pragma checksum "E:\NewWork\newsellinggas\s2\s2\Pages\自动下账信息.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5E0BD2303EB94F5E84E0F4F4CB11BDFB"
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
    
    
    public partial class 自动下账信息 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.ExcelObj excel;
        
        internal Com.Aote.ObjectTools.ObjectList czylist;
        
        internal Com.Aote.ObjectTools.ObjectList gongsitypelist;
        
        internal Com.Aote.ObjectTools.ObjectList wangdianlist;
        
        internal Com.Aote.ObjectTools.ObjectList fgslist;
        
        internal Com.Aote.ObjectTools.GeneralObject zonggongsi;
        
        internal Com.Aote.ObjectTools.ObjectList youxiaolist;
        
        internal Com.Aote.ObjectTools.GeneralObject heji;
        
        internal System.Windows.Controls.Grid daninfosearch;
        
        internal System.Windows.Controls.TextBox tj1;
        
        internal System.Windows.Controls.TextBox tj7;
        
        internal System.Windows.Controls.ComboBox tjc2;
        
        internal System.Windows.Controls.Button dansearchbutton;
        
        internal System.Windows.Controls.DatePicker tj4;
        
        internal System.Windows.Controls.DatePicker tj8;
        
        internal System.Windows.Controls.ComboBox tjc1;
        
        internal System.Windows.Controls.ComboBox tjc4;
        
        internal System.Windows.Controls.ComboBox tjc5;
        
        internal System.Windows.Controls.ComboBox tjc3;
        
        internal System.Windows.Controls.DataPager pager2;
        
        internal System.Windows.Controls.DataGrid daninfos;
        
        internal Com.Aote.ObjectTools.PagedObjectList daninfoslist;
        
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
                        "nent/Pages/%E8%87%AA%E5%8A%A8%E4%B8%8B%E8%B4%A6%E4%BF%A1%E6%81%AF.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.excel = ((Com.Aote.ObjectTools.ExcelObj)(this.FindName("excel")));
            this.czylist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("czylist")));
            this.gongsitypelist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("gongsitypelist")));
            this.wangdianlist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("wangdianlist")));
            this.fgslist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("fgslist")));
            this.zonggongsi = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("zonggongsi")));
            this.youxiaolist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("youxiaolist")));
            this.heji = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("heji")));
            this.daninfosearch = ((System.Windows.Controls.Grid)(this.FindName("daninfosearch")));
            this.tj1 = ((System.Windows.Controls.TextBox)(this.FindName("tj1")));
            this.tj7 = ((System.Windows.Controls.TextBox)(this.FindName("tj7")));
            this.tjc2 = ((System.Windows.Controls.ComboBox)(this.FindName("tjc2")));
            this.dansearchbutton = ((System.Windows.Controls.Button)(this.FindName("dansearchbutton")));
            this.tj4 = ((System.Windows.Controls.DatePicker)(this.FindName("tj4")));
            this.tj8 = ((System.Windows.Controls.DatePicker)(this.FindName("tj8")));
            this.tjc1 = ((System.Windows.Controls.ComboBox)(this.FindName("tjc1")));
            this.tjc4 = ((System.Windows.Controls.ComboBox)(this.FindName("tjc4")));
            this.tjc5 = ((System.Windows.Controls.ComboBox)(this.FindName("tjc5")));
            this.tjc3 = ((System.Windows.Controls.ComboBox)(this.FindName("tjc3")));
            this.pager2 = ((System.Windows.Controls.DataPager)(this.FindName("pager2")));
            this.daninfos = ((System.Windows.Controls.DataGrid)(this.FindName("daninfos")));
            this.daninfoslist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("daninfoslist")));
        }
    }
}

