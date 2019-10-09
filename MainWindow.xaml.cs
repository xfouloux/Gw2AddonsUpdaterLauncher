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
    public partial class MainWindow : Window {

        public static string Gw2Path = Properties.Resources.Gw2Path;
        public static string Gw2AddonPath = Gw2Path + Properties.Resources.Gw2AddonPath;
        public static string TacoPath = Gw2AddonPath + Properties.Resources.TacoPath;
        public static string ArcdpsPath = Gw2Path + Properties.Resources.ArcdpsPath;

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
                ArcdpsPath = Path.GetDirectoryName(gw2PathDialog.FileName) + "\\" + Properties.Resources.ArcdpsPath;
            }
        }

        private void gw2_path_text_Initialized(object sender, EventArgs e)
        {
            string UserGw2Path = Properties.User.Default.Gw2Path;
            if (UserGw2Path != "")
            {
                Gw2Path = UserGw2Path;
            }
            if ( Directory.Exists(Gw2Path) == true)
            {
                gw2_path_text.Text = Path.GetDirectoryName(Gw2Path);
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
            string UserTacoPath = Properties.User.Default.TacoPath;
            if (UserTacoPath != "")
            {
                TacoPath = UserTacoPath;
            }
            if (Directory.Exists(TacoPath) == true)
            {
                taco_path_text.Text = Path.GetDirectoryName(TacoPath);
            }
            else if(Directory.Exists(Gw2AddonPath) == true)
            {
                taco_path_text.Text = Path.GetDirectoryName(TacoPath);
            }
            else
            {
                taco_path_text.Text = "Choose Taco executable path";
            }

        }

        private void update_button_Click(object sender, RoutedEventArgs e)
        {
            //Get GW2 Options

            //Get Taco Options
            if (taco_update.IsChecked == true)
            {

            }
            //Get Arcdps Options
            if (arcdps_update.IsChecked == true)
            {
                if(arcdps_template.IsChecked == true)
                {
                    App.Download_File(Properties.Resources.ArcdpsURi, ArcdpsPath);
                }
                if (arcdps_mechanics.IsChecked == true)
                {
                    App.Download_File(Properties.Resources.ArcdpsMechanicsURi, ArcdpsPath);
                }

            }
        }
    }
}
