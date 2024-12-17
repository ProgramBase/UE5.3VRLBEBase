using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.QuartzClockHandle")]
	public partial class UQuartzClockHandle : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioMixer.QuartzClockHandle");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UnsubscribeFromTimeDivision(UObject WorldContextObject, EQuartzCommandQuantization InQuantizationBoundary, ref UQuartzClockHandle ClockHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InQuantizationBoundary;

				*(nint*)(__InBuffer + 9) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __UnsubscribeFromTimeDivision, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void UnsubscribeFromAllTimeDivisions(UObject WorldContextObject, ref UQuartzClockHandle ClockHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __UnsubscribeFromAllTimeDivisions, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void SubscribeToQuantizationEvent(UObject WorldContextObject, EQuartzCommandQuantization InQuantizationBoundary, FOnQuartzMetronomeEventBP OnQuantizationEvent, ref UQuartzClockHandle ClockHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InQuantizationBoundary;

				*(nint*)(__InBuffer + 9) = OnQuantizationEvent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SubscribeToQuantizationEvent, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void SubscribeToAllQuantizationEvents(UObject WorldContextObject, FOnQuartzMetronomeEventBP OnQuantizationEvent, ref UQuartzClockHandle ClockHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OnQuantizationEvent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SubscribeToAllQuantizationEvents, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void StopClock(UObject WorldContextObject, bool CancelPendingEvents, ref UQuartzClockHandle ClockHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = CancelPendingEvents;

				*(nint*)(__InBuffer + 9) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __StopClock, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void StartOtherClock(UObject WorldContextObject, FName OtherClockName, FQuartzQuantizationBoundary InQuantizationBoundary, FOnQuartzCommandEventBP InDelegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OtherClockName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InQuantizationBoundary?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InDelegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartOtherClock, __InBuffer);
			}
		}

		public virtual void StartClock(UObject WorldContextObject, ref UQuartzClockHandle ClockHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __StartClock, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void SetTicksPerSecond(UObject WorldContextObject, FQuartzQuantizationBoundary QuantizationBoundary, FOnQuartzCommandEventBP Delegate, ref UQuartzClockHandle ClockHandle, float TicksPerSecond)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = QuantizationBoundary?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = TicksPerSecond;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SetTicksPerSecond, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void SetThirtySecondNotesPerMinute(UObject WorldContextObject, FQuartzQuantizationBoundary QuantizationBoundary, FOnQuartzCommandEventBP Delegate, ref UQuartzClockHandle ClockHandle, float ThirtySecondsNotesPerMinute)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = QuantizationBoundary?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = ThirtySecondsNotesPerMinute;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SetThirtySecondNotesPerMinute, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void SetSecondsPerTick(UObject WorldContextObject, FQuartzQuantizationBoundary QuantizationBoundary, FOnQuartzCommandEventBP Delegate, ref UQuartzClockHandle ClockHandle, float SecondsPerTick)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = QuantizationBoundary?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = SecondsPerTick;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SetSecondsPerTick, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void SetMillisecondsPerTick(UObject WorldContextObject, FQuartzQuantizationBoundary QuantizationBoundary, FOnQuartzCommandEventBP Delegate, ref UQuartzClockHandle ClockHandle, float MillisecondsPerTick)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = QuantizationBoundary?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = MillisecondsPerTick;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SetMillisecondsPerTick, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void SetBeatsPerMinute(UObject WorldContextObject, FQuartzQuantizationBoundary QuantizationBoundary, FOnQuartzCommandEventBP Delegate, ref UQuartzClockHandle ClockHandle, float BeatsPerMinute)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = QuantizationBoundary?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = BeatsPerMinute;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SetBeatsPerMinute, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void ResumeClock(UObject WorldContextObject, ref UQuartzClockHandle ClockHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ResumeClock, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void ResetTransportQuantized(UObject WorldContextObject, FQuartzQuantizationBoundary InQuantizationBoundary, FOnQuartzCommandEventBP InDelegate, ref UQuartzClockHandle ClockHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InQuantizationBoundary?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InDelegate?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ResetTransportQuantized, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void ResetTransport(UObject WorldContextObject, FOnQuartzCommandEventBP InDelegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InDelegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResetTransport, __InBuffer);
			}
		}

		public virtual void PauseClock(UObject WorldContextObject, ref UQuartzClockHandle ClockHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __PauseClock, __InBuffer, __OutBuffer);

				ClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

			}
		}

		public virtual void NotifyOnQuantizationBoundary(UObject WorldContextObject, FQuartzQuantizationBoundary InQuantizationBoundary, FOnQuartzCommandEventBP InDelegate, float InMsOffset = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InQuantizationBoundary?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InDelegate?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = InMsOffset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __NotifyOnQuantizationBoundary, __InBuffer);
			}
		}

		public virtual bool IsClockRunning(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsClockRunning, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetTicksPerSecond(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetTicksPerSecond, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetThirtySecondNotesPerMinute(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetThirtySecondNotesPerMinute, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetSecondsPerTick(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetSecondsPerTick, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetMillisecondsPerTick(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetMillisecondsPerTick, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetEstimatedRunTime(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetEstimatedRunTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="The">
		/// Quantization type to measure
		/// </param>
		/// <param name="The">
		/// quantity of the Quantization Type to calculate the time of
		/// </param>
		/// <returns>
		/// The duration, in seconds, of a multiplier amount of the Quantization Type, or -1 in the case the clock is invalid
		/// </returns>
		public virtual float GetDurationOfQuantizationTypeInSeconds(UObject WorldContextObject, EQuartzCommandQuantization QuantizationType, float Multiplier = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)QuantizationType;

				*(float*)(__InBuffer + 9) = Multiplier;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetDurationOfQuantizationTypeInSeconds, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FQuartzTransportTimeStamp GetCurrentTimestamp(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetCurrentTimestamp, __InBuffer, __ReturnBuffer);

				return *(FQuartzTransportTimeStamp*)__ReturnBuffer;
			}
		}

		public virtual float GetBeatsPerMinute(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetBeatsPerMinute, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetBeatProgressPercent(EQuartzCommandQuantization QuantizationBoundary = EQuartzCommandQuantization.Beat, float PhaseOffset = 0.000000f, float MsOffset = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)QuantizationBoundary;

				*(float*)(__InBuffer + 1) = PhaseOffset;

				*(float*)(__InBuffer + 5) = MsOffset;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetBeatProgressPercent, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __UnsubscribeFromTimeDivision = 0;

		private static uint __UnsubscribeFromAllTimeDivisions = 0;

		private static uint __SubscribeToQuantizationEvent = 0;

		private static uint __SubscribeToAllQuantizationEvents = 0;

		private static uint __StopClock = 0;

		private static uint __StartOtherClock = 0;

		private static uint __StartClock = 0;

		private static uint __SetTicksPerSecond = 0;

		private static uint __SetThirtySecondNotesPerMinute = 0;

		private static uint __SetSecondsPerTick = 0;

		private static uint __SetMillisecondsPerTick = 0;

		private static uint __SetBeatsPerMinute = 0;

		private static uint __ResumeClock = 0;

		private static uint __ResetTransportQuantized = 0;

		private static uint __ResetTransport = 0;

		private static uint __PauseClock = 0;

		private static uint __NotifyOnQuantizationBoundary = 0;

		private static uint __IsClockRunning = 0;

		private static uint __GetTicksPerSecond = 0;

		private static uint __GetThirtySecondNotesPerMinute = 0;

		private static uint __GetSecondsPerTick = 0;

		private static uint __GetMillisecondsPerTick = 0;

		private static uint __GetEstimatedRunTime = 0;

		private static uint __GetDurationOfQuantizationTypeInSeconds = 0;

		private static uint __GetCurrentTimestamp = 0;

		private static uint __GetBeatsPerMinute = 0;

		private static uint __GetBeatProgressPercent = 0;
	}
}