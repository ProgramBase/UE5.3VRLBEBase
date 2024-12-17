using System.Runtime.CompilerServices;
using Script.CoreUObject;

namespace Script.Binding
{
	public static partial class FDateTimeImplementation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FDateTime_FDateTimeImplementation(FDateTime InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FDateTime_FDateTime1Implementation(FDateTime InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GreaterImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GreaterEqualImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_LessImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_LessEqualImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_PlusImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_MinusImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_Minus1Implementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetDateImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FDateTime_GetDate1Implementation(nint InObject, out object[] OutValue, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetDayImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetDayOfWeekImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetDayOfYearImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetHourImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetHour12Implementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetJulianDayImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetModifiedJulianDayImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetMillisecondImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetMinuteImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetMonthImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetMonthOfYearImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetSecondImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetTicksImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetTimeOfDayImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_GetYearImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_IsAfternoonImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_IsMorningImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_ToHttpDateImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_ToIso8601Implementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_ToStringImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_ToUnixTimestampImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_DaysInMonthImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_DaysInYearImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_FromJulianDayImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_FromUnixTimestampImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_IsLeapYearImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_MaxValueImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_MinValueImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_NowImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_ParseImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_ParseHttpDateImplementation(nint InObject, params object[] InValue);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_TodayImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_UtcNowImplementation(nint InObject);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object FDateTime_ValidateImplementation(nint InObject, params object[] InValue);
	}
}