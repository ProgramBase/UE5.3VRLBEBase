using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.QuartzSubsystem")]
	public partial class UQuartzSubsystem : UTickableWorldSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioMixer.QuartzSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsQuartzEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsQuartzEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsClockRunning(UObject WorldContextObject, FName ClockName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClockName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsClockRunning, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetRoundTripMinLatency(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetRoundTripMinLatency, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetRoundTripMaxLatency(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetRoundTripMaxLatency, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetRoundTripAverageLatency(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetRoundTripAverageLatency, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UQuartzClockHandle GetHandleForClock(UObject WorldContextObject, FName ClockName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClockName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetHandleForClock, __InBuffer, __ReturnBuffer);

				return *(UQuartzClockHandle*)__ReturnBuffer;
			}
		}

		public virtual float GetGameThreadToAudioRenderThreadMinLatency(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetGameThreadToAudioRenderThreadMinLatency, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetGameThreadToAudioRenderThreadMaxLatency(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetGameThreadToAudioRenderThreadMaxLatency, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetGameThreadToAudioRenderThreadAverageLatency(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetGameThreadToAudioRenderThreadAverageLatency, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetEstimatedClockRunTime(UObject WorldContextObject, FName InClockName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InClockName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetEstimatedClockRunTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetDurationOfQuantizationTypeInSeconds(UObject WorldContextObject, FName ClockName, EQuartzCommandQuantization QuantizationType, float Multiplier = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClockName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)QuantizationType;

				*(float*)(__InBuffer + 17) = Multiplier;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDurationOfQuantizationTypeInSeconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FQuartzTransportTimeStamp GetCurrentClockTimestamp(UObject WorldContextObject, FName InClockName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InClockName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetCurrentClockTimestamp, __InBuffer, __ReturnBuffer);

				return *(FQuartzTransportTimeStamp*)__ReturnBuffer;
			}
		}

		public virtual float GetAudioRenderThreadToGameThreadMinLatency()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAudioRenderThreadToGameThreadMinLatency, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetAudioRenderThreadToGameThreadMaxLatency()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAudioRenderThreadToGameThreadMaxLatency, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetAudioRenderThreadToGameThreadAverageLatency()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAudioRenderThreadToGameThreadAverageLatency, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual bool DoesClockExist(UObject WorldContextObject, FName ClockName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClockName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DoesClockExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void DeleteClockByName(UObject WorldContextObject, FName ClockName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClockName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DeleteClockByName, __InBuffer);
			}
		}

		public virtual void DeleteClockByHandle(UObject WorldContextObject, ref UQuartzClockHandle InClockHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __DeleteClockByHandle, __InBuffer, __OutBuffer);

				InClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual UQuartzClockHandle CreateNewClock(UObject WorldContextObject, FName ClockName, FQuartzClockSettings InSettings, bool bOverrideSettingsIfClockExists = false, bool bUseAudioEngineClockManager = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClockName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bOverrideSettingsIfClockExists;

				*(bool*)(__InBuffer + 25) = bUseAudioEngineClockManager;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateNewClock, __InBuffer, __ReturnBuffer);

				return *(UQuartzClockHandle*)__ReturnBuffer;
			}
		}

		private static uint __IsQuartzEnabled = 0;

		private static uint __IsClockRunning = 0;

		private static uint __GetRoundTripMinLatency = 0;

		private static uint __GetRoundTripMaxLatency = 0;

		private static uint __GetRoundTripAverageLatency = 0;

		private static uint __GetHandleForClock = 0;

		private static uint __GetGameThreadToAudioRenderThreadMinLatency = 0;

		private static uint __GetGameThreadToAudioRenderThreadMaxLatency = 0;

		private static uint __GetGameThreadToAudioRenderThreadAverageLatency = 0;

		private static uint __GetEstimatedClockRunTime = 0;

		private static uint __GetDurationOfQuantizationTypeInSeconds = 0;

		private static uint __GetCurrentClockTimestamp = 0;

		private static uint __GetAudioRenderThreadToGameThreadMinLatency = 0;

		private static uint __GetAudioRenderThreadToGameThreadMaxLatency = 0;

		private static uint __GetAudioRenderThreadToGameThreadAverageLatency = 0;

		private static uint __DoesClockExist = 0;

		private static uint __DeleteClockByName = 0;

		private static uint __DeleteClockByHandle = 0;

		private static uint __CreateNewClock = 0;
	}
}