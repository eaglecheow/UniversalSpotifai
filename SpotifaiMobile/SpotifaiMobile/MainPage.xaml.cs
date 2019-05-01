using SpotifaiStandard.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SpotifaiMobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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

        private void TestButton_Clicked(object sender, EventArgs e)
        {
            TestScript();
        }
    }
}
