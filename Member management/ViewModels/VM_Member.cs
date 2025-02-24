using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Member_management.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Xml.Linq;

namespace Member_management.ViewModels
{
    class VM_Member : BaseNotifyPropertyChanged
    {
        public ObservableCollection<Member> Members { get; set; }
        public ObservableCollection<Position> Positions { get; set; }
        public ObservableCollection<Member> FilteredMembers { get; set; }
        private Member _selectedMember;
        private string _searchText;

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

        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
                FilterMembers(); // Gọi hàm lọc mỗi khi SearchText thay đổi
            }
        }

        public VM_Member()
        {
            // Dữ liệu mẫu
            Members = new ObservableCollection<Member>
            {
                new Member { Id = Guid.NewGuid(), Number = "NV0001", Name = "Phạm Tuấn Hà", Position = new Position{ Id = Guid.Parse("1220c9ee-71ce-4b3d-a4a9-0a0e60f860d4"), Name = "Quản lý"}, Email = "hatuanpham12@example.com", PhoneNumber = "0262157632" },
                new Member { Id = Guid.NewGuid(), Number = "NV0002", Name = "Hoàng Nam Anh", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0003", Name = "Nguyễn Tuấn Sơn An", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0004", Name = "Hoàng Đức Hải", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0005", Name = "Bạch Ngọc Lan", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0006", Name = "Nguyễn Tuấn Đức", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0007", Name = "Trần Đức Anh", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0008", Name = "Hà Mạnh Dũng", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0009", Name = "Hoàng Hà Sơn", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0010", Name = "Hoàng Nam Tiến", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0011", Name = "Lê Ngọc Hợi", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0012", Name = "Hà Ngọc Tuấn", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0013", Name = "Hoàng Nam Anh", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0014", Name = "Hoàng Nam Anh", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0015", Name = "Hoàng Nam Anh", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0016", Name = "Hoàng Nam Anh", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0017", Name = "Hoàng Nam Anh", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" },
                new Member { Id = Guid.NewGuid(), Number = "NV0018", Name = "Hoàng Nam Anh", Position = new Position{ Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên"}, Email = "hoangnamanh@example.com", PhoneNumber = "0987727273" }
            };

            // Dữ liệu position
            Positions = new ObservableCollection<Position>
            {
                new Position { Id = Guid.Parse("1220c9ee-71ce-4b3d-a4a9-0a0e60f860d4"), Name = "Quản lý" },
                new Position { Id = Guid.Parse("8ce92c05-c9c1-4afa-9a05-0ac86d684f2d"), Name = "Hội trưởng" },
                new Position { Id = Guid.Parse("1648e81e-396f-4ff2-a90d-7e16088a0c67"), Name = "Hội viên" },
                new Position { Id = Guid.Parse("7927b04c-6caf-4336-85eb-91f62e6812c8"), Name = "Thư kí" }
            };

            FilteredMembers = new ObservableCollection<Member>(Members);

            AddMemberCommand = new RelayCommand<Member>(o => AddMember());
            DeleteMemberCommand = new RelayCommand<Member>(DeleteMember, CanDeleteMember);
            EditMemberCommand = new RelayCommand<Member>(EditMember, CanEditMember);
        }

        private void FilterMembers()
       {
            var filtered = string.IsNullOrEmpty(SearchText)
                ? Members
                : Members.Where(m => m.Name.IndexOf(SearchText, StringComparison.OrdinalIgnoreCase) >= 0);

            FilteredMembers.Clear();

            foreach (var member in filtered)
            {
                FilteredMembers.Add(member);
            }
        }

        private void AddMember()
        {
            var newMember = new Member();
            var popupViewModel = new VM_MemberPopup(newMember, Positions, "Add Member");

            var popup = new MemberPopup(popupViewModel);
            if (popup.ShowDialog() == true)
            {
                Members.Add(newMember);
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
                var editMember = new Member()
                {
                    Id = memberToEdit.Id,
                    Number = memberToEdit.Number,
                    Name = memberToEdit.Name,
                    Email = memberToEdit.Email,
                    PhoneNumber = memberToEdit.PhoneNumber,
                    Position = memberToEdit.Position,
                };

                var popupViewModel = new VM_MemberPopup(editMember, Positions, "Edit Member");

                var popup = new MemberPopup(popupViewModel);
                if (popup.ShowDialog() == true)
                {
                    memberToEdit.Number = editMember.Number;
                    memberToEdit.Name = editMember.Name;
                    memberToEdit.Email = editMember.Email;
                    memberToEdit.PhoneNumber = editMember.PhoneNumber;
                    memberToEdit.Position = editMember.Position;
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
