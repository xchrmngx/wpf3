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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Col1.SelectedIndex == 0)
            {
                BG.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                txt1.Text = "Сейчас красный цвет";
            }
            else if (Col1.SelectedIndex == 1)
            {
                BG.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                txt1.Text = "Сейчас зеленый цвет";
            }
            else if (Col1.SelectedIndex == 2)
            {
                BG.Background = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                txt1.Text = "Сейчас синий цвет";
            }
                
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вычигин Тукай сделали эту программу, если что WPF гавно");
        }
    }
}
