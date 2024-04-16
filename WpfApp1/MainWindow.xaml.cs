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
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
           byte r1 = (byte) random.Next(256);
           byte r2 = (byte) random.Next(256);
           byte r3 = (byte) random.Next(256);
            var colorm = new SolidColorBrush(Color.FromRgb(r1,r2,r3));
            b1.Background = colorm;
            MessageBox.Show($"Button1's color changed to {colorm}","Changing",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            byte r1 = (byte)random.Next(256);
            byte r2 = (byte)random.Next(256);
            byte r3 = (byte)random.Next(256);
            var colorm = new SolidColorBrush(Color.FromRgb(r1, r2, r3));
            b2.Background = colorm;
            MessageBox.Show($"Button2's color changed to {colorm}", "Changing", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            byte r1 = (byte)random.Next(256);
            byte r2 = (byte)random.Next(256);
            byte r3 = (byte)random.Next(256);
            var colorm = new SolidColorBrush(Color.FromRgb(r1, r2, r3));
            b3.Background = colorm;
            MessageBox.Show($"Button3's color changed to {colorm}", "Changing", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            byte r1 = (byte)random.Next(256);
            byte r2 = (byte)random.Next(256);
            byte r3 = (byte)random.Next(256);
            var colorm = new SolidColorBrush(Color.FromRgb(r1, r2, r3));
            b4.Background = colorm;
            MessageBox.Show($"Button4's color changed to {colorm}", "Changing", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            byte r1 = (byte)random.Next(256);
            byte r2 = (byte)random.Next(256);
            byte r3 = (byte)random.Next(256);
            var colorm = new SolidColorBrush(Color.FromRgb(r1, r2, r3));
            b5.Background = colorm;
            MessageBox.Show($"Button5's color changed to {colorm}", "Changing", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            byte r1 = (byte)random.Next(256);
            byte r2 = (byte)random.Next(256);
            byte r3 = (byte)random.Next(256);
            var colorm = new SolidColorBrush(Color.FromRgb(r1, r2, r3));
            b6.Background = colorm;
            MessageBox.Show($"Button6's color changed to {colorm}", "Changing", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void rght1(object sender, MouseButtonEventArgs e)
        {
            this.Title = (string)b1.Content;
            b1.Visibility =Visibility.Collapsed;

        }

        private void rght2(object sender, MouseButtonEventArgs e)
        {
            this.Title = (string)b2.Content;
            b2.Visibility = Visibility.Collapsed;

        }



        private void rght3(object sender, MouseButtonEventArgs e)
        {
            this.Title = (string)b3.Content;
            b3.Visibility = Visibility.Collapsed;

        }


        private void rght4(object sender, MouseButtonEventArgs e)
        {
            this.Title = (string)b4.Content;
            b4.Visibility = Visibility.Collapsed;

        }


        private void rght5(object sender, MouseButtonEventArgs e)
        {
            this.Title = (string)b5.Content;
            b5.Visibility = Visibility.Collapsed;

        }

        private void rght6(object sender, MouseButtonEventArgs e)
        {
            this.Title = (string)b6.Content;
            b6.Visibility = Visibility.Collapsed;

        }


    }
}