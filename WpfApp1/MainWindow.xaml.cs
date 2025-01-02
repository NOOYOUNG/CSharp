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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var visibility=LeftPanel.Visibility;

            switch (visibility)
            {
                case Visibility.Visible:
                    LeftPanel.Visibility = Visibility.Hidden;
                    break;
                case Visibility.Hidden:
                    LeftPanel.Visibility= Visibility.Collapsed;
                    break;
                case Visibility.Collapsed:
                    LeftPanel.Visibility=Visibility.Visible;
                    break;
            }
        }

        private void Button_Click_IsVisible(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(LeftPanel.IsVisible.ToString(), "IsVisible");
        }

        private void Button_Click_Opacity(object sender, RoutedEventArgs e)
        {
            double opacity = LeftPanel.Opacity;
            opacity -= 0.25;

            if (opacity < 0)
            {
                opacity = 1;
            }

            LeftPanel.Opacity= opacity;
        }


        private void Me_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("클릭");
        }

        private void Button_Click_IsHitTestVisible(object sender, RoutedEventArgs e)
        {
            LeftPanel.IsHitTestVisible = !LeftPanel.IsHitTestVisible;
            //foreach (var child in LeftPanel.Children)
            //{
            //    if (child is Button button)
            //    {
            //        button.IsHitTestVisible = true;
            //    }
            //}
        }

        private void Button_Click_InEnabled(object sender, RoutedEventArgs e)
        {
            LeftPanel.IsEnabled = !LeftPanel.IsEnabled;
        }
    }
}