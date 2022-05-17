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
    /// Логика взаимодействия для Thec.xaml
    /// </summary>
    public partial class Thec : Page
    {
        private static readonly Models.Model1 _db = new Models.Model1();
        public ObservableCollection<Models.Receipt> Receipts { get; set; } = new ObservableCollection<Models.Receipt>(_db.Receipt.ToList());
        public
            Thec()
        {
            InitializeComponent();
        }
    }
}
