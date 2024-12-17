using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FColorImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetWhiteImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetBlackImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetTransparentImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetRedImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetGreenImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetBlueImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetYellowImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetCyanImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetMagentaImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetOrangeImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetPurpleImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetTurquoiseImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetSilverImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor FColor_GetEmeraldImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FColor_FColorImplementation(FColor InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FColor_FColor1Implementation(FColor InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_FromRGBEImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_FromHexImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_MakeRandomColorImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_MakeRedToGreenColorFromScalarImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_MakeFromColorTemperatureImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_QuantizeUNormFloatTo8Implementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_QuantizeUNormFloatTo16Implementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_DequantizeUNorm8ToFloatImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_DequantizeUNorm16ToFloatImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_Requantize10to8Implementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_Requantize16to8Implementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_MakeRequantizeFrom1010102Implementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_WithAlphaImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_ReinterpretAsLinearImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_ToHexImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_ToStringImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_InitFromStringImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_ToPackedARGBImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_ToPackedABGRImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_ToPackedRGBAImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FColor_ToPackedBGRAImplementation(nint InObject);
	}
}