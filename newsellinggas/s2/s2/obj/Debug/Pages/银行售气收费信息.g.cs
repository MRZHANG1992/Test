﻿#pragma checksum "E:\NewWork\newsellinggas\s2\s2\Pages\银行售气收费信息.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3EB110BA4C34222BF6ABC1B3CACC4415"
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
    
    
    public partial class 银行售气收费信息 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.ExcelObj excel;
        
        internal Com.Aote.ObjectTools.ObjectList fukuanfangshi;
        
        internal Com.Aote.ObjectTools.ObjectList czylist;
        
        internal Com.Aote.ObjectTools.ObjectList wangdianlist;
        
        internal Com.Aote.ObjectTools.ObjectList fgslist;
        
        internal Com.Aote.ObjectTools.ObjectList usertypelist;
        
        internal Com.Aote.ObjectTools.GeneralObject zonggongsi;
        
        internal Com.Aote.ObjectTools.ObjectList qblist;
        
        internal Com.Aote.ObjectTools.ObjectList qjlist;
        
        internal Com.Aote.ObjectTools.ObjectList payfeetypelist;
        
        internal Com.Aote.ObjectTools.ObjectList youxiaolist;
        
        internal System.Windows.Controls.Grid daninfosearch;
        
        internal System.Windows.Controls.TextBox tj1;
        
        internal System.Windows.Controls.TextBox tj2;
        
        internal System.Windows.Controls.TextBox tj7;
        
        internal System.Windows.Controls.ComboBox tj9;
        
        internal System.Windows.Controls.Button dansearchbutton;
        
        internal System.Windows.Controls.ComboBox tj5;
        
        internal System.Windows.Controls.ComboBox tj6;
        
        internal System.Windows.Controls.DatePicker tj4;
        
        internal System.Windows.Controls.DatePicker tj8;
        
        internal System.Windows.Controls.ComboBox tja;
        
        internal System.Windows.Controls.ComboBox tjb;
        
        internal System.Windows.Controls.ComboBox tjc;
        
        internal System.Windows.Controls.ComboBox tjwangdian;
        
        internal System.Windows.Controls.ComboBox tjczy;
        
        internal System.Windows.Controls.TextBox tjwhf;
        
        internal System.Windows.Controls.ComboBox tjc_Copy;
        
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
                        "nent/Pages/%E9%93%B6%E8%A1%8C%E5%94%AE%E6%B0%94%E6%94%B6%E8%B4%B9%E4%BF%A1%E6%81" +
                        "%AF.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.excel = ((Com.Aote.ObjectTools.ExcelObj)(this.FindName("excel")));
            this.fukuanfangshi = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("fukuanfangshi")));
            this.czylist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("czylist")));
            this.wangdianlist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("wangdianlist")));
            this.fgslist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("fgslist")));
            this.usertypelist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("usertypelist")));
            this.zonggongsi = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("zonggongsi")));
            this.qblist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("qblist")));
            this.qjlist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("qjlist")));
            this.payfeetypelist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("payfeetypelist")));
            this.youxiaolist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("youxiaolist")));
            this.daninfosearch = ((System.Windows.Controls.Grid)(this.FindName("daninfosearch")));
            this.tj1 = ((System.Windows.Controls.TextBox)(this.FindName("tj1")));
            this.tj2 = ((System.Windows.Controls.TextBox)(this.FindName("tj2")));
            this.tj7 = ((System.Windows.Controls.TextBox)(this.FindName("tj7")));
            this.tj9 = ((System.Windows.Controls.ComboBox)(this.FindName("tj9")));
            this.dansearchbutton = ((System.Windows.Controls.Button)(this.FindName("dansearchbutton")));
            this.tj5 = ((System.Windows.Controls.ComboBox)(this.FindName("tj5")));
            this.tj6 = ((System.Windows.Controls.ComboBox)(this.FindName("tj6")));
            this.tj4 = ((System.Windows.Controls.DatePicker)(this.FindName("tj4")));
            this.tj8 = ((System.Windows.Controls.DatePicker)(this.FindName("tj8")));
            this.tja = ((System.Windows.Controls.ComboBox)(this.FindName("tja")));
            this.tjb = ((System.Windows.Controls.ComboBox)(this.FindName("tjb")));
            this.tjc = ((System.Windows.Controls.ComboBox)(this.FindName("tjc")));
            this.tjwangdian = ((System.Windows.Controls.ComboBox)(this.FindName("tjwangdian")));
            this.tjczy = ((System.Windows.Controls.ComboBox)(this.FindName("tjczy")));
            this.tjwhf = ((System.Windows.Controls.TextBox)(this.FindName("tjwhf")));
            this.tjc_Copy = ((System.Windows.Controls.ComboBox)(this.FindName("tjc_Copy")));
            this.pager2 = ((System.Windows.Controls.DataPager)(this.FindName("pager2")));
            this.daninfos = ((System.Windows.Controls.DataGrid)(this.FindName("daninfos")));
            this.daninfoslist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("daninfoslist")));
        }
    }
}

