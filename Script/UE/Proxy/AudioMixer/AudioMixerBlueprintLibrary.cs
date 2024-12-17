using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.AudioMixerBlueprintLibrary")]
	public partial class UAudioMixerBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioMixer.AudioMixerBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static float TrimAudioCache(float InMegabytesToFree)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InMegabytesToFree;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __TrimAudioCache, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="NewDeviceId">
		/// - the device Id to swap to
		/// </param>
		/// <param name="OnCompletedDeviceSwap">
		/// - the event to fire when the audio endpoint devices have been retrieved
		/// </param>
		public static void SwapAudioOutputDevice(UObject WorldContextObject, FString NewDeviceId, FOnCompletedDeviceSwap OnCompletedDeviceSwap)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewDeviceId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OnCompletedDeviceSwap?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SwapAudioOutputDevice, __InBuffer);
			}
		}

		public static USoundWave StopRecordingOutput(UObject WorldContextObject, EAudioRecordingExportType ExportType, FString Name, FString Path, USoundSubmix SubmixToRecord = null, USoundWave ExistingSoundWaveToOverwrite = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)ExportType;

				*(nint*)(__InBuffer + 9) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = Path?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = SubmixToRecord?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 33) = ExistingSoundWaveToOverwrite?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __StopRecordingOutput, __InBuffer, __ReturnBuffer);

				return *(USoundWave*)__ReturnBuffer;
			}
		}

		public static void StopAudioBus(UObject WorldContextObject, UAudioBus AudioBus)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AudioBus?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __StopAudioBus, __InBuffer);
			}
		}

		public static void StopAnalyzingOutput(UObject WorldContextObject, USoundSubmix SubmixToStopAnalyzing = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SubmixToStopAnalyzing?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __StopAnalyzingOutput, __InBuffer);
			}
		}

		public static void StartRecordingOutput(UObject WorldContextObject, float ExpectedDuration, USoundSubmix SubmixToRecord = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ExpectedDuration;

				*(nint*)(__InBuffer + 12) = SubmixToRecord?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __StartRecordingOutput, __InBuffer);
			}
		}

		public static void StartAudioBus(UObject WorldContextObject, UAudioBus AudioBus)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AudioBus?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __StartAudioBus, __InBuffer);
			}
		}

		public static void StartAnalyzingOutput(UObject WorldContextObject, USoundSubmix SubmixToAnalyze = null, EFFTSize FFTSize = EFFTSize.DefaultSize, EFFTPeakInterpolationMethod InterpolationMethod = EFFTPeakInterpolationMethod.Linear, EFFTWindowType WindowType = EFFTWindowType.Hann, float HopSize = 0.000000f, EAudioSpectrumType SpectrumType = EAudioSpectrumType.MagnitudeSpectrum)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SubmixToAnalyze?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)FFTSize;

				*(byte*)(__InBuffer + 17) = (byte)InterpolationMethod;

				*(byte*)(__InBuffer + 18) = (byte)WindowType;

				*(float*)(__InBuffer + 19) = HopSize;

				*(byte*)(__InBuffer + 23) = (byte)SpectrumType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __StartAnalyzingOutput, __InBuffer);
			}
		}

		public static void SetSubmixEffectChainOverride(UObject WorldContextObject, USoundSubmix SoundSubmix, TArray<USoundEffectSubmixPreset> SubmixEffectPresetChain, float FadeTimeSec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SoundSubmix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SubmixEffectPresetChain?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = FadeTimeSec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSubmixEffectChainOverride, __InBuffer);
			}
		}

		public static void SetBypassSourceEffectChainEntry(UObject WorldContextObject, USoundEffectSourcePresetChain PresetChain, int EntryIndex, bool bBypassed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PresetChain?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = EntryIndex;

				*(bool*)(__InBuffer + 20) = bBypassed;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBypassSourceEffectChainEntry, __InBuffer);
			}
		}

		public static void ResumeRecordingOutput(UObject WorldContextObject, USoundSubmix SubmixToPause = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SubmixToPause?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ResumeRecordingOutput, __InBuffer);
			}
		}

		public static void ReplaceSubmixEffect(UObject WorldContextObject, USoundSubmix InSoundSubmix, int SubmixChainIndex, USoundEffectSubmixPreset SubmixEffectPreset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSoundSubmix?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = SubmixChainIndex;

				*(nint*)(__InBuffer + 20) = SubmixEffectPreset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReplaceSubmixEffect, __InBuffer);
			}
		}

		public static void ReplaceSoundEffectSubmix(UObject WorldContextObject, USoundSubmix InSoundSubmix, int SubmixChainIndex, USoundEffectSubmixPreset SubmixEffectPreset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InSoundSubmix?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = SubmixChainIndex;

				*(nint*)(__InBuffer + 20) = SubmixEffectPreset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReplaceSoundEffectSubmix, __InBuffer);
			}
		}

		public static void RemoveSubmixEffectPresetAtIndex(UObject WorldContextObject, USoundSubmix SoundSubmix, int SubmixChainIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SoundSubmix?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = SubmixChainIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveSubmixEffectPresetAtIndex, __InBuffer);
			}
		}

		public static void RemoveSubmixEffectPreset(UObject WorldContextObject, USoundSubmix SoundSubmix, USoundEffectSubmixPreset SubmixEffectPreset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SoundSubmix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SubmixEffectPreset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveSubmixEffectPreset, __InBuffer);
			}
		}

		public static void RemoveSubmixEffectAtIndex(UObject WorldContextObject, USoundSubmix SoundSubmix, int SubmixChainIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SoundSubmix?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = SubmixChainIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveSubmixEffectAtIndex, __InBuffer);
			}
		}

		public static void RemoveSubmixEffect(UObject WorldContextObject, USoundSubmix SoundSubmix, USoundEffectSubmixPreset SubmixEffectPreset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SoundSubmix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SubmixEffectPreset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveSubmixEffect, __InBuffer);
			}
		}

		public static void RemoveSourceEffectFromPresetChain(UObject WorldContextObject, USoundEffectSourcePresetChain PresetChain, int EntryIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PresetChain?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = EntryIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveSourceEffectFromPresetChain, __InBuffer);
			}
		}

		public static void RemoveMasterSubmixEffect(UObject WorldContextObject, USoundEffectSubmixPreset SubmixEffectPreset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SubmixEffectPreset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveMasterSubmixEffect, __InBuffer);
			}
		}

		public static void PrimeSoundForPlayback(USoundWave SoundWave, FOnSoundLoadComplete OnLoadCompletion)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SoundWave?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OnLoadCompletion?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PrimeSoundForPlayback, __InBuffer);
			}
		}

		public static void PrimeSoundCueForPlayback(USoundCue SoundCue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoundCue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PrimeSoundCueForPlayback, __InBuffer);
			}
		}

		public static void PauseRecordingOutput(UObject WorldContextObject, USoundSubmix SubmixToPause = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SubmixToPause?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PauseRecordingOutput, __InBuffer);
			}
		}

		/// <param name="InBandPresetType">
		/// - The type audio content which the bands encompass.
		/// </param>
		/// <param name="InNumBands">
		/// - The number of bands used to represent the spectrum.
		/// </param>
		/// <param name="InAttackTimeMsec">
		/// - The attack time (in milliseconds) to apply to each band's envelope tracker.
		/// </param>
		/// <param name="InReleaseTimeMsec">
		/// - The release time (in milliseconds) to apply to each band's envelope tracker.
		/// </param>
		public static TArray<FSoundSubmixSpectralAnalysisBandSettings> MakePresetSpectralAnalysisBandSettings(EAudioSpectrumBandPresetType InBandPresetType, int InNumBands = 10, int InAttackTimeMsec = 10, int InReleaseTimeMsec = 10)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(byte*)(__InBuffer) = (byte)InBandPresetType;

				*(int*)(__InBuffer + 1) = InNumBands;

				*(int*)(__InBuffer + 5) = InAttackTimeMsec;

				*(int*)(__InBuffer + 9) = InReleaseTimeMsec;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakePresetSpectralAnalysisBandSettings, __InBuffer, __ReturnBuffer);

				return *(TArray<FSoundSubmixSpectralAnalysisBandSettings>*)__ReturnBuffer;
			}
		}

		/// <param name="InNumSemitones">
		/// - The number of semitones to represent.
		/// </param>
		/// <param name="InStartingMuiscalNote">
		/// - The name of the first note in the array.
		/// </param>
		/// <param name="InStartingOctave">
		/// - The octave of the first note in the array.
		/// </param>
		/// <param name="InAttackTimeMsec">
		/// - The attack time (in milliseconds) to apply to each band's envelope tracker.
		/// </param>
		/// <param name="InReleaseTimeMsec">
		/// - The release time (in milliseconds) to apply to each band's envelope tracker.
		/// </param>
		public static TArray<FSoundSubmixSpectralAnalysisBandSettings> MakeMusicalSpectralAnalysisBandSettings(int InNumSemitones = 60, EMusicalNoteName InStartingMusicalNote = EMusicalNoteName.C, int InStartingOctave = 2, int InAttackTimeMsec = 10, int InReleaseTimeMsec = 10)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(int*)(__InBuffer) = InNumSemitones;

				*(byte*)(__InBuffer + 4) = (byte)InStartingMusicalNote;

				*(int*)(__InBuffer + 5) = InStartingOctave;

				*(int*)(__InBuffer + 9) = InAttackTimeMsec;

				*(int*)(__InBuffer + 13) = InReleaseTimeMsec;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeMusicalSpectralAnalysisBandSettings, __InBuffer, __ReturnBuffer);

				return *(TArray<FSoundSubmixSpectralAnalysisBandSettings>*)__ReturnBuffer;
			}
		}

		/// <param name="InNumBands">
		/// - The number of bands to used to represent the spectrum.
		/// </param>
		/// <param name="InMinimumFrequency">
		/// - The center frequency of the first band.
		/// </param>
		/// <param name="InMaximumFrequency">
		/// - The center frequency of the last band.
		/// </param>
		/// <param name="InAttackTimeMsec">
		/// - The attack time (in milliseconds) to apply to each band's envelope tracker.
		/// </param>
		/// <param name="InReleaseTimeMsec">
		/// - The release time (in milliseconds) to apply to each band's envelope tracker.
		/// </param>
		public static TArray<FSoundSubmixSpectralAnalysisBandSettings> MakeFullSpectrumSpectralAnalysisBandSettings(int InNumBands = 30, float InMinimumFrequency = 40.000000f, float InMaximumFrequency = 16000.000000f, int InAttackTimeMsec = 10, int InReleaseTimeMsec = 10)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(int*)(__InBuffer) = InNumBands;

				*(float*)(__InBuffer + 4) = InMinimumFrequency;

				*(float*)(__InBuffer + 8) = InMaximumFrequency;

				*(int*)(__InBuffer + 12) = InAttackTimeMsec;

				*(int*)(__InBuffer + 16) = InReleaseTimeMsec;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeFullSpectrumSpectralAnalysisBandSettings, __InBuffer, __ReturnBuffer);

				return *(TArray<FSoundSubmixSpectralAnalysisBandSettings>*)__ReturnBuffer;
			}
		}

		public static bool IsAudioBusActive(UObject WorldContextObject, UAudioBus AudioBus)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AudioBus?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsAudioBusActive, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void GetPhaseForFrequencies(UObject WorldContextObject, TArray<float> Frequencies, ref TArray<float> Phases, USoundSubmix SubmixToAnalyze)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Frequencies?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Phases?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = SubmixToAnalyze?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetPhaseForFrequencies, __InBuffer, __OutBuffer);

				Phases = *(TArray<float>*)(__OutBuffer);

			}
		}

		public static int GetNumberOfEntriesInSourceEffectChain(UObject WorldContextObject, USoundEffectSourcePresetChain PresetChain)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PresetChain?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNumberOfEntriesInSourceEffectChain, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void GetMagnitudeForFrequencies(UObject WorldContextObject, TArray<float> Frequencies, ref TArray<float> Magnitudes, USoundSubmix SubmixToAnalyze)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Frequencies?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Magnitudes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = SubmixToAnalyze?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetMagnitudeForFrequencies, __InBuffer, __OutBuffer);

				Magnitudes = *(TArray<float>*)(__OutBuffer);

			}
		}

		/// <param name="OnObtainCurrentDeviceEvent">
		/// - the event to fire when the audio endpoint devices have been retrieved
		/// </param>
		public static void GetCurrentAudioOutputDeviceName(UObject WorldContextObject, FOnMainAudioOutputDeviceObtained OnObtainCurrentDeviceEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OnObtainCurrentDeviceEvent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentAudioOutputDeviceName, __InBuffer);
			}
		}

		/// <param name="OnObtainDevicesEvent">
		/// - the event to fire when the audio endpoint devices have been retrieved
		/// </param>
		public static void GetAvailableAudioOutputDevices(UObject WorldContextObject, FOnAudioOutputDevicesObtained OnObtainDevicesEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OnObtainDevicesEvent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __GetAvailableAudioOutputDevices, __InBuffer);
			}
		}

		/// <param name="info">
		/// - The audio device data to print
		/// </param>
		/// <returns>
		/// The data in a string format
		/// </returns>
		public static FString Conv_AudioOutputDeviceInfoToString(FAudioOutputDeviceInfo Info)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Info?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_AudioOutputDeviceInfoToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static void ClearSubmixEffects(UObject WorldContextObject, USoundSubmix SoundSubmix)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SoundSubmix?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearSubmixEffects, __InBuffer);
			}
		}

		public static void ClearSubmixEffectChainOverride(UObject WorldContextObject, USoundSubmix SoundSubmix, float FadeTimeSec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SoundSubmix?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = FadeTimeSec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearSubmixEffectChainOverride, __InBuffer);
			}
		}

		public static void ClearMasterSubmixEffects(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearMasterSubmixEffects, __InBuffer);
			}
		}

		public static int AddSubmixEffect(UObject WorldContextObject, USoundSubmix SoundSubmix, USoundEffectSubmixPreset SubmixEffectPreset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SoundSubmix?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SubmixEffectPreset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddSubmixEffect, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void AddSourceEffectToPresetChain(UObject WorldContextObject, USoundEffectSourcePresetChain PresetChain, FSourceEffectChainEntry Entry)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PresetChain?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Entry?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddSourceEffectToPresetChain, __InBuffer);
			}
		}

		public static void AddMasterSubmixEffect(UObject WorldContextObject, USoundEffectSubmixPreset SubmixEffectPreset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SubmixEffectPreset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddMasterSubmixEffect, __InBuffer);
			}
		}

		private static uint __TrimAudioCache = 0;

		private static uint __SwapAudioOutputDevice = 0;

		private static uint __StopRecordingOutput = 0;

		private static uint __StopAudioBus = 0;

		private static uint __StopAnalyzingOutput = 0;

		private static uint __StartRecordingOutput = 0;

		private static uint __StartAudioBus = 0;

		private static uint __StartAnalyzingOutput = 0;

		private static uint __SetSubmixEffectChainOverride = 0;

		private static uint __SetBypassSourceEffectChainEntry = 0;

		private static uint __ResumeRecordingOutput = 0;

		private static uint __ReplaceSubmixEffect = 0;

		private static uint __ReplaceSoundEffectSubmix = 0;

		private static uint __RemoveSubmixEffectPresetAtIndex = 0;

		private static uint __RemoveSubmixEffectPreset = 0;

		private static uint __RemoveSubmixEffectAtIndex = 0;

		private static uint __RemoveSubmixEffect = 0;

		private static uint __RemoveSourceEffectFromPresetChain = 0;

		private static uint __RemoveMasterSubmixEffect = 0;

		private static uint __PrimeSoundForPlayback = 0;

		private static uint __PrimeSoundCueForPlayback = 0;

		private static uint __PauseRecordingOutput = 0;

		private static uint __MakePresetSpectralAnalysisBandSettings = 0;

		private static uint __MakeMusicalSpectralAnalysisBandSettings = 0;

		private static uint __MakeFullSpectrumSpectralAnalysisBandSettings = 0;

		private static uint __IsAudioBusActive = 0;

		private static uint __GetPhaseForFrequencies = 0;

		private static uint __GetNumberOfEntriesInSourceEffectChain = 0;

		private static uint __GetMagnitudeForFrequencies = 0;

		private static uint __GetCurrentAudioOutputDeviceName = 0;

		private static uint __GetAvailableAudioOutputDevices = 0;

		private static uint __Conv_AudioOutputDeviceInfoToString = 0;

		private static uint __ClearSubmixEffects = 0;

		private static uint __ClearSubmixEffectChainOverride = 0;

		private static uint __ClearMasterSubmixEffects = 0;

		private static uint __AddSubmixEffect = 0;

		private static uint __AddSourceEffectToPresetChain = 0;

		private static uint __AddMasterSubmixEffect = 0;
	}
}