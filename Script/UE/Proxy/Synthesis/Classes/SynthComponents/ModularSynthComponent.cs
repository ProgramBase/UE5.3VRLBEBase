using Script.CoreUObject;
using Script.AudioMixer;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.ModularSynthComponent")]
	public partial class UModularSynthComponent : USynthComponent, IStaticClass
	{
		public int VoiceCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VoiceCount, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VoiceCount, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.ModularSynthComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSynthPreset(FModularSynthPreset SynthPreset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SynthPreset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSynthPreset, __InBuffer);
			}
		}

		public virtual void SetSustainGain(float SustainGain)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = SustainGain;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSustainGain, __InBuffer);
			}
		}

		public virtual void SetStereoDelayWetlevel(float DelayWetlevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DelayWetlevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStereoDelayWetlevel, __InBuffer);
			}
		}

		public virtual void SetStereoDelayTime(float DelayTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DelayTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStereoDelayTime, __InBuffer);
			}
		}

		public virtual void SetStereoDelayRatio(float DelayRatio)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DelayRatio;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStereoDelayRatio, __InBuffer);
			}
		}

		public virtual void SetStereoDelayMode(ESynthStereoDelayMode StereoDelayMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)StereoDelayMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStereoDelayMode, __InBuffer);
			}
		}

		public virtual void SetStereoDelayIsEnabled(bool StereoDelayEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = StereoDelayEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStereoDelayIsEnabled, __InBuffer);
			}
		}

		public virtual void SetStereoDelayFeedback(float DelayFeedback)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DelayFeedback;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStereoDelayFeedback, __InBuffer);
			}
		}

		public virtual void SetSpread(float Spread)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Spread;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSpread, __InBuffer);
			}
		}

		public virtual void SetReleaseTime(float ReleaseTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = ReleaseTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReleaseTime, __InBuffer);
			}
		}

		public virtual void SetPortamento(float Portamento)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Portamento;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPortamento, __InBuffer);
			}
		}

		public virtual void SetPitchBend(float PitchBend)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = PitchBend;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPitchBend, __InBuffer);
			}
		}

		public virtual void SetPan(float Pan)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Pan;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPan, __InBuffer);
			}
		}

		/// <param name="OscIndex">
		/// Which oscillator to set the type for.
		/// </param>
		/// <param name="OscType">
		/// The oscillator type to set.
		/// </param>
		public virtual void SetOscType(int OscIndex, ESynth1OscType OscType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = OscIndex;

				*(byte*)(__InBuffer + 4) = (byte)OscType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOscType, __InBuffer);
			}
		}

		public virtual void SetOscSync(bool bIsSynced)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsSynced;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOscSync, __InBuffer);
			}
		}

		/// <param name="OscIndex">
		/// Which oscillator to set the type for.
		/// </param>
		/// <param name="Semitones">
		/// The amount of semitones to set the oscillator to (relative to base frequency/pitch).
		/// </param>
		public virtual void SetOscSemitones(int OscIndex, float Semitones)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = OscIndex;

				*(float*)(__InBuffer + 4) = Semitones;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOscSemitones, __InBuffer);
			}
		}

		public virtual void SetOscPulsewidth(int OscIndex, float Pulsewidth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = OscIndex;

				*(float*)(__InBuffer + 4) = Pulsewidth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOscPulsewidth, __InBuffer);
			}
		}

		/// <param name="OscIndex">
		/// Which oscillator to set the type for.
		/// </param>
		/// <param name="Octave">
		/// Which octave to set the oscillator to (relative to base frequency/pitch).
		/// </param>
		public virtual void SetOscOctave(int OscIndex, float Octave)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = OscIndex;

				*(float*)(__InBuffer + 4) = Octave;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOscOctave, __InBuffer);
			}
		}

		/// <param name="OscIndex">
		/// Which oscillator to set the type for.
		/// </param>
		/// <param name="OscGainMod">
		/// The oscillator gain modulation to use.
		/// </param>
		public virtual void SetOscGainMod(int OscIndex, float OscGainMod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = OscIndex;

				*(float*)(__InBuffer + 4) = OscGainMod;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOscGainMod, __InBuffer);
			}
		}

		/// <param name="OscIndex">
		/// Which oscillator to set the type for.
		/// </param>
		/// <param name="OscGain">
		/// The oscillator gain.
		/// </param>
		public virtual void SetOscGain(int OscIndex, float OscGain)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = OscIndex;

				*(float*)(__InBuffer + 4) = OscGain;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOscGain, __InBuffer);
			}
		}

		/// <param name="OscIndex">
		/// Which oscillator to set the type for.
		/// </param>
		/// <param name="OscFreqMod">
		/// The oscillator frequency modulation to use.
		/// </param>
		public virtual void SetOscFrequencyMod(int OscIndex, float OscFreqMod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = OscIndex;

				*(float*)(__InBuffer + 4) = OscFreqMod;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOscFrequencyMod, __InBuffer);
			}
		}

		/// <param name="OscIndex">
		/// Which oscillator to set the type for.
		/// </param>
		/// <param name="Cents">
		/// The amount of cents to set the oscillator to (relative to base frequency/pitch)..
		/// </param>
		public virtual void SetOscCents(int OscIndex, float Cents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = OscIndex;

				*(float*)(__InBuffer + 4) = Cents;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOscCents, __InBuffer);
			}
		}

		public virtual void SetModEnvSustainGain(float SustainGain)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = SustainGain;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetModEnvSustainGain, __InBuffer);
			}
		}

		public virtual void SetModEnvReleaseTime(float Release)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Release;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetModEnvReleaseTime, __InBuffer);
			}
		}

		public virtual void SetModEnvPatch(ESynthModEnvPatch InPatchType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InPatchType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetModEnvPatch, __InBuffer);
			}
		}

		public virtual void SetModEnvInvert(bool bInvert)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInvert;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetModEnvInvert, __InBuffer);
			}
		}

		public virtual void SetModEnvDepth(float Depth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Depth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetModEnvDepth, __InBuffer);
			}
		}

		public virtual void SetModEnvDecayTime(float DecayTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DecayTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetModEnvDecayTime, __InBuffer);
			}
		}

		public virtual void SetModEnvBiasPatch(ESynthModEnvBiasPatch InPatchType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InPatchType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetModEnvBiasPatch, __InBuffer);
			}
		}

		public virtual void SetModEnvBiasInvert(bool bInvert)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInvert;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetModEnvBiasInvert, __InBuffer);
			}
		}

		public virtual void SetModEnvAttackTime(float AttackTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = AttackTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetModEnvAttackTime, __InBuffer);
			}
		}

		/// <param name="LFOIndex">
		/// Which LFO to set the frequency for.
		/// </param>
		/// <param name="LFOType">
		/// The LFO type to use.
		/// </param>
		public virtual void SetLFOType(int LFOIndex, ESynthLFOType LFOType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = LFOIndex;

				*(byte*)(__InBuffer + 4) = (byte)LFOType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLFOType, __InBuffer);
			}
		}

		/// <param name="LFOIndex">
		/// Which LFO to set the frequency for.
		/// </param>
		/// <param name="LFOPatchType">
		/// The LFO patch type to use.
		/// </param>
		public virtual void SetLFOPatch(int LFOIndex, ESynthLFOPatchType LFOPatchType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = LFOIndex;

				*(byte*)(__InBuffer + 4) = (byte)LFOPatchType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLFOPatch, __InBuffer);
			}
		}

		/// <param name="LFOIndex">
		/// Which LFO to set the frequency for.
		/// </param>
		/// <param name="LFOMode">
		/// The LFO mode to use.
		/// </param>
		public virtual void SetLFOMode(int LFOIndex, ESynthLFOMode LFOMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = LFOIndex;

				*(byte*)(__InBuffer + 4) = (byte)LFOMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLFOMode, __InBuffer);
			}
		}

		/// <param name="LFOIndex">
		/// Which LFO to set the frequency for.
		/// </param>
		/// <param name="Gain">
		/// The gain factor to use for the LFO.
		/// </param>
		public virtual void SetLFOGainMod(int LFOIndex, float GainMod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = LFOIndex;

				*(float*)(__InBuffer + 4) = GainMod;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLFOGainMod, __InBuffer);
			}
		}

		/// <param name="LFOIndex">
		/// Which LFO to set the frequency for.
		/// </param>
		/// <param name="Gain">
		/// The gain factor to use for the LFO.
		/// </param>
		public virtual void SetLFOGain(int LFOIndex, float Gain)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = LFOIndex;

				*(float*)(__InBuffer + 4) = Gain;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLFOGain, __InBuffer);
			}
		}

		/// <param name="LFOIndex">
		/// Which LFO to set the frequency for.
		/// </param>
		/// <param name="FrequencyModHz">
		/// The LFO frequency to use.
		/// </param>
		public virtual void SetLFOFrequencyMod(int LFOIndex, float FrequencyModHz)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = LFOIndex;

				*(float*)(__InBuffer + 4) = FrequencyModHz;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLFOFrequencyMod, __InBuffer);
			}
		}

		/// <param name="LFOIndex">
		/// Which LFO to set the frequency for.
		/// </param>
		/// <param name="FrequencyHz">
		/// The LFO frequency to use.
		/// </param>
		public virtual void SetLFOFrequency(int LFOIndex, float FrequencyHz)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = LFOIndex;

				*(float*)(__InBuffer + 4) = FrequencyHz;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLFOFrequency, __InBuffer);
			}
		}

		public virtual void SetGainDb(float GainDb)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = GainDb;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGainDb, __InBuffer);
			}
		}

		public virtual void SetFilterType(ESynthFilterType FilterType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)FilterType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterType, __InBuffer);
			}
		}

		public virtual void SetFilterQMod(float FilterQ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = FilterQ;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterQMod, __InBuffer);
			}
		}

		public virtual void SetFilterQ(float FilterQ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = FilterQ;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterQ, __InBuffer);
			}
		}

		public virtual void SetFilterFrequencyMod(float FilterFrequencyHz)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = FilterFrequencyHz;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterFrequencyMod, __InBuffer);
			}
		}

		public virtual void SetFilterFrequency(float FilterFrequencyHz)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = FilterFrequencyHz;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterFrequency, __InBuffer);
			}
		}

		public virtual void SetFilterAlgorithm(ESynthFilterAlgorithm FilterAlgorithm)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)FilterAlgorithm;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterAlgorithm, __InBuffer);
			}
		}

		public virtual void SetEnableUnison(bool EnableUnison)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = EnableUnison;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableUnison, __InBuffer);
			}
		}

		public virtual void SetEnableRetrigger(bool RetriggerEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = RetriggerEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableRetrigger, __InBuffer);
			}
		}

		/// <param name="bEnablePolyphony">
		/// Whether or not to enable polyphony for the synth.
		/// </param>
		public virtual void SetEnablePolyphony(bool bEnablePolyphony)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnablePolyphony;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnablePolyphony, __InBuffer);
			}
		}

		public virtual bool SetEnablePatch(FPatchId PatchId, bool bIsEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = PatchId?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsEnabled;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetEnablePatch, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetEnableLegato(bool LegatoEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = LegatoEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableLegato, __InBuffer);
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

		public virtual void SetChorusFrequency(float Frequency)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Frequency;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetChorusFrequency, __InBuffer);
			}
		}

		public virtual void SetChorusFeedback(float Feedback)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Feedback;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetChorusFeedback, __InBuffer);
			}
		}

		public virtual void SetChorusEnabled(bool EnableChorus)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = EnableChorus;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetChorusEnabled, __InBuffer);
			}
		}

		public virtual void SetChorusDepth(float Depth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Depth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetChorusDepth, __InBuffer);
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

		public virtual void NoteOff(float Note, bool bAllNotesOff = false, bool bKillAllNotes = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(float*)(__InBuffer) = Note;

				*(bool*)(__InBuffer + 4) = bAllNotesOff;

				*(bool*)(__InBuffer + 5) = bKillAllNotes;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __NoteOff, __InBuffer);
			}
		}

		public virtual FPatchId CreatePatch(ESynth1PatchSource PatchSource, TArray<FSynth1PatchCable> PatchCables, bool bEnableByDefault)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(byte*)(__InBuffer) = (byte)PatchSource;

				*(nint*)(__InBuffer + 1) = PatchCables?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 9) = bEnableByDefault;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreatePatch, __InBuffer, __ReturnBuffer);

				return *(FPatchId*)__ReturnBuffer;
			}
		}

		private static uint __VoiceCount = 0;

		private static uint __SetSynthPreset = 0;

		private static uint __SetSustainGain = 0;

		private static uint __SetStereoDelayWetlevel = 0;

		private static uint __SetStereoDelayTime = 0;

		private static uint __SetStereoDelayRatio = 0;

		private static uint __SetStereoDelayMode = 0;

		private static uint __SetStereoDelayIsEnabled = 0;

		private static uint __SetStereoDelayFeedback = 0;

		private static uint __SetSpread = 0;

		private static uint __SetReleaseTime = 0;

		private static uint __SetPortamento = 0;

		private static uint __SetPitchBend = 0;

		private static uint __SetPan = 0;

		private static uint __SetOscType = 0;

		private static uint __SetOscSync = 0;

		private static uint __SetOscSemitones = 0;

		private static uint __SetOscPulsewidth = 0;

		private static uint __SetOscOctave = 0;

		private static uint __SetOscGainMod = 0;

		private static uint __SetOscGain = 0;

		private static uint __SetOscFrequencyMod = 0;

		private static uint __SetOscCents = 0;

		private static uint __SetModEnvSustainGain = 0;

		private static uint __SetModEnvReleaseTime = 0;

		private static uint __SetModEnvPatch = 0;

		private static uint __SetModEnvInvert = 0;

		private static uint __SetModEnvDepth = 0;

		private static uint __SetModEnvDecayTime = 0;

		private static uint __SetModEnvBiasPatch = 0;

		private static uint __SetModEnvBiasInvert = 0;

		private static uint __SetModEnvAttackTime = 0;

		private static uint __SetLFOType = 0;

		private static uint __SetLFOPatch = 0;

		private static uint __SetLFOMode = 0;

		private static uint __SetLFOGainMod = 0;

		private static uint __SetLFOGain = 0;

		private static uint __SetLFOFrequencyMod = 0;

		private static uint __SetLFOFrequency = 0;

		private static uint __SetGainDb = 0;

		private static uint __SetFilterType = 0;

		private static uint __SetFilterQMod = 0;

		private static uint __SetFilterQ = 0;

		private static uint __SetFilterFrequencyMod = 0;

		private static uint __SetFilterFrequency = 0;

		private static uint __SetFilterAlgorithm = 0;

		private static uint __SetEnableUnison = 0;

		private static uint __SetEnableRetrigger = 0;

		private static uint __SetEnablePolyphony = 0;

		private static uint __SetEnablePatch = 0;

		private static uint __SetEnableLegato = 0;

		private static uint __SetDecayTime = 0;

		private static uint __SetChorusFrequency = 0;

		private static uint __SetChorusFeedback = 0;

		private static uint __SetChorusEnabled = 0;

		private static uint __SetChorusDepth = 0;

		private static uint __SetAttackTime = 0;

		private static uint __NoteOn = 0;

		private static uint __NoteOff = 0;

		private static uint __CreatePatch = 0;
	}
}