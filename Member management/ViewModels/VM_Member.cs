using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Member_management.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Member_management.ViewModels
{
    class VM_Member : BaseNotifyPropertyChanged
    {
        public ObservableCollection<Member> Members { get; set; }
        private Member _selectedMember;

        public ICommand AddMemberCommand { get; set; }
        public ICommand DeleteMemberCommand { get; set; }
        public ICommand EditMemberCommand { get; set; }

        public Member SelectedMember
        {
            get => _selectedMember;
            set
            {
                _selectedMember = value;
                OnPropertyChanged(nameof(SelectedMember));
            }
        }

        public VM_Member()
        {
            // Dữ liệu mẫu
            Members = new ObservableCollection<Member>
            {
                new Member { Id = Guid.NewGuid(), Number = "NV0001", Name = "Phạm Tuấn Hà", Position = new Position{ Id = Guid.Parse("0cf75866-f97b-4bb2-a620-50222564ef65"), Name = "Trưởng phòng"}, Email = "hatuanpham12@example.com", PhoneNumber = "0262157632" },
                new Member { Id = Guid.NewGuid(), Number = "NV0002", Name = "Hoàng Nam Anh", Position = new Position{ Id = Guid.Parse("9faaff98-3505-4a76-ac42-07ef0fd2219f"), Name = "Nhân viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" }
            };

            AddMemberCommand = new RelayCommand<Member>(o => AddMember());
            DeleteMemberCommand = new RelayCommand<Member>(DeleteMember, CanDeleteMember);
            //EditMemberCommand = new RelayCommand<Member>(EditMember, CanEditMember);
        }

        private void AddMember()
        {
            var positions = new List<Position>
            {
                new Position { Id = Guid.Parse("1220c9ee-71ce-4b3d-a4a9-0a0e60f860d4"), Name = "Quản lý" },
                new Position { Id = Guid.Parse("8ce92c05-c9c1-4afa-9a05-0ac86d684f2d"), Name = "Hội trưởng" },
                new Position { Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên" },
                new Position { Id = Guid.Parse("7927b04c-6caf-4336-85eb-91f62e6812c8"), Name = "Thư kí" }
            };

            var addMemberPopup = new MemberPopup()
            {
                DataContext = new Member(),
                Positions = positions,
            };
            if (addMemberPopup.ShowDialog() == true)
            {
                
                Members.Add(addMemberPopup.ActionMember);
            }
        }

        private void DeleteMember(Member memberToDelete)
        {
            if (memberToDelete != null)
            {
                // Hiển thị popup xác nhận
                var result = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    Members.Remove(memberToDelete);
                }
            }
        }

        private void EditMember(Member memberToEdit)
        {
            if (memberToEdit != null)
            {
                var editMemberPopup = new MemberPopup()
                {
                    DataContext = memberToEdit
                };
                if (editMemberPopup.ShowDialog() == true)
                {
                    // Cập nhật thông tin thành viên nếu popup trả về true
                    var updatedMember = editMemberPopup.ActionMember;
                    memberToEdit.Name = updatedMember.Name;
                    memberToEdit.Email = updatedMember.Email;
                    memberToEdit.PhoneNumber = updatedMember.PhoneNumber;
                    memberToEdit.Position = updatedMember.Position;
                }
            }
        }

        private bool CanDeleteMember(Member member)
        {
            return member != null;
        }

        private bool CanEditMember(Member member)
        {
            return member != null;
        }
    }
}
