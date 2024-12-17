using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FTimespan
	{
		public FTimespan(long InTicks)
		{
			if (GetType() == typeof(FTimespan))
			{
				FTimespanImplementation.FTimespan_FTimespanImplementation(this, InTicks);
			}
		}

		public FTimespan(int Hours, int Minutes, int Seconds)
		{
			if (GetType() == typeof(FTimespan))
			{
				FTimespanImplementation.FTimespan_FTimespan1Implementation(this, Hours, Minutes, Seconds);
			}
		}

		public FTimespan(int Days, int Hours, int Minutes, int Seconds)
		{
			if (GetType() == typeof(FTimespan))
			{
				FTimespanImplementation.FTimespan_FTimespan2Implementation(this, Days, Hours, Minutes, Seconds);
			}
		}

		public FTimespan(int Days, int Hours, int Minutes, int Seconds, int FractionNano)
		{
			if (GetType() == typeof(FTimespan))
			{
				FTimespanImplementation.FTimespan_FTimespan3Implementation(this, Days, Hours, Minutes, Seconds, FractionNano);
			}
		}

		public static FTimespan operator +(FTimespan InValue0, FTimespan InValue1)
		{
			return FTimespanImplementation.FTimespan_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FTimespan;
		}

		public static FTimespan operator -(FTimespan InValue0)
		{
			return FTimespanImplementation.FTimespan_UnaryMinusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero) as FTimespan;
		}

		public static FTimespan operator -(FTimespan InValue0, FTimespan InValue1)
		{
			return FTimespanImplementation.FTimespan_Minus1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FTimespan;
		}

		public static FTimespan operator %(FTimespan InValue0, FTimespan InValue1)
		{
			return FTimespanImplementation.FTimespan_ModulusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FTimespan;
		}

		public static bool operator >(FTimespan InValue0, FTimespan InValue1)
		{
			return (bool)FTimespanImplementation.FTimespan_GreaterImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool operator >=(FTimespan InValue0, FTimespan InValue1)
		{
			return (bool)FTimespanImplementation.FTimespan_GreaterEqualImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool operator <(FTimespan InValue0, FTimespan InValue1)
		{
			return (bool)FTimespanImplementation.FTimespan_LessImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool operator <=(FTimespan InValue0, FTimespan InValue1)
		{
			return (bool)FTimespanImplementation.FTimespan_LessEqualImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FTimespan operator *(FTimespan InValue0, double InValue1)
		{
			return FTimespanImplementation.FTimespan_MultipliesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FTimespan;
		}

		public static FTimespan operator /(FTimespan InValue0, double InValue1)
		{
			return FTimespanImplementation.FTimespan_DividesImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1) as FTimespan;
		}

		public int GetDays()
		{
			return (int)FTimespanImplementation.FTimespan_GetDaysImplementation(GarbageCollectionHandle);
		}

		public FTimespan GetDuration()
		{
			return FTimespanImplementation.FTimespan_GetDurationImplementation(GarbageCollectionHandle) as FTimespan;
		}

		public int GetFractionMicro()
		{
			return (int)FTimespanImplementation.FTimespan_GetFractionMicroImplementation(GarbageCollectionHandle);
		}

		public int GetFractionMilli()
		{
			return (int)FTimespanImplementation.FTimespan_GetFractionMilliImplementation(GarbageCollectionHandle);
		}

		public int GetFractionNano()
		{
			return (int)FTimespanImplementation.FTimespan_GetFractionNanoImplementation(GarbageCollectionHandle);
		}

		public int GetFractionTicks()
		{
			return (int)FTimespanImplementation.FTimespan_GetFractionTicksImplementation(GarbageCollectionHandle);
		}

		public int GetHours()
		{
			return (int)FTimespanImplementation.FTimespan_GetHoursImplementation(GarbageCollectionHandle);
		}

		public int GetMinutes()
		{
			return (int)FTimespanImplementation.FTimespan_GetMinutesImplementation(GarbageCollectionHandle);
		}

		public int GetSeconds()
		{
			return (int)FTimespanImplementation.FTimespan_GetSecondsImplementation(GarbageCollectionHandle);
		}

		public long GetTicks()
		{
			return (long)FTimespanImplementation.FTimespan_GetTicksImplementation(GarbageCollectionHandle);
		}

		public double GetTotalDays()
		{
			return (double)FTimespanImplementation.FTimespan_GetTotalDaysImplementation(GarbageCollectionHandle);
		}

		public double GetTotalHours()
		{
			return (double)FTimespanImplementation.FTimespan_GetTotalHoursImplementation(GarbageCollectionHandle);
		}

		public double GetTotalMicroseconds()
		{
			return (double)FTimespanImplementation.FTimespan_GetTotalMicrosecondsImplementation(GarbageCollectionHandle);
		}

		public double GetTotalMilliseconds()
		{
			return (double)FTimespanImplementation.FTimespan_GetTotalMillisecondsImplementation(GarbageCollectionHandle);
		}

		public double GetTotalMinutes()
		{
			return (double)FTimespanImplementation.FTimespan_GetTotalMinutesImplementation(GarbageCollectionHandle);
		}

		public double GetTotalSeconds()
		{
			return (double)FTimespanImplementation.FTimespan_GetTotalSecondsImplementation(GarbageCollectionHandle);
		}

		public bool IsZero()
		{
			return (bool)FTimespanImplementation.FTimespan_IsZeroImplementation(GarbageCollectionHandle);
		}

		public new FString ToString()
		{
			return FTimespanImplementation.FTimespan_ToStringImplementation(GarbageCollectionHandle) as FString;
		}

		public static FTimespan FromDays(double Days)
		{
			return FTimespanImplementation.FTimespan_FromDaysImplementation(nint.Zero, Days) as FTimespan;
		}

		public static FTimespan FromHours(double Hours)
		{
			return FTimespanImplementation.FTimespan_FromHoursImplementation(nint.Zero, Hours) as FTimespan;
		}

		public static FTimespan FromMicroseconds(double Microseconds)
		{
			return FTimespanImplementation.FTimespan_FromMicrosecondsImplementation(nint.Zero, Microseconds) as FTimespan;
		}

		public static FTimespan FromMilliseconds(double Milliseconds)
		{
			return FTimespanImplementation.FTimespan_FromMillisecondsImplementation(nint.Zero, Milliseconds) as FTimespan;
		}

		public static FTimespan FromMinutes(double Minutes)
		{
			return FTimespanImplementation.FTimespan_FromMinutesImplementation(nint.Zero, Minutes) as FTimespan;
		}

		public static FTimespan FromSeconds(double Seconds)
		{
			return FTimespanImplementation.FTimespan_FromSecondsImplementation(nint.Zero, Seconds) as FTimespan;
		}

		public static FTimespan MaxValue()
		{
			return FTimespanImplementation.FTimespan_MaxValueImplementation(nint.Zero) as FTimespan;
		}

		public static FTimespan MinValue()
		{
			return FTimespanImplementation.FTimespan_MinValueImplementation(nint.Zero) as FTimespan;
		}

		public static bool Parse(FString TimespanString, FTimespan OutTimespan)
		{
			return (bool)FTimespanImplementation.FTimespan_ParseImplementation(nint.Zero, TimespanString?.GarbageCollectionHandle ?? nint.Zero, OutTimespan?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static double Ratio(FTimespan Dividend, FTimespan Divisor)
		{
			return (double)FTimespanImplementation.FTimespan_RatioImplementation(nint.Zero, Dividend?.GarbageCollectionHandle ?? nint.Zero, Divisor?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FTimespan Zero()
		{
			return FTimespanImplementation.FTimespan_ZeroImplementation(nint.Zero) as FTimespan;
		}
	}
}