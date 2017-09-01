using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace HelloWorld
{
    enum MonthDay
    {
        Monday=1,
        Friday=2
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,NET 4.0");

            RuntimeCompatibilityAttribute attr = new RuntimeCompatibilityAttribute();
            FileStream fileStream = new FileStream("f:\\temp.dat", FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(fileStream, attr);

            string s = attr.ToString();
            string classname = "ActorInfo";
            string tx = string.Format("static StringItem s_{0}-{0}Methods[]={{", classname);
            Console.WriteLine(tx);
            Type type = typeof(Program);
            if (type.Name == "Program")
            {
                // Name=>  
            }
            Console.WriteLine("Type Name:" + type.Name);
            Console.WriteLine("Type Name:" + type.FullName);

            Type t = Type.GetType("HelloWorld.Program");

            Program p = (Program)Activator.CreateInstance(t);
            p.test();

            MethodInfo method = t.GetMethod("test");
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance;
            object[] parameters = new object[] { };
            object returnValue = method.Invoke(p, parameters);

            MonthDay e1 = MonthDay.Monday;
            Console.WriteLine("e:" + e1.ToString());

            Object o = Enum.Parse(typeof(MonthDay), "Monday");
            MonthDay o1 = (MonthDay)o;

            Console.WriteLine("MonthDay:" + o1);

        }

        public void test()
        {
            Console.WriteLine("Test");
        }
    }
}
