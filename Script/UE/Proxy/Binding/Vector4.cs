using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FVector4
	{
		public double this[int ComponentIndex]
		{
			get => (double)FVector4Implementation.FVector4_GetSubscriptImplementation(GarbageCollectionHandle, ComponentIndex);

			set => FVector4Implementation.FVector4_SetSubscriptImplementation(GarbageCollectionHandle, ComponentIndex, value);
		}

		public FVector4(FVector InVector)
		{
			if (GetType() == typeof(FVector4))
			{
				FVector4Implementation.FVector4_FVector4Implementation(this, InVector?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FVector4(FLinearColor InColor)
		{
			if (GetType() == typeof(FVector4))
			{
				FVector4Implementation.FVector4_FVector41Implementation(this, InColor?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FVector4(FLinearColor InColor, double InOverrideW)
		{
			if (GetType() == typeof(FVector4))
			{
				FVector4Implementation.FVector4_FVector42Implementation(this, InColor?.GarbageCollectionHandle ?? nint.Zero, InOverrideW);
			}
		}

		public FVector4(double InX, double InY, double InZ, double InW)
		{
			if (GetType() == typeof(FVector4))
			{
				FVector4Implementation.FVector4_FVector43Implementation(this, InX, InY, InZ, InW);
			}
		}

		public FVector4(FVector2D InXY, FVector2D InZW)
		{
			if (GetType() == typeof(FVector4))
			{
				FVector4Implementation.FVector4_FVector44Implementation(this, InXY?.GarbageCollectionHandle ?? nint.Zero, InZW?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FVector4(EForceInit InValue0)
		{
			if (GetType() == typeof(FVector4))
			{
				FVector4Implementation.FVector4_FVector45Implementation(this, InValue0);
			}
		}

		public static FVector4 operator -(FVector4 InValue0)
		{
			return FVector4Implementation.FVector4_UnaryMinusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public static FVector4 operator +(FVector4 InValue0, FVector4 InValue1)
		{
			return FVector4Implementation.FVector4_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public static FVector4 operator -(FVector4 InValue0, FVector4 InValue1)
		{
			return FVector4Implementation.FVector4_Minus1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public static FVector4 operator *(FVector4 InValue0, FVector4 InValue1)
		{
			return FVector4Implementation.FVector4_MultipliesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public static FVector4 operator /(FVector4 InValue0, FVector4 InValue1)
		{
			return FVector4Implementation.FVector4_DividesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public static FVector4 operator ^(FVector4 InValue0, FVector4 InValue1)
		{
			return FVector4Implementation.FVector4_BitXorImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public static FVector4 operator *(FVector4 InValue0, int InValue1)
		{
			return FVector4Implementation.FVector4_Multiplies1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector4;
		}

		public static FVector4 operator *(FVector4 InValue0, float InValue1)
		{
			return FVector4Implementation.FVector4_Multiplies2Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector4;
		}

		public static FVector4 operator *(FVector4 InValue0, double InValue1)
		{
			return FVector4Implementation.FVector4_Multiplies3Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector4;
		}

		public static FVector4 operator *(int InValue0, FVector4 InValue1)
		{
			return FVector4Implementation.FVector4_Multiplies4Implementation(nint.Zero, InValue0, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public static FVector4 operator *(float InValue0, FVector4 InValue1)
		{
			return FVector4Implementation.FVector4_Multiplies5Implementation(nint.Zero, InValue0, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public static FVector4 operator *(double InValue0, FVector4 InValue1)
		{
			return FVector4Implementation.FVector4_Multiplies6Implementation(nint.Zero, InValue0, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public static FVector4 operator /(FVector4 InValue0, int InValue1)
		{
			return FVector4Implementation.FVector4_Divides1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector4;
		}

		public static FVector4 operator /(FVector4 InValue0, float InValue1)
		{
			return FVector4Implementation.FVector4_Divides2Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector4;
		}

		public static FVector4 operator /(FVector4 InValue0, double InValue1)
		{
			return FVector4Implementation.FVector4_Divides3Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FVector4;
		}

		public static FVector4 Zero()
		{
			return FVector4Implementation.FVector4_ZeroImplementation(nint.Zero) as FVector4;
		}

		public static FVector4 One()
		{
			return FVector4Implementation.FVector4_OneImplementation(nint.Zero) as FVector4;
		}

		public double Component(int Index)
		{
			return (double)FVector4Implementation.FVector4_ComponentImplementation(GarbageCollectionHandle, Index);
		}

		public bool Equals(FVector4 V, double Tolerance = 0.0001)
		{
			return (bool)FVector4Implementation.FVector4_EqualsImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}

		public bool IsUnit3(double LengthSquaredTolerance = 0.0001)
		{
			return (bool)FVector4Implementation.FVector4_IsUnit3Implementation(GarbageCollectionHandle, LengthSquaredTolerance);
		}

		public new FString ToString()
		{
			return FVector4Implementation.FVector4_ToStringImplementation(GarbageCollectionHandle) as FString;
		}

		public bool InitFromString(FString InSourceString)
		{
			return (bool)FVector4Implementation.FVector4_InitFromStringImplementation(GarbageCollectionHandle, InSourceString?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FVector4 GetSafeNormal(double Tolerance = 0.00000001)
		{
			return FVector4Implementation.FVector4_GetSafeNormalImplementation(GarbageCollectionHandle, Tolerance) as FVector4;
		}

		public FVector4 GetUnsafeNormal3()
		{
			return FVector4Implementation.FVector4_GetUnsafeNormal3Implementation(GarbageCollectionHandle) as FVector4;
		}

		public FRotator ToOrientationRotator()
		{
			return FVector4Implementation.FVector4_ToOrientationRotatorImplementation(GarbageCollectionHandle) as FRotator;
		}

		public FQuat ToOrientationQuat()
		{
			return FVector4Implementation.FVector4_ToOrientationQuatImplementation(GarbageCollectionHandle) as FQuat;
		}

		public FRotator Rotation()
		{
			return FVector4Implementation.FVector4_RotationImplementation(GarbageCollectionHandle) as FRotator;
		}

		public void Set(double InX, double InY, double InZ, double InW)
		{
			FVector4Implementation.FVector4_SetImplementation(GarbageCollectionHandle, InX, InY, InZ, InW);
		}

		public double Size3()
		{
			return (double)FVector4Implementation.FVector4_Size3Implementation(GarbageCollectionHandle);
		}

		public double SizeSquared3()
		{
			return (double)FVector4Implementation.FVector4_SizeSquared3Implementation(GarbageCollectionHandle);
		}

		public double Size()
		{
			return (double)FVector4Implementation.FVector4_SizeImplementation(GarbageCollectionHandle);
		}

		public double SizeSquared()
		{
			return (double)FVector4Implementation.FVector4_SizeSquaredImplementation(GarbageCollectionHandle);
		}

		public bool ContainsNaN()
		{
			return (bool)FVector4Implementation.FVector4_ContainsNaNImplementation(GarbageCollectionHandle);
		}

		public bool IsNearlyZero3(double Tolerance = 0.0001)
		{
			return (bool)FVector4Implementation.FVector4_IsNearlyZero3Implementation(GarbageCollectionHandle, Tolerance);
		}

		public FVector4 Reflect3(FVector4 Normal)
		{
			return FVector4Implementation.FVector4_Reflect3Implementation(GarbageCollectionHandle, Normal?.GarbageCollectionHandle ?? nint.Zero) as FVector4;
		}

		public void FindBestAxisVectors3(FVector4 Axis1, FVector4 Axis2)
		{
			FVector4Implementation.FVector4_FindBestAxisVectors3Implementation(GarbageCollectionHandle, Axis1?.GarbageCollectionHandle ?? nint.Zero, Axis2?.GarbageCollectionHandle ?? nint.Zero);
		}
	}
}