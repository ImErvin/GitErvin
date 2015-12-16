using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace QuikPik
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void lotto_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Random r = new Random();
            squareOne.Text = (r.Next(1, 47).ToString());
            squareTwo.Text = (r.Next(1, 47).ToString());
            squareThree.Text = (r.Next(1, 47).ToString());
            squareFour.Text = (r.Next(1, 47).ToString());
            squareFive.Text = (r.Next(1, 47).ToString());
            squareSix.Text = (r.Next(1, 47).ToString());
            squareSeven.Text = "";
        }

        private void lottoPlus_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Random r = new Random();
            squareOne.Text = (r.Next(1, 39).ToString());
            squareTwo.Text = (r.Next(1, 39).ToString());
            squareThree.Text = (r.Next(1, 39).ToString());
            squareFour.Text = (r.Next(1, 39).ToString());
            squareFive.Text = (r.Next(1, 39).ToString());
            squareSix.Text = (r.Next(1, 39).ToString());
            squareSeven.Text = "";
        }

        private void euroMillions_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Random r = new Random();
            squareOne.Text = (r.Next(1, 50).ToString());
            squareTwo.Text = (r.Next(1, 50).ToString());
            squareThree.Text = (r.Next(1, 50).ToString());
            squareFour.Text = (r.Next(1, 50).ToString());
            squareFive.Text = (r.Next(1, 50).ToString());
            squareSix.Text = (r.Next(1, 10).ToString());
            squareSeven.Text = (r.Next(1, 10).ToString());
        }
    }
}
