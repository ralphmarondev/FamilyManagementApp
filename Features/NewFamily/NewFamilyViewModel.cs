using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyApp.Core.Models;
using System;

namespace MyApp.Features.NewFamily
{
    public partial class NewFamilyViewModel : ObservableObject
    {
        //private readonly FamilyRepository _repo;

        public NewFamilyViewModel()
        {
            // TODO: inject or configure connection string properly
            //_repo = new FamilyRepository("Data Source=church.db");
        }

        // Bindable properties
        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private DateTime createDate = DateTime.Now;

        [ObservableProperty]
        private DateTime updateDate = DateTime.Now;

        [ObservableProperty]
        private bool isDeleted = false;

        // Command to create a new family
        [RelayCommand]
        private void CreateFamily()
        {
            var family = new Family
            {
                Name = Name,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                IsDeleted = false
            };

            //_repo.AddFamily(family);

            //// Reset form or show feedback
            Name = string.Empty;
        }

        // Command to cancel
        [RelayCommand]
        private void Cancel()
        {
            // Logic to navigate back or clear form
            Name = string.Empty;
        }
    }
}