﻿using System.Windows;
using Lab_rab4_1_KutlubaevA.D._БПИ_23_02.ViewModel;

namespace Lab_rab4_1_KutlubaevA.D._БПИ_23_02.View
{
    public partial class WindowRole : Window
    {
        public WindowRole()
        {
            InitializeComponent();

            RoleViewModel vmRole = new RoleViewModel();
            lvRole.ItemsSource = vmRole.ListRole;
        }
    }
}
