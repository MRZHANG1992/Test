﻿#pragma checksum "E:\NewWork\newsellinggas\s2\s2\Pages\街道管理.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D23F11FD5FB49F9680E109217787D937"
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


namespace s2 {
    
    
    public partial class 街道管理 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.GeneralObject roadexist;
        
        internal Com.Aote.ObjectTools.SeriaNumber roadid;
        
        internal Com.Aote.ObjectTools.GeneralObject zonggongsi;
        
        internal Com.Aote.Behaviors.HQLAction DeleteAction;
        
        internal Com.Aote.Behaviors.BatchExcuteAction SaveAction;
        
        internal System.Windows.Controls.DockPanel roadmanege;
        
        internal Com.Aote.ObjectTools.GeneralObject roadItem;
        
        internal System.Windows.Controls.Button save;
        
        internal System.Windows.Controls.Button save_Copy;
        
        internal System.Windows.Controls.Button delete;
        
        internal System.Windows.Controls.DataPager pager;
        
        internal System.Windows.Controls.Grid roadsearch;
        
        internal System.Windows.Controls.Button searchbutton;
        
        internal System.Windows.Controls.DataGrid roads;
        
        internal Com.Aote.ObjectTools.PagedObjectList roadlist;
        
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
                        "nent/Pages/%E8%A1%97%E9%81%93%E7%AE%A1%E7%90%86.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.roadexist = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("roadexist")));
            this.roadid = ((Com.Aote.ObjectTools.SeriaNumber)(this.FindName("roadid")));
            this.zonggongsi = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("zonggongsi")));
            this.DeleteAction = ((Com.Aote.Behaviors.HQLAction)(this.FindName("DeleteAction")));
            this.SaveAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("SaveAction")));
            this.roadmanege = ((System.Windows.Controls.DockPanel)(this.FindName("roadmanege")));
            this.roadItem = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("roadItem")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
            this.save_Copy = ((System.Windows.Controls.Button)(this.FindName("save_Copy")));
            this.delete = ((System.Windows.Controls.Button)(this.FindName("delete")));
            this.pager = ((System.Windows.Controls.DataPager)(this.FindName("pager")));
            this.roadsearch = ((System.Windows.Controls.Grid)(this.FindName("roadsearch")));
            this.searchbutton = ((System.Windows.Controls.Button)(this.FindName("searchbutton")));
            this.roads = ((System.Windows.Controls.DataGrid)(this.FindName("roads")));
            this.roadlist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("roadlist")));
        }
    }
}

