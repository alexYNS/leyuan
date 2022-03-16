using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;// 窗体居中
            InitializeComponent();
        }

        private void b1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void EXIT_DS(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
