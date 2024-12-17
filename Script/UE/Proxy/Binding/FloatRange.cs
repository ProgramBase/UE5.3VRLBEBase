using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FFloatRange
	{
		public FFloatRange(float A)
		{
			if (GetType() == typeof(FFloatRange))
			{
				FFloatRangeImplementation.FFloatRange_FFloatRangeImplementation(this, A);
			}
		}

		public FFloatRange(float A, float B)
		{
			if (GetType() == typeof(FFloatRange))
			{
				FFloatRangeImplementation.FFloatRange_FFloatRange1Implementation(this, A, B);
			}
		}

		public FFloatRange(FFloatRangeBound InLowerBound, FFloatRangeBound InUpperBound)
		{
			if (GetType() == typeof(FFloatRange))
			{
				FFloatRangeImplementation.FFloatRange_FFloatRange2Implementation(this, InLowerBound?.GarbageCollectionHandle ?? nint.Zero, InUpperBound?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public void SetLowerBoundValue(float NewLowerBoundValue)
		{
			FFloatRangeImplementation.FFloatRange_SetLowerBoundValueImplementation(GarbageCollectionHandle, NewLowerBoundValue);
		}

		public float GetLowerBoundValue()
		{
			return (float)FFloatRangeImplementation.FFloatRange_GetLowerBoundValueImplementation(GarbageCollectionHandle);
		}

		public void SetUpperBoundValue(float NewUpperBoundValue)
		{
			FFloatRangeImplementation.FFloatRange_SetUpperBoundValueImplementation(GarbageCollectionHandle, NewUpperBoundValue);
		}

		public float GetUpperBoundValue()
		{
			return (float)FFloatRangeImplementation.FFloatRange_GetUpperBoundValueImplementation(GarbageCollectionHandle);
		}

		public bool HasLowerBound()
		{
			return (bool)FFloatRangeImplementation.FFloatRange_HasLowerBoundImplementation(GarbageCollectionHandle);
		}

		public bool HasUpperBound()
		{
			return (bool)FFloatRangeImplementation.FFloatRange_HasUpperBoundImplementation(GarbageCollectionHandle);
		}

		public bool IsDegenerate()
		{
			return (bool)FFloatRangeImplementation.FFloatRange_IsDegenerateImplementation(GarbageCollectionHandle);
		}

		public bool IsEmpty()
		{
			return (bool)FFloatRangeImplementation.FFloatRange_IsEmptyImplementation(GarbageCollectionHandle);
		}

		public TArray<FFloatRange> Split(float Element)
		{
			return FFloatRangeImplementation.FFloatRange_SplitImplementation(GarbageCollectionHandle, Element) as TArray<FFloatRange>;
		}

		public static TArray<FFloatRange> Union(FFloatRange X, FFloatRange Y)
		{
			return FFloatRangeImplementation.FFloatRange_UnionImplementation(nint.Zero, X?.GarbageCollectionHandle ?? nint.Zero, Y?.GarbageCollectionHandle ?? nint.Zero) as TArray<FFloatRange>;
		}

		public static FFloatRange All()
		{
			return FFloatRangeImplementation.FFloatRange_AllImplementation(nint.Zero) as FFloatRange;
		}

		public static FFloatRange AtLeast(float Value)
		{
			return FFloatRangeImplementation.FFloatRange_AtLeastImplementation(nint.Zero, Value) as FFloatRange;
		}

		public static FFloatRange AtMost(float Value)
		{
			return FFloatRangeImplementation.FFloatRange_AtMostImplementation(nint.Zero, Value) as FFloatRange;
		}

		public static FFloatRange Empty()
		{
			return FFloatRangeImplementation.FFloatRange_EmptyImplementation(nint.Zero) as FFloatRange;
		}
	}
}