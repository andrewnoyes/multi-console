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
using Xceed.Wpf.AvalonDock.Layout;

namespace MultiConsoleApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void OpenConsole_OnClick(object sender, RoutedEventArgs e)
        {
            var pane = new LayoutAnchorablePane();
            var consoleCtrl = new ConsoleControl.WPF.ConsoleControl { IsInputEnabled = true };
            consoleCtrl.StartProcess("cmd.exe", string.Empty);
            var anchor = new LayoutAnchorable
            {
                Content = consoleCtrl,
                Title = "Console",
                ContentId = "Console"
            };

            pane.Children.Add(anchor);
            MainLayoutGroup.Children.Add(pane);
        }
    }
}
