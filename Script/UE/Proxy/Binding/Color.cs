using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FColor
	{
		public static FColor White
		{
			get => FColorImplementation.FColor_GetWhiteImplementation(nint.Zero);
		}

		public static FColor Black
		{
			get => FColorImplementation.FColor_GetBlackImplementation(nint.Zero);
		}

		public static FColor Transparent
		{
			get => FColorImplementation.FColor_GetTransparentImplementation(nint.Zero);
		}

		public static FColor Red
		{
			get => FColorImplementation.FColor_GetRedImplementation(nint.Zero);
		}

		public static FColor Green
		{
			get => FColorImplementation.FColor_GetGreenImplementation(nint.Zero);
		}

		public static FColor Blue
		{
			get => FColorImplementation.FColor_GetBlueImplementation(nint.Zero);
		}

		public static FColor Yellow
		{
			get => FColorImplementation.FColor_GetYellowImplementation(nint.Zero);
		}

		public static FColor Cyan
		{
			get => FColorImplementation.FColor_GetCyanImplementation(nint.Zero);
		}

		public static FColor Magenta
		{
			get => FColorImplementation.FColor_GetMagentaImplementation(nint.Zero);
		}

		public static FColor Orange
		{
			get => FColorImplementation.FColor_GetOrangeImplementation(nint.Zero);
		}

		public static FColor Purple
		{
			get => FColorImplementation.FColor_GetPurpleImplementation(nint.Zero);
		}

		public static FColor Turquoise
		{
			get => FColorImplementation.FColor_GetTurquoiseImplementation(nint.Zero);
		}

		public static FColor Silver
		{
			get => FColorImplementation.FColor_GetSilverImplementation(nint.Zero);
		}

		public static FColor Emerald
		{
			get => FColorImplementation.FColor_GetEmeraldImplementation(nint.Zero);
		}

		public FColor(byte R, byte G, byte B, byte A)
		{
			if (GetType() == typeof(FColor))
			{
				FColorImplementation.FColor_FColorImplementation(this, R, G, B, A);
			}
		}

		public FColor(uint InColor)
		{
			if (GetType() == typeof(FColor))
			{
				FColorImplementation.FColor_FColor1Implementation(this, InColor);
			}
		}

		public FLinearColor FromRGBE()
		{
			return FColorImplementation.FColor_FromRGBEImplementation(GarbageCollectionHandle) as FLinearColor;
		}

		public static FColor FromHex(FString HexString)
		{
			return FColorImplementation.FColor_FromHexImplementation(nint.Zero, HexString?.GarbageCollectionHandle ?? nint.Zero) as FColor;
		}

		public static FColor MakeRandomColor()
		{
			return FColorImplementation.FColor_MakeRandomColorImplementation(nint.Zero) as FColor;
		}

		public static FColor MakeRedToGreenColorFromScalar(float Scalar)
		{
			return FColorImplementation.FColor_MakeRedToGreenColorFromScalarImplementation(nint.Zero, Scalar) as FColor;
		}

		public static FColor MakeFromColorTemperature(float Temp)
		{
			return FColorImplementation.FColor_MakeFromColorTemperatureImplementation(nint.Zero, Temp) as FColor;
		}

		public static byte QuantizeUNormFloatTo8(float UnitFloat)
		{
			return (byte)FColorImplementation.FColor_QuantizeUNormFloatTo8Implementation(nint.Zero, UnitFloat);
		}

		public static ushort QuantizeUNormFloatTo16(float UnitFloat)
		{
			return (ushort)FColorImplementation.FColor_QuantizeUNormFloatTo16Implementation(nint.Zero, UnitFloat);
		}

		public static float DequantizeUNorm8ToFloat(int Value8)
		{
			return (float)FColorImplementation.FColor_DequantizeUNorm8ToFloatImplementation(nint.Zero, Value8);
		}

		public static float DequantizeUNorm16ToFloat(int Value16)
		{
			return (float)FColorImplementation.FColor_DequantizeUNorm16ToFloatImplementation(nint.Zero, Value16);
		}

		public static byte Requantize10to8(int Value10)
		{
			return (byte)FColorImplementation.FColor_Requantize10to8Implementation(nint.Zero, Value10);
		}

		public static byte Requantize16to8(int Value16)
		{
			return (byte)FColorImplementation.FColor_Requantize16to8Implementation(nint.Zero, Value16);
		}

		public static FColor MakeRequantizeFrom1010102(int R, int G, int B, int A)
		{
			return FColorImplementation.FColor_MakeRequantizeFrom1010102Implementation(nint.Zero, R, G, B, A) as FColor;
		}

		public FColor WithAlpha(byte Alpha)
		{
			return FColorImplementation.FColor_WithAlphaImplementation(GarbageCollectionHandle, Alpha) as FColor;
		}

		public FLinearColor ReinterpretAsLinear()
		{
			return FColorImplementation.FColor_ReinterpretAsLinearImplementation(GarbageCollectionHandle) as FLinearColor;
		}

		public FString ToHex()
		{
			return FColorImplementation.FColor_ToHexImplementation(GarbageCollectionHandle) as FString;
		}

		public new FString ToString()
		{
			return FColorImplementation.FColor_ToStringImplementation(GarbageCollectionHandle) as FString;
		}

		public bool InitFromString(FString InSourceString)
		{
			return (bool)FColorImplementation.FColor_InitFromStringImplementation(GarbageCollectionHandle, InSourceString?.GarbageCollectionHandle ?? nint.Zero);
		}

		public uint ToPackedARGB()
		{
			return (uint)FColorImplementation.FColor_ToPackedARGBImplementation(GarbageCollectionHandle);
		}

		public uint ToPackedABGR()
		{
			return (uint)FColorImplementation.FColor_ToPackedABGRImplementation(GarbageCollectionHandle);
		}

		public uint ToPackedRGBA()
		{
			return (uint)FColorImplementation.FColor_ToPackedRGBAImplementation(GarbageCollectionHandle);
		}

		public uint ToPackedBGRA()
		{
			return (uint)FColorImplementation.FColor_ToPackedBGRAImplementation(GarbageCollectionHandle);
		}
	}
}