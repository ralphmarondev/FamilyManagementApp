using CommunityToolkit.Mvvm.ComponentModel;
using MyApp.Core.Models;
using System;
using System.Collections.ObjectModel;

namespace MyApp.Features.FamilyList
{
    public partial class FamilyListViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Family> _families = new();

        public FamilyListViewModel()
        {
            // Load from repository
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
            _families.Add(new Family { Id = 1, Name = "Eda Family", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
        }

    }
}
