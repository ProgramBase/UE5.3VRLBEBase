using Script.CoreUObject;
using Script.AudioMixer;
using Script.Engine;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.GranularSynth")]
	public partial class UGranularSynth : USynthComponent, IStaticClass
	{
		public USoundWave GranulatedSoundWave
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GranulatedSoundWave, __ReturnBuffer);

					return *(USoundWave*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GranulatedSoundWave, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.GranularSynth");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSustainGain(float SustainGain)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = SustainGain;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSustainGain, __InBuffer);
			}
		}

		public virtual void SetSoundWave(USoundWave InSoundWave)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSoundWave?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSoundWave, __InBuffer);
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

		public virtual void SetReleaseTimeMsec(float ReleaseTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = ReleaseTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReleaseTimeMsec, __InBuffer);
			}
		}

		public virtual void SetPlayheadTime(float InPositionSec, float LerpTimeSec = 0.000000f, EGranularSynthSeekType SeekType = EGranularSynthSeekType.FromBeginning)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(float*)(__InBuffer) = InPositionSec;

				*(float*)(__InBuffer + 4) = LerpTimeSec;

				*(byte*)(__InBuffer + 8) = (byte)SeekType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlayheadTime, __InBuffer);
			}
		}

		public virtual void SetPlaybackSpeed(float InPlayheadRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InPlayheadRate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlaybackSpeed, __InBuffer);
			}
		}

		public virtual void SetGrainVolume(float BaseVolume, FVector2D VolumeRange = null)
		{
			unsafe
			{
				VolumeRange ??= new FVector2D();

				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = BaseVolume;

				*(nint*)(__InBuffer + 4) = VolumeRange?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGrainVolume, __InBuffer);
			}
		}

		public virtual void SetGrainsPerSecond(float InGrainsPerSecond)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InGrainsPerSecond;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGrainsPerSecond, __InBuffer);
			}
		}

		public virtual void SetGrainProbability(float InGrainProbability)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InGrainProbability;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGrainProbability, __InBuffer);
			}
		}

		public virtual void SetGrainPitch(float BasePitch, FVector2D PitchRange = null)
		{
			unsafe
			{
				PitchRange ??= new FVector2D();

				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = BasePitch;

				*(nint*)(__InBuffer + 4) = PitchRange?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGrainPitch, __InBuffer);
			}
		}

		public virtual void SetGrainPan(float BasePan, FVector2D PanRange = null)
		{
			unsafe
			{
				PanRange ??= new FVector2D();

				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = BasePan;

				*(nint*)(__InBuffer + 4) = PanRange?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGrainPan, __InBuffer);
			}
		}

		public virtual void SetGrainEnvelopeType(EGranularSynthEnvelopeType EnvelopeType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)EnvelopeType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGrainEnvelopeType, __InBuffer);
			}
		}

		public virtual void SetGrainDuration(float BaseDurationMsec, FVector2D DurationRange = null)
		{
			unsafe
			{
				DurationRange ??= new FVector2D();

				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = BaseDurationMsec;

				*(nint*)(__InBuffer + 4) = DurationRange?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGrainDuration, __InBuffer);
			}
		}

		public virtual void SetDecayTime(float DecayTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DecayTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDecayTime, __InBuffer);
			}
		}

		public virtual void SetAttackTime(float AttackTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = AttackTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAttackTime, __InBuffer);
			}
		}

		public virtual void NoteOn(float Note, int Velocity, float Duration = -1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = Note;

				*(int*)(__InBuffer + 4) = Velocity;

				*(float*)(__InBuffer + 8) = Duration;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __NoteOn, __InBuffer);
			}
		}

		public virtual void NoteOff(float Note, bool bKill = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Note;

				*(bool*)(__InBuffer + 4) = bKill;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __NoteOff, __InBuffer);
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

		public virtual float GetCurrentPlayheadTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCurrentPlayheadTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __GranulatedSoundWave = 0;

		private static uint __SetSustainGain = 0;

		private static uint __SetSoundWave = 0;

		private static uint __SetScrubMode = 0;

		private static uint __SetReleaseTimeMsec = 0;

		private static uint __SetPlayheadTime = 0;

		private static uint __SetPlaybackSpeed = 0;

		private static uint __SetGrainVolume = 0;

		private static uint __SetGrainsPerSecond = 0;

		private static uint __SetGrainProbability = 0;

		private static uint __SetGrainPitch = 0;

		private static uint __SetGrainPan = 0;

		private static uint __SetGrainEnvelopeType = 0;

		private static uint __SetGrainDuration = 0;

		private static uint __SetDecayTime = 0;

		private static uint __SetAttackTime = 0;

		private static uint __NoteOn = 0;

		private static uint __NoteOff = 0;

		private static uint __IsLoaded = 0;

		private static uint __GetSampleDuration = 0;

		private static uint __GetCurrentPlayheadTime = 0;
	}
}