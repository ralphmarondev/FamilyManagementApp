using CommunityToolkit.Mvvm.ComponentModel;
using MyApp.Core.Models;
using MyApp.Core.Repository;
using System.Collections.ObjectModel;

namespace MyApp.Features.FamilyList
{
    public partial class FamilyListViewModel : ObservableObject
    {
        private readonly FamilyRepository _repo;

        [ObservableProperty]
        private ObservableCollection<Family> _families = new();

        public FamilyListViewModel()
        {
            _repo = new FamilyRepository();

            foreach (var family in _repo.GetFamilies())
            {
                Families.Add(family);
            }
        }
    }
}
