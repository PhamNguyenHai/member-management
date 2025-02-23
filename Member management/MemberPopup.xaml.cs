using Member_management.Models;
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
        public List<Position> Positions { get; set; }
        public Member ActionMember { get; private set; }
        public MemberPopup()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ActionMember = new Member
            {
                Id = Guid.NewGuid(),
                Number = txtNumber.Text,
                Name = txtName.Text,
                Position = (Position)cbbPosition.SelectedItem,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text
            };

            DialogResult = true; // Xác nhận thêm thành công
            Close();
        }
    }
}