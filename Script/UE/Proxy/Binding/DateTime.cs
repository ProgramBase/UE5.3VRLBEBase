using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FDateTime
	{
		public FDateTime(long InTicks)
		{
			if (GetType() == typeof(FDateTime))
			{
				FDateTimeImplementation.FDateTime_FDateTimeImplementation(this, InTicks);
			}
		}

		public FDateTime(int Year, int Month, int Day, int Hour, int Minute, int Second, int Millisecond)
		{
			if (GetType() == typeof(FDateTime))
			{
				FDateTimeImplementation.FDateTime_FDateTime1Implementation(this, Year, Month, Day, Hour, Minute, Second, Millisecond);
			}
		}

		public static bool operator >(FDateTime InValue0, FDateTime InValue1)
		{
			return (bool)FDateTimeImplementation.FDateTime_GreaterImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool operator >=(FDateTime InValue0, FDateTime InValue1)
		{
			return (bool)FDateTimeImplementation.FDateTime_GreaterEqualImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool operator <(FDateTime InValue0, FDateTime InValue1)
		{
			return (bool)FDateTimeImplementation.FDateTime_LessImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool operator <=(FDateTime InValue0, FDateTime InValue1)
		{
			return (bool)FDateTimeImplementation.FDateTime_LessEqualImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FDateTime operator +(FDateTime InValue0, FTimespan InValue1)
		{
			return FDateTimeImplementation.FDateTime_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FDateTime;
		}

		public static FTimespan operator -(FDateTime InValue0, FDateTime InValue1)
		{
			return FDateTimeImplementation.FDateTime_MinusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FTimespan;
		}

		public static FDateTime operator -(FDateTime InValue0, FTimespan InValue1)
		{
			return FDateTimeImplementation.FDateTime_Minus1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FDateTime;
		}

		public FDateTime GetDate()
		{
			return FDateTimeImplementation.FDateTime_GetDateImplementation(GarbageCollectionHandle) as FDateTime;
		}

		public void GetDate(ref int OutYear, ref int OutMonth, ref int OutDay)
		{
			FDateTimeImplementation.FDateTime_GetDate1Implementation(GarbageCollectionHandle, out var __OutValue, OutYear, OutMonth, OutDay);

			OutYear = (int)__OutValue[0];

			OutMonth = (int)__OutValue[1];

			OutDay = (int)__OutValue[2];
		}

		public int GetDay()
		{
			return (int)FDateTimeImplementation.FDateTime_GetDayImplementation(GarbageCollectionHandle);
		}

		public EDayOfWeek GetDayOfWeek()
		{
			return (EDayOfWeek)FDateTimeImplementation.FDateTime_GetDayOfWeekImplementation(GarbageCollectionHandle);
		}

		public int GetDayOfYear()
		{
			return (int)FDateTimeImplementation.FDateTime_GetDayOfYearImplementation(GarbageCollectionHandle);
		}

		public int GetHour()
		{
			return (int)FDateTimeImplementation.FDateTime_GetHourImplementation(GarbageCollectionHandle);
		}

		public int GetHour12()
		{
			return (int)FDateTimeImplementation.FDateTime_GetHour12Implementation(GarbageCollectionHandle);
		}

		public double GetJulianDay()
		{
			return (double)FDateTimeImplementation.FDateTime_GetJulianDayImplementation(GarbageCollectionHandle);
		}

		public double GetModifiedJulianDay()
		{
			return (double)FDateTimeImplementation.FDateTime_GetModifiedJulianDayImplementation(GarbageCollectionHandle);
		}

		public int GetMillisecond()
		{
			return (int)FDateTimeImplementation.FDateTime_GetMillisecondImplementation(GarbageCollectionHandle);
		}

		public int GetMinute()
		{
			return (int)FDateTimeImplementation.FDateTime_GetMinuteImplementation(GarbageCollectionHandle);
		}

		public int GetMonth()
		{
			return (int)FDateTimeImplementation.FDateTime_GetMonthImplementation(GarbageCollectionHandle);
		}

		public EMonthOfYear GetMonthOfYear()
		{
			return (EMonthOfYear)FDateTimeImplementation.FDateTime_GetMonthOfYearImplementation(GarbageCollectionHandle);
		}

		public int GetSecond()
		{
			return (int)FDateTimeImplementation.FDateTime_GetSecondImplementation(GarbageCollectionHandle);
		}

		public long GetTicks()
		{
			return (long)FDateTimeImplementation.FDateTime_GetTicksImplementation(GarbageCollectionHandle);
		}

		public FTimespan GetTimeOfDay()
		{
			return FDateTimeImplementation.FDateTime_GetTimeOfDayImplementation(GarbageCollectionHandle) as FTimespan;
		}

		public int GetYear()
		{
			return (int)FDateTimeImplementation.FDateTime_GetYearImplementation(GarbageCollectionHandle);
		}

		public bool IsAfternoon()
		{
			return (bool)FDateTimeImplementation.FDateTime_IsAfternoonImplementation(GarbageCollectionHandle);
		}

		public bool IsMorning()
		{
			return (bool)FDateTimeImplementation.FDateTime_IsMorningImplementation(GarbageCollectionHandle);
		}

		public FString ToHttpDate()
		{
			return FDateTimeImplementation.FDateTime_ToHttpDateImplementation(GarbageCollectionHandle) as FString;
		}

		public FString ToIso8601()
		{
			return FDateTimeImplementation.FDateTime_ToIso8601Implementation(GarbageCollectionHandle) as FString;
		}

		public new FString ToString()
		{
			return FDateTimeImplementation.FDateTime_ToStringImplementation(GarbageCollectionHandle) as FString;
		}

		public long ToUnixTimestamp()
		{
			return (long)FDateTimeImplementation.FDateTime_ToUnixTimestampImplementation(GarbageCollectionHandle);
		}

		public static int DaysInMonth(int Year, int Month)
		{
			return (int)FDateTimeImplementation.FDateTime_DaysInMonthImplementation(nint.Zero, Year, Month);
		}

		public static int DaysInYear(int Year)
		{
			return (int)FDateTimeImplementation.FDateTime_DaysInYearImplementation(nint.Zero, Year);
		}

		public static FDateTime FromJulianDay(double JulianDay)
		{
			return FDateTimeImplementation.FDateTime_FromJulianDayImplementation(nint.Zero, JulianDay) as FDateTime;
		}

		public static FDateTime FromUnixTimestamp(long UnixTime)
		{
			return FDateTimeImplementation.FDateTime_FromUnixTimestampImplementation(nint.Zero, UnixTime) as FDateTime;
		}

		public static bool IsLeapYear(int Year)
		{
			return (bool)FDateTimeImplementation.FDateTime_IsLeapYearImplementation(nint.Zero, Year);
		}

		public static FDateTime MaxValue()
		{
			return FDateTimeImplementation.FDateTime_MaxValueImplementation(nint.Zero) as FDateTime;
		}

		public static FDateTime MinValue()
		{
			return FDateTimeImplementation.FDateTime_MinValueImplementation(nint.Zero) as FDateTime;
		}

		public static FDateTime Now()
		{
			return FDateTimeImplementation.FDateTime_NowImplementation(nint.Zero) as FDateTime;
		}

		public static bool Parse(FString DateTimeString, FDateTime OutDateTime)
		{
			return (bool)FDateTimeImplementation.FDateTime_ParseImplementation(nint.Zero, DateTimeString?.GarbageCollectionHandle ?? nint.Zero, OutDateTime?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool ParseHttpDate(FString HttpDate, FDateTime OutDateTime)
		{
			return (bool)FDateTimeImplementation.FDateTime_ParseHttpDateImplementation(nint.Zero, HttpDate?.GarbageCollectionHandle ?? nint.Zero, OutDateTime?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FDateTime Today()
		{
			return FDateTimeImplementation.FDateTime_TodayImplementation(nint.Zero) as FDateTime;
		}

		public static FDateTime UtcNow()
		{
			return FDateTimeImplementation.FDateTime_UtcNowImplementation(nint.Zero) as FDateTime;
		}

		public static bool Validate(int Year, int Month, int Day, int Hour, int Minute, int Second, int Millisecond)
		{
			return (bool)FDateTimeImplementation.FDateTime_ValidateImplementation(nint.Zero, Year, Month, Day, Hour, Minute, Second, Millisecond);
		}
	}
}