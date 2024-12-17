using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FFloatRangeBound
	{
		public FFloatRangeBound(float InValue)
		{
			if (GetType() == typeof(FFloatRangeBound))
			{
				FFloatRangeBoundImplementation.FFloatRangeBound_FFloatRangeBoundImplementation(this, InValue);
			}
		}

		public float GetValue()
		{
			return (float)FFloatRangeBoundImplementation.FFloatRangeBound_GetValueImplementation(GarbageCollectionHandle);
		}

		public void SetValue(float NewValue)
		{
			FFloatRangeBoundImplementation.FFloatRangeBound_SetValueImplementation(GarbageCollectionHandle, NewValue);
		}

		public bool IsClosed()
		{
			return (bool)FFloatRangeBoundImplementation.FFloatRangeBound_IsClosedImplementation(GarbageCollectionHandle);
		}

		public bool IsExclusive()
		{
			return (bool)FFloatRangeBoundImplementation.FFloatRangeBound_IsExclusiveImplementation(GarbageCollectionHandle);
		}

		public bool IsInclusive()
		{
			return (bool)FFloatRangeBoundImplementation.FFloatRangeBound_IsInclusiveImplementation(GarbageCollectionHandle);
		}

		public bool IsOpen()
		{
			return (bool)FFloatRangeBoundImplementation.FFloatRangeBound_IsOpenImplementation(GarbageCollectionHandle);
		}

		public static FFloatRangeBound Exclusive(float Value)
		{
			return FFloatRangeBoundImplementation.FFloatRangeBound_ExclusiveImplementation(nint.Zero, Value) as FFloatRangeBound;
		}

		public static FFloatRangeBound Inclusive(float Value)
		{
			return FFloatRangeBoundImplementation.FFloatRangeBound_InclusiveImplementation(nint.Zero, Value) as FFloatRangeBound;
		}

		public static FFloatRangeBound Open()
		{
			return FFloatRangeBoundImplementation.FFloatRangeBound_OpenImplementation(nint.Zero) as FFloatRangeBound;
		}

		public static FFloatRangeBound FlipInclusion(FFloatRangeBound Bound)
		{
			return FFloatRangeBoundImplementation.FFloatRangeBound_FlipInclusionImplementation(nint.Zero, Bound?.GarbageCollectionHandle ?? nint.Zero) as FFloatRangeBound;
		}

		public static FFloatRangeBound MaxLower(FFloatRangeBound A, FFloatRangeBound B)
		{
			return FFloatRangeBoundImplementation.FFloatRangeBound_MaxLowerImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FFloatRangeBound;
		}

		public static FFloatRangeBound MaxUpper(FFloatRangeBound A, FFloatRangeBound B)
		{
			return FFloatRangeBoundImplementation.FFloatRangeBound_MaxUpperImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FFloatRangeBound;
		}

		public static FFloatRangeBound MinLower(FFloatRangeBound A, FFloatRangeBound B)
		{
			return FFloatRangeBoundImplementation.FFloatRangeBound_MinLowerImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FFloatRangeBound;
		}

		public static FFloatRangeBound MinUpper(FFloatRangeBound A, FFloatRangeBound B)
		{
			return FFloatRangeBoundImplementation.FFloatRangeBound_MinUpperImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FFloatRangeBound;
		}
	}
}