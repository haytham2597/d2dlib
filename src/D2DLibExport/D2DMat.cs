using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace unvell.D2DLib
{
	public class D2DMat : D2DObject
	{
		public IntPtr Ptr => base.Handle;
		public int Width;
		public int Height;
		public int NumberChannel;
		public bool IsPtrValid()
		{
			return this.Ptr != IntPtr.Zero;
		}
		public D2DMat(HANDLE handle) : base(handle)
		{

		}
	}
}
