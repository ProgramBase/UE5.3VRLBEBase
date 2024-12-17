using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FVector2D
	{
		public double this[int Index]
		{
			get => (double)FVector2DImplementation.FVector2D_GetSubscriptImplementation(GarbageCollectionHandle, Index);

			set => FVector2DImplementation.FVector2D_SetSubscriptImplementation(GarbageCollectionHandle, Index, value);
		}

		public static FVector2D ZeroVector
		{
			get => FVector2DImplementation.FVector2D_GetZeroVectorImplementation(nint.Zero);
		}

		public static FVector2D UnitVector
		{
			get => FVector2DImplementation.FVector2D_GetUnitVectorImplementation(nint.Zero);
		}

		public static FVector2D Unit45Deg
		{
			get => FVector2DImplementation.FVector2D_GetUnit45DegImplementation(nint.Zero);
		}

		public FVector2D(double InX, double InY)
		{
			if (GetType() == typeof(FVector2D))
			{
				FVector2DImplementation.FVector2D_FVector2DImplementation(this, InX, InY);
			}
		}

		public FVector2D(double InF)
		{
			if (GetType() == typeof(FVector2D))
			{
				FVector2DImplementation.FVector2D_FVector2D1Implementation(this, InF);
			}
		}

		public FVector2D(FIntPoint InPos)
		{
			if (GetType() == typeof(FVector2D))
			{
				FVector2DImplementation.FVector2D_FVector2D2Implementation(this, InPos?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FVector2D(EForceInit InValue0)
		{
			if (GetType() == typeof(FVector2D))
			{
				FVector2DImplementation.FVector2D_FVector2D3Implementation(this, InValue0);
			}
		}

		public FVector2D(FVector V)
		{
			if (GetType() == typeof(FVector2D))
			{
				FVector2DImplementation.FVector2D_FVector2D4Implementation(this, V?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FVector2D(FVector4 V)
		{
			if (GetType() == typeof(FVector2D))
			{
				FVector2DImplementation.FVector2D_FVector2D5Implementation(this, V?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public static FVector2D operator +(FVector2D InValue0, FVector2D InValue1)
		{
			return FVector2DImplementation.FVector2D_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector2D;
		}

		public static FVector2D operator -(FVector2D InValue0, FVector2D InValue1)
		{
			return FVector2DImplementation.FVector2D_MinusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector2D;
		}

		public static FVector2D operator *(FVector2D InValue0, FVector2D InValue1)
		{
			return FVector2DImplementation.FVector2D_MultipliesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector2D;
		}

		public static FVector2D operator /(FVector2D InValue0, FVector2D InValue1)
		{
			return FVector2DImplementation.FVector2D_DividesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector2D;
		}

		public static FVector2D operator -(FVector2D InValue0)
		{
			return FVector2DImplementation.FVector2D_UnaryMinus1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero) as FVector2D;
		}

		public static FVector2D operator *(FVector2D InValue0, double InValue1)
		{
			return FVector2DImplementation.FVector2D_Multiplies1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector2D;
		}

		public static FVector2D operator *(int InValue0, FVector2D InValue1)
		{
			return FVector2DImplementation.FVector2D_Multiplies2Implementation(nint.Zero, InValue0, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector2D;
		}

		public static FVector2D operator *(float InValue0, FVector2D InValue1)
		{
			return FVector2DImplementation.FVector2D_Multiplies3Implementation(nint.Zero, InValue0, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector2D;
		}

		public static FVector2D operator *(double InValue0, FVector2D InValue1)
		{
			return FVector2DImplementation.FVector2D_Multiplies4Implementation(nint.Zero, InValue0, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector2D;
		}

		public static FVector2D operator /(FVector2D InValue0, double InValue1)
		{
			return FVector2DImplementation.FVector2D_Divides1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector2D;
		}

		public static FVector2D operator +(FVector2D InValue0, double InValue1)
		{
			return FVector2DImplementation.FVector2D_Plus1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector2D;
		}

		public static FVector2D operator -(FVector2D InValue0, double InValue1)
		{
			return FVector2DImplementation.FVector2D_Minus2Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector2D;
		}

		public static double operator |(FVector2D InValue0, FVector2D InValue1)
		{
			return (double)FVector2DImplementation.FVector2D_BitOrImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double operator ^(FVector2D InValue0, FVector2D InValue1)
		{
			return (double)FVector2DImplementation.FVector2D_BitXorImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FVector2D Zero()
		{
			return FVector2DImplementation.FVector2D_ZeroImplementation(nint.Zero) as FVector2D;
		}

		public static FVector2D One()
		{
			return FVector2DImplementation.FVector2D_OneImplementation(nint.Zero) as FVector2D;
		}

		public static FVector2D UnitX()
		{
			return FVector2DImplementation.FVector2D_UnitXImplementation(nint.Zero) as FVector2D;
		}

		public static FVector2D UnitY()
		{
			return FVector2DImplementation.FVector2D_UnitYImplementation(nint.Zero) as FVector2D;
		}

		public bool ComponentwiseAllLessThan(FVector2D InValue0)
		{
			return (bool)FVector2DImplementation.FVector2D_ComponentwiseAllLessThanImplementation(GarbageCollectionHandle, InValue0?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool ComponentwiseAllGreaterThan(FVector2D InValue0)
		{
			return (bool)FVector2DImplementation.FVector2D_ComponentwiseAllGreaterThanImplementation(GarbageCollectionHandle, InValue0?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool ComponentwiseAllLessOrEqual(FVector2D InValue0)
		{
			return (bool)FVector2DImplementation.FVector2D_ComponentwiseAllLessOrEqualImplementation(GarbageCollectionHandle, InValue0?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool ComponentwiseAllGreaterOrEqual(FVector2D InValue0)
		{
			return (bool)FVector2DImplementation.FVector2D_ComponentwiseAllGreaterOrEqualImplementation(GarbageCollectionHandle, InValue0?.GarbageCollectionHandle ?? nint.Zero);
		}

		public double Component(int Index)
		{
			return (double)FVector2DImplementation.FVector2D_ComponentImplementation(GarbageCollectionHandle, Index);
		}

		public static double DotProduct(FVector2D A, FVector2D B)
		{
			return (double)FVector2DImplementation.FVector2D_DotProductImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double DistSquared(FVector2D V1, FVector2D V2)
		{
			return (double)FVector2DImplementation.FVector2D_DistSquaredImplementation(nint.Zero, V1?.GarbageCollectionHandle ?? nint.Zero, V2?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double Distance(FVector2D V1, FVector2D V2)
		{
			return (double)FVector2DImplementation.FVector2D_DistanceImplementation(nint.Zero, V1?.GarbageCollectionHandle ?? nint.Zero, V2?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double CrossProduct(FVector2D A, FVector2D B)
		{
			return (double)FVector2DImplementation.FVector2D_CrossProductImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FVector2D Max(FVector2D A, FVector2D B)
		{
			return FVector2DImplementation.FVector2D_MaxImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FVector2D;
		}

		public static FVector2D Min(FVector2D A, FVector2D B)
		{
			return FVector2DImplementation.FVector2D_MinImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FVector2D;
		}

		public bool Equals(FVector2D V, double Tolerance = 0.0001)
		{
			return (bool)FVector2DImplementation.FVector2D_EqualsImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public void Set(double InX, double InY)
		{
			FVector2DImplementation.FVector2D_SetImplementation(GarbageCollectionHandle, InX, InY);
		}

		public double GetMax()
		{
			return (double)FVector2DImplementation.FVector2D_GetMaxImplementation(GarbageCollectionHandle);
		}

		public double GetAbsMax()
		{
			return (double)FVector2DImplementation.FVector2D_GetAbsMaxImplementation(GarbageCollectionHandle);
		}

		public double GetMin()
		{
			return (double)FVector2DImplementation.FVector2D_GetMinImplementation(GarbageCollectionHandle);
		}

		public double Size()
		{
			return (double)FVector2DImplementation.FVector2D_SizeImplementation(GarbageCollectionHandle);
		}

		public double Length()
		{
			return (double)FVector2DImplementation.FVector2D_LengthImplementation(GarbageCollectionHandle);
		}

		public double SizeSquared()
		{
			return (double)FVector2DImplementation.FVector2D_SizeSquaredImplementation(GarbageCollectionHandle);
		}

		public double SquaredLength()
		{
			return (double)FVector2DImplementation.FVector2D_SquaredLengthImplementation(GarbageCollectionHandle);
		}

		public double Dot(FVector2D V2)
		{
			return (double)FVector2DImplementation.FVector2D_DotImplementation(GarbageCollectionHandle, V2?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FVector2D GetRotated(double AngleDeg)
		{
			return FVector2DImplementation.FVector2D_GetRotatedImplementation(GarbageCollectionHandle, AngleDeg) as FVector2D;
		}

		public FVector2D GetSafeNormal(double Tolerance = 0.00000001)
		{
			return FVector2DImplementation.FVector2D_GetSafeNormalImplementation(GarbageCollectionHandle, Tolerance) as FVector2D;
		}

		public bool Normalize(double Tolerance = 0.00000001)
		{
			return (bool)FVector2DImplementation.FVector2D_NormalizeImplementation(GarbageCollectionHandle, Tolerance);
		}

		public bool IsNearlyZero(double Tolerance = 0.0001)
		{
			return (bool)FVector2DImplementation.FVector2D_IsNearlyZeroImplementation(GarbageCollectionHandle, Tolerance);
		}

		public void ToDirectionAndLength(FVector2D OutDir, ref double OutLength)
		{
			FVector2DImplementation.FVector2D_ToDirectionAndLengthImplementation(GarbageCollectionHandle, out var __OutValue, OutDir?.GarbageCollectionHandle ?? nint.Zero, OutLength);

			OutLength = (double)__OutValue[0];
		}

		public void ToDirectionAndLength(FVector2D OutDir, ref float OutLength)
		{
			FVector2DImplementation.FVector2D_ToDirectionAndLength1Implementation(GarbageCollectionHandle, out var __OutValue, OutDir?.GarbageCollectionHandle ?? nint.Zero, OutLength);

			OutLength = (float)__OutValue[0];
		}

		public bool IsZero()
		{
			return (bool)FVector2DImplementation.FVector2D_IsZeroImplementation(GarbageCollectionHandle);
		}

		public FIntPoint IntPoint()
		{
			return FVector2DImplementation.FVector2D_IntPointImplementation(GarbageCollectionHandle) as FIntPoint;
		}

		public FVector2D RoundToVector()
		{
			return FVector2DImplementation.FVector2D_RoundToVectorImplementation(GarbageCollectionHandle) as FVector2D;
		}

		public FVector2D ClampAxes(double MinAxisVal, double MaxAxisVal)
		{
			return FVector2DImplementation.FVector2D_ClampAxesImplementation(GarbageCollectionHandle, MinAxisVal, MaxAxisVal) as FVector2D;
		}

		public FVector2D GetSignVector()
		{
			return FVector2DImplementation.FVector2D_GetSignVectorImplementation(GarbageCollectionHandle) as FVector2D;
		}

		public FVector2D GetAbs()
		{
			return FVector2DImplementation.FVector2D_GetAbsImplementation(GarbageCollectionHandle) as FVector2D;
		}

		public new FString ToString()
		{
			return FVector2DImplementation.FVector2D_ToStringImplementation(GarbageCollectionHandle) as FString;
		}

		public bool InitFromString(FString InSourceString)
		{
			return (bool)FVector2DImplementation.FVector2D_InitFromStringImplementation(GarbageCollectionHandle, InSourceString?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool ContainsNaN()
		{
			return (bool)FVector2DImplementation.FVector2D_ContainsNaNImplementation(GarbageCollectionHandle);
		}

		public FVector SphericalToUnitCartesian()
		{
			return FVector2DImplementation.FVector2D_SphericalToUnitCartesianImplementation(GarbageCollectionHandle) as FVector;
		}
	}
}