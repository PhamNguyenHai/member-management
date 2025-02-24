using Member_management.Models;
using Member_management.ViewModels;
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
using System.Windows.Shapes;

namespace Member_management
{
    /// <summary>
    /// Interaction logic for MemberPopup.xaml
    /// </summary>
    public partial class MemberPopup : Window
    {
        public MemberPopup(VM_MemberPopup viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}