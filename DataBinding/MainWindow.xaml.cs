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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = new List<Record>( new Record[]
            {
                new Record{FirstName="Luka",LastName="Radovanovic",WebSite=new Uri("http://lr120.com"),Gender=Gender.Male },
                new Record{FirstName="Perka",LastName="Peranovic",WebSite=new Uri("http://perka.com"),Gender=Gender.Female }
            });
        }
    }
}
