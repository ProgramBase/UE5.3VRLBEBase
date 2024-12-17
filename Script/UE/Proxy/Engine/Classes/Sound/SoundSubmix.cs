using Script.CoreUObject;
using Script.AudioExtensions;
using Script.AudioLinkCore;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundSubmix")]
	public partial class USoundSubmix : USoundSubmixWithParentBase, IStaticClass
	{
		public bool bMuteWhenBackgrounded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bMuteWhenBackgrounded, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bMuteWhenBackgrounded, __InBuffer);
				}
			}
		}

		public TArray<USoundEffectSubmixPreset> SubmixEffectChain
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubmixEffectChain, __ReturnBuffer);

					return *(TArray<USoundEffectSubmixPreset>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubmixEffectChain, __InBuffer);
				}
			}
		}

		public USoundfieldEncodingSettingsBase AmbisonicsPluginSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AmbisonicsPluginSettings, __ReturnBuffer);

					return *(USoundfieldEncodingSettingsBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AmbisonicsPluginSettings, __InBuffer);
				}
			}
		}

		public int EnvelopeFollowerAttackTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EnvelopeFollowerAttackTime, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EnvelopeFollowerAttackTime, __InBuffer);
				}
			}
		}

		public int EnvelopeFollowerReleaseTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EnvelopeFollowerReleaseTime, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EnvelopeFollowerReleaseTime, __InBuffer);
				}
			}
		}

		public float OutputVolume
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OutputVolume, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OutputVolume, __InBuffer);
				}
			}
		}

		public float WetLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WetLevel, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WetLevel, __InBuffer);
				}
			}
		}

		public float DryLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DryLevel, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DryLevel, __InBuffer);
				}
			}
		}

		public FSoundModulationDestinationSettings OutputVolumeModulation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OutputVolumeModulation, __ReturnBuffer);

					return *(FSoundModulationDestinationSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OutputVolumeModulation, __InBuffer);
				}
			}
		}

		public FSoundModulationDestinationSettings WetLevelModulation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WetLevelModulation, __ReturnBuffer);

					return *(FSoundModulationDestinationSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WetLevelModulation, __InBuffer);
				}
			}
		}

		public FSoundModulationDestinationSettings DryLevelModulation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DryLevelModulation, __ReturnBuffer);

					return *(FSoundModulationDestinationSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DryLevelModulation, __InBuffer);
				}
			}
		}

		public bool bSendToAudioLink
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSendToAudioLink, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSendToAudioLink, __InBuffer);
				}
			}
		}

		public UAudioLinkSettingsAbstract AudioLinkSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioLinkSettings, __ReturnBuffer);

					return *(UAudioLinkSettingsAbstract*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioLinkSettings, __InBuffer);
				}
			}
		}

		public FOnSubmixRecordedFileDone OnSubmixRecordedFileDone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSubmixRecordedFileDone, __ReturnBuffer);

					return *(FOnSubmixRecordedFileDone*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSubmixRecordedFileDone, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundSubmix");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void StopSpectralAnalysis(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopSpectralAnalysis, __InBuffer);
			}
		}

		public virtual void StopRecordingOutput(UObject WorldContextObject, EAudioRecordingExportType ExportType, FString Name, FString Path, USoundWave ExistingSoundWaveToOverwrite = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)ExportType;

				*(nint*)(__InBuffer + 9) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = Path?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = ExistingSoundWaveToOverwrite?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopRecordingOutput, __InBuffer);
			}
		}

		public virtual void StopEnvelopeFollowing(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopEnvelopeFollowing, __InBuffer);
			}
		}

		public virtual void StartSpectralAnalysis(UObject WorldContextObject, EFFTSize FFTSize = EFFTSize.DefaultSize, EFFTPeakInterpolationMethod InterpolationMethod = EFFTPeakInterpolationMethod.Linear, EFFTWindowType WindowType = EFFTWindowType.Hann, float HopSize = 0.000000f, EAudioSpectrumType SpectrumType = EAudioSpectrumType.MagnitudeSpectrum)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)FFTSize;

				*(byte*)(__InBuffer + 9) = (byte)InterpolationMethod;

				*(byte*)(__InBuffer + 10) = (byte)WindowType;

				*(float*)(__InBuffer + 11) = HopSize;

				*(byte*)(__InBuffer + 15) = (byte)SpectrumType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartSpectralAnalysis, __InBuffer);
			}
		}

		public virtual void StartRecordingOutput(UObject WorldContextObject, float ExpectedDuration)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ExpectedDuration;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartRecordingOutput, __InBuffer);
			}
		}

		public virtual void StartEnvelopeFollowing(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartEnvelopeFollowing, __InBuffer);
			}
		}

		public virtual void SetWetVolumeModulation(FSoundModulationDestinationSettings InVolMod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVolMod?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWetVolumeModulation, __InBuffer);
			}
		}

		public virtual void SetSubmixWetLevel(UObject WorldContextObject, float InWetLevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InWetLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSubmixWetLevel, __InBuffer);
			}
		}

		public virtual void SetSubmixOutputVolume(UObject WorldContextObject, float InOutputVolume)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InOutputVolume;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSubmixOutputVolume, __InBuffer);
			}
		}

		public virtual void SetSubmixDryLevel(UObject WorldContextObject, float InDryLevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InDryLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSubmixDryLevel, __InBuffer);
			}
		}

		public virtual void SetOutputVolumeModulation(FSoundModulationDestinationSettings InVolMod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVolMod?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOutputVolumeModulation, __InBuffer);
			}
		}

		public virtual void SetDryVolumeModulation(FSoundModulationDestinationSettings InVolMod)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVolMod?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDryVolumeModulation, __InBuffer);
			}
		}

		/// <param name="OnSubmixSpectralAnalysisBP">
		/// The event delegate to remove.
		/// </param>
		public virtual void RemoveSpectralAnalysisDelegate(UObject WorldContextObject, FOnSubmixSpectralAnalysisBP OnSubmixSpectralAnalysisBP)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OnSubmixSpectralAnalysisBP?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveSpectralAnalysisDelegate, __InBuffer);
			}
		}

		/// <param name="InBandsettings">
		/// The frequency bands to analyze and their envelope-following settings.
		/// </param>
		/// <param name="OnSubmixSpectralAnalysisBP">
		/// Event to fire when new spectral data is available.
		/// </param>
		/// <param name="UpdateRate">
		/// How often to retrieve the data from the spectral analyzer and broadcast the event. Max is 30 times per second.
		/// </param>
		/// <param name="InterpMethod">
		/// Method to used for band peak calculation.
		/// </param>
		/// <param name="SpectrumType">
		/// Metric to use when returning spectrum values.
		/// </param>
		/// <param name="DecibelNoiseFloor">
		/// Decibel Noise Floor to consider as silence when using a Decibel Spectrum Type.
		/// </param>
		/// <param name="bDoNormalize">
		/// If true, output band values will be normalized between zero and one.
		/// </param>
		/// <param name="bDoAutoRange">
		/// If true, output band values will have their ranges automatically adjusted to the minimum and maximum values in the audio. Output band values will be normalized between zero and one.
		/// </param>
		/// <param name="AutoRangeAttackTime">
		/// The time (in seconds) it takes for the range to expand to 90% of a larger range.
		/// </param>
		/// <param name="AutoRangeReleaseTime">
		/// The time (in seconds) it takes for the range to shrink to 90% of a smaller range.
		/// </param>
		public virtual void AddSpectralAnalysisDelegate(UObject WorldContextObject, TArray<FSoundSubmixSpectralAnalysisBandSettings> InBandSettings, FOnSubmixSpectralAnalysisBP OnSubmixSpectralAnalysisBP, float UpdateRate = 10.000000f, float DecibelNoiseFloor = -40.000000f, bool bDoNormalize = true, bool bDoAutoRange = false, float AutoRangeAttackTime = 0.100000f, float AutoRangeReleaseTime = 60.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[42];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InBandSettings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OnSubmixSpectralAnalysisBP?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = UpdateRate;

				*(float*)(__InBuffer + 28) = DecibelNoiseFloor;

				*(bool*)(__InBuffer + 32) = bDoNormalize;

				*(bool*)(__InBuffer + 33) = bDoAutoRange;

				*(float*)(__InBuffer + 34) = AutoRangeAttackTime;

				*(float*)(__InBuffer + 38) = AutoRangeReleaseTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddSpectralAnalysisDelegate, __InBuffer);
			}
		}

		/// <param name="OnSubmixEnvelopeBP">
		/// Event to fire when new envelope data is available.
		/// </param>
		public virtual void AddEnvelopeFollowerDelegate(UObject WorldContextObject, FOnSubmixEnvelopeBP OnSubmixEnvelopeBP)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OnSubmixEnvelopeBP?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddEnvelopeFollowerDelegate, __InBuffer);
			}
		}

		private static uint __bMuteWhenBackgrounded = 0;

		private static uint __SubmixEffectChain = 0;

		private static uint __AmbisonicsPluginSettings = 0;

		private static uint __EnvelopeFollowerAttackTime = 0;

		private static uint __EnvelopeFollowerReleaseTime = 0;

		private static uint __OutputVolume = 0;

		private static uint __WetLevel = 0;

		private static uint __DryLevel = 0;

		private static uint __OutputVolumeModulation = 0;

		private static uint __WetLevelModulation = 0;

		private static uint __DryLevelModulation = 0;

		private static uint __bSendToAudioLink = 0;

		private static uint __AudioLinkSettings = 0;

		private static uint __OnSubmixRecordedFileDone = 0;

		private static uint __StopSpectralAnalysis = 0;

		private static uint __StopRecordingOutput = 0;

		private static uint __StopEnvelopeFollowing = 0;

		private static uint __StartSpectralAnalysis = 0;

		private static uint __StartRecordingOutput = 0;

		private static uint __StartEnvelopeFollowing = 0;

		private static uint __SetWetVolumeModulation = 0;

		private static uint __SetSubmixWetLevel = 0;

		private static uint __SetSubmixOutputVolume = 0;

		private static uint __SetSubmixDryLevel = 0;

		private static uint __SetOutputVolumeModulation = 0;

		private static uint __SetDryVolumeModulation = 0;

		private static uint __RemoveSpectralAnalysisDelegate = 0;

		private static uint __AddSpectralAnalysisDelegate = 0;

		private static uint __AddEnvelopeFollowerDelegate = 0;
	}
}