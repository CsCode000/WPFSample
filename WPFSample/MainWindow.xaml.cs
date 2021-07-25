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
using LiveCharts;
using LiveCharts.Wpf;

namespace WPFSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Values1 = new ChartValues<double> { 3, 4, 6, 3, 2, 6 };

            DataContext = this;
        }

        public ChartValues<double> Values1 { get; set; }

        void OnClick_blur(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This button does nothing..... ");

        }

    }


}
