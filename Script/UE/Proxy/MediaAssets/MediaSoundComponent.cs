using Script.CoreUObject;
using Script.AudioMixer;
using Script.Library;
using Script.Engine;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaSoundComponent")]
	public partial class UMediaSoundComponent : USynthComponent, IStaticClass
	{
		public EMediaSoundChannels Channels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Channels, __ReturnBuffer);

					return *(EMediaSoundChannels*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Channels, __InBuffer);
				}
			}
		}

		public bool DynamicRateAdjustment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicRateAdjustment, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DynamicRateAdjustment, __InBuffer);
				}
			}
		}

		public float RateAdjustmentFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RateAdjustmentFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RateAdjustmentFactor, __InBuffer);
				}
			}
		}

		public FFloatRange RateAdjustmentRange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RateAdjustmentRange, __ReturnBuffer);

					return *(FFloatRange*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RateAdjustmentRange, __InBuffer);
				}
			}
		}

		public UMediaPlayer MediaPlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MediaPlayer, __ReturnBuffer);

					return *(UMediaPlayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MediaPlayer, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaAssets.MediaSoundComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSpectralAnalysisSettings(TArray<float> InFrequenciesToAnalyze, EMediaSoundComponentFFTSize InFFTSize = EMediaSoundComponentFFTSize.Medium_512)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InFrequenciesToAnalyze?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InFFTSize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSpectralAnalysisSettings, __InBuffer);
			}
		}

		/// <param name="NewMediaPlayer">
		/// The player to set.
		/// </param>
		/// <see>
		/// GetMediaPlayer
		/// </see>
		public virtual void SetMediaPlayer(UMediaPlayer NewMediaPlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewMediaPlayer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMediaPlayer, __InBuffer);
			}
		}

		public virtual void SetEnvelopeFollowingsettings(int AttackTimeMsec, int ReleaseTimeMsec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = AttackTimeMsec;

				*(int*)(__InBuffer + 4) = ReleaseTimeMsec;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnvelopeFollowingsettings, __InBuffer);
			}
		}

		public virtual void SetEnableSpectralAnalysis(bool bInSpectralAnalysisEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInSpectralAnalysisEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableSpectralAnalysis, __InBuffer);
			}
		}

		public virtual void SetEnableEnvelopeFollowing(bool bInEnvelopeFollowing)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInEnvelopeFollowing;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnableEnvelopeFollowing, __InBuffer);
			}
		}

		public virtual TArray<FMediaSoundComponentSpectralData> GetSpectralData()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSpectralData, __ReturnBuffer);

				return *(TArray<FMediaSoundComponentSpectralData>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FMediaSoundComponentSpectralData> GetNormalizedSpectralData()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetNormalizedSpectralData, __ReturnBuffer);

				return *(TArray<FMediaSoundComponentSpectralData>*)__ReturnBuffer;
			}
		}

		/// <see>
		/// SetMediaPlayer
		/// </see>
		/// <returns>
		/// The component's media player, or nullptr if not set.
		/// </returns>
		public virtual UMediaPlayer GetMediaPlayer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMediaPlayer, __ReturnBuffer);

				return *(UMediaPlayer*)__ReturnBuffer;
			}
		}

		public virtual float GetEnvelopeValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetEnvelopeValue, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="OutAttenuationSettings">
		/// Will contain the attenuation settings, if available.
		/// </param>
		/// <returns>
		/// true if attenuation settings were returned, false if attenuation is disabled.
		/// </returns>
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

		private static uint __Channels = 0;

		private static uint __DynamicRateAdjustment = 0;

		private static uint __RateAdjustmentFactor = 0;

		private static uint __RateAdjustmentRange = 0;

		private static uint __MediaPlayer = 0;

		private static uint __SetSpectralAnalysisSettings = 0;

		private static uint __SetMediaPlayer = 0;

		private static uint __SetEnvelopeFollowingsettings = 0;

		private static uint __SetEnableSpectralAnalysis = 0;

		private static uint __SetEnableEnvelopeFollowing = 0;

		private static uint __GetSpectralData = 0;

		private static uint __GetNormalizedSpectralData = 0;

		private static uint __GetMediaPlayer = 0;

		private static uint __GetEnvelopeValue = 0;

		private static uint __BP_GetAttenuationSettingsToApply = 0;
	}
}