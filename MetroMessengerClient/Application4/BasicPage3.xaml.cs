﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Application4
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class BasicPage3 : Application4.Common.LayoutAwarePage
    {
        public BasicPage3()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
                
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ServerConnection.SendMessageToServer(ServerConnection.getStreamSocket(), 2, RegUsernameBox.Text + "\r\n");
            ServerConnection.SendMessageToServer(ServerConnection.getStreamSocket(), 2, RegPasswordBox_1.Password + "\r\n");
            ServerConnection.setCurrentUser(RegUsernameBox.Text);    

            StatusBox.Foreground = new SolidColorBrush(Colors.Green);
            StatusBox.Text = "You are logged in now!";
        }
    }
}
