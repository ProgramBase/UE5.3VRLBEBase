using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FPlane
	{
		public FPlane(FVector4 V)
		{
			if (GetType() == typeof(FPlane))
			{
				FPlaneImplementation.FPlane_FPlaneImplementation(this, V?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FPlane(double InX, double InY, double InZ, double InW)
		{
			if (GetType() == typeof(FPlane))
			{
				FPlaneImplementation.FPlane_FPlane1Implementation(this, InX, InY, InZ, InW);
			}
		}

		public FPlane(FVector InNormal, double InW)
		{
			if (GetType() == typeof(FPlane))
			{
				FPlaneImplementation.FPlane_FPlane2Implementation(this, InNormal?.GarbageCollectionHandle ?? nint.Zero, InW);
			}
		}

		public FPlane(FVector InBase, FVector InNormal)
		{
			if (GetType() == typeof(FPlane))
			{
				FPlaneImplementation.FPlane_FPlane3Implementation(this, InBase?.GarbageCollectionHandle ?? nint.Zero, InNormal?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FPlane(FVector A, FVector B, FVector C)
		{
			if (GetType() == typeof(FPlane))
			{
				FPlaneImplementation.FPlane_FPlane4Implementation(this, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero, C?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FPlane(EForceInit InValue0)
		{
			if (GetType() == typeof(FPlane))
			{
				FPlaneImplementation.FPlane_FPlane5Implementation(this, InValue0);
			}
		}

		public static FPlane operator +(FPlane InValue0, FPlane InValue1)
		{
			return FPlaneImplementation.FPlane_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FPlane;
		}

		public static FPlane operator -(FPlane InValue0, FPlane InValue1)
		{
			return FPlaneImplementation.FPlane_MinusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FPlane;
		}

		public static double operator |(FPlane InValue0, FPlane InValue1)
		{
			return (double)FPlaneImplementation.FPlane_BitOrImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FPlane operator /(FPlane InValue0, double InValue1)
		{
			return FPlaneImplementation.FPlane_DividesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FPlane;
		}

		public static FPlane operator *(FPlane InValue0, double InValue1)
		{
			return FPlaneImplementation.FPlane_MultipliesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FPlane;
		}

		public static FPlane operator *(FPlane InValue0, FPlane InValue1)
		{
			return FPlaneImplementation.FPlane_Multiplies1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FPlane;
		}

		public bool IsValid()
		{
			return (bool)FPlaneImplementation.FPlane_IsValidImplementation(GarbageCollectionHandle);
		}

		public FVector GetOrigin()
		{
			return FPlaneImplementation.FPlane_GetOriginImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector GetNormal()
		{
			return FPlaneImplementation.FPlane_GetNormalImplementation(GarbageCollectionHandle) as FVector;
		}

		public double PlaneDot(FVector P)
		{
			return (double)FPlaneImplementation.FPlane_PlaneDotImplementation(GarbageCollectionHandle, P?.GarbageCollectionHandle ?? nint.Zero);
		}

		public new bool Normalize(double Tolerance = 0.00000001)
		{
			return (bool)FPlaneImplementation.FPlane_NormalizeImplementation(GarbageCollectionHandle, Tolerance);
		}

		public FPlane Flip()
		{
			return FPlaneImplementation.FPlane_FlipImplementation(GarbageCollectionHandle) as FPlane;
		}

		public FPlane TransformBy(FMatrix M)
		{
			return FPlaneImplementation.FPlane_TransformByImplementation(GarbageCollectionHandle, M?.GarbageCollectionHandle ?? nint.Zero) as FPlane;
		}

		public FPlane TransformByUsingAdjointT(FMatrix M, double DetM, FMatrix TA)
		{
			return FPlaneImplementation.FPlane_TransformByUsingAdjointTImplementation(GarbageCollectionHandle, M?.GarbageCollectionHandle ?? nint.Zero, DetM, TA?.GarbageCollectionHandle ?? nint.Zero) as FPlane;
		}

		public FPlane TranslateBy(FVector V)
		{
			return FPlaneImplementation.FPlane_TranslateByImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FPlane;
		}

		public bool Equals(FPlane V, double Tolerance = 0.0001)
		{
			return (bool)FPlaneImplementation.FPlane_EqualsImplementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero, Tolerance);
		}
	}
}