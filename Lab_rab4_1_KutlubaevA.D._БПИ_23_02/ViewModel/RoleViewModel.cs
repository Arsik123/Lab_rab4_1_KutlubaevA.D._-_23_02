using System.Collections.ObjectModel;
using Lab_rab4_1_KutlubaevA.D._БПИ_23_02.Model;
namespace Lab_rab4_1_KutlubaevA.D._БПИ_23_02.ViewModel
{
    public class RoleViewModel
    {
        public ObservableCollection<Role> ListRole { get; set; } = new ObservableCollection<Role>();
        public RoleViewModel()
        {
            this.ListRole.Add(
            new Role
            {
                Id = 1,
                NameRole = "Директор"
            }
            );
            this.ListRole.Add(
            new Role
            {
                Id = 2,
                NameRole = "Бухгалтер"
            }
            );
            this.ListRole.Add(new Role
            {
                Id = 3,
                NameRole = "Менеджер"
            });
        }
    }
}
