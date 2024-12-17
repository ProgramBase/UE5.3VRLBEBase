using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FFrameNumber
	{
		public FFrameNumber(int InValue)
		{
			if (GetType() == typeof(FFrameNumber))
			{
				FFrameNumberImplementation.FFrameNumber_FFrameNumberImplementation(this, InValue);
			}
		}

		public static FFrameNumber operator ++(FFrameNumber InValue0)
		{
			return FFrameNumberImplementation.FFrameNumber_PreIncrementImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero) as FFrameNumber;
		}

		public static FFrameNumber operator --(FFrameNumber InValue0)
		{
			return FFrameNumberImplementation.FFrameNumber_PreDecrementImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero) as FFrameNumber;
		}

		public static bool operator <(FFrameNumber InValue0, FFrameNumber InValue1)
		{
			return (bool)FFrameNumberImplementation.FFrameNumber_LessImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool operator >(FFrameNumber InValue0, FFrameNumber InValue1)
		{
			return (bool)FFrameNumberImplementation.FFrameNumber_GreaterImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool operator <=(FFrameNumber InValue0, FFrameNumber InValue1)
		{
			return (bool)FFrameNumberImplementation.FFrameNumber_LessEqualImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool operator >=(FFrameNumber InValue0, FFrameNumber InValue1)
		{
			return (bool)FFrameNumberImplementation.FFrameNumber_GreaterEqualImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FFrameNumber operator +(FFrameNumber InValue0, FFrameNumber InValue1)
		{
			return FFrameNumberImplementation.FFrameNumber_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FFrameNumber;
		}

		public static FFrameNumber operator -(FFrameNumber InValue0, FFrameNumber InValue1)
		{
			return FFrameNumberImplementation.FFrameNumber_MinusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FFrameNumber;
		}

		public static FFrameNumber operator %(FFrameNumber InValue0, FFrameNumber InValue1)
		{
			return FFrameNumberImplementation.FFrameNumber_ModulusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FFrameNumber;
		}

		public static FFrameNumber operator -(FFrameNumber InValue0)
		{
			return FFrameNumberImplementation.FFrameNumber_UnaryMinus1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero) as FFrameNumber;
		}

		public static FFrameNumber operator *(FFrameNumber InValue0, float InValue1)
		{
			return FFrameNumberImplementation.FFrameNumber_MultipliesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FFrameNumber;
		}

		public static FFrameNumber operator /(FFrameNumber InValue0, float InValue1)
		{
			return FFrameNumberImplementation.FFrameNumber_DividesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FFrameNumber;
		}
	}
}