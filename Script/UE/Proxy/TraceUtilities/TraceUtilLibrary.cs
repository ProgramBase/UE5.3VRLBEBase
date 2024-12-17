using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.TraceUtilities
{
	[PathName("/Script/TraceUtilities.TraceUtilLibrary")]
	public partial class UTraceUtilLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TraceUtilities.TraceUtilLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void TraceMarkRegionStart(FString Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __TraceMarkRegionStart, __InBuffer);
			}
		}

		public static void TraceMarkRegionEnd(FString Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __TraceMarkRegionEnd, __InBuffer);
			}
		}

		public static void TraceBookmark(FString Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __TraceBookmark, __InBuffer);
			}
		}

		public static bool ToggleChannel(FString ChannelName, bool enabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ChannelName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = enabled;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ToggleChannel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool StopTracing()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __StopTracing, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool StartTraceToFile(FString FileName, TArray<FString> Channels)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = FileName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Channels?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __StartTraceToFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool StartTraceSendTo(FString Target, TArray<FString> Channels)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Channels?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __StartTraceSendTo, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool ResumeTracing()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __ResumeTracing, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool PauseTracing()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __PauseTracing, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsTracing()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsTracing, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsChannelEnabled(FString ChannelName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ChannelName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsChannelEnabled, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetEnabledChannels()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetEnabledChannels, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static TArray<FString> GetAllChannels()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetAllChannels, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		private static uint __TraceMarkRegionStart = 0;

		private static uint __TraceMarkRegionEnd = 0;

		private static uint __TraceBookmark = 0;

		private static uint __ToggleChannel = 0;

		private static uint __StopTracing = 0;

		private static uint __StartTraceToFile = 0;

		private static uint __StartTraceSendTo = 0;

		private static uint __ResumeTracing = 0;

		private static uint __PauseTracing = 0;

		private static uint __IsTracing = 0;

		private static uint __IsChannelEnabled = 0;

		private static uint __GetEnabledChannels = 0;

		private static uint __GetAllChannels = 0;
	}
}