using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Pecarnya
{
    /// <summary>
    /// Логика взаимодействия для Ingradient.xaml
    /// </summary>
    public partial class Ingradient : Page
    {
        private static readonly Models.Model1 _db = new Models.Model1();
        public ObservableCollection<Models.Ingredients> Ingredients { get; set; } = new ObservableCollection<Models.Ingredients>(_db.Ingredients.ToList());
        public
            Ingradient()
        {
            InitializeComponent();
        }
    }
}
