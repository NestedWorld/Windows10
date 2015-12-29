﻿using NestedWorld.Classes.ElementsGame.Users;
using NestedWorld.View.MapPoint;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace NestedWorld.View.MapViews
{
    public sealed partial class MapControlView : UserControl
    {
        public MapControl mapControl { get { return mC; } set { mC = value; } }
        public MapControlView()
        {
            this.InitializeComponent();
        }


        private void Locate(object sender, RoutedEventArgs e)
        {

        }

        public void ShowUser()
        {
            Random rand = new Random();
            foreach (User user in App.core.userList.userList)
            {
                UserMapPoint tmp = new UserMapPoint();
                tmp.DataContext = user;

                MapControl.SetLocation(tmp,
                    new Windows.Devices.Geolocation.Geopoint(
                        new Windows.Devices.Geolocation.BasicGeoposition
                        {
                            Latitude = rand.Next(-89, 89),
                            Longitude = rand.Next(-89, 89)
                        }));
                mapControl.Children.Add(tmp);
            }
        }
    }
}