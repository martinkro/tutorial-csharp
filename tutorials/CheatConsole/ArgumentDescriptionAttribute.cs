using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatConsole
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]
    public class ArgumentDescriptionAttribute:Attribute
    {
        public enum DEFAULT_VALUE_TAG
        {
            TAG
        }
        public ArgumentDescriptionAttribute(int index,
            Type argumentType,
            string name,
            params object[] dependencies)
        {

        }

        public ArgumentDescriptionAttribute(Type argumentType,
            string name,
            params object[] dependencies):this(0,argumentType,name,dependencies)
        {

        }

        public ArgumentDescriptionAttribute(DEFAULT_VALUE_TAG tag,
            int index,
            Type argumentType,
            string name,
            string defaultValue,
            params object[] dependencies):
            this(index,argumentType,name,dependencies)
        {

        }
    }
}
