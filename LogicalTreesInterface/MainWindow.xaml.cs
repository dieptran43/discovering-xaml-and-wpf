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

namespace LogicalTreesInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.AddHandler(Window.MouseRightButtonDownEvent,
                new MouseButtonEventHandler(MainWindow_MouseRightButtonDown), true);
            this.AddHandler(ListBox.SelectionChangedEvent,
                new SelectionChangedEventHandler(ListBox_SelectionChanged));
            this.AddHandler(Button.ClickEvent, new RoutedEventHandler(Button_Click));
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
                b.Foreground = Brushes.Blue;
        }

        void MainWindow_MouseRightButtonDown(object sender,MouseButtonEventArgs e)
        {
            this.Title = "Source = " + e.Source.GetType().Name + ", OriginalSource = " +
                e.OriginalSource.GetType().Name + " @ " + e.Timestamp;

            Control source = e.Source as Control;

            if(source.BorderThickness != new Thickness(5))
            {
                source.BorderThickness = new Thickness(5);
                source.BorderBrush = Brushes.Black;
            }
            else
            {
                source.BorderThickness = new Thickness(0);
            }
        }


        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
                b.Foreground = Brushes.Black;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.AddedItems.Count > 0)
                MessageBox.Show("You just selected "+e.AddedItems[0]);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You just clicked " +e.Source);
        }
    }
}
