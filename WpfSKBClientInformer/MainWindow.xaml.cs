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
using System.Threading;
using ShevarvProject.SKBClientInformerDataBaseNamespace;

namespace WpfSKBClientInformer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        
            InitializeComponent();
            
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            ProgBar.IsIndeterminate = true;
            SqlExpression sq = new SqlExpression();
            await sq.SelectData("", "", "", "");
            CbUserGrid.ItemsSource = sq.Dt.DefaultView;
            ProgBar.IsIndeterminate = false;
        }

        private void CbUserGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
