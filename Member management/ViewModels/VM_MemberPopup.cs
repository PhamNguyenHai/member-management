using Member_management.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member_management.ViewModels
{
    public class VM_MemberPopup : BaseNotifyPropertyChanged
    {
        private Member member;

        public ObservableCollection<Position> Positions { get; set; }

        public Member Member
        {
            get => member;
            set
            {
                member = value;
                OnPropertyChanged(nameof(Member));
            }
        }

        public string Title { get; set; }

        public VM_MemberPopup(Member member, ObservableCollection<Position> positions, string title)
        {
            Member = member;
            Positions = positions;
            Title = title;
        }
    }
}
