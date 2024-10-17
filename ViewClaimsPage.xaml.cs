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

namespace ClaimAPPv2
{
   
        public partial class ViewClaimsPage : Page
        {

        /// <summary>
        /// display
        /// </summary>
            public ViewClaimsPage()
            {
                InitializeComponent();
                ClaimsListView.ItemsSource = SubmitClaimPage.ClaimsList;
            }

            private void SubmitClaim_Click(object sender, System.Windows.RoutedEventArgs e)
            {
                NavigationService.Navigate(new SubmitClaimPage());
            }

            private void ApproveDenyClaim_Click(object sender, System.Windows.RoutedEventArgs e)
            {
                NavigationService.Navigate(new ApproveDenyClaim());
            }
        }
    }

