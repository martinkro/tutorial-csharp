using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


    public class StringData
    {
        ObservableCollection<string> lst = new ObservableCollection<string>();
        public StringData()
        {
            lst.Add("Abhishek");
            lst.Add("Abhijit");
            lst.Add("Kunal");
            lst.Add("Sheo");
        }

        public ObservableCollection<string> GetStrings()
        {
            return lst;
        }
    }

