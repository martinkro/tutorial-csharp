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
using TreeViewDemo.DataModel;
using TreeViewDemo.TextSearch.ViewModel;
using TreeViewDemo.DataAccess;

namespace TreeViewDemo.TextSearch
{
    /// <summary>
    /// Interaction logic for TextSearchUserControl.xaml
    /// </summary>
    public partial class TextSearchUserControl : UserControl
    {
        readonly FamilyTreeViewModel _familyTree;
        public TextSearchUserControl()
        {
            InitializeComponent();
            // Get raw family tree data from a database.
            Person rootPerson = Database.GetFamilyTree();

            // Create UI-friendly wrappers around the 
            // raw data objects (i.e. the view-model).
            _familyTree = new FamilyTreeViewModel(rootPerson);

            // Let the UI bind to the view-model.
            base.DataContext = _familyTree;
        }

        void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                _familyTree.SearchCommand.Execute(null);
        }
    }
}
