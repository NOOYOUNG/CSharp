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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MyObject();
        }
    }

    public class MyObject
    {
        public int TheValue { get; set; }
    }

    public class PBColorConvert : IValueConverter
    {
        public object Convert(object Value, Type targetType,
            object Parameter, System.Globalization.CultureInfo culture)
        {
            int progressValue=(int)Value;

            if(progressValue <= 30 )
            {
                return 0;
            }
            else if (progressValue <= 60)
            {
                return 1;
            }
            else if (progressValue <= 90)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public object ConvertBack(object Value, Type targetType, object Parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
