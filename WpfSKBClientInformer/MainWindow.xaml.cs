using System.Windows;
using System.Windows.Input;
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
            await sq.SelectData("","","","");
            CbUserGrid.ItemsSource = sq.Dt.DefaultView;
            ProgBar.IsIndeterminate = false;
        }

        private void CbUserGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
