using System;
using System.Windows;
using Fluent;
using MahApps.Metro.Controls;

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
            this.Loaded += this.MetroWindow_Loaded;
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
            this.Loaded -= this.MetroWindow_Loaded;

            TitleBar = this.FindChild<RibbonTitleBar>("RibbonTitleBar");
            TitleBar.InvalidateArrange();
            TitleBar.UpdateLayout();
        }
    }
}
