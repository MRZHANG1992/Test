﻿#pragma checksum "E:\NewWork\newsellinggas\s2\s2\Pages\安检地址管理.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C75BCBF724253D87416EBF9BBCA987AA"
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
    
    
    public partial class 安检地址管理 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.Behaviors.HQLAction DeleteAction;
        
        internal Com.Aote.Behaviors.BatchExcuteAction SaveAction;
        
        internal System.Windows.Controls.Grid applysearch;
        
        internal System.Windows.Controls.DataPager pager;
        
        internal System.Windows.Controls.DataGrid applys;
        
        internal Com.Aote.ObjectTools.PagedObjectList applyslist;
        
        internal System.Windows.Controls.Grid apply;
        
        internal Com.Aote.ObjectTools.GasADObject applygo;
        
        internal System.Windows.Controls.Button save;
        
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
                        "nent/Pages/%E5%AE%89%E6%A3%80%E5%9C%B0%E5%9D%80%E7%AE%A1%E7%90%86.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.DeleteAction = ((Com.Aote.Behaviors.HQLAction)(this.FindName("DeleteAction")));
            this.SaveAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("SaveAction")));
            this.applysearch = ((System.Windows.Controls.Grid)(this.FindName("applysearch")));
            this.pager = ((System.Windows.Controls.DataPager)(this.FindName("pager")));
            this.applys = ((System.Windows.Controls.DataGrid)(this.FindName("applys")));
            this.applyslist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("applyslist")));
            this.apply = ((System.Windows.Controls.Grid)(this.FindName("apply")));
            this.applygo = ((Com.Aote.ObjectTools.GasADObject)(this.FindName("applygo")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
        }
    }
}

