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

namespace CommandLine
{
    /// <summary>
    /// CommandLineWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CommandLineWindow : Window
    {
        public CommandLineWindow()
        {
            InitializeComponent();

        }
        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {
                // throw;
            }
        }
        public void AddKeyPressed(object sender, KeyEventArgs e)
        {
            try
            {
                Tb_Command.AppendText(e.Key.ToString());
            }
            catch
            {
                Tb_Command.Text = "键入命令";
            }
        }

        private void Bt_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Bt_Settings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Bt_SelectCommand_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
