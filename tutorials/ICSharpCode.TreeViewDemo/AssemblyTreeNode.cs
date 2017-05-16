using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICSharpCode.TreeViewDemo
{
    class AssemblyTreeNode:ITreeViewNode
    {
        private string name;
        public AssemblyTreeNode(string name)
        {
            this.name = name;
        }

        public override bool IsCheckable
        {
            get
            {
                return true;
            }
        }

        public override object Text
        {
            get
            {
                return string.IsNullOrEmpty(name) ? "NULL" : name;
            }
        }
    }
}
