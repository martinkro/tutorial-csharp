using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICSharpCode.TreeViewDemo
{
    class AssemblyListTreeNode:ITreeViewNode
    {
        public AssemblyListTreeNode()
        {
            IsChecked = false;
        }

        public override object Text
        {
            get { return "UnityEngine"; }
        }

        public override bool IsCheckable
        {
            get
            {
                return true;
            }
        }

        private void LoadChildrenNode()
        {
            
        }
    }
}
