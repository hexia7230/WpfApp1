using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DebugButton.Click += DebugButton_Click;
        }

        private void DebugButton_Click(object sender, RoutedEventArgs e)
        {
            // PasswordBoxを非表示にする
            PasswordBox.Visibility = Visibility.Hidden;

            // FucListとSubWindowを表示する
            FucList.Visibility = Visibility.Visible;
            SubWindow.Visibility = Visibility.Visible;
        }
    }
}
