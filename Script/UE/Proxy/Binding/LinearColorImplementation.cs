using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FLinearColorImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor FLinearColor_GetWhiteImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor FLinearColor_GetGrayImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor FLinearColor_GetBlackImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor FLinearColor_GetTransparentImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor FLinearColor_GetRedImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor FLinearColor_GetGreenImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor FLinearColor_GetBlueImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor FLinearColor_GetYellowImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FLinearColor_FLinearColorImplementation(FLinearColor InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FLinearColor_FLinearColor1Implementation(FLinearColor InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FLinearColor_FLinearColor2Implementation(FLinearColor InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_PlusImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_MinusImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_MultipliesImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_DividesImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_Multiplies1Implementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_Divides1Implementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_ToRGBEImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_FromSRGBColorImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_FromPow22ColorImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_ComponentImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_GetClampedImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_EqualsImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_CopyWithNewOpacityImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_MakeFromHSV8Implementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_MakeRandomColorImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_MakeFromColorTemperatureImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_DistImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_EvaluateBezierImplementation(nint InObject, out object[] OutValue, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_LinearRGBToHSVImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_HSVToLinearRGBImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_LerpUsingHSVImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_QuantizeRoundImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_QuantizeFloorImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_ToFColorSRGBImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_ToFColorImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_DesaturateImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_GetLuminanceImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_GetMaxImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_IsAlmostBlackImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_GetMinImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_ToStringImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FLinearColor_InitFromStringImplementation(nint InObject, params object[] InValue);
	}
}