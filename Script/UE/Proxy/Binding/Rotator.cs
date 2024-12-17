using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FRotator
	{
		public FRotator(double InF)
		{
			if (GetType() == typeof(FRotator))
			{
				FRotatorImplementation.FRotator_FRotatorImplementation(this, InF);
			}
		}

		public FRotator(double InPitch, double InYaw, double InRoll)
		{
			if (GetType() == typeof(FRotator))
			{
				FRotatorImplementation.FRotator_FRotator1Implementation(this, InPitch, InYaw, InRoll);
			}
		}

		public FRotator(EForceInit InValue0)
		{
			if (GetType() == typeof(FRotator))
			{
				FRotatorImplementation.FRotator_FRotator2Implementation(this, InValue0);
			}
		}

		public FRotator(FQuat Quat)
		{
			if (GetType() == typeof(FRotator))
			{
				FRotatorImplementation.FRotator_FRotator3Implementation(this, Quat?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public static FRotator operator +(FRotator InValue0, FRotator InValue1)
		{
			return FRotatorImplementation.FRotator_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FRotator;
		}

		public static FRotator operator -(FRotator InValue0, FRotator InValue1)
		{
			return FRotatorImplementation.FRotator_MinusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FRotator;
		}

		public static FRotator operator *(FRotator InValue0, int InValue1)
		{
			return FRotatorImplementation.FRotator_MultipliesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FRotator;
		}

		public static FRotator operator *(FRotator InValue0, float InValue1)
		{
			return FRotatorImplementation.FRotator_Multiplies1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FRotator;
		}

		public static FRotator operator *(FRotator InValue0, double InValue1)
		{
			return FRotatorImplementation.FRotator_Multiplies2Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FRotator;
		}

		public bool IsNearlyZero(double Tolerance = 0.0001)
		{
			return (bool)FRotatorImplementation.FRotator_IsNearlyZeroImplementation(GarbageCollectionHandle, Tolerance);
		}

		public bool IsZero()
		{
			return (bool)FRotatorImplementation.FRotator_IsZeroImplementation(GarbageCollectionHandle);
		}

		public bool Equals(double Tolerance = 0.0001)
		{
			return (bool)FRotatorImplementation.FRotator_EqualsImplementation(GarbageCollectionHandle, Tolerance);
		}

		public FRotator Add(double DeltaPitch, double DeltaYaw, double DeltaRoll)
		{
			return FRotatorImplementation.FRotator_AddImplementation(GarbageCollectionHandle, DeltaPitch, DeltaYaw, DeltaRoll) as FRotator;
		}

		public FRotator GetInverse()
		{
			return FRotatorImplementation.FRotator_GetInverseImplementation(GarbageCollectionHandle) as FRotator;
		}

		public FRotator GridSnap(FRotator RotGrid)
		{
			return FRotatorImplementation.FRotator_GridSnapImplementation(GarbageCollectionHandle, RotGrid?.GarbageCollectionHandle ?? nint.Zero) as FRotator;
		}

		public FVector Vector()
		{
			return FRotatorImplementation.FRotator_VectorImplementation(GarbageCollectionHandle) as FVector;
		}

		public FQuat Quaternion()
		{
			return FRotatorImplementation.FRotator_QuaternionImplementation(GarbageCollectionHandle) as FQuat;
		}

		public FVector Euler()
		{
			return FRotatorImplementation.FRotator_EulerImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector RotateVector(FVector V)
		{
			return FRotatorImplementation.FRotator_RotateVectorImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector UnrotateVector(FVector V)
		{
			return FRotatorImplementation.FRotator_UnrotateVectorImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FRotator Clamp()
		{
			return FRotatorImplementation.FRotator_ClampImplementation(GarbageCollectionHandle) as FRotator;
		}

		public FRotator GetNormalized()
		{
			return FRotatorImplementation.FRotator_GetNormalizedImplementation(GarbageCollectionHandle) as FRotator;
		}

		public FRotator GetDenormalized()
		{
			return FRotatorImplementation.FRotator_GetDenormalizedImplementation(GarbageCollectionHandle) as FRotator;
		}

		public double GetComponentForAxis(EAxis Axis)
		{
			return (double)FRotatorImplementation.FRotator_GetComponentForAxisImplementation(GarbageCollectionHandle, Axis);
		}

		public double SetComponentForAxis(EAxis Axis)
		{
			return (double)FRotatorImplementation.FRotator_SetComponentForAxisImplementation(GarbageCollectionHandle, Axis);
		}

		public void Normalize()
		{
			FRotatorImplementation.FRotator_NormalizeImplementation(GarbageCollectionHandle);
		}

		public void GetWindingAndRemainder(FRotator Winding, FRotator Remainder)
		{
			FRotatorImplementation.FRotator_GetWindingAndRemainderImplementation(GarbageCollectionHandle, Winding?.GarbageCollectionHandle ?? nint.Zero, Remainder?.GarbageCollectionHandle ?? nint.Zero);
		}

		public double GetManhattanDistance(FRotator Rotator)
		{
			return (double)FRotatorImplementation.FRotator_GetManhattanDistanceImplementation(GarbageCollectionHandle, Rotator?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FRotator GetEquivalentRotator()
		{
			return FRotatorImplementation.FRotator_GetEquivalentRotatorImplementation(GarbageCollectionHandle) as FRotator;
		}

		public void SetClosestToMe(FRotator MakeClosest)
		{
			FRotatorImplementation.FRotator_SetClosestToMeImplementation(GarbageCollectionHandle, MakeClosest?.GarbageCollectionHandle ?? nint.Zero);
		}

		public new FString ToString()
		{
			return FRotatorImplementation.FRotator_ToStringImplementation(GarbageCollectionHandle) as FString;
		}

		public FString ToCompactString()
		{
			return FRotatorImplementation.FRotator_ToCompactStringImplementation(GarbageCollectionHandle) as FString;
		}

		public bool InitFromString(FString InSourceString)
		{
			return (bool)FRotatorImplementation.FRotator_InitFromStringImplementation(GarbageCollectionHandle, InSourceString?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool ContainsNaN()
		{
			return (bool)FRotatorImplementation.FRotator_ContainsNaNImplementation(GarbageCollectionHandle);
		}

		public static double ClampAxis(double Angle)
		{
			return (double)FRotatorImplementation.FRotator_ClampAxisImplementation(nint.Zero, Angle);
		}

		public static double NormalizeAxis(double Angle)
		{
			return (double)FRotatorImplementation.FRotator_NormalizeAxisImplementation(nint.Zero, Angle);
		}

		public static byte CompressAxisToByte(double Angle)
		{
			return (byte)FRotatorImplementation.FRotator_CompressAxisToByteImplementation(nint.Zero, Angle);
		}

		public static double DecompressAxisFromByte(byte Angle)
		{
			return (double)FRotatorImplementation.FRotator_DecompressAxisFromByteImplementation(nint.Zero, Angle);
		}

		public static ushort CompressAxisToShort(double Angle)
		{
			return (ushort)FRotatorImplementation.FRotator_CompressAxisToShortImplementation(nint.Zero, Angle);
		}

		public static double DecompressAxisFromShort(ushort Angle)
		{
			return (double)FRotatorImplementation.FRotator_DecompressAxisFromShortImplementation(nint.Zero, Angle);
		}

		public static FRotator MakeFromEuler(FVector Euler)
		{
			return FRotatorImplementation.FRotator_MakeFromEulerImplementation(nint.Zero, Euler?.GarbageCollectionHandle ?? nint.Zero) as FRotator;
		}
	}
}