using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICSharpCode.TreeViewDemo
{
    class AssemblyListTreeNode:ITreeViewNode
    {
        private static List<string> assemblies = new List<string>
        {
            "Assembly-CSharp.dll",
            "Assembly-CSharp-firstpass.dll"
        };
        public AssemblyListTreeNode()
        {
            IsChecked = false;
            LoadChildrenNode();
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
            this.Children.Clear();
            foreach(var name in assemblies)
            {
                var child = new AssemblyTreeNode(name);
                this.Children.Add(child);
            }
        }
    }
}
