//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Runtime.InteropServices;

namespace Sample
{
	public class Test:MonoBehaviour
	{
		
		void Update()
		{
			// Debug.Log ("Loader::Update");
		}

		void OnGUI()
		{

		}
	}

	interface ITest1
	{
		void Print(string msg);
		int Add(int a, int b);
	}

	interface ITest2
	{
		void Log(string msg);
		int Sub(int a, int b);
	}

	abstract class ATest1
	{
		public abstract void Dump();
		public abstract int Mul(int a, int b);
	}

	class Test1:ATest1,ITest1,ITest2
	{
		public override void Dump(){Debug.Log ("Dump");}
		public override int Mul(int a, int b){
			return a * b;
		}

		public virtual void Print(string msg){
			Debug.Log ("Print");
		}

		public int Add(int a, int b){
			return a + b;
		}

		public virtual void Log(string msg){
			Debug.Log ("Log:" + msg);
		}

		public int Sub(int a, int b){
			return a - b;
		}
	}

	// Generic class
	class TestB<K,V> where K:class where V:struct
	{
		private K key = null;
		public V value = default(V);
		public void Dump(){
			Debug.Log (key.GetType ().Name);
			Debug.Log (value.GetType ().Name);
		}
	}

	public delegate void DelLogOutput(string msg);

	class TestC
	{
		public static int mCount = 0;
		private int mAge = 0;
		private string mName = "";
		public TestC(int age,string name){
			mAge = age;
			mName = name;
			mLogOutput += Log;
			mActionLog += Log;
			mCount++;
		}

		public int Age{
			get{ return mAge;}
			set{ mAge = value;}
		}

		public string Name{
			get{ return mName;}
			set{ mName = value;}
		}

		public static void Print(){
			Debug.Log ("Count:" + mCount);
		}

		void Log(string msg){
			Debug.Log ("Log:" + msg);
		}

		public event DelLogOutput mLogOutput;
		public Action<string> mActionLog;

	}

	class TestD
	{
		public void Swap<T>(ref T a, ref T b)
		{
			T t;
			t = a;
			a = b;
			b = t;
		}
	}

	struct SCoordinate{
		public int a;
		public int b;
		int c;
	}

	enum WeekDay{
		Sunday = 0,
		Monday = 1,
	}

	class TestE:TestB<Test1,SCoordinate>{
		public void DumpCoordinate()
		{
			value.a = 1;
			value.b = 2;
		}
	}

	class TestCase{
		public static void TestMain(){
			TestD d = new TestD ();
			int a = 1;
			int b = 2;
			d.Swap<int> (ref a, ref b);
			Debug.Log ("1+2=:" + 1);

			TestE e = new TestE ();
			e.Dump ();
		}

		[DllImport("__Internal")]
		public static extern int tss_unity_is_enable(byte[] data, int len);

		class NestedTest{
			public void Dump(){
				Debug.Log ("a=" + a);
				Debug.Log ("a=" + b);
			}
			private int a = 0;
			private int b = 0;
		}

		public static void RcvAntiData(byte[] data, ushort length)
		{
			IntPtr pv = Marshal.AllocHGlobal (2 + IntPtr.Size);
			if (pv != IntPtr.Zero) 
			{
				Marshal.WriteInt16 (pv,0,(short)length);
				//Marshal.WriteIntPtr (pv,2,(IntPtr)data);
				IntPtr p = Marshal.AllocHGlobal(data.Length);
				if (p != IntPtr.Zero)
				{
					Marshal.Copy (data,0,p, data.Length);
					Marshal.WriteIntPtr (pv,2,p);
					//tss_sdk_rcv_anti_data (pv);
					Marshal.FreeHGlobal(p);
				}
				
				Marshal.FreeHGlobal(pv);
			}
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class AntiDataInfo
	{
		//[FieldOffset(0)]
		public ushort anti_data_len;
		//[FieldOffset(2)]
		public IntPtr anti_data;
	};
	
	[StructLayout(LayoutKind.Explicit, Size = 20)]
	public class EncryptPkgInfo
	{
		[FieldOffset(0)]
		public int cmd_id_;				/* [in] game pkg cmd */
		[FieldOffset(4)]
		public IntPtr game_pkg_;		/* [in] game pkg */
		[FieldOffset(8)]
		public uint game_pkg_len_;		/* [in] the length of game data packets, maximum length less than 65,000 */
		[FieldOffset(12)]
		public IntPtr encrpty_data_;	/* [in/out] assembling encrypted game data package into anti data, memory allocated by the caller, 64k at the maximum */
		[FieldOffset(16)]
		public uint encrypt_data_len_;	/* [in/out] length of anti_data when input, actual length of anti_data when output */
	}
	
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	public class DecryptPkgInfo
	{
		[FieldOffset(0)]
		public IntPtr encrypt_data_;		/* [in] anti data received by game client */
		[FieldOffset(4)]
		public uint encrypt_data_len;       /* [in] length of anti data received by game client */
		[FieldOffset(8)]
		public IntPtr game_pkg_;            /* [out] buffer used to store the decrypted game package, space allocated by the caller */
		[FieldOffset(12)]
		public uint game_pkg_len_;          /* [out] input is size of game_pkg_, output is the actual length of decrypted game package */
	}

}

