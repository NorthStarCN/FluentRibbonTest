using Fluent;
using MahApps.Metro.Controls;
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

namespace FluentRibbonTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MetroWindow 
    {
        public MetroWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowsViewModel();
        }

        private static readonly DependencyPropertyKey TitleBarPropertyKey = DependencyProperty.RegisterReadOnly(nameof(TitleBar), typeof(RibbonTitleBar), typeof(MainWindow), new PropertyMetadata());

        public static readonly DependencyProperty TitleBarProperty = TitleBarPropertyKey.DependencyProperty;

        public RibbonTitleBar TitleBar
        {
            get => (RibbonTitleBar)GetValue(TitleBarProperty);
            private set => SetValue(TitleBarPropertyKey, value);
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            TitleBar = this.FindChild<RibbonTitleBar>("RibbonTitleBar");
            TitleBar.InvalidateArrange();
            TitleBar.UpdateLayout();
        }
    }
}
