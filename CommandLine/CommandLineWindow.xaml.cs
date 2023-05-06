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
        List<string> NumLetterKeyCodeList = new List<string>()
        {
            "NumPad0", "NumPad1", "NumPad2", "NumPad3", "NumPad4",
            "NumPad5", "NumPad6", "NumPad7", "NumPad8", "NumPad9",
            "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9",
            "D0", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P",
            "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X",
            "C", "V", "B", "N", "M"
        };
        Dictionary<string, List<string>> UsualCmdDict = new Dictionary<string, List<string>>()
        {
            { "WA", new List<string> { "Icons/WA.png", "Create Wall"}},
            { "DR", new List<string> { "Icons/DR.png", "Place Door" }},
            { "WN", new List<string> { "Icons/WN.png", "Place Window" } },
            { "CL", new List<string> { "Icons/CL.png", "Place Column" } },
            { "BM", new List<string> { "Icons/BM.png", "Place Beam" } },
            { "DT", new List<string> { "Icons/DT.png", "Create Duct" } },
            { "DF", new List<string> { "Icons/DF.png", "Place Duct Fitting" } },
            { "FD", new List<string> { "Icons/FD.png", "Place Flexible Duct" } },
            { "PI", new List<string> { "Icons/PI.png", "Create Pipe" } },
            { "PF", new List<string> { "Icons/PF.png", "Place Pipe Fitting" } },
            { "PA", new List<string> { "Icons/PA.png", "Place Pipe Accessory" } },
            { "FP", new List<string> { "Icons/FP.png", "Flexible Pipe" } },
            { "EW", new List<string> { "Icons/EW.png", "Electric Curved Wire" } },
            { "TF", new List<string> { "Icons/TF.png", "Cable Tray Fitting" } },
            { "NF", new List<string> { "Icons/NF.png", "Conduit Fitting" } },
            { "CM", new List<string> { "Icons/CM.png", "Place Current Models" } },
            { "DI", new List<string> { "Icons/DI.png", "Dimension os Models" } },
            { "EL", new List<string> { "Icons/EL.png", "Elevation of Models" } },
            { "TX", new List<string> { "Icons/TX.png", "Place Text" } },
            { "UN", new List<string> { "Icons/UN.png", "Setup Unit" } },
            { "TG", new List<string> { "Icons/TG.png", "Tag Models" } },
            { "GR", new List<string> { "Icons/GR.png", "Place Grid" } }
        };
        public CommandLineWindow()
        {
            InitializeComponent();
            Popup popup = (Popup)this.FindName("SearchPopup");
            popup.Width = Grid_CommandLine.ActualWidth;
            Lstbx_SearchCommand.Width = Grid_CommandLine.ActualWidth;

        }
        public class UsualLstBoxData
        {
            public string UsualCmd { get; set; }
            public string UsualIconPath { get; set; }
            public string UsualCmdToolTip { get; set; }
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
            if (NumLetterKeyCodeList.Contains(e.Key.ToString()))
            {
                Tb_Command.AppendText(e.Key.ToString());
                Tb_CommandResult.AppendText(e.Key.ToString());
            }
            else
            {
                Tb_Command.Text = "Type Command";
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

            foreach (KeyValuePair<string, List<string>> kvp in UsualCmdDict)
            {
                if (Lstbx_UsualCommand.Items.Count < UsualCmdDict.Count)
                {
                    UsualLstBoxData usualLstBoxData = new UsualLstBoxData
                    {

                        UsualCmd = kvp.Key,
                        UsualIconPath = kvp.Value[0],
                        UsualCmdToolTip = kvp.Value[1]
                    };
                }
                else
                {
                    continue;
                }
            }
            Popup popup = (Popup)this.FindName("UsualPopup");
            popup.Placement = PlacementMode.Top;
            popup.Width = 200;
            Lstbx_UsualCommand.Width = 200;
            popup.IsOpen = true;
        }

        private void Bt_CommandHelp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tb_Command_TextChanged(object sender, TextChangedEventArgs e)
        {
            /// Input Command and Match Revit Command
            /// Then Execute Command
/*            Lstbx_Command.Items.Add(Tb_Command.Text);*/
            Popup popup = (Popup)this.FindName("SearchPopup");
            popup.Placement = PlacementMode.Top;
            popup.Width = Grid_CommandLine.ActualWidth;
            Lstbx_SearchCommand.Width = Grid_CommandLine.ActualWidth;
            popup.IsOpen = true;

            // If command not match Revit Command 
            // Then Return "Command: {Command} Unknown Upper{Command}. Press F1 Check Out Help"
        }
    }
}
