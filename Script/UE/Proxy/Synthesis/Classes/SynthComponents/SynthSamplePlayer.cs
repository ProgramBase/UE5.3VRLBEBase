using Script.CoreUObject;
using Script.AudioMixer;
using Script.Engine;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SynthSamplePlayer")]
	public partial class USynthSamplePlayer : USynthComponent, IStaticClass
	{
		public USoundWave SoundWave
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoundWave, __ReturnBuffer);

					return *(USoundWave*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoundWave, __InBuffer);
				}
			}
		}

		public FOnSampleLoaded OnSampleLoaded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSampleLoaded, __ReturnBuffer);

					return *(FOnSampleLoaded*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSampleLoaded, __InBuffer);
				}
			}
		}

		public FOnSamplePlaybackProgress OnSamplePlaybackProgress
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSamplePlaybackProgress, __ReturnBuffer);

					return *(FOnSamplePlaybackProgress*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSamplePlaybackProgress, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.SynthSamplePlayer");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSoundWave(USoundWave InSoundWave)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSoundWave?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSoundWave, __InBuffer);
			}
		}

		public virtual void SetScrubTimeWidth(float InScrubTimeWidthSec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InScrubTimeWidthSec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScrubTimeWidth, __InBuffer);
			}
		}

		public virtual void SetScrubMode(bool bScrubMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bScrubMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScrubMode, __InBuffer);
			}
		}

		public virtual void SetPitch(float InPitch, float TimeSec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = InPitch;

				*(float*)(__InBuffer + 4) = TimeSec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPitch, __InBuffer);
			}
		}

		public virtual void SeekToTime(float TimeSec, ESamplePlayerSeekType SeekType, bool bWrap = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(float*)(__InBuffer) = TimeSec;

				*(byte*)(__InBuffer + 4) = (byte)SeekType;

				*(bool*)(__InBuffer + 5) = bWrap;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SeekToTime, __InBuffer);
			}
		}

		public virtual bool IsLoaded()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLoaded, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetSampleDuration()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSampleDuration, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetCurrentPlaybackProgressTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCurrentPlaybackProgressTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetCurrentPlaybackProgressPercent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCurrentPlaybackProgressPercent, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __SoundWave = 0;

		private static uint __OnSampleLoaded = 0;

		private static uint __OnSamplePlaybackProgress = 0;

		private static uint __SetSoundWave = 0;

		private static uint __SetScrubTimeWidth = 0;

		private static uint __SetScrubMode = 0;

		private static uint __SetPitch = 0;

		private static uint __SeekToTime = 0;

		private static uint __IsLoaded = 0;

		private static uint __GetSampleDuration = 0;

		private static uint __GetCurrentPlaybackProgressTime = 0;

		private static uint __GetCurrentPlaybackProgressPercent = 0;
	}
}