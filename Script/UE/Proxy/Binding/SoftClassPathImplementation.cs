using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FSoftClassPathImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FSoftClassPath_FSoftClassPathImplementation(FSoftClassPath InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FSoftClassPath_FSoftClassPath1Implementation(FSoftClassPath InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FSoftClassPath_FSoftClassPath2Implementation(FSoftClassPath InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftClassPath_ResolveClassImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FSoftClassPath_GetOrCreateIDForClassImplementation(nint InObject, params object[] InValue);
	}
}