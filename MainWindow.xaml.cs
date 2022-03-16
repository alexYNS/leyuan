using System;
using System.Windows;
using System.Windows.Input;
using Panuon.UI.Silver;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private int MAIN_WIND_WEID;

        private Point DOCK_BACK_BORD_LOCAL_X_Y;

        public enum MouseDirection
        {
            East,
            West,
            South,
            North,
            Southeast,
            Southwest,
            Northeast,
            Northwest,
            None
        }
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;// 窗体居中
            InitializeComponent();
            Window win = new Window1();
            win.ShowDialog();
            //启动登录窗口
            this.Hide();
            //隐藏主窗口，退出登录窗口后自动返回主窗口
            this.Show();
           //显示主窗口；
        }

        private void WIND_MOUS_MOVE(object sender, MouseEventArgs e)
        {
            Point p = Mouse.GetPosition(windows_DSystem);
            //TEXT_LOCAL_X.Text = "X:" + p.X + "  " + "Y:" + p.Y;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EXIT_MSIN_WIND(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MAIN_WIND_MAX(object sender, RoutedEventArgs e)
        {
            //private int WIND_WDITH = System.Windows. 
            this.WindowState = System.Windows.WindowState.Maximized;
        }

        private void MAIN_WIND_MIN(object sender, RoutedEventArgs e)
        {
            MAIN_WIND_WEID = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;

            this.WindowState = System.Windows.WindowState.Minimized;

            
        }

        private void DOCK_BACK_BORD_MOUS_ENTR(object sender, MouseEventArgs e)
        {
            IntPtr hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle;

        }

        private void DOCK_BACK_BORD_MOUS_MOVE(object sender, MouseEventArgs e)
        {
            DOCK_BACK_BORD_LOCAL_X_Y = Mouse.GetPosition(DOCK_BACK_BORD);

            TEXT_SHOW_DOCK_BACK_X_Y.Text = "X:"+DOCK_BACK_BORD_LOCAL_X_Y.X + " "+"Y:"+ DOCK_BACK_BORD_LOCAL_X_Y.Y;
        }

        private void menuOpen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DACK_BACK_BORD_MOUS_DOWN(object sender, MouseButtonEventArgs e)
        {
            this.MouseDown += (x, y) =>
            {
                if (y.LeftButton == MouseButtonState.Pressed)
                {
                    this.DragMove();
                }
            };
        }

        private void DOCK_LIFT_MOUS_ENTR(object sender, MouseEventArgs e)
        {
      
        }


        private void DOCK_LIFT_MOUS_LEVE(object sender, MouseEventArgs e)
        {
            
        }

        private void DOCK_LIFT_MOUS_MOVE(object sender, MouseEventArgs e)
        {
           
        }
    }
}
