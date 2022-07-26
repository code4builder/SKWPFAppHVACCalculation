﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SKUWPFAppHVAC.View
{
    /// <summary>
    /// Interaction logic for Water.xaml
    /// </summary>
    public partial class WaterPage : Page
    {
        public WaterFlowPipe waterFlowPipe;
        public WaterPage()
        {
            InitializeComponent();
            waterFlowPipe = new WaterFlowPipe();
            WaterPageFrame1.Content = waterFlowPipe;
        }
    }
}
