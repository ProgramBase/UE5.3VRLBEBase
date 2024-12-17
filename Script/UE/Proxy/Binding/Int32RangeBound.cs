using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FInt32RangeBound
	{
		public FInt32RangeBound(int InValue)
		{
			if (GetType() == typeof(FInt32RangeBound))
			{
				FInt32RangeBoundImplementation.FInt32RangeBound_FInt32RangeBoundImplementation(this, InValue);
			}
		}

		public int GetValue()
		{
			return (int)FInt32RangeBoundImplementation.FInt32RangeBound_GetValueImplementation(GarbageCollectionHandle);
		}

		public void SetValue(int NewValue)
		{
			FInt32RangeBoundImplementation.FInt32RangeBound_SetValueImplementation(GarbageCollectionHandle, NewValue);
		}

		public bool IsClosed()
		{
			return (bool)FInt32RangeBoundImplementation.FInt32RangeBound_IsClosedImplementation(GarbageCollectionHandle);
		}

		public bool IsExclusive()
		{
			return (bool)FInt32RangeBoundImplementation.FInt32RangeBound_IsExclusiveImplementation(GarbageCollectionHandle);
		}

		public bool IsInclusive()
		{
			return (bool)FInt32RangeBoundImplementation.FInt32RangeBound_IsInclusiveImplementation(GarbageCollectionHandle);
		}

		public bool IsOpen()
		{
			return (bool)FInt32RangeBoundImplementation.FInt32RangeBound_IsOpenImplementation(GarbageCollectionHandle);
		}

		public static FInt32RangeBound Exclusive(int Value)
		{
			return FInt32RangeBoundImplementation.FInt32RangeBound_ExclusiveImplementation(nint.Zero, Value) as FInt32RangeBound;
		}

		public static FInt32RangeBound Inclusive(int Value)
		{
			return FInt32RangeBoundImplementation.FInt32RangeBound_InclusiveImplementation(nint.Zero, Value) as FInt32RangeBound;
		}

		public static FInt32RangeBound Open()
		{
			return FInt32RangeBoundImplementation.FInt32RangeBound_OpenImplementation(nint.Zero) as FInt32RangeBound;
		}

		public static FInt32RangeBound FlipInclusion(FInt32RangeBound Bound)
		{
			return FInt32RangeBoundImplementation.FInt32RangeBound_FlipInclusionImplementation(nint.Zero, Bound?.GarbageCollectionHandle ?? nint.Zero) as FInt32RangeBound;
		}

		public static FInt32RangeBound MaxLower(FInt32RangeBound A, FInt32RangeBound B)
		{
			return FInt32RangeBoundImplementation.FInt32RangeBound_MaxLowerImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FInt32RangeBound;
		}

		public static FInt32RangeBound MaxUpper(FInt32RangeBound A, FInt32RangeBound B)
		{
			return FInt32RangeBoundImplementation.FInt32RangeBound_MaxUpperImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FInt32RangeBound;
		}

		public static FInt32RangeBound MinLower(FInt32RangeBound A, FInt32RangeBound B)
		{
			return FInt32RangeBoundImplementation.FInt32RangeBound_MinLowerImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FInt32RangeBound;
		}

		public static FInt32RangeBound MinUpper(FInt32RangeBound A, FInt32RangeBound B)
		{
			return FInt32RangeBoundImplementation.FInt32RangeBound_MinUpperImplementation(nint.Zero, A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero) as FInt32RangeBound;
		}
	}
}