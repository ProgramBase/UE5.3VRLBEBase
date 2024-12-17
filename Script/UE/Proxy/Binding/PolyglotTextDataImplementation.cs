using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FPolyglotTextDataImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FPolyglotTextData_FPolyglotTextDataImplementation(FPolyglotTextData InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FPolyglotTextData_SetCategoryImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPolyglotTextData_GetCategoryImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FPolyglotTextData_SetCategory1Implementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPolyglotTextData_GetNativeCultureImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPolyglotTextData_ResolveNativeCultureImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPolyglotTextData_GetLocalizedCulturesImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FPolyglotTextData_SetIdentityImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FPolyglotTextData_GetIdentityImplementation(nint InObject, out object[] OutValue, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPolyglotTextData_GetNamespaceImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPolyglotTextData_GetKeyImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FPolyglotTextData_SetNativeStringImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPolyglotTextData_GetNativeStringImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FPolyglotTextData_AddLocalizedStringImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FPolyglotTextData_RemoveLocalizedStringImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPolyglotTextData_GetLocalizedStringImplementation(nint InObject, out object[] OutValue, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FPolyglotTextData_ClearLocalizedStringsImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FPolyglotTextData_IsMinimalPatchImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPolyglotTextData_IsMinimalPatch1Implementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FPolyglotTextData_GetTextImplementation(nint InObject);
	}
}