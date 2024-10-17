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
    /// Interaction logic for ApproveDenyClaim.xaml
    /// </summary>
    public partial class ApproveDenyClaim : Page
    {
        public Claim selectedClaim { get; set; }


        /// <summary>
        /// list display of claims
        /// </summary>
        public ApproveDenyClaim()
        {
            InitializeComponent();
            ClaimsListView.ItemsSource = SubmitClaimPage.ClaimsList;  
            ClaimsListView.SelectionChanged += ClaimsListView_SelectionChanged;  
        }
        /// <summary>
        /// path location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClaimsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedClaim = (Claim)ClaimsListView.SelectedItem; 

           
            if (selectedClaim != null)
            {
                
                ClaimDescriptionTextBlock.Text = selectedClaim.Description;

               
                ClaimDocumentTypeTextBlock.Text = System.IO.Path.GetExtension(selectedClaim.DocumentPath);  
            }
        }
        /// <summary>
        /// approve
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Approve_Click(object sender, RoutedEventArgs e)
        {
            if (selectedClaim != null)
            {
                selectedClaim.Status = "Approved"; 
                ClaimsListView.Items.Refresh();  
                MessageBox.Show("Claim Approved.");
            }
            else
            {
                MessageBox.Show("Please select a claim.");
            }
        }
        //deny
        public void Deny_Click(object sender, RoutedEventArgs e)
        {
            if (selectedClaim != null)
            {
                selectedClaim.Status = "Denied";  
                ClaimsListView.Items.Refresh();  
                MessageBox.Show("Claim Denied.");
            }
            else
            {
                MessageBox.Show("Please select a claim.");
            }
        }

        private void ViewClaims_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ViewClaimsPage()); 
        }
    }
    }

