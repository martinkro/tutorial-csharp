using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatConsole
{
    public class CheatCommandName
    {
        public string BaseName { get; protected set; }
        public string GroupName { get; protected set; }

        public string RawName { get; protected set; }
        public string[] GroupHierarchies { get; protected set; }
    }

    [AttributeUsage(AttributeTargets.Class,AllowMultiple =false)]
    public class CheatCommandAttribute:AutoRegisterAttribute,
        IIdentifierAttribute<string>
    {
        public CheatCommandName Command { get; protected set; }
        public CheatCommandAttribute(string expression,
            string comment,
            int messageId)
        {

        }

        public string ID
        {
            get
            {
                return Command.BaseName;
            }
        }

        public string[] AddtionalIdList
        {
            get
            {
                return null;
            }
        }
    }
}
