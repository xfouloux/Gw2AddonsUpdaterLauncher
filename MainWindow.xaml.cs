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

using Microsoft.Win32;
using System.IO;
using System.Collections;
using Path = System.IO.Path;

namespace Gw2AddonsUpdaterLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string Gw2Path = "C:\\Program Files\\Guild Wars 2\\";
        public static string Gw2AddonPath = Gw2Path + "addons\\";
        public static string TacoPath = Gw2AddonPath + "taco\\";
        public static string ArcdpsPath = Gw2AddonPath + "arcdps\\";

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void gw2_select_path_btn_Click(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            OpenFileDialog gw2PathDialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "Exe File|*.exe",
                DefaultExt = ".exe",
                InitialDirectory = "c:\\",
                RestoreDirectory = true,
                Title = "Select GW2 Path",
                CheckFileExists = true,
                CheckPathExists = true
            };
            // Show open file dialog box
            Nullable<bool> result = gw2PathDialog.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                gw2_path_text.Text = Path.GetDirectoryName(gw2PathDialog.FileName);
            }
        }

        private void gw2_path_text_Initialized(object sender, EventArgs e)
        {
            if ( Directory.Exists(Gw2Path) == true)
            {
                gw2_path_text.Text = Gw2Path;
            }
            else
            {
                gw2_path_text.Text = "Choose Gw2 executable path";
            }

        }

        private void taco_select_path_btn_Click(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            OpenFileDialog tacoPathDialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "Exe File|*.exe",
                DefaultExt = ".exe",
                InitialDirectory = "c:\\",
                RestoreDirectory = true,
                Title = "Select Taco Path",
                CheckFileExists = true,
                CheckPathExists = true
            };
            // Show open file dialog box
            Nullable<bool> result = tacoPathDialog.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                taco_path_text.Text = Path.GetDirectoryName(tacoPathDialog.FileName);
            }
        }

        private void taco_path_text_Initialized(object sender, EventArgs e)
        {
            if (Directory.Exists(TacoPath) == true)
            {
                taco_path_text.Text = TacoPath;
            }
            else if(Directory.Exists(Gw2AddonPath) == true)
            {
                taco_path_text.Text = TacoPath;
            }
            else
            {
                taco_path_text.Text = "Choose Taco executable path";
            }

        }
        private void arcdps_select_path_btn_Click(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            OpenFileDialog arcdpsPathDialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "Exe File|*.exe",
                DefaultExt = ".exe",
                InitialDirectory = "c:\\",
                RestoreDirectory = true,
                Title = "Select Arcdps Path",
                CheckFileExists = true,
                CheckPathExists = true
            };
            // Show open file dialog box
            Nullable<bool> result = arcdpsPathDialog.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                arcdps_path_text.Text = Path.GetDirectoryName(arcdpsPathDialog.FileName);
            }
        }

        private void arcdps_path_text_Initialized(object sender, EventArgs e)
        {
            if (Directory.Exists(ArcdpsPath) == true)
            {
                arcdps_path_text.Text = ArcdpsPath;
            }
            else if (Directory.Exists(Gw2AddonPath) == true)
            {
                arcdps_path_text.Text = ArcdpsPath;
            }
            else
            {
                arcdps_path_text.Text = "Choose ArcDPS executable path";
            }

        }

    }
}
