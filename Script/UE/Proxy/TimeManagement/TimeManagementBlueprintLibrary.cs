using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.TimeManagement
{
	[PathName("/Script/TimeManagement.TimeManagementBlueprintLibrary")]
	public partial class UTimeManagementBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TimeManagement.TimeManagementBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FFrameTime TransformTime(FFrameTime SourceTime, FFrameRate SourceRate, FFrameRate DestinationRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SourceTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceRate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DestinationRate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __TransformTime, __InBuffer, __ReturnBuffer);

				return *(FFrameTime*)__ReturnBuffer;
			}
		}

		public static FFrameNumber Subtract_FrameNumberInteger(FFrameNumber A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_FrameNumberInteger, __InBuffer, __ReturnBuffer);

				return *(FFrameNumber*)__ReturnBuffer;
			}
		}

		public static FFrameNumber Subtract_FrameNumberFrameNumber(FFrameNumber A, FFrameNumber B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Subtract_FrameNumberFrameNumber, __InBuffer, __ReturnBuffer);

				return *(FFrameNumber*)__ReturnBuffer;
			}
		}

		public static FFrameTime SnapFrameTimeToRate(FFrameTime SourceTime, FFrameRate SourceRate, FFrameRate SnapToRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = SourceTime?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceRate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SnapToRate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SnapFrameTimeToRate, __InBuffer, __ReturnBuffer);

				return *(FFrameTime*)__ReturnBuffer;
			}
		}

		public static FFrameTime Multiply_SecondsFrameRate(float TimeInSeconds, FFrameRate FrameRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = TimeInSeconds;

				*(nint*)(__InBuffer + 4) = FrameRate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_SecondsFrameRate, __InBuffer, __ReturnBuffer);

				return *(FFrameTime*)__ReturnBuffer;
			}
		}

		public static FFrameNumber Multiply_FrameNumberInteger(FFrameNumber A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Multiply_FrameNumberInteger, __InBuffer, __ReturnBuffer);

				return *(FFrameNumber*)__ReturnBuffer;
			}
		}

		public static bool IsValid_MultipleOf(FFrameRate InFrameRate, FFrameRate OtherFramerate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InFrameRate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OtherFramerate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValid_MultipleOf, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsValid_Framerate(FFrameRate InFrameRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFrameRate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValid_Framerate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FFrameRate GetTimecodeFrameRate()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetTimecodeFrameRate, __ReturnBuffer);

				return *(FFrameRate*)__ReturnBuffer;
			}
		}

		public static FTimecode GetTimecode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetTimecode, __ReturnBuffer);

				return *(FTimecode*)__ReturnBuffer;
			}
		}

		public static FFrameNumber Divide_FrameNumberInteger(FFrameNumber A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Divide_FrameNumberInteger, __InBuffer, __ReturnBuffer);

				return *(FFrameNumber*)__ReturnBuffer;
			}
		}

		public static FString Conv_TimecodeToString(FTimecode InTimecode, bool bForceSignDisplay = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InTimecode?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bForceSignDisplay;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_TimecodeToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static float Conv_QualifiedFrameTimeToSeconds(FQualifiedFrameTime InFrameTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFrameTime?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_QualifiedFrameTimeToSeconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float Conv_FrameRateToSeconds(FFrameRate InFrameRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFrameRate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_FrameRateToSeconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float Conv_FrameRateToInterval(FFrameRate InFrameRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFrameRate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_FrameRateToInterval, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static int Conv_FrameNumberToInteger(FFrameNumber InFrameNumber)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFrameNumber?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_FrameNumberToInteger, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FFrameNumber Add_FrameNumberInteger(FFrameNumber A, int B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = B;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_FrameNumberInteger, __InBuffer, __ReturnBuffer);

				return *(FFrameNumber*)__ReturnBuffer;
			}
		}

		public static FFrameNumber Add_FrameNumberFrameNumber(FFrameNumber A, FFrameNumber B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Add_FrameNumberFrameNumber, __InBuffer, __ReturnBuffer);

				return *(FFrameNumber*)__ReturnBuffer;
			}
		}

		private static uint __TransformTime = 0;

		private static uint __Subtract_FrameNumberInteger = 0;

		private static uint __Subtract_FrameNumberFrameNumber = 0;

		private static uint __SnapFrameTimeToRate = 0;

		private static uint __Multiply_SecondsFrameRate = 0;

		private static uint __Multiply_FrameNumberInteger = 0;

		private static uint __IsValid_MultipleOf = 0;

		private static uint __IsValid_Framerate = 0;

		private static uint __GetTimecodeFrameRate = 0;

		private static uint __GetTimecode = 0;

		private static uint __Divide_FrameNumberInteger = 0;

		private static uint __Conv_TimecodeToString = 0;

		private static uint __Conv_QualifiedFrameTimeToSeconds = 0;

		private static uint __Conv_FrameRateToSeconds = 0;

		private static uint __Conv_FrameRateToInterval = 0;

		private static uint __Conv_FrameNumberToInteger = 0;

		private static uint __Add_FrameNumberInteger = 0;

		private static uint __Add_FrameNumberFrameNumber = 0;
	}
}