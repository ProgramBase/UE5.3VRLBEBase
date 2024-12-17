using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Library
{
	public static partial class UClassImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UObject UClass_GetClassDefaultObjectImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object UClass_GetDefaultObjectImplementation(nint InObject, params object[] InValue);
	}
}