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
using DatabaseLayer;
using System.Collections.ObjectModel;

namespace BSK_Proj2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<Dataset> _datasets;

        public MainWindow()
        {
            // help is required here (never had experience with using EF)
            // binding datasets to observable collection in datagrid
            using (var ctx = new Entities())
            {
                _datasets = ctx.Set<Dataset>().Local;
            }
            InitializeComponent();
        }
    }
}
