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
using System.Data.SqlClient;
using System.Configuration;

namespace FilmPick
{
    /// <summary>
    /// Логика взаимодействия для Plus.xaml
    /// </summary>
    public partial class Plus : Page
    {
        private FilmPickEntities3 data = new FilmPickEntities3();
        private FILM film = new FILM();
        public Plus()
        {
            InitializeComponent();
            Gerne.ItemsSource = data.GERNE.ToList();
            DataContext = film;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(Name.Text))
                errors.AppendLine("Укажите название фильма");
            if (string.IsNullOrWhiteSpace(Data.Text))
                errors.AppendLine("Укажите год выпуска фильма");
            if (string.IsNullOrWhiteSpace(Actor.Text))
                errors.AppendLine("Укажите ФИО главного актера фильма");
            if (string.IsNullOrWhiteSpace(Producer.Text))
                errors.AppendLine("Укажите имя режиссера фильма");
            if (string.IsNullOrWhiteSpace(Screenwriter.Text))
                errors.AppendLine("Укажите имя сценариста фильма");
            if (Gerne.SelectedItems == null)
                errors.AppendLine("Укажите жанр фильма");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {
                try
                {
                    data.FILM.Add(film);
                    data.SaveChanges();
                    MessageBox.Show("Информация сохранена");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void CheckGerne_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
