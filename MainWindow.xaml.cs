using System.Windows;

namespace ClaimAPPv2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new SubmitClaimPage());  
        }
        /// <summary>
        /// naviagtion buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SubmitClaimPage());  
        }

        private void ViewClaims_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ViewClaimsPage());  
        }

        private void ApproveDenyClaim_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ApproveDenyClaim());  
        }
    }
}
