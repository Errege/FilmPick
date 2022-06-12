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
    /// Логика взаимодействия для Film.xaml
    /// </summary>

    
    public partial class Film : Page
    {
        private FilmPickEntities3 data = new FilmPickEntities3();
        public Film()
        {
            InitializeComponent();
        }

        private void Gobtn_Click(object sender, RoutedEventArgs e)
        {
            DG_Film.Items.Clear();
            var d = from f in data.FILM
                    where f.F_NAME.Contains(Source.Text) || f.ACTOR.A_NAME.Contains(Source.Text) || f.PRODUCER.P_NAME.Contains(Source.Text) || f.SCREENWRITER.S_NAME.Contains(Source.Text) || f.GERNE.G_NAME.Contains(Source.Text)
                    select new
                    {
                        NAME = f.F_NAME,
                        DATA = f.DATA.D_NAME,
                        RATING = f.RATING.R_NAME,
                        ACTOR = f.ACTOR.A_NAME,
                        PRODUCER = f.PRODUCER.P_NAME,
                        SCREENWRITER = f.SCREENWRITER.S_NAME,
                        GERNE = f.GERNE.G_NAME
                    };
            foreach (var item in d)
            {
                DG_Film.Items.Add(item);
            }
        }


         private void Page_Loaded(object sender, RoutedEventArgs e)
         {
            DG_Film.Items.Clear();
            var d = from f in data.FILM
                    where f.F_NAME.Contains(Source.Text) || f.ACTOR.A_NAME.Contains(Source.Text) || f.PRODUCER.P_NAME.Contains(Source.Text) || f.SCREENWRITER.S_NAME.Contains(Source.Text) || f.GERNE.G_NAME.Contains(Source.Text)
                    select new
                    {
                        NAME = f.F_NAME,
                        DATA = f.DATA.D_NAME,
                        RATING = f.RATING.R_NAME,
                        ACTOR = f.ACTOR.A_NAME,
                        PRODUCER = f.PRODUCER.P_NAME,
                        SCREENWRITER = f.SCREENWRITER.S_NAME,
                        GERNE = f.GERNE.G_NAME
                    };
            foreach (var item in d)
            {
                DG_Film.Items.Add(item);
            }
        }

        private void DG_Film_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var firstSelectedCellContent = ((TextBlock)(this.DG_Film.Columns[0].GetCellContent(DG_Film.SelectedItem))).Text;
            var deletefilm = data.FILM.Where(m => m.F_NAME == firstSelectedCellContent);

            if (e.Key == Key.End)
            {
                var d = from s in data.FILM
                        where s.F_NAME.Equals(firstSelectedCellContent)
                        select new 
                        {
                            F_NAME = s.F_NAME,
                        };
              
            }

                    if (e.Key == Key.Delete)
            {
                if (MessageBox.Show($"Вы точно хотите удалить следующие элементы",
                    "Внмимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        
                        data.FILM.RemoveRange(deletefilm);
                        data.SaveChanges();
                        MessageBox.Show("Данные удалены");

                        DG_Film.Items.Clear();
                        var d = from f in data.FILM
                                where f.F_NAME.Contains(Source.Text) || f.ACTOR.A_NAME.Contains(Source.Text) || f.PRODUCER.P_NAME.Contains(Source.Text) || f.SCREENWRITER.S_NAME.Contains(Source.Text) || f.GERNE.G_NAME.Contains(Source.Text)
                                select new
                                {
                                    NAME = f.F_NAME,
                                    DATA = f.DATA.D_NAME,
                                    RATING = f.RATING.R_NAME,
                                    ACTOR = f.ACTOR.A_NAME,
                                    PRODUCER = f.PRODUCER.P_NAME,
                                    SCREENWRITER = f.SCREENWRITER.S_NAME,
                                    GERNE = f.GERNE.G_NAME
                                };
                        foreach (var item in d)
                        {
                            DG_Film.Items.Add(item);
                        }
                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message.ToString());
                    }
                }

            }
        }

        private void Source_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                DG_Film.Items.Clear();
                var d = from f in data.FILM
                        where f.F_NAME.Contains(Source.Text) || f.ACTOR.A_NAME.Contains(Source.Text) || f.PRODUCER.P_NAME.Contains(Source.Text) || f.SCREENWRITER.S_NAME.Contains(Source.Text) || f.GERNE.G_NAME.Contains(Source.Text)
                        select new
                        {
                            NAME = f.F_NAME,
                            DATA = f.DATA.D_NAME,
                            RATING = f.RATING.R_NAME,
                            ACTOR = f.ACTOR.A_NAME,
                            PRODUCER = f.PRODUCER.P_NAME,
                            SCREENWRITER = f.SCREENWRITER.S_NAME,
                            GERNE = f.GERNE.G_NAME
                        };
                foreach (var item in d)
                {
                    DG_Film.Items.Add(item);
                }
            }
        }
    }
}
