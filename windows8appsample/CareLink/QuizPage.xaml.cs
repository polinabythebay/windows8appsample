using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace CareLink
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class QuizPage : CareLink.Common.LayoutAwarePage
    {
        public QuizPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void QuizSubmit_Button(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(GroupedItemsPage), "AllGroups");
                var mailto = new Uri("mailto:?to=nassifhenry@gmail.com&subject=Patient: Mukabo &body= Henry Mukaebo has not been running, jumping, playing, or swimming every day for the past seven days | Henry Mukaebo has been feeling weak more than 24 hours after operation | Henry Mukaebo's wound/stich has not been bleeding or leaking fluids in the past seven days | Henry Mukaebo's wound/stitch  did become red or swell in the past seven days | Henry Mukaebo has not lost any weight | Henry Mukaebo did not have vomiting, or diarrhea more than 24 hours after operation | Henry Mukaebo has been taking medication as prescribed");
                Windows.System.Launcher.LaunchUriAsync(mailto);
            }
        }
    }
}
