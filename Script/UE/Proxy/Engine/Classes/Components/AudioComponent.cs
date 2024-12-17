using Script.CoreUObject;
using Script.AudioExtensions;
using Script.Library;
using Script.AudioMixer;

namespace Script.Engine
{
	[PathName("/Script/Engine.AudioComponent")]
	public partial class UAudioComponent : USceneComponent, IStaticClass, ISoundParameterControllerInterface
	{
		public USoundBase Sound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Sound, __ReturnBuffer);

					return *(USoundBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Sound, __InBuffer);
				}
			}
		}

		public TArray<FAudioParameter> DefaultParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultParameters, __ReturnBuffer);

					return *(TArray<FAudioParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultParameters, __InBuffer);
				}
			}
		}

		public TArray<FAudioParameter> InstanceParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceParameters, __ReturnBuffer);

					return *(TArray<FAudioParameter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstanceParameters, __InBuffer);
				}
			}
		}

		public USoundClass SoundClassOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoundClassOverride, __ReturnBuffer);

					return *(USoundClass*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoundClassOverride, __InBuffer);
				}
			}
		}

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

		public bool bShouldRemainActiveIfDropped
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldRemainActiveIfDropped, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldRemainActiveIfDropped, __InBuffer);
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

		public bool bOverrideSubtitlePriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideSubtitlePriority, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideSubtitlePriority, __InBuffer);
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

		public bool bEnableLowPassFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableLowPassFilter, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableLowPassFilter, __InBuffer);
				}
			}
		}

		public bool bOverridePriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverridePriority, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverridePriority, __InBuffer);
				}
			}
		}

		public bool bSuppressSubtitles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSuppressSubtitles, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSuppressSubtitles, __InBuffer);
				}
			}
		}

		public bool bCanPlayMultipleInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanPlayMultipleInstances, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanPlayMultipleInstances, __InBuffer);
				}
			}
		}

		public bool bDisableParameterUpdatesWhilePlaying
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDisableParameterUpdatesWhilePlaying, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDisableParameterUpdatesWhilePlaying, __InBuffer);
				}
			}
		}

		public bool bAutoManageAttachment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoManageAttachment, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoManageAttachment, __InBuffer);
				}
			}
		}

		public FName AudioComponentUserID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioComponentUserID, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioComponentUserID, __InBuffer);
				}
			}
		}

		public float PitchModulationMin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PitchModulationMin, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PitchModulationMin, __InBuffer);
				}
			}
		}

		public float PitchModulationMax
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PitchModulationMax, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PitchModulationMax, __InBuffer);
				}
			}
		}

		public float VolumeModulationMin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumeModulationMin, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumeModulationMin, __InBuffer);
				}
			}
		}

		public float VolumeModulationMax
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumeModulationMax, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumeModulationMax, __InBuffer);
				}
			}
		}

		public float VolumeMultiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumeMultiplier, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumeMultiplier, __InBuffer);
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

		public float Priority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Priority, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Priority, __InBuffer);
				}
			}
		}

		public float SubtitlePriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubtitlePriority, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubtitlePriority, __InBuffer);
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

		public float PitchMultiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PitchMultiplier, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PitchMultiplier, __InBuffer);
				}
			}
		}

		public float LowPassFilterFrequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LowPassFilterFrequency, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LowPassFilterFrequency, __InBuffer);
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

		public EAttachmentRule AutoAttachLocationRule
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachLocationRule, __ReturnBuffer);

					return *(EAttachmentRule*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachLocationRule, __InBuffer);
				}
			}
		}

		public EAttachmentRule AutoAttachRotationRule
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachRotationRule, __ReturnBuffer);

					return *(EAttachmentRule*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachRotationRule, __InBuffer);
				}
			}
		}

		public EAttachmentRule AutoAttachScaleRule
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachScaleRule, __ReturnBuffer);

					return *(EAttachmentRule*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachScaleRule, __InBuffer);
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

		public FOnAudioPlayStateChanged OnAudioPlayStateChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioPlayStateChanged, __ReturnBuffer);

					return *(FOnAudioPlayStateChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioPlayStateChanged, __InBuffer);
				}
			}
		}

		public FOnAudioVirtualizationChanged OnAudioVirtualizationChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioVirtualizationChanged, __ReturnBuffer);

					return *(FOnAudioVirtualizationChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioVirtualizationChanged, __InBuffer);
				}
			}
		}

		public FOnAudioFinished OnAudioFinished
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioFinished, __ReturnBuffer);

					return *(FOnAudioFinished*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioFinished, __InBuffer);
				}
			}
		}

		public FOnAudioPlaybackPercent OnAudioPlaybackPercent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioPlaybackPercent, __ReturnBuffer);

					return *(FOnAudioPlaybackPercent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioPlaybackPercent, __InBuffer);
				}
			}
		}

		public FOnAudioSingleEnvelopeValue OnAudioSingleEnvelopeValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioSingleEnvelopeValue, __ReturnBuffer);

					return *(FOnAudioSingleEnvelopeValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioSingleEnvelopeValue, __InBuffer);
				}
			}
		}

		public FOnAudioMultiEnvelopeValue OnAudioMultiEnvelopeValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioMultiEnvelopeValue, __ReturnBuffer);

					return *(FOnAudioMultiEnvelopeValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnAudioMultiEnvelopeValue, __InBuffer);
				}
			}
		}

		public FOnQueueSubtitles OnQueueSubtitles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnQueueSubtitles, __ReturnBuffer);

					return *(FOnQueueSubtitles*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnQueueSubtitles, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<USceneComponent> AutoAttachParent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachParent, __ReturnBuffer);

					return *(TWeakObjectPtr<USceneComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachParent, __InBuffer);
				}
			}
		}

		public FName AutoAttachSocketName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachSocketName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoAttachSocketName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AudioComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetTriggerParameter(FName InName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTriggerParameter, __InBuffer);
			}
		}

		public virtual void SetStringParameter(FName InName, FString InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStringParameter, __InBuffer);
			}
		}

		public virtual void SetStringArrayParameter(FName InName, TArray<FString> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStringArrayParameter, __InBuffer);
			}
		}

		public virtual void SetParameters_Blueprint(TArray<FAudioParameter> InParameters)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InParameters?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetParameters_Blueprint, __InBuffer);
			}
		}

		public virtual void SetObjectParameter(FName InName, UObject InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetObjectParameter, __InBuffer);
			}
		}

		public virtual void SetObjectArrayParameter(FName InName, TArray<UObject> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetObjectArrayParameter, __InBuffer);
			}
		}

		public virtual void SetIntParameter(FName InName, int InInt)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InInt;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIntParameter, __InBuffer);
			}
		}

		public virtual void SetIntArrayParameter(FName InName, TArray<int> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIntArrayParameter, __InBuffer);
			}
		}

		public virtual void SetFloatParameter(FName InName, float InFloat)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InFloat;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFloatParameter, __InBuffer);
			}
		}

		public virtual void SetFloatArrayParameter(FName InName, TArray<float> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFloatArrayParameter, __InBuffer);
			}
		}

		public virtual void SetBoolParameter(FName InName, bool InBool)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = InBool;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoolParameter, __InBuffer);
			}
		}

		public virtual void SetBoolArrayParameter(FName InName, TArray<bool> InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoolArrayParameter, __InBuffer);
			}
		}

		public virtual void ResetParameters()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetParameters);
			}
		}

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void StopDelayed(float DelayTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DelayTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopDelayed, __InBuffer);
			}
		}

		public virtual void Stop()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Stop);
			}
		}

		/// <param name="InName">
		/// The name of the parameter to assign the wave to.
		/// </param>
		/// <param name="InWave">
		/// The wave value to set.
		/// </param>
		public virtual void SetWaveParameter(FName InName, USoundWave InWave)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InWave?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWaveParameter, __InBuffer);
			}
		}

		public virtual void SetVolumeMultiplier(float NewVolumeMultiplier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewVolumeMultiplier;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVolumeMultiplier, __InBuffer);
			}
		}

		public virtual void SetUISound(bool bInUISound)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInUISound;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUISound, __InBuffer);
			}
		}

		/// <param name="Submix">
		/// The Submix to send the signal to.
		/// </param>
		/// <param name="SendLevel">
		/// The scalar used to alter the volume of the copied signal.*/
		/// </param>
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

		/// <param name="SoundSourceBus">
		/// The Bus to send the signal to.
		/// </param>
		/// <param name="SourceBusSendLevel">
		/// The scalar used to alter the volume of the copied signal.
		/// </param>
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

		/// <param name="SoundSourceBus">
		/// The Bus to send the signal to
		/// </param>
		/// <param name="SourceBusSendLevel">
		/// The scalar used to alter the volume of the copied signal
		/// </param>
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

		public virtual void SetSound(USoundBase NewSound)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewSound?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSound, __InBuffer);
			}
		}

		public virtual void SetPitchMultiplier(float NewPitchMultiplier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewPitchMultiplier;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPitchMultiplier, __InBuffer);
			}
		}

		public virtual void SetPaused(bool bPause)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bPause;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPaused, __InBuffer);
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

		/// <param name="AudioBus">
		/// The Bus to send the signal to
		/// </param>
		/// <param name="AudioBusSendLevel">
		/// The scalar used to alter the volume of the copied signal
		/// </param>
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

		/// <param name="AudioBus">
		/// The Bus to send the signal to
		/// </param>
		/// <param name="AudioBusSendLevel">
		/// The scalar used to alter the volume of the copied signal
		/// </param>
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

		public virtual void PlayQuantized(UObject WorldContextObject, ref UQuartzClockHandle InClockHandle, ref FQuartzQuantizationBoundary InQuantizationBoundary, FOnQuartzCommandEventBP InDelegate, float InStartTime, float InFadeInDuration, float InFadeVolumeLevel, EAudioFaderCurve InFadeCurve)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[45];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InClockHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InQuantizationBoundary?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = InDelegate?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = InStartTime;

				*(float*)(__InBuffer + 36) = InFadeInDuration;

				*(float*)(__InBuffer + 40) = InFadeVolumeLevel;

				*(byte*)(__InBuffer + 44) = (byte)InFadeCurve;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __PlayQuantized, __InBuffer, __OutBuffer);

				InClockHandle = *(UQuartzClockHandle*)(__OutBuffer);

				InQuantizationBoundary = *(FQuartzQuantizationBoundary*)(__OutBuffer + 8);

			}
		}

		/// <param name="StartTime">
		/// The offset, in seconds, to begin reading the sound at
		/// </param>
		public virtual void Play(float StartTime = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = StartTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Play, __InBuffer);
			}
		}

		public virtual bool IsVirtualized()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsVirtualized, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
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

		public virtual bool HasCookedFFTData()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasCookedFFTData, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasCookedAmplitudeEnvelopeData()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasCookedAmplitudeEnvelopeData, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual EAudioComponentPlayState GetPlayState()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPlayState, __ReturnBuffer);

				return *(EAudioComponentPlayState*)__ReturnBuffer;
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

		public virtual bool GetCookedFFTDataForAllPlayingSounds(ref TArray<FSoundWaveSpectralDataPerSound> OutSoundWaveSpectralData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutSoundWaveSpectralData?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCookedFFTDataForAllPlayingSounds, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutSoundWaveSpectralData = *(TArray<FSoundWaveSpectralDataPerSound>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCookedFFTData(TArray<float> FrequenciesToGet, ref TArray<FSoundWaveSpectralData> OutSoundWaveSpectralData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = FrequenciesToGet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutSoundWaveSpectralData?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCookedFFTData, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutSoundWaveSpectralData = *(TArray<FSoundWaveSpectralData>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCookedEnvelopeDataForAllPlayingSounds(ref TArray<FSoundWaveEnvelopeDataPerSound> OutEnvelopeData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutEnvelopeData?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCookedEnvelopeDataForAllPlayingSounds, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutEnvelopeData = *(TArray<FSoundWaveEnvelopeDataPerSound>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCookedEnvelopeData(ref float OutEnvelopeData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = OutEnvelopeData;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCookedEnvelopeData, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutEnvelopeData = *(float*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
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

		public virtual bool BP_GetAttenuationSettingsToApply(ref FSoundAttenuationSettings OutAttenuationSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutAttenuationSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __BP_GetAttenuationSettingsToApply, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutAttenuationSettings = *(FSoundAttenuationSettings*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
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

		public virtual void AdjustAttenuation(FSoundAttenuationSettings InAttenuationSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAttenuationSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AdjustAttenuation, __InBuffer);
			}
		}

		private static uint __Sound = 0;

		private static uint __DefaultParameters = 0;

		private static uint __InstanceParameters = 0;

		private static uint __SoundClassOverride = 0;

		private static uint __bAutoDestroy = 0;

		private static uint __bStopWhenOwnerDestroyed = 0;

		private static uint __bShouldRemainActiveIfDropped = 0;

		private static uint __bAllowSpatialization = 0;

		private static uint __bOverrideAttenuation = 0;

		private static uint __bOverrideSubtitlePriority = 0;

		private static uint __bIsUISound = 0;

		private static uint __bEnableLowPassFilter = 0;

		private static uint __bOverridePriority = 0;

		private static uint __bSuppressSubtitles = 0;

		private static uint __bCanPlayMultipleInstances = 0;

		private static uint __bDisableParameterUpdatesWhilePlaying = 0;

		private static uint __bAutoManageAttachment = 0;

		private static uint __AudioComponentUserID = 0;

		private static uint __PitchModulationMin = 0;

		private static uint __PitchModulationMax = 0;

		private static uint __VolumeModulationMin = 0;

		private static uint __VolumeModulationMax = 0;

		private static uint __VolumeMultiplier = 0;

		private static uint __EnvelopeFollowerAttackTime = 0;

		private static uint __EnvelopeFollowerReleaseTime = 0;

		private static uint __Priority = 0;

		private static uint __SubtitlePriority = 0;

		private static uint __SourceEffectChain = 0;

		private static uint __PitchMultiplier = 0;

		private static uint __LowPassFilterFrequency = 0;

		private static uint __AttenuationSettings = 0;

		private static uint __AttenuationOverrides = 0;

		private static uint __ConcurrencySet = 0;

		private static uint __AutoAttachLocationRule = 0;

		private static uint __AutoAttachRotationRule = 0;

		private static uint __AutoAttachScaleRule = 0;

		private static uint __ModulationRouting = 0;

		private static uint __OnAudioPlayStateChanged = 0;

		private static uint __OnAudioVirtualizationChanged = 0;

		private static uint __OnAudioFinished = 0;

		private static uint __OnAudioPlaybackPercent = 0;

		private static uint __OnAudioSingleEnvelopeValue = 0;

		private static uint __OnAudioMultiEnvelopeValue = 0;

		private static uint __OnQueueSubtitles = 0;

		private static uint __AutoAttachParent = 0;

		private static uint __AutoAttachSocketName = 0;

		private static uint __SetTriggerParameter = 0;

		private static uint __SetStringParameter = 0;

		private static uint __SetStringArrayParameter = 0;

		private static uint __SetParameters_Blueprint = 0;

		private static uint __SetObjectParameter = 0;

		private static uint __SetObjectArrayParameter = 0;

		private static uint __SetIntParameter = 0;

		private static uint __SetIntArrayParameter = 0;

		private static uint __SetFloatParameter = 0;

		private static uint __SetFloatArrayParameter = 0;

		private static uint __SetBoolParameter = 0;

		private static uint __SetBoolArrayParameter = 0;

		private static uint __ResetParameters = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __StopDelayed = 0;

		private static uint __Stop = 0;

		private static uint __SetWaveParameter = 0;

		private static uint __SetVolumeMultiplier = 0;

		private static uint __SetUISound = 0;

		private static uint __SetSubmixSend = 0;

		private static uint __SetSourceBusSendPreEffect = 0;

		private static uint __SetSourceBusSendPostEffect = 0;

		private static uint __SetSound = 0;

		private static uint __SetPitchMultiplier = 0;

		private static uint __SetPaused = 0;

		private static uint __SetOutputToBusOnly = 0;

		private static uint __SetModulationRouting = 0;

		private static uint __SetLowPassFilterFrequency = 0;

		private static uint __SetLowPassFilterEnabled = 0;

		private static uint __SetAudioBusSendPreEffect = 0;

		private static uint __SetAudioBusSendPostEffect = 0;

		private static uint __PlayQuantized = 0;

		private static uint __Play = 0;

		private static uint __IsVirtualized = 0;

		private static uint __IsPlaying = 0;

		private static uint __HasCookedFFTData = 0;

		private static uint __HasCookedAmplitudeEnvelopeData = 0;

		private static uint __GetPlayState = 0;

		private static uint __GetModulators = 0;

		private static uint __GetCookedFFTDataForAllPlayingSounds = 0;

		private static uint __GetCookedFFTData = 0;

		private static uint __GetCookedEnvelopeDataForAllPlayingSounds = 0;

		private static uint __GetCookedEnvelopeData = 0;

		private static uint __FadeOut = 0;

		private static uint __FadeIn = 0;

		private static uint __BP_GetAttenuationSettingsToApply = 0;

		private static uint __AdjustVolume = 0;

		private static uint __AdjustAttenuation = 0;
	}
}