using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FLinearColor
	{
		public static FLinearColor White
		{
			get => FLinearColorImplementation.FLinearColor_GetWhiteImplementation(nint.Zero);
		}

		public static FLinearColor Gray
		{
			get => FLinearColorImplementation.FLinearColor_GetGrayImplementation(nint.Zero);
		}

		public static FLinearColor Black
		{
			get => FLinearColorImplementation.FLinearColor_GetBlackImplementation(nint.Zero);
		}

		public static FLinearColor Transparent
		{
			get => FLinearColorImplementation.FLinearColor_GetTransparentImplementation(nint.Zero);
		}

		public static FLinearColor Red
		{
			get => FLinearColorImplementation.FLinearColor_GetRedImplementation(nint.Zero);
		}

		public static FLinearColor Green
		{
			get => FLinearColorImplementation.FLinearColor_GetGreenImplementation(nint.Zero);
		}

		public static FLinearColor Blue
		{
			get => FLinearColorImplementation.FLinearColor_GetBlueImplementation(nint.Zero);
		}

		public static FLinearColor Yellow
		{
			get => FLinearColorImplementation.FLinearColor_GetYellowImplementation(nint.Zero);
		}

		public FLinearColor(EForceInit InValue0)
		{
			if (GetType() == typeof(FLinearColor))
			{
				FLinearColorImplementation.FLinearColor_FLinearColorImplementation(this, InValue0);
			}
		}

		public FLinearColor(float InR, float InG, float InB, float InA)
		{
			if (GetType() == typeof(FLinearColor))
			{
				FLinearColorImplementation.FLinearColor_FLinearColor1Implementation(this, InR, InG, InB, InA);
			}
		}

		public FLinearColor(FColor Color)
		{
			if (GetType() == typeof(FLinearColor))
			{
				FLinearColorImplementation.FLinearColor_FLinearColor2Implementation(this, Color?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public static FLinearColor operator +(FLinearColor InValue0, FLinearColor InValue1)
		{
			return FLinearColorImplementation.FLinearColor_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FLinearColor;
		}

		public static FLinearColor operator -(FLinearColor InValue0, FLinearColor InValue1)
		{
			return FLinearColorImplementation.FLinearColor_MinusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FLinearColor;
		}

		public static FLinearColor operator *(FLinearColor InValue0, FLinearColor InValue1)
		{
			return FLinearColorImplementation.FLinearColor_MultipliesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FLinearColor;
		}

		public static FLinearColor operator /(FLinearColor InValue0, FLinearColor InValue1)
		{
			return FLinearColorImplementation.FLinearColor_DividesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FLinearColor;
		}

		public static FLinearColor operator *(FLinearColor InValue0, float InValue1)
		{
			return FLinearColorImplementation.FLinearColor_Multiplies1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FLinearColor;
		}

		public static FLinearColor operator /(FLinearColor InValue0, float InValue1)
		{
			return FLinearColorImplementation.FLinearColor_Divides1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FLinearColor;
		}

		public FColor ToRGBE()
		{
			return FLinearColorImplementation.FLinearColor_ToRGBEImplementation(GarbageCollectionHandle) as FColor;
		}

		public static FLinearColor FromSRGBColor(FColor Color)
		{
			return FLinearColorImplementation.FLinearColor_FromSRGBColorImplementation(nint.Zero, Color?.GarbageCollectionHandle ?? nint.Zero) as FLinearColor;
		}

		public static FLinearColor FromPow22Color(FColor Color)
		{
			return FLinearColorImplementation.FLinearColor_FromPow22ColorImplementation(nint.Zero, Color?.GarbageCollectionHandle ?? nint.Zero) as FLinearColor;
		}

		public float Component(int Index)
		{
			return (float)FLinearColorImplementation.FLinearColor_ComponentImplementation(GarbageCollectionHandle, Index);
		}

		public FLinearColor GetClamped(float InMin = 0.0f, float InMax = 1.0f)
		{
			return FLinearColorImplementation.FLinearColor_GetClampedImplementation(GarbageCollectionHandle, InMin, InMax) as FLinearColor;
		}

		public bool Equals(FLinearColor ColorB, float Tolerance = 0.0001f)
		{
			return (bool)FLinearColorImplementation.FLinearColor_EqualsImplementation(GarbageCollectionHandle, ColorB?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public FLinearColor CopyWithNewOpacity(float NewOpacicty)
		{
			return FLinearColorImplementation.FLinearColor_CopyWithNewOpacityImplementation(GarbageCollectionHandle, NewOpacicty) as FLinearColor;
		}

		public static FLinearColor MakeFromHSV8(byte H, byte S, byte V)
		{
			return FLinearColorImplementation.FLinearColor_MakeFromHSV8Implementation(nint.Zero, H, S, V) as FLinearColor;
		}

		public static FLinearColor MakeRandomColor()
		{
			return FLinearColorImplementation.FLinearColor_MakeRandomColorImplementation(nint.Zero) as FLinearColor;
		}

		public static FLinearColor MakeFromColorTemperature(float Temp)
		{
			return FLinearColorImplementation.FLinearColor_MakeFromColorTemperatureImplementation(nint.Zero, Temp) as FLinearColor;
		}

		public static float Dist(FLinearColor V1, FLinearColor V2)
		{
			return (float)FLinearColorImplementation.FLinearColor_DistImplementation(nint.Zero, V1?.GarbageCollectionHandle ?? nint.Zero, V2?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static float EvaluateBezier(FLinearColor ControlPoints, int NumPoints, ref TArray<FLinearColor> OutPoints)
		{
			var __ReturnValue = FLinearColorImplementation.FLinearColor_EvaluateBezierImplementation(nint.Zero, out var __OutValue, ControlPoints?.GarbageCollectionHandle ?? nint.Zero, NumPoints, OutPoints?.GarbageCollectionHandle ?? nint.Zero);

			OutPoints = __OutValue[0] as TArray<FLinearColor>;

			return (float)__ReturnValue;
		}

		public FLinearColor LinearRGBToHSV()
		{
			return FLinearColorImplementation.FLinearColor_LinearRGBToHSVImplementation(GarbageCollectionHandle) as FLinearColor;
		}

		public FLinearColor HSVToLinearRGB()
		{
			return FLinearColorImplementation.FLinearColor_HSVToLinearRGBImplementation(GarbageCollectionHandle) as FLinearColor;
		}

		public static FLinearColor LerpUsingHSV(FLinearColor From, FLinearColor To, float Progress)
		{
			return FLinearColorImplementation.FLinearColor_LerpUsingHSVImplementation(nint.Zero, From?.GarbageCollectionHandle ?? nint.Zero, To?.GarbageCollectionHandle ?? nint.Zero, Progress) as FLinearColor;
		}

		public FColor QuantizeRound()
		{
			return FLinearColorImplementation.FLinearColor_QuantizeRoundImplementation(GarbageCollectionHandle) as FColor;
		}

		public FColor QuantizeFloor()
		{
			return FLinearColorImplementation.FLinearColor_QuantizeFloorImplementation(GarbageCollectionHandle) as FColor;
		}

		public FColor ToFColorSRGB()
		{
			return FLinearColorImplementation.FLinearColor_ToFColorSRGBImplementation(GarbageCollectionHandle) as FColor;
		}

		public FColor ToFColor(bool bSRGB)
		{
			return FLinearColorImplementation.FLinearColor_ToFColorImplementation(GarbageCollectionHandle, bSRGB) as FColor;
		}

		public FLinearColor Desaturate(float Desaturation)
		{
			return FLinearColorImplementation.FLinearColor_DesaturateImplementation(GarbageCollectionHandle, Desaturation) as FLinearColor;
		}

		public float GetLuminance()
		{
			return (float)FLinearColorImplementation.FLinearColor_GetLuminanceImplementation(GarbageCollectionHandle);
		}

		public float GetMax()
		{
			return (float)FLinearColorImplementation.FLinearColor_GetMaxImplementation(GarbageCollectionHandle);
		}

		public bool IsAlmostBlack()
		{
			return (bool)FLinearColorImplementation.FLinearColor_IsAlmostBlackImplementation(GarbageCollectionHandle);
		}

		public float GetMin()
		{
			return (float)FLinearColorImplementation.FLinearColor_GetMinImplementation(GarbageCollectionHandle);
		}

		public new FString ToString()
		{
			return FLinearColorImplementation.FLinearColor_ToStringImplementation(GarbageCollectionHandle) as FString;
		}

		public bool InitFromString(FString InSourceString)
		{
			return (bool)FLinearColorImplementation.FLinearColor_InitFromStringImplementation(GarbageCollectionHandle, InSourceString?.GarbageCollectionHandle ?? nint.Zero);
		}
	}
}