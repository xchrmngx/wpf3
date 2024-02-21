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

namespace задание_2
{
    /// <summary>
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Col1.SelectedIndex == 0)
            {
                Col2.Color = Color.FromRgb(255, 0, 0);
            }
            else if (Col1.SelectedIndex == 1)
            {
                Col2.Color = Color.FromRgb(0, 255, 0);
            }
            else if (Col1.SelectedIndex == 2)
            {
                Col2.Color = Color.FromRgb(0, 0, 255);
            }
            else if (Col1.SelectedIndex == 3)
            {
                Col2.Color = Color.FromRgb(255, 255, 255);
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Col2.Width = Slider1.Value;
            Col2.Height = Slider1.Value;
        }
    }
}
