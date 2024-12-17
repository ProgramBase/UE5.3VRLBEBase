using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FFrameTime
	{
		public static float MaxSubframe
		{
			get => FFrameTimeImplementation.FFrameTime_GetMaxSubframeImplementation(nint.Zero);
		}

		public FFrameTime(int InFrameNumber)
		{
			if (GetType() == typeof(FFrameTime))
			{
				FFrameTimeImplementation.FFrameTime_FFrameTimeImplementation(this, InFrameNumber);
			}
		}

		public FFrameTime(FFrameNumber InFrameNumber)
		{
			if (GetType() == typeof(FFrameTime))
			{
				FFrameTimeImplementation.FFrameTime_FFrameTime1Implementation(this, InFrameNumber?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FFrameTime(FFrameNumber InFrameNumber, float InSubFrame)
		{
			if (GetType() == typeof(FFrameTime))
			{
				FFrameTimeImplementation.FFrameTime_FFrameTime2Implementation(this, InFrameNumber?.GarbageCollectionHandle ?? nint.Zero, InSubFrame);
			}
		}

		public static bool operator >(FFrameTime InValue0, FFrameTime InValue1)
		{
			return (bool)FFrameTimeImplementation.FFrameTime_GreaterImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool operator >=(FFrameTime InValue0, FFrameTime InValue1)
		{
			return (bool)FFrameTimeImplementation.FFrameTime_GreaterEqualImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool operator <(FFrameTime InValue0, FFrameTime InValue1)
		{
			return (bool)FFrameTimeImplementation.FFrameTime_LessImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool operator <=(FFrameTime InValue0, FFrameTime InValue1)
		{
			return (bool)FFrameTimeImplementation.FFrameTime_LessEqualImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FFrameTime operator +(FFrameTime InValue0, FFrameTime InValue1)
		{
			return FFrameTimeImplementation.FFrameTime_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FFrameTime;
		}

		public static FFrameTime operator -(FFrameTime InValue0, FFrameTime InValue1)
		{
			return FFrameTimeImplementation.FFrameTime_MinusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FFrameTime;
		}

		public static FFrameTime operator %(FFrameTime InValue0, FFrameTime InValue1)
		{
			return FFrameTimeImplementation.FFrameTime_ModulusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FFrameTime;
		}

		public static FFrameTime operator -(FFrameTime InValue0)
		{
			return FFrameTimeImplementation.FFrameTime_UnaryMinus1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero) as FFrameTime;
		}

		public static FFrameTime operator *(FFrameTime InValue0, float InValue1)
		{
			return FFrameTimeImplementation.FFrameTime_MultipliesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FFrameTime;
		}

		public static FFrameTime operator /(FFrameTime InValue0, float InValue1)
		{
			return FFrameTimeImplementation.FFrameTime_DividesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FFrameTime;
		}

		public FFrameNumber GetFrame()
		{
			return FFrameTimeImplementation.FFrameTime_GetFrameImplementation(GarbageCollectionHandle) as FFrameNumber;
		}

		public float GetSubFrame()
		{
			return (float)FFrameTimeImplementation.FFrameTime_GetSubFrameImplementation(GarbageCollectionHandle);
		}

		public FFrameNumber FloorToFrame()
		{
			return FFrameTimeImplementation.FFrameTime_FloorToFrameImplementation(GarbageCollectionHandle) as FFrameNumber;
		}

		public FFrameNumber CeilToFrame()
		{
			return FFrameTimeImplementation.FFrameTime_CeilToFrameImplementation(GarbageCollectionHandle) as FFrameNumber;
		}

		public FFrameNumber RoundToFrame()
		{
			return FFrameTimeImplementation.FFrameTime_RoundToFrameImplementation(GarbageCollectionHandle) as FFrameNumber;
		}

		public double AsDecimal()
		{
			return (double)FFrameTimeImplementation.FFrameTime_AsDecimalImplementation(GarbageCollectionHandle);
		}

		public static FFrameTime FromDecimal(double InDecimalFrame)
		{
			return FFrameTimeImplementation.FFrameTime_FromDecimalImplementation(nint.Zero, InDecimalFrame) as FFrameTime;
		}
	}
}