using System.Windows;
using System.Windows.Input;
using ShevarvProject.SKBClientInformerDataBaseNamespace;
using Microsoft.Win32;
using System.IO;
using System;
using System.Data;


namespace WpfSKBClientInformer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string id = "";
        private string EDRPOU = "";
        private string clName = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            ProgBar.IsIndeterminate = true;
            SqlExpression sq = new SqlExpression();
            if ((bool)IdLabel.IsChecked)
            {
                id = ClientID.Text;
            }
            if ((bool)EDRPOULabel.IsChecked)
            {
                EDRPOU = ClientEDRPOU.Text;
            }
            if ((bool)NameLabel.IsChecked)
            {
                clName = ClientName.Text;
            }
            await sq.SelectData(id,clName,EDRPOU,"");
            CbUserGrid.ItemsSource = sq.Dt.DefaultView;
            ProgBar.IsIndeterminate = false;
        }

        private void IdLabel_Checked(object sender, RoutedEventArgs e)
        {
            ClientID.IsEnabled = true;
        }

        private void IdLabel_Unchecked(object sender, RoutedEventArgs e)
        {
            ClientID.IsEnabled = false;
            id = "";
        }

        private void EDRPOULabel_Checked(object sender, RoutedEventArgs e)
        {
            ClientEDRPOU.IsEnabled = true;
        }

        private void EDRPOULabel_Unchecked(object sender, RoutedEventArgs e)
        {
            ClientEDRPOU.IsEnabled = false;
            EDRPOU = "";
        }

        private void NameLabel_Checked(object sender, RoutedEventArgs e)
        {
            ClientName.IsEnabled = true;
        }

        private void NameLabel_Unchecked(object sender, RoutedEventArgs e)
        {
            ClientName.IsEnabled = false;
            clName = "";
        }

        private void FileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
                foreach (string file in openFileDialog.FileNames)
                {
                     Files.Items.Add(Path.GetFullPath(file));
                }


        }
        private void DateilInfo(object sender, RoutedEventArgs e)
        {
            if (CbUserGrid.HasItems)
            {
                Details.Text = ((DataRowView)CbUserGrid.SelectedValue).Row.ItemArray[6].ToString();
            }
        }

        private void CbUserGrid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            tabControl.SelectedIndex = 1;
            tab2_MouseUp(sender, e);
        }


        private void tab2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            DateilInfo(sender, e);
        }
    }
}
