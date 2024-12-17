using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FRandomStream
	{
		public FRandomStream(int InSeed)
		{
			if (GetType() == typeof(FRandomStream))
			{
				FRandomStreamImplementation.FRandomStream_FRandomStreamImplementation(this, InSeed);
			}
		}

		public FRandomStream(FName InName)
		{
			if (GetType() == typeof(FRandomStream))
			{
				FRandomStreamImplementation.FRandomStream_FRandomStream1Implementation(this, InName?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public void Initialize(int InSeed)
		{
			FRandomStreamImplementation.FRandomStream_InitializeImplementation(GarbageCollectionHandle, InSeed);
		}

		public void Initialize(FName InName)
		{
			FRandomStreamImplementation.FRandomStream_Initialize1Implementation(GarbageCollectionHandle, InName?.GarbageCollectionHandle ?? nint.Zero);
		}

		public void Reset()
		{
			FRandomStreamImplementation.FRandomStream_ResetImplementation(GarbageCollectionHandle);
		}

		public int GetInitialSeed()
		{
			return (int)FRandomStreamImplementation.FRandomStream_GetInitialSeedImplementation(GarbageCollectionHandle);
		}

		public void GenerateNewSeed()
		{
			FRandomStreamImplementation.FRandomStream_GenerateNewSeedImplementation(GarbageCollectionHandle);
		}

		public float GetFraction()
		{
			return (float)FRandomStreamImplementation.FRandomStream_GetFractionImplementation(GarbageCollectionHandle);
		}

		public uint GetUnsignedInt()
		{
			return (uint)FRandomStreamImplementation.FRandomStream_GetUnsignedIntImplementation(GarbageCollectionHandle);
		}

		public FVector GetUnitVector()
		{
			return FRandomStreamImplementation.FRandomStream_GetUnitVectorImplementation(GarbageCollectionHandle) as FVector;
		}

		public int GetCurrentSeed()
		{
			return (int)FRandomStreamImplementation.FRandomStream_GetCurrentSeedImplementation(GarbageCollectionHandle);
		}

		public float FRand()
		{
			return (float)FRandomStreamImplementation.FRandomStream_FRandImplementation(GarbageCollectionHandle);
		}

		public int RandHelper(int A)
		{
			return (int)FRandomStreamImplementation.FRandomStream_RandHelperImplementation(GarbageCollectionHandle, A);
		}

		public int RandRange(int Min, int Max)
		{
			return (int)FRandomStreamImplementation.FRandomStream_RandRangeImplementation(GarbageCollectionHandle, Min, Max);
		}

		public double FRandRange(double InMin, double InMax)
		{
			return (double)FRandomStreamImplementation.FRandomStream_FRandRangeImplementation(GarbageCollectionHandle, InMin, InMax);
		}

		public FVector VRand()
		{
			return FRandomStreamImplementation.FRandomStream_VRandImplementation(GarbageCollectionHandle) as FVector;
		}

		public FVector RandPointInBox(FBox Box)
		{
			return FRandomStreamImplementation.FRandomStream_RandPointInBoxImplementation(GarbageCollectionHandle, Box?.GarbageCollectionHandle ?? nint.Zero) as FVector;
		}

		public FVector VRandCone(FVector Dir, float ConeHalfAngleRad)
		{
			return FRandomStreamImplementation.FRandomStream_VRandConeImplementation(GarbageCollectionHandle, Dir?.GarbageCollectionHandle ?? nint.Zero, ConeHalfAngleRad) as FVector;
		}

		public FVector VRandCone(FVector Dir, float HorizontalConeHalfAngleRad, float VerticalConeHalfAngleRad)
		{
			return FRandomStreamImplementation.FRandomStream_VRandCone1Implementation(GarbageCollectionHandle, Dir?.GarbageCollectionHandle ?? nint.Zero, HorizontalConeHalfAngleRad, VerticalConeHalfAngleRad) as FVector;
		}

		public new FString ToString()
		{
			return FRandomStreamImplementation.FRandomStream_ToStringImplementation(GarbageCollectionHandle) as FString;
		}
	}
}