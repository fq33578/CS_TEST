using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Window_TEST
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            //Solo();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            NotifyIcon notifyIcon= new System.Windows.Forms.NotifyIcon();
            notifyIcon.Icon = new System.Drawing.Icon(@"E:\Project\TestCode\Window_TEST\Window_TEST\Window_TEST\saa_ico.ico");
            notifyIcon.BalloonTipText = Title;
            notifyIcon.Text = Title;
            StateChanged += (o, e2) =>
            {
                if (WindowState == WindowState.Minimized)
                   Hide();
            };
            notifyIcon.Visible = true;
            //点击托盘 展示窗体
            notifyIcon.Click += (o, e1) =>
            {
                Show(); //this.Visible=true;
                WindowState = WindowState.Normal;
            };
        }
    }
}


