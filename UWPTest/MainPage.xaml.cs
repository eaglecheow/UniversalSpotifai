using Windows.UI.Xaml.Controls;
using System.Diagnostics;
using SpotifaiStandard.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
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
