using Script.CoreUObject;
using Script.AudioMixer;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SynthComponentMonoWaveTable")]
	public partial class USynthComponentMonoWaveTable : USynthComponent, IStaticClass
	{
		public FOnTableAltered OnTableAltered
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTableAltered, __ReturnBuffer);

					return *(FOnTableAltered*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTableAltered, __InBuffer);
				}
			}
		}

		public FNumTablesChanged OnNumTablesChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnNumTablesChanged, __ReturnBuffer);

					return *(FNumTablesChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnNumTablesChanged, __InBuffer);
				}
			}
		}

		public UMonoWaveTableSynthPreset CurrentPreset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentPreset, __ReturnBuffer);

					return *(UMonoWaveTableSynthPreset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentPreset, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.SynthComponentMonoWaveTable");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetWaveTablePosition(float InPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InPosition;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWaveTablePosition, __InBuffer);
			}
		}

		public virtual void SetSustainPedalState(bool InSustainPedalState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InSustainPedalState;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSustainPedalState, __InBuffer);
			}
		}

		public virtual void SetPosLfoType(ESynthLFOType InLfoType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InLfoType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPosLfoType, __InBuffer);
			}
		}

		public virtual void SetPosLfoFrequency(float InLfoFrequency)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InLfoFrequency;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPosLfoFrequency, __InBuffer);
			}
		}

		public virtual void SetPosLfoDepth(float InLfoDepth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InLfoDepth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPosLfoDepth, __InBuffer);
			}
		}

		public virtual void SetPositionEnvelopeSustainGain(float InSustainGain)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InSustainGain;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPositionEnvelopeSustainGain, __InBuffer);
			}
		}

		public virtual void SetPositionEnvelopeReleaseTime(float InReleaseTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InReleaseTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPositionEnvelopeReleaseTime, __InBuffer);
			}
		}

		public virtual void SetPositionEnvelopeInvert(bool bInInvert)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInInvert;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPositionEnvelopeInvert, __InBuffer);
			}
		}

		public virtual void SetPositionEnvelopeDepth(float InDepth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDepth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPositionEnvelopeDepth, __InBuffer);
			}
		}

		public virtual void SetPositionEnvelopeDecayTime(float InDecayTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDecayTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPositionEnvelopeDecayTime, __InBuffer);
			}
		}

		public virtual void SetPositionEnvelopeBiasInvert(bool bInBiasInvert)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInBiasInvert;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPositionEnvelopeBiasInvert, __InBuffer);
			}
		}

		public virtual void SetPositionEnvelopeBiasDepth(float InDepth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDepth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPositionEnvelopeBiasDepth, __InBuffer);
			}
		}

		public virtual void SetPositionEnvelopeAttackTime(float InAttackTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InAttackTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPositionEnvelopeAttackTime, __InBuffer);
			}
		}

		public virtual void SetLowPassFilterResonance(float InNewQ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InNewQ;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLowPassFilterResonance, __InBuffer);
			}
		}

		public virtual void SetFrequencyWithMidiNote(float InMidiNote)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InMidiNote;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrequencyWithMidiNote, __InBuffer);
			}
		}

		public virtual void SetFrequencyPitchBend(float FrequencyOffsetCents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = FrequencyOffsetCents;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrequencyPitchBend, __InBuffer);
			}
		}

		public virtual void SetFrequency(float FrequencyHz)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = FrequencyHz;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrequency, __InBuffer);
			}
		}

		public virtual void SetFilterEnvelopeSustainGain(float InSustainGain)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InSustainGain;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterEnvelopeSustainGain, __InBuffer);
			}
		}

		public virtual void SetFilterEnvelopeReleaseTime(float InReleaseTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InReleaseTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterEnvelopeReleaseTime, __InBuffer);
			}
		}

		public virtual void SetFilterEnvelopenDecayTime(float InDecayTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDecayTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterEnvelopenDecayTime, __InBuffer);
			}
		}

		public virtual void SetFilterEnvelopeInvert(bool bInInvert)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInInvert;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterEnvelopeInvert, __InBuffer);
			}
		}

		public virtual void SetFilterEnvelopeDepth(float InDepth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDepth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterEnvelopeDepth, __InBuffer);
			}
		}

		public virtual void SetFilterEnvelopeBiasInvert(bool bInBiasInvert)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInBiasInvert;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterEnvelopeBiasInvert, __InBuffer);
			}
		}

		public virtual void SetFilterEnvelopeBiasDepth(float InDepth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDepth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterEnvelopeBiasDepth, __InBuffer);
			}
		}

		public virtual void SetFilterEnvelopeAttackTime(float InAttackTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InAttackTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterEnvelopeAttackTime, __InBuffer);
			}
		}

		public virtual bool SetCurveValue(int TableIndex, int KeyframeIndex, float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = TableIndex;

				*(int*)(__InBuffer + 4) = KeyframeIndex;

				*(float*)(__InBuffer + 8) = NewValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCurveValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCurveTangent(int TableIndex, float InNewTangent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = TableIndex;

				*(float*)(__InBuffer + 4) = InNewTangent;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCurveTangent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCurveInterpolationType(CurveInterpolationType InterpolationType, int TableIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)InterpolationType;

				*(int*)(__InBuffer + 1) = TableIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCurveInterpolationType, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetAmpEnvelopeSustainGain(float InSustainGain)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InSustainGain;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAmpEnvelopeSustainGain, __InBuffer);
			}
		}

		public virtual void SetAmpEnvelopeReleaseTime(float InReleaseTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InReleaseTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAmpEnvelopeReleaseTime, __InBuffer);
			}
		}

		public virtual void SetAmpEnvelopeInvert(bool bInInvert)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInInvert;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAmpEnvelopeInvert, __InBuffer);
			}
		}

		public virtual void SetAmpEnvelopeDepth(float InDepth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDepth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAmpEnvelopeDepth, __InBuffer);
			}
		}

		public virtual void SetAmpEnvelopeDecayTime(float InDecayTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDecayTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAmpEnvelopeDecayTime, __InBuffer);
			}
		}

		public virtual void SetAmpEnvelopeBiasInvert(bool bInBiasInvert)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInBiasInvert;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAmpEnvelopeBiasInvert, __InBuffer);
			}
		}

		public virtual void SetAmpEnvelopeBiasDepth(float InDepth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InDepth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAmpEnvelopeBiasDepth, __InBuffer);
			}
		}

		public virtual void SetAmpEnvelopeAttackTime(float InAttackTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InAttackTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAmpEnvelopeAttackTime, __InBuffer);
			}
		}

		public virtual void RefreshWaveTable(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RefreshWaveTable, __InBuffer);
			}
		}

		public virtual void RefreshAllWaveTables()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RefreshAllWaveTables);
			}
		}

		public virtual void NoteOn(float InMidiNote, float InVelocity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = InMidiNote;

				*(float*)(__InBuffer + 4) = InVelocity;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __NoteOn, __InBuffer);
			}
		}

		public virtual void NoteOff(float InMidiNote)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InMidiNote;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __NoteOff, __InBuffer);
			}
		}

		public virtual int GetNumTableEntries()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumTableEntries, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetMaxTableIndex()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetMaxTableIndex, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual TArray<float> GetKeyFrameValuesForTable(float TableIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = TableIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetKeyFrameValuesForTable, __InBuffer, __ReturnBuffer);

				return *(TArray<float>*)__ReturnBuffer;
			}
		}

		public virtual float GetCurveTangent(int TableIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = TableIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetCurveTangent, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __OnTableAltered = 0;

		private static uint __OnNumTablesChanged = 0;

		private static uint __CurrentPreset = 0;

		private static uint __SetWaveTablePosition = 0;

		private static uint __SetSustainPedalState = 0;

		private static uint __SetPosLfoType = 0;

		private static uint __SetPosLfoFrequency = 0;

		private static uint __SetPosLfoDepth = 0;

		private static uint __SetPositionEnvelopeSustainGain = 0;

		private static uint __SetPositionEnvelopeReleaseTime = 0;

		private static uint __SetPositionEnvelopeInvert = 0;

		private static uint __SetPositionEnvelopeDepth = 0;

		private static uint __SetPositionEnvelopeDecayTime = 0;

		private static uint __SetPositionEnvelopeBiasInvert = 0;

		private static uint __SetPositionEnvelopeBiasDepth = 0;

		private static uint __SetPositionEnvelopeAttackTime = 0;

		private static uint __SetLowPassFilterResonance = 0;

		private static uint __SetFrequencyWithMidiNote = 0;

		private static uint __SetFrequencyPitchBend = 0;

		private static uint __SetFrequency = 0;

		private static uint __SetFilterEnvelopeSustainGain = 0;

		private static uint __SetFilterEnvelopeReleaseTime = 0;

		private static uint __SetFilterEnvelopenDecayTime = 0;

		private static uint __SetFilterEnvelopeInvert = 0;

		private static uint __SetFilterEnvelopeDepth = 0;

		private static uint __SetFilterEnvelopeBiasInvert = 0;

		private static uint __SetFilterEnvelopeBiasDepth = 0;

		private static uint __SetFilterEnvelopeAttackTime = 0;

		private static uint __SetCurveValue = 0;

		private static uint __SetCurveTangent = 0;

		private static uint __SetCurveInterpolationType = 0;

		private static uint __SetAmpEnvelopeSustainGain = 0;

		private static uint __SetAmpEnvelopeReleaseTime = 0;

		private static uint __SetAmpEnvelopeInvert = 0;

		private static uint __SetAmpEnvelopeDepth = 0;

		private static uint __SetAmpEnvelopeDecayTime = 0;

		private static uint __SetAmpEnvelopeBiasInvert = 0;

		private static uint __SetAmpEnvelopeBiasDepth = 0;

		private static uint __SetAmpEnvelopeAttackTime = 0;

		private static uint __RefreshWaveTable = 0;

		private static uint __RefreshAllWaveTables = 0;

		private static uint __NoteOn = 0;

		private static uint __NoteOff = 0;

		private static uint __GetNumTableEntries = 0;

		private static uint __GetMaxTableIndex = 0;

		private static uint __GetKeyFrameValuesForTable = 0;

		private static uint __GetCurveTangent = 0;
	}
}