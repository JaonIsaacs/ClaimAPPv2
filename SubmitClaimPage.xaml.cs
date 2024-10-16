using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
    /// <summary>
    /// Interaction logic for SubmitClaimPage.xaml
    /// </summary>
    /// 

   
    public partial class SubmitClaimPage : Page
    {
        private string attachedDocumentPath;

        public SubmitClaimPage()
        {
            InitializeComponent();
        }

        private void BrowseDocument_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                attachedDocumentPath = openFileDialog.FileName;
            }
        }
        public static List<Claim> ClaimsList = new List<Claim>();
        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ClaimDescriptionTextBox.Text) && !string.IsNullOrEmpty(attachedDocumentPath))
            {
                var newClaim = new Claim
                {
                    Description = ClaimDescriptionTextBox.Text,
                    DocumentPath = attachedDocumentPath,
                    Status = "Pending"
                };
                SubmitClaimPage.ClaimsList.Add(newClaim);
                MessageBox.Show("Claim submitted successfully.");
            }
            else
            {
                MessageBox.Show("Please provide all details.");
            }
        }

        private void ViewClaims_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ViewClaimsPage());
        }

        private void ApproveDenyClaim_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ApproveDenyClaim());
        }
    }

}
