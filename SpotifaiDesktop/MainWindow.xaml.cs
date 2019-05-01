using SpotifaiStandard.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace SpotifaiDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TestScript();
        }

        public void TestScript()
        {
            Track track = new Track()
            {
                Album = new Album(),
                Artists = new Artist[] { new Artist() },
                AvailableMarkets = new string[] { "en", "us" },
                DiscNumber = 3,
                DurationMs = 3000,
                Explicit = false,
                Id = "A0021A",
                IsPlayable = true,
                Name = "LATATA",
                PreviewUrl = "www.google.com",
                TrackNumber = 2,
                Uri = "hhhahaha:ssddf"
            };

            Debug.WriteLine("Current track: " + track.Name);
        }
    }
}
