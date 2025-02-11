﻿using System;
using System.Collections.Generic;
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

namespace coursWPF.Controls
{
    /// <summary>
    /// Logique d'interaction pour SpecialButton.xaml
    /// </summary>
    public partial class SpecialButton : UserControl
    {
        public RoutedEventHandler Click { get; set; }
        public SpecialButton()
        {
            InitializeComponent();
            b.Click += Click;      
        }
    }
}
