﻿#pragma checksum "E:\GitStore\newsellinggas\s2\s2\Pages\民用营业厅发卡售气.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "44B6F92EE388B6E00362D2A83A17EA14"
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
    
    
    public partial class 民用营业厅发卡售气 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.GeneralObject fakafei;
        
        internal Com.Aote.ObjectTools.ObjectList invoicelist;
        
        internal Com.Aote.ObjectTools.GeneralObject gsxiangou;
        
        internal Com.Aote.ObjectTools.ObjectList payfeetypelist;
        
        internal Com.Aote.ObjectTools.ObjectList paylist;
        
        internal Com.Aote.ObjectTools.ChildWindowObj openkafei;
        
        internal Com.Aote.ObjectTools.ChildWindowObj openxiangou;
        
        internal Com.Aote.ObjectTools.GeneralObject hunhes;
        
        internal Com.Aote.ObjectTools.GeneralObject userfiles1;
        
        internal Com.Aote.ObjectTools.GeneralObject sellgasobj;
        
        internal Com.Aote.ObjectTools.GeneralObject userfilego;
        
        internal Com.Aote.ObjectTools.GeneralObject cardid1;
        
        internal Com.Aote.ObjectTools.NewGeneralICCard card;
        
        internal Com.Aote.Behaviors.HQLAction UpdateFaka;
        
        internal Com.Aote.Behaviors.HQLAction UpdateSellgas;
        
        internal Com.Aote.Behaviors.HQLAction UpdateUserfile;
        
        internal Com.Aote.Behaviors.BatchExcuteAction RollbackAction;
        
        internal Com.Aote.Behaviors.BatchExcuteAction SaveAction;
        
        internal Com.Aote.Behaviors.HQLAction SubmitAction;
        
        internal System.Windows.Controls.DataPager pager;
        
        internal System.Windows.Controls.Grid userfilesearch;
        
        internal System.Windows.Controls.Button searchbutton;
        
        internal System.Windows.Controls.DataGrid userfiles;
        
        internal Com.Aote.ObjectTools.PagedObjectList userfileslist;
        
        internal System.Windows.Controls.Grid userfile;
        
        internal System.Windows.Controls.Button save;
        
        internal System.Windows.Controls.TextBox qbnumber;
        
        internal System.Windows.Controls.TextBox times;
        
        internal System.Windows.Controls.Grid guoshuiprint;
        
        internal Com.Aote.ObjectTools.GeneralObject fkprint;
        
        internal System.Windows.Controls.Grid aofengprint;
        
        internal Com.Aote.ObjectTools.GeneralObject fkprint1;
        
        internal System.Windows.Controls.Grid fazheprint;
        
        internal Com.Aote.ObjectTools.GeneralObject fzprint;
        
        internal Com.Aote.Controls.PrintObj print;
        
        internal Com.Aote.Controls.PrintObj print1;
        
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
                        "nent/Pages/%E6%B0%91%E7%94%A8%E8%90%A5%E4%B8%9A%E5%8E%85%E5%8F%91%E5%8D%A1%E5%94" +
                        "%AE%E6%B0%94.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.fakafei = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("fakafei")));
            this.invoicelist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("invoicelist")));
            this.gsxiangou = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("gsxiangou")));
            this.payfeetypelist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("payfeetypelist")));
            this.paylist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("paylist")));
            this.openkafei = ((Com.Aote.ObjectTools.ChildWindowObj)(this.FindName("openkafei")));
            this.openxiangou = ((Com.Aote.ObjectTools.ChildWindowObj)(this.FindName("openxiangou")));
            this.hunhes = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("hunhes")));
            this.userfiles1 = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("userfiles1")));
            this.sellgasobj = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("sellgasobj")));
            this.userfilego = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("userfilego")));
            this.cardid1 = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("cardid1")));
            this.card = ((Com.Aote.ObjectTools.NewGeneralICCard)(this.FindName("card")));
            this.UpdateFaka = ((Com.Aote.Behaviors.HQLAction)(this.FindName("UpdateFaka")));
            this.UpdateSellgas = ((Com.Aote.Behaviors.HQLAction)(this.FindName("UpdateSellgas")));
            this.UpdateUserfile = ((Com.Aote.Behaviors.HQLAction)(this.FindName("UpdateUserfile")));
            this.RollbackAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("RollbackAction")));
            this.SaveAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("SaveAction")));
            this.SubmitAction = ((Com.Aote.Behaviors.HQLAction)(this.FindName("SubmitAction")));
            this.pager = ((System.Windows.Controls.DataPager)(this.FindName("pager")));
            this.userfilesearch = ((System.Windows.Controls.Grid)(this.FindName("userfilesearch")));
            this.searchbutton = ((System.Windows.Controls.Button)(this.FindName("searchbutton")));
            this.userfiles = ((System.Windows.Controls.DataGrid)(this.FindName("userfiles")));
            this.userfileslist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("userfileslist")));
            this.userfile = ((System.Windows.Controls.Grid)(this.FindName("userfile")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
            this.qbnumber = ((System.Windows.Controls.TextBox)(this.FindName("qbnumber")));
            this.times = ((System.Windows.Controls.TextBox)(this.FindName("times")));
            this.guoshuiprint = ((System.Windows.Controls.Grid)(this.FindName("guoshuiprint")));
            this.fkprint = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("fkprint")));
            this.aofengprint = ((System.Windows.Controls.Grid)(this.FindName("aofengprint")));
            this.fkprint1 = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("fkprint1")));
            this.fazheprint = ((System.Windows.Controls.Grid)(this.FindName("fazheprint")));
            this.fzprint = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("fzprint")));
            this.print = ((Com.Aote.Controls.PrintObj)(this.FindName("print")));
            this.print1 = ((Com.Aote.Controls.PrintObj)(this.FindName("print1")));
        }
    }
}

