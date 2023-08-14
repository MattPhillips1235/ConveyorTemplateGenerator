using GrantaTemplateGenerator.Views;
using System.Windows;


namespace GrantaTemplateGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Home home = new Home();

        public MainWindow()
        {
            InitializeComponent();
           
            MainFrame.Content = null;
            MainFrame.Content = home;
        }

    
    }
}
