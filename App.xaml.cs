using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;

namespace Gw2AddonsUpdaterLauncher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    public partial class App : Application
    {
        static readonly WebClient wc = new WebClient();
        internal static void Download_File(string uri, string save_path)
        {
            wc.DownloadFileAsync(new System.Uri(uri), save_path);
        }
    }
    
}
