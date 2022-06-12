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

namespace FilmPick
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (Tg_Btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_film.Visibility = Visibility.Collapsed;
                tt_add.Visibility = Visibility.Collapsed;
                tt_edit.Visibility = Visibility.Collapsed;
                tt_signout.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_film.Visibility = Visibility.Visible;
                tt_add.Visibility = Visibility.Visible;
                tt_edit.Visibility = Visibility.Visible;
                tt_signout.Visibility = Visibility.Visible;
            }
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            Home.Opacity = 1;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            Home.Opacity = 0.3;
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void stfilm_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new Film();
        }

        private void sthome_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new Home();
        }

        private void Add_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new Plus();
        }

        private void Edit_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new Edit();
        }

        private void Signout_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new SignOut();
        }

        private void Home_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Home.Opacity == 0.3)
            {
                
            }
        }
    }
}
