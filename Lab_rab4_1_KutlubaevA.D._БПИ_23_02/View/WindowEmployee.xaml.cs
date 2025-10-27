using System.Windows;
using Lab_rab4_1_KutlubaevA.D._БПИ_23_02.Helper;
using Lab_rab4_1_KutlubaevA.D._БПИ_23_02.ViewModel;
using Lab_rab4_1_KutlubaevA.D._БПИ_23_02.Model;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
namespace Lab_rab4_1_KutlubaevA.D._БПИ_23_02.View
{

    public partial class WindowEmployee : Window
    {
        public WindowEmployee()
        {
            InitializeComponent();
            PersonViewModel vmPerson = new PersonViewModel();
            RoleViewModel vmRole = new RoleViewModel();
            List<Role> roles = new List<Role>();
            foreach (Role r in vmRole.ListRole)
            {
                roles.Add(r);
            }
            ObservableCollection<PersonDPO> persons =
            new ObservableCollection<PersonDPO>();
            FindRole finder;
            foreach (var p in vmPerson.ListPerson)
            {
                finder = new FindRole(p.RoleId);
                Role rol = roles.Find(new Predicate<Role>(finder.RolePredicate));
                persons.Add(new PersonDPO
                {
                    Id = p.Id,
                    Role = rol.NameRole,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Birthday = p.Birthday
                });
            }
            lvEmployee.ItemsSource = persons;
        }
    }
}