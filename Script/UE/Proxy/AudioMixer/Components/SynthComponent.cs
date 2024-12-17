using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.AudioExtensions;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.SynthComponent")]
	public partial class USynthComponent : USceneComponent, IStaticClass
	{
		public bool bAutoDestroy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoDestroy, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoDestroy, __InBuffer);
				}
			}
		}

		public bool bStopWhenOwnerDestroyed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStopWhenOwnerDestroyed, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStopWhenOwnerDestroyed, __InBuffer);
				}
			}
		}

		public bool bAllowSpatialization
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowSpatialization, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowSpatialization, __InBuffer);
				}
			}
		}

		public bool bOverrideAttenuation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideAttenuation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideAttenuation, __InBuffer);
				}
			}
		}

		public bool bEnableBusSends
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableBusSends, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableBusSends, __InBuffer);
				}
			}
		}

		public bool bEnableBaseSubmix
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableBaseSubmix, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableBaseSubmix, __InBuffer);
				}
			}
		}

		public bool bEnableSubmixSends
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableSubmixSends, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableSubmixSends, __InBuffer);
				}
			}
		}

		public USoundAttenuation AttenuationSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AttenuationSettings, __ReturnBuffer);

					return *(USoundAttenuation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AttenuationSettings, __InBuffer);
				}
			}
		}

		public FSoundAttenuationSettings AttenuationOverrides
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AttenuationOverrides, __ReturnBuffer);

					return *(FSoundAttenuationSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AttenuationOverrides, __InBuffer);
				}
			}
		}

		public TSet<USoundConcurrency> ConcurrencySet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConcurrencySet, __ReturnBuffer);

					return *(TSet<USoundConcurrency>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConcurrencySet, __InBuffer);
				}
			}
		}

		public FSoundModulationDefaultRoutingSettings ModulationRouting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ModulationRouting, __ReturnBuffer);

					return *(FSoundModulationDefaultRoutingSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ModulationRouting, __InBuffer);
				}
			}
		}

		public USoundClass SoundClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoundClass, __ReturnBuffer);

					return *(USoundClass*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoundClass, __InBuffer);
				}
			}
		}

		public USoundEffectSourcePresetChain SourceEffectChain
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceEffectChain, __ReturnBuffer);

					return *(USoundEffectSourcePresetChain*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceEffectChain, __InBuffer);
				}
			}
		}

		public USoundSubmixBase SoundSubmix
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoundSubmix, __ReturnBuffer);

					return *(USoundSubmixBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoundSubmix, __InBuffer);
				}
			}
		}

		public TArray<FSoundSubmixSendInfo> SoundSubmixSends
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoundSubmixSends, __ReturnBuffer);

					return *(TArray<FSoundSubmixSendInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoundSubmixSends, __InBuffer);
				}
			}
		}

		public TArray<FSoundSourceBusSendInfo> BusSends
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BusSends, __ReturnBuffer);

					return *(TArray<FSoundSourceBusSendInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BusSends, __InBuffer);
				}
			}
		}

		public TArray<FSoundSourceBusSendInfo> PreEffectBusSends
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreEffectBusSends, __ReturnBuffer);

					return *(TArray<FSoundSourceBusSendInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreEffectBusSends, __InBuffer);
				}
			}
		}

		public bool bIsUISound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsUISound, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsUISound, __InBuffer);
				}
			}
		}

		public bool bIsPreviewSound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsPreviewSound, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsPreviewSound, __InBuffer);
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

		public FOnSynthEnvelopeValue OnAudioEnvelopeValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioEnvelopeValue, __ReturnBuffer);

					return *(FOnSynthEnvelopeValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioEnvelopeValue, __InBuffer);
				}
			}
		}

		public USynthSound Synth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Synth, __ReturnBuffer);

					return *(USynthSound*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Synth, __InBuffer);
				}
			}
		}

		public UAudioComponent AudioComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioComponent, __ReturnBuffer);

					return *(UAudioComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioMixer.SynthComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Stop()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Stop);
			}
		}

		public virtual void Start()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Start);
			}
		}

		public virtual void SetVolumeMultiplier(float VolumeMultiplier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = VolumeMultiplier;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVolumeMultiplier, __InBuffer);
			}
		}

		public virtual void SetSubmixSend(USoundSubmixBase Submix, float SendLevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Submix?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = SendLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSubmixSend, __InBuffer);
			}
		}

		public virtual void SetSourceBusSendPreEffect(USoundSourceBus SoundSourceBus, float SourceBusSendLevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SoundSourceBus?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = SourceBusSendLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSourceBusSendPreEffect, __InBuffer);
			}
		}

		public virtual void SetSourceBusSendPostEffect(USoundSourceBus SoundSourceBus, float SourceBusSendLevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = SoundSourceBus?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = SourceBusSendLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSourceBusSendPostEffect, __InBuffer);
			}
		}

		public virtual void SetOutputToBusOnly(bool bInOutputToBusOnly)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInOutputToBusOnly;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOutputToBusOnly, __InBuffer);
			}
		}

		/// <param name="Modulators">
		/// The set of modulators to apply to the given destination on the component.
		/// </param>
		/// <param name="Destination">
		/// The destination to assign the modulators to.
		/// </param>
		/// <param name="RoutingMethod">
		/// The routing method to use for the given modulator.
		/// </param>
		public virtual void SetModulationRouting(TSet<USoundModulatorBase> Modulators, EModulationDestination Destination, EModulationRouting RoutingMethod = EModulationRouting.Inherit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = Modulators?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Destination;

				*(byte*)(__InBuffer + 9) = (byte)RoutingMethod;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetModulationRouting, __InBuffer);
			}
		}

		public virtual void SetLowPassFilterFrequency(float InLowPassFilterFrequency)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InLowPassFilterFrequency;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLowPassFilterFrequency, __InBuffer);
			}
		}

		public virtual void SetLowPassFilterEnabled(bool InLowPassFilterEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = InLowPassFilterEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLowPassFilterEnabled, __InBuffer);
			}
		}

		public virtual void SetAudioBusSendPreEffect(UAudioBus AudioBus, float AudioBusSendLevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = AudioBus?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = AudioBusSendLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAudioBusSendPreEffect, __InBuffer);
			}
		}

		public virtual void SetAudioBusSendPostEffect(UAudioBus AudioBus, float AudioBusSendLevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = AudioBus?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = AudioBusSendLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAudioBusSendPostEffect, __InBuffer);
			}
		}

		public virtual bool IsPlaying()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPlaying, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Destination">
		/// The Destination to retrieve the Modulators from.
		/// </param>
		/// <returns>
		/// The set of of Modulators applied to this component for the given Destination.
		/// </returns>
		public virtual TSet<USoundModulatorBase> GetModulators(EModulationDestination Destination)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)Destination;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetModulators, __InBuffer, __ReturnBuffer);

				return *(TSet<USoundModulatorBase>*)__ReturnBuffer;
			}
		}

		/// <param name="FadeOutDuration">
		/// how long it should take to reach the FadeVolumeLevel
		/// </param>
		/// <param name="FadeVolumeLevel">
		/// the percentage of the AudioComponents's calculated volume in which to fade to
		/// </param>
		/// <param name="FadeCurve">
		/// The curve to use when interpolating between the old and new volume
		/// </param>
		public virtual void FadeOut(float FadeOutDuration, float FadeVolumeLevel, EAudioFaderCurve FadeCurve = EAudioFaderCurve.Linear)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(float*)(__InBuffer) = FadeOutDuration;

				*(float*)(__InBuffer + 4) = FadeVolumeLevel;

				*(byte*)(__InBuffer + 8) = (byte)FadeCurve;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FadeOut, __InBuffer);
			}
		}

		/// <param name="FadeInDuration">
		/// How long it should take to reach the FadeVolumeLevel
		/// </param>
		/// <param name="FadeVolumeLevel">
		/// The percentage of the AudioComponents's calculated volume to fade to
		/// </param>
		/// <param name="FadeCurve">
		/// The curve to use when interpolating between the old and new volume
		/// </param>
		public virtual void FadeIn(float FadeInDuration, float FadeVolumeLevel = 1.000000f, float StartTime = 0.000000f, EAudioFaderCurve FadeCurve = EAudioFaderCurve.Linear)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(float*)(__InBuffer) = FadeInDuration;

				*(float*)(__InBuffer + 4) = FadeVolumeLevel;

				*(float*)(__InBuffer + 8) = StartTime;

				*(byte*)(__InBuffer + 12) = (byte)FadeCurve;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FadeIn, __InBuffer);
			}
		}

		/// <param name="AdjustVolumeDuration">
		/// The length of time in which to interpolate between the initial volume and the new volume.
		/// </param>
		/// <param name="AdjustVolumeLevel">
		/// The new volume to set the Audio Component to.
		/// </param>
		/// <param name="FadeCurve">
		/// The curve used when interpolating between the old and new volume.
		/// </param>
		public virtual void AdjustVolume(float AdjustVolumeDuration, float AdjustVolumeLevel, EAudioFaderCurve FadeCurve = EAudioFaderCurve.Linear)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(float*)(__InBuffer) = AdjustVolumeDuration;

				*(float*)(__InBuffer + 4) = AdjustVolumeLevel;

				*(byte*)(__InBuffer + 8) = (byte)FadeCurve;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AdjustVolume, __InBuffer);
			}
		}

		private static uint __bAutoDestroy = 0;

		private static uint __bStopWhenOwnerDestroyed = 0;

		private static uint __bAllowSpatialization = 0;

		private static uint __bOverrideAttenuation = 0;

		private static uint __bEnableBusSends = 0;

		private static uint __bEnableBaseSubmix = 0;

		private static uint __bEnableSubmixSends = 0;

		private static uint __AttenuationSettings = 0;

		private static uint __AttenuationOverrides = 0;

		private static uint __ConcurrencySet = 0;

		private static uint __ModulationRouting = 0;

		private static uint __SoundClass = 0;

		private static uint __SourceEffectChain = 0;

		private static uint __SoundSubmix = 0;

		private static uint __SoundSubmixSends = 0;

		private static uint __BusSends = 0;

		private static uint __PreEffectBusSends = 0;

		private static uint __bIsUISound = 0;

		private static uint __bIsPreviewSound = 0;

		private static uint __EnvelopeFollowerAttackTime = 0;

		private static uint __EnvelopeFollowerReleaseTime = 0;

		private static uint __OnAudioEnvelopeValue = 0;

		private static uint __Synth = 0;

		private static uint __AudioComponent = 0;

		private static uint __Stop = 0;

		private static uint __Start = 0;

		private static uint __SetVolumeMultiplier = 0;

		private static uint __SetSubmixSend = 0;

		private static uint __SetSourceBusSendPreEffect = 0;

		private static uint __SetSourceBusSendPostEffect = 0;

		private static uint __SetOutputToBusOnly = 0;

		private static uint __SetModulationRouting = 0;

		private static uint __SetLowPassFilterFrequency = 0;

		private static uint __SetLowPassFilterEnabled = 0;

		private static uint __SetAudioBusSendPreEffect = 0;

		private static uint __SetAudioBusSendPostEffect = 0;

		private static uint __IsPlaying = 0;

		private static uint __GetModulators = 0;

		private static uint __FadeOut = 0;

		private static uint __FadeIn = 0;

		private static uint __AdjustVolume = 0;
	}
}