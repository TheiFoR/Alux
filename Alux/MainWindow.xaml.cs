using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Alux
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        #region --CloseButton--
        private void CloseButton_MouseEnter(object sender, MouseEventArgs e)
        {
            lineUp.Stroke = new SolidColorBrush(Color.FromRgb(0xdc,0x14,0x3c));
            lineDown.Stroke = new SolidColorBrush(Color.FromRgb(0xdc,0x14,0x3c));
        }

        private void CloseButton_MouseLeave(object sender, MouseEventArgs e)
        {
            lineUp.Stroke = new SolidColorBrush(Color.FromRgb(0xff,0xff,0xff));
            lineDown.Stroke = new SolidColorBrush(Color.FromRgb(0xff,0xff,0xff));
        }

        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        #endregion
    }
}
