using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.TreeView;

namespace ICSharpCode.TreeViewDemo
{
    abstract class ITreeViewNode:SharpTreeNode
    {
        public override bool IsCheckable
        {
            get
            {
                return true;
            }
        }
    }
}
