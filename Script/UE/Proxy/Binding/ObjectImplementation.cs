using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Library
{
	public static partial class UObjectImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object UObject_GetWorldImplementation(nint InObject);
	}
}