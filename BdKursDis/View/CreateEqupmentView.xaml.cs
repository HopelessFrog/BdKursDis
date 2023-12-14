﻿using BdKursDis.ViewModels.Interfaces;
using System;
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
using System.Windows.Shapes;

namespace BdKursDis.View
{
    /// <summary>
    /// Interaction logic for CreateEqupmentView.xaml
    /// </summary>
    public partial class CreateEqupmentView : Window
    {
        public CreateEqupmentView()
        {
            InitializeComponent();
            Loaded += CreateEqupmentView_Loaded;
        }

        private void CreateEqupmentView_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is ICloseWindow viewModel)
            {
                viewModel.Close +=
                    () => { this.Close(); };

                Closing += (s, e) => { e.Cancel = !viewModel.CanClose(); };
            }
        }
    }
}