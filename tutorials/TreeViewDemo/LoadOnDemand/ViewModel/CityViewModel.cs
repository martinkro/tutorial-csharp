using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeViewDemo.DataModel;

namespace TreeViewDemo.LoadOnDemand.ViewModel
{
    class CityViewModel:TreeViewItemViewModel
    {
        readonly City _city;

        public CityViewModel(City city, StateViewModel parentState)
            : base(parentState, false)
        {
            _city = city;
        }

        public string CityName
        {
            get { return _city.CityName; }
        }
    }
}
