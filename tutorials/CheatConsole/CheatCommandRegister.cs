using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CheatConsole
{
    public class CheatCommandRegister:Singleton<CheatCommandRegister>
    {
        public void Register(Assembly assembly)
        {

        }

        protected void RegisterCommonCommand(Assembly assembly)
        {
            Type[] types = assembly.GetTypes();
            int i;
            for(i = 0; i < types.Length; i++)
            {
                Type t = types[i];
                object[] attributes = t.GetCustomAttributes(typeof(CheatCommandAttribute), true);
            }
        }

        protected void RegisterMethodCommand(Assembly assembly)
        {

        }
    }
}
