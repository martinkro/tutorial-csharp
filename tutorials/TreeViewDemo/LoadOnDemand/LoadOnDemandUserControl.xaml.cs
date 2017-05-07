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
using TreeViewDemo.DataAccess;
using TreeViewDemo.DataModel;
using TreeViewDemo.LoadOnDemand.ViewModel;

namespace TreeViewDemo.LoadOnDemand
{
    /// <summary>
    /// Interaction logic for LoadOnDemandUserControl.xaml
    /// </summary>
    public partial class LoadOnDemandUserControl : UserControl
    {
        public LoadOnDemandUserControl()
        {
            InitializeComponent();
            Region[] regions = Database.GetRegions();
            CountryViewModel viewModel = new CountryViewModel(regions);
            base.DataContext = viewModel;
        }
    }
}
