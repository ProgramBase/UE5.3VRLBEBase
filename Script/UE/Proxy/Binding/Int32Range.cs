using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FInt32Range
	{
		public FInt32Range(int A)
		{
			if (GetType() == typeof(FInt32Range))
			{
				FInt32RangeImplementation.FInt32Range_FInt32RangeImplementation(this, A);
			}
		}

		public FInt32Range(int A, int B)
		{
			if (GetType() == typeof(FInt32Range))
			{
				FInt32RangeImplementation.FInt32Range_FInt32Range1Implementation(this, A, B);
			}
		}

		public FInt32Range(FInt32RangeBound InLowerBound, FInt32RangeBound InUpperBound)
		{
			if (GetType() == typeof(FInt32Range))
			{
				FInt32RangeImplementation.FInt32Range_FInt32Range2Implementation(this, InLowerBound?.GarbageCollectionHandle ?? nint.Zero, InUpperBound?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public void SetLowerBoundValue(int NewLowerBoundValue)
		{
			FInt32RangeImplementation.FInt32Range_SetLowerBoundValueImplementation(GarbageCollectionHandle, NewLowerBoundValue);
		}

		public int GetLowerBoundValue()
		{
			return (int)FInt32RangeImplementation.FInt32Range_GetLowerBoundValueImplementation(GarbageCollectionHandle);
		}

		public void SetUpperBoundValue(int NewUpperBoundValue)
		{
			FInt32RangeImplementation.FInt32Range_SetUpperBoundValueImplementation(GarbageCollectionHandle, NewUpperBoundValue);
		}

		public int GetUpperBoundValue()
		{
			return (int)FInt32RangeImplementation.FInt32Range_GetUpperBoundValueImplementation(GarbageCollectionHandle);
		}

		public bool HasLowerBound()
		{
			return (bool)FInt32RangeImplementation.FInt32Range_HasLowerBoundImplementation(GarbageCollectionHandle);
		}

		public bool HasUpperBound()
		{
			return (bool)FInt32RangeImplementation.FInt32Range_HasUpperBoundImplementation(GarbageCollectionHandle);
		}

		public bool IsDegenerate()
		{
			return (bool)FInt32RangeImplementation.FInt32Range_IsDegenerateImplementation(GarbageCollectionHandle);
		}

		public bool IsEmpty()
		{
			return (bool)FInt32RangeImplementation.FInt32Range_IsEmptyImplementation(GarbageCollectionHandle);
		}

		public TArray<FInt32Range> Split(int Element)
		{
			return FInt32RangeImplementation.FInt32Range_SplitImplementation(GarbageCollectionHandle, Element) as TArray<FInt32Range>;
		}

		public static TArray<FInt32Range> Union(FInt32Range X, FInt32Range Y)
		{
			return FInt32RangeImplementation.FInt32Range_UnionImplementation(nint.Zero, X?.GarbageCollectionHandle ?? nint.Zero, Y?.GarbageCollectionHandle ?? nint.Zero) as TArray<FInt32Range>;
		}

		public static FInt32Range All()
		{
			return FInt32RangeImplementation.FInt32Range_AllImplementation(nint.Zero) as FInt32Range;
		}

		public static FInt32Range AtLeast(int Value)
		{
			return FInt32RangeImplementation.FInt32Range_AtLeastImplementation(nint.Zero, Value) as FInt32Range;
		}

		public static FInt32Range AtMost(int Value)
		{
			return FInt32RangeImplementation.FInt32Range_AtMostImplementation(nint.Zero, Value) as FInt32Range;
		}

		public static FInt32Range Empty()
		{
			return FInt32RangeImplementation.FInt32Range_EmptyImplementation(nint.Zero) as FInt32Range;
		}
	}
}