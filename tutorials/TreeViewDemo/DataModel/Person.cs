﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewDemo.DataModel
{
    class Person
    {
        readonly List<Person> _children = new List<Person>();
        public IList<Person> Children
        {
            get { return _children; }
        }

        public string Name { get; set; }
    }
}
