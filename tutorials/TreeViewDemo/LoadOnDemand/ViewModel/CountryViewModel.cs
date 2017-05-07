using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeViewDemo.DataModel;
using System.Collections.ObjectModel;

namespace TreeViewDemo.LoadOnDemand.ViewModel
{
    class CountryViewModel
    {
        readonly ReadOnlyCollection<RegionViewModel> _regions;

        public CountryViewModel(Region[] regions)
        {
            _regions = new ReadOnlyCollection<RegionViewModel>(
                (from region in regions
                 select new RegionViewModel(region))
                .ToList());
        }

        public ReadOnlyCollection<RegionViewModel> Regions
        {
            get { return _regions; }
        }
    }
}
