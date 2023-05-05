using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
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
            Popup popup = (Popup)this.FindName("popup");
            popup.Width = Grid_CommandLine.ActualWidth;
            Lstbx_Command.Width = Grid_CommandLine.ActualWidth;
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
                Tb_CommandResult.AppendText(e.Key.ToString());
            }
            catch
            {
                Tb_Command.Text = "键入命令";
                Tb_CommandResult.Text = "无输入，未返回任何结果！";
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

        private void Bt_CommandHelp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tb_Command_TextChanged(object sender, TextChangedEventArgs e)
        {
            /// Input Command and Match Revit Command
            /// Then Execute Command
/*            Lstbx_Command.Items.Add(Tb_Command.Text);
            Popup popup = (Popup)this.FindName("popup");
            popup.Placement = PlacementMode.Top;
            popup.Width = Grid_CommandLine.ActualWidth;
            Lstbx_Command.Width = Grid_CommandLine.ActualWidth;
            popup.IsOpen = true;*/
        }
    }
}
