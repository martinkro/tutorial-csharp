using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatConsole
{
    public interface IIdentifierAttribute<T>
    {
        T ID { get; }
        T[] AddtionalIdList { get; }
    }
    public class AutoRegisterAttribute:Attribute
    {

    }
}
