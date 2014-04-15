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

            this.btnSearch.Click += (sender, args) =>
            {
                var eventArgs = new SearchInitiatedEventArgs(SearchInitiatedEvent)
                {
                    UserName = Environment.UserName,
                    InitiatedTime = DateTime.Now,
                    SearchString = this.txtSearchString.Text
                };

                RaiseEvent(eventArgs);
            };
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

        public event RoutedEventHandler SearchInitiated
        {
            add
            {
                AddHandler(SearchInitiatedEvent, value);
            }
            remove
            {
                RemoveHandler(SearchInitiatedEvent, value);
            }
        }

        public static readonly DependencyProperty SearchStringProperty =
            DependencyProperty.Register(
                "SearchString",
                typeof(string),
                typeof(SearchPanel),
                new PropertyMetadata(default(string)));

        public static readonly RoutedEvent SearchInitiatedEvent =
            EventManager.RegisterRoutedEvent(
                "SearchInitiated",
                RoutingStrategy.Direct,
                typeof(RoutedEventHandler),
                typeof(SearchPanel));
    }
}
