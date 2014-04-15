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

namespace SearchPanelLibrary
{
    /// <summary>
    /// Interaction logic for SearchPanel.xaml
    /// </summary>
    public partial class SearchPanel : UserControl
    {
        public SearchPanel()
        {
            InitializeComponent();
        }

        public string SearchString
        {
            get
            {
                return GetValue(SearchStringProperty) as string;
            }
            set
            {
                SetValue(SearchStringProperty, value);
            }
        }

        public static readonly DependencyProperty SearchStringProperty =
            DependencyProperty.Register(
                "SearchString",
                typeof(string),
                typeof(SearchPanel),
                new PropertyMetadata(default(string)));
    }
}
