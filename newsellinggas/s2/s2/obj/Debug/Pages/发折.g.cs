﻿#pragma checksum "E:\GitStore\newsellinggas\s2\s2\Pages\发折.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7F84E6C660339CE65984BFEFDD276F71"
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
    
    
    public partial class 发折 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.Behaviors.HQLAction DeleteAction;
        
        internal Com.Aote.Behaviors.HQLAction SubmitAction;
        
        internal Com.Aote.ObjectTools.GeneralObject users;
        
        internal Com.Aote.Behaviors.BatchExcuteAction SaveAction;
        
        internal System.Windows.Controls.DockPanel userfilesearch;
        
        internal System.Windows.Controls.Button searchbutton;
        
        internal System.Windows.Controls.DataGrid userfiles;
        
        internal Com.Aote.ObjectTools.PagedObjectList userfileslist;
        
        internal System.Windows.Controls.Grid userfile;
        
        internal Com.Aote.ObjectTools.GeneralObject userfilego;
        
        internal System.Windows.Controls.Button save;
        
        internal System.Windows.Controls.DataPager pager;
        
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
                        "nent/Pages/%E5%8F%91%E6%8A%98.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.DeleteAction = ((Com.Aote.Behaviors.HQLAction)(this.FindName("DeleteAction")));
            this.SubmitAction = ((Com.Aote.Behaviors.HQLAction)(this.FindName("SubmitAction")));
            this.users = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("users")));
            this.SaveAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("SaveAction")));
            this.userfilesearch = ((System.Windows.Controls.DockPanel)(this.FindName("userfilesearch")));
            this.searchbutton = ((System.Windows.Controls.Button)(this.FindName("searchbutton")));
            this.userfiles = ((System.Windows.Controls.DataGrid)(this.FindName("userfiles")));
            this.userfileslist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("userfileslist")));
            this.userfile = ((System.Windows.Controls.Grid)(this.FindName("userfile")));
            this.userfilego = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("userfilego")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
            this.pager = ((System.Windows.Controls.DataPager)(this.FindName("pager")));
        }
    }
}

