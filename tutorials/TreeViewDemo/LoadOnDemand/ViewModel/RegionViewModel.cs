using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeViewDemo.DataModel;
using TreeViewDemo.DataAccess;

namespace TreeViewDemo.LoadOnDemand.ViewModel
{
    class RegionViewModel:TreeViewItemViewModel
    {
        readonly Region _region;

        public RegionViewModel(Region region)
            : base(null, true)
        {
            _region = region;
        }

        public string RegionName
        {
            get { return _region.RegionName; }
        }

        protected override void LoadChildren()
        {
            foreach (State state in Database.GetStates(_region))
                base.Children.Add(new StateViewModel(state, this));
        }
    }
}
