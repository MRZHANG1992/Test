﻿#pragma checksum "E:\NewWork\newsellinggas\s2\s2\Pages\停气公告管理.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "324F6EA86F0EA7B7F9E1B197D3643A37"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
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
    
    
    public partial class 停气公告管理 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.Behaviors.HQLAction DeleteAction;
        
        internal Com.Aote.ObjectTools.ObjectList IsShow;
        
        internal System.Windows.Controls.StackPanel personsearch;
        
        internal System.Windows.Controls.Button searchbutton;
        
        internal System.Windows.Controls.DataGrid persons;
        
        internal Com.Aote.ObjectTools.ObjectList personslist;
        
        internal System.Windows.Controls.DockPanel main;
        
        internal Com.Aote.ObjectTools.GeneralObject persongo;
        
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
                        "nent/Pages/%E5%81%9C%E6%B0%94%E5%85%AC%E5%91%8A%E7%AE%A1%E7%90%86.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.DeleteAction = ((Com.Aote.Behaviors.HQLAction)(this.FindName("DeleteAction")));
            this.IsShow = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("IsShow")));
            this.personsearch = ((System.Windows.Controls.StackPanel)(this.FindName("personsearch")));
            this.searchbutton = ((System.Windows.Controls.Button)(this.FindName("searchbutton")));
            this.persons = ((System.Windows.Controls.DataGrid)(this.FindName("persons")));
            this.personslist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("personslist")));
            this.main = ((System.Windows.Controls.DockPanel)(this.FindName("main")));
            this.persongo = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("persongo")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
        }
    }
}

