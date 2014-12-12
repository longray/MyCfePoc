﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CfePocApp.Examples
{
    using CfePocApp.ViewModel;

    using GalaSoft.MvvmLight.Ioc;

    using ModernUI;

    /// <summary>
    /// Buttons.xaml 的交互逻辑
    /// </summary>
    public partial class ModernDataGrid : UserControl
    {
        public ModernDataGrid()
        {
            InitializeComponent();
            this.RegisterResources();
        }

        private void RegisterResources()
        {
            //GlobleResources.ResourceDictionary = this.Resources;
        }
    }
}
