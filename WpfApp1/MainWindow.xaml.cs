using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

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

        private void Button_Click(object sender, EventArgs e)
        {
            var values = typeof(Brushes).GetProperties().Select(p => p.GetValue(null) as Brush).ToArray();
            Random rnd = new Random();
            (sender as Button).Background = values[rnd.Next(1, values.Length - 1)];
            MessageBox.Show((sender as Button).Content.ToString());
        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Title = $"{(sender as Button).Content.ToString()} Hidden";
            (sender as Button).Visibility = Visibility.Hidden;
        }
    }
}