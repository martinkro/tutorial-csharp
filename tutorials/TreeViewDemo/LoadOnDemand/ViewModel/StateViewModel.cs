using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeViewDemo.DataModel;
using TreeViewDemo.DataAccess;

namespace TreeViewDemo.LoadOnDemand.ViewModel
{
    class StateViewModel: TreeViewItemViewModel
    {
        readonly State _state;

        public StateViewModel(State state, RegionViewModel parentRegion)
            : base(parentRegion, true)
        {
            _state = state;
        }

        public string StateName
        {
            get { return _state.StateName; }
        }

        protected override void LoadChildren()
        {
            foreach (City city in Database.GetCities(_state))
                base.Children.Add(new CityViewModel(city, this));
        }
    }
}
