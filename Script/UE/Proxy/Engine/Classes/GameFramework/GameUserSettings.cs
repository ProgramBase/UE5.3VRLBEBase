using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.GameUserSettings")]
	public partial class UGameUserSettings : UObject, IStaticClass
	{
		public bool bUseVSync
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseVSync, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseVSync, __InBuffer);
				}
			}
		}

		public bool bUseDynamicResolution
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseDynamicResolution, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseDynamicResolution, __InBuffer);
				}
			}
		}

		public uint ResolutionSizeX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ResolutionSizeX, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ResolutionSizeX, __InBuffer);
				}
			}
		}

		public uint ResolutionSizeY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ResolutionSizeY, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ResolutionSizeY, __InBuffer);
				}
			}
		}

		public uint LastUserConfirmedResolutionSizeX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastUserConfirmedResolutionSizeX, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastUserConfirmedResolutionSizeX, __InBuffer);
				}
			}
		}

		public uint LastUserConfirmedResolutionSizeY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastUserConfirmedResolutionSizeY, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastUserConfirmedResolutionSizeY, __InBuffer);
				}
			}
		}

		public int WindowPosX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WindowPosX, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WindowPosX, __InBuffer);
				}
			}
		}

		public int WindowPosY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WindowPosY, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WindowPosY, __InBuffer);
				}
			}
		}

		public int FullscreenMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FullscreenMode, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FullscreenMode, __InBuffer);
				}
			}
		}

		public int LastConfirmedFullscreenMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastConfirmedFullscreenMode, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastConfirmedFullscreenMode, __InBuffer);
				}
			}
		}

		public int PreferredFullscreenMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreferredFullscreenMode, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreferredFullscreenMode, __InBuffer);
				}
			}
		}

		public uint Version
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Version, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Version, __InBuffer);
				}
			}
		}

		public int AudioQualityLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioQualityLevel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioQualityLevel, __InBuffer);
				}
			}
		}

		public int LastConfirmedAudioQualityLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastConfirmedAudioQualityLevel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastConfirmedAudioQualityLevel, __InBuffer);
				}
			}
		}

		public float FrameRateLimit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FrameRateLimit, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FrameRateLimit, __InBuffer);
				}
			}
		}

		public int DesiredScreenWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredScreenWidth, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredScreenWidth, __InBuffer);
				}
			}
		}

		public bool bUseDesiredScreenHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseDesiredScreenHeight, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseDesiredScreenHeight, __InBuffer);
				}
			}
		}

		public int DesiredScreenHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredScreenHeight, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DesiredScreenHeight, __InBuffer);
				}
			}
		}

		public int LastUserConfirmedDesiredScreenWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastUserConfirmedDesiredScreenWidth, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastUserConfirmedDesiredScreenWidth, __InBuffer);
				}
			}
		}

		public int LastUserConfirmedDesiredScreenHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastUserConfirmedDesiredScreenHeight, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastUserConfirmedDesiredScreenHeight, __InBuffer);
				}
			}
		}

		public float LastRecommendedScreenWidth
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastRecommendedScreenWidth, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastRecommendedScreenWidth, __InBuffer);
				}
			}
		}

		public float LastRecommendedScreenHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastRecommendedScreenHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastRecommendedScreenHeight, __InBuffer);
				}
			}
		}

		public float LastCPUBenchmarkResult
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastCPUBenchmarkResult, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastCPUBenchmarkResult, __InBuffer);
				}
			}
		}

		public float LastGPUBenchmarkResult
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastGPUBenchmarkResult, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastGPUBenchmarkResult, __InBuffer);
				}
			}
		}

		public TArray<float> LastCPUBenchmarkSteps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastCPUBenchmarkSteps, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastCPUBenchmarkSteps, __InBuffer);
				}
			}
		}

		public TArray<float> LastGPUBenchmarkSteps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastGPUBenchmarkSteps, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastGPUBenchmarkSteps, __InBuffer);
				}
			}
		}

		public float LastGPUBenchmarkMultiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastGPUBenchmarkMultiplier, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastGPUBenchmarkMultiplier, __InBuffer);
				}
			}
		}

		public bool bUseHDRDisplayOutput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseHDRDisplayOutput, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseHDRDisplayOutput, __InBuffer);
				}
			}
		}

		public int HDRDisplayOutputNits
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HDRDisplayOutputNits, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HDRDisplayOutputNits, __InBuffer);
				}
			}
		}

		public FOnGameUserSettingsUINeedsUpdate OnGameUserSettingsUINeedsUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnGameUserSettingsUINeedsUpdate, __ReturnBuffer);

					return *(FOnGameUserSettingsUINeedsUpdate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnGameUserSettingsUINeedsUpdate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.GameUserSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ValidateSettings()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ValidateSettings);
			}
		}

		public virtual bool SupportsHDRDisplayOutput()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __SupportsHDRDisplayOutput, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetVSyncEnabled(bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVSyncEnabled, __InBuffer);
			}
		}

		/// <param name="Value">
		/// 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
		/// </param>
		public virtual void SetVisualEffectQuality(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVisualEffectQuality, __InBuffer);
			}
		}

		/// <param name="Value">
		/// 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
		/// </param>
		public virtual void SetViewDistanceQuality(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetViewDistanceQuality, __InBuffer);
			}
		}

		public virtual void SetToDefaults()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SetToDefaults);
			}
		}

		/// <param name="Value">
		/// 0:low, 1:medium, 2:high, 3:epic, 4:cinematic  (gets clamped if needed)
		/// </param>
		public virtual void SetTextureQuality(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTextureQuality, __InBuffer);
			}
		}

		/// <param name="Value">
		/// 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
		/// </param>
		public virtual void SetShadowQuality(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShadowQuality, __InBuffer);
			}
		}

		/// <param name="Value">
		/// 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
		/// </param>
		public virtual void SetShadingQuality(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShadingQuality, __InBuffer);
			}
		}

		public virtual void SetScreenResolution(FIntPoint Resolution)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Resolution?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScreenResolution, __InBuffer);
			}
		}

		public virtual void SetResolutionScaleValueEx(float NewScaleValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewScaleValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetResolutionScaleValueEx, __InBuffer);
			}
		}

		public virtual void SetResolutionScaleNormalized(float NewScaleNormalized)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewScaleNormalized;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetResolutionScaleNormalized, __InBuffer);
			}
		}

		/// <param name="Value">
		/// 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
		/// </param>
		public virtual void SetReflectionQuality(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReflectionQuality, __InBuffer);
			}
		}

		/// <param name="Value">
		/// 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
		/// </param>
		public virtual void SetPostProcessingQuality(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPostProcessingQuality, __InBuffer);
			}
		}

		/// <param name="Value">
		/// 0:low, 1:medium, 2:high, 3:epic, 4:cinematic
		/// </param>
		public virtual void SetOverallScalabilityLevel(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOverallScalabilityLevel, __InBuffer);
			}
		}

		/// <param name="Value">
		/// 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
		/// </param>
		public virtual void SetGlobalIlluminationQuality(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGlobalIlluminationQuality, __InBuffer);
			}
		}

		public virtual void SetFullscreenMode(EWindowMode InFullscreenMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InFullscreenMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFullscreenMode, __InBuffer);
			}
		}

		public virtual void SetFrameRateLimit(float NewLimit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewLimit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrameRateLimit, __InBuffer);
			}
		}

		/// <param name="Value">
		/// 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
		/// </param>
		public virtual void SetFoliageQuality(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFoliageQuality, __InBuffer);
			}
		}

		public virtual void SetDynamicResolutionEnabled(bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDynamicResolutionEnabled, __InBuffer);
			}
		}

		public virtual void SetBenchmarkFallbackValues()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SetBenchmarkFallbackValues);
			}
		}

		public virtual void SetAudioQualityLevel(int QualityLevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = QualityLevel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAudioQualityLevel, __InBuffer);
			}
		}

		/// <param name="Value">
		/// 0:low, 1:medium, 2:high, 3:epic, 4:cinematic (gets clamped if needed)
		/// </param>
		public virtual void SetAntiAliasingQuality(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAntiAliasingQuality, __InBuffer);
			}
		}

		public virtual void SaveSettings()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SaveSettings);
			}
		}

		public virtual void RunHardwareBenchmark(int WorkScale = 10, float CPUMultiplier = 1.000000f, float GPUMultiplier = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = WorkScale;

				*(float*)(__InBuffer + 4) = CPUMultiplier;

				*(float*)(__InBuffer + 8) = GPUMultiplier;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RunHardwareBenchmark, __InBuffer);
			}
		}

		public virtual void RevertVideoMode()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RevertVideoMode);
			}
		}

		public virtual void ResetToCurrentSettings()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetToCurrentSettings);
			}
		}

		public virtual void LoadSettings(bool bForceReload = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bForceReload;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __LoadSettings, __InBuffer);
			}
		}

		public virtual bool IsVSyncEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsVSyncEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsVSyncDirty()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsVSyncDirty, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsScreenResolutionDirty()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsScreenResolutionDirty, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsHDREnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsHDREnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsFullscreenModeDirty()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsFullscreenModeDirty, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsDynamicResolutionEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsDynamicResolutionEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsDynamicResolutionDirty()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsDynamicResolutionDirty, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsDirty()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsDirty, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual int GetVisualEffectQuality()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetVisualEffectQuality, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetViewDistanceQuality()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetViewDistanceQuality, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetTextureQuality()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTextureQuality, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetSyncInterval()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetSyncInterval, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetShadowQuality()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetShadowQuality, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetShadingQuality()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetShadingQuality, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FIntPoint GetScreenResolution()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetScreenResolution, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public virtual float GetResolutionScaleNormalized()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetResolutionScaleNormalized, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void GetResolutionScaleInformationEx(ref float CurrentScaleNormalized, ref float CurrentScaleValue, ref float MinScaleValue, ref float MaxScaleValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(float*)(__InBuffer) = CurrentScaleNormalized;

				*(float*)(__InBuffer + 4) = CurrentScaleValue;

				*(float*)(__InBuffer + 8) = MinScaleValue;

				*(float*)(__InBuffer + 12) = MaxScaleValue;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetResolutionScaleInformationEx, __InBuffer, __OutBuffer);

				CurrentScaleNormalized = *(float*)(__OutBuffer);

				CurrentScaleValue = *(float*)(__OutBuffer + 4);

				MinScaleValue = *(float*)(__OutBuffer + 8);

				MaxScaleValue = *(float*)(__OutBuffer + 12);

			}
		}

		public virtual int GetReflectionQuality()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetReflectionQuality, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual float GetRecommendedResolutionScale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetRecommendedResolutionScale, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual EWindowMode GetPreferredFullscreenMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPreferredFullscreenMode, __ReturnBuffer);

				return *(EWindowMode*)__ReturnBuffer;
			}
		}

		public virtual int GetPostProcessingQuality()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPostProcessingQuality, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetOverallScalabilityLevel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetOverallScalabilityLevel, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FIntPoint GetLastConfirmedScreenResolution()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLastConfirmedScreenResolution, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public virtual EWindowMode GetLastConfirmedFullscreenMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetLastConfirmedFullscreenMode, __ReturnBuffer);

				return *(EWindowMode*)__ReturnBuffer;
			}
		}

		public virtual int GetGlobalIlluminationQuality()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetGlobalIlluminationQuality, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static UGameUserSettings GetGameUserSettings()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetGameUserSettings, __ReturnBuffer);

				return *(UGameUserSettings*)__ReturnBuffer;
			}
		}

		public virtual EWindowMode GetFullscreenMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFullscreenMode, __ReturnBuffer);

				return *(EWindowMode*)__ReturnBuffer;
			}
		}

		public virtual float GetFrameRateLimit()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFrameRateLimit, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static int GetFramePace()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetFramePace, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetFoliageQuality()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFoliageQuality, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FIntPoint GetDesktopResolution()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDesktopResolution, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static FIntPoint GetDefaultWindowPosition()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetDefaultWindowPosition, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public static EWindowMode GetDefaultWindowMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetDefaultWindowMode, __ReturnBuffer);

				return *(EWindowMode*)__ReturnBuffer;
			}
		}

		public virtual float GetDefaultResolutionScale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDefaultResolutionScale, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static FIntPoint GetDefaultResolution()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetDefaultResolution, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		public virtual int GetCurrentHDRDisplayNits()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCurrentHDRDisplayNits, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetAudioQualityLevel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAudioQualityLevel, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetAntiAliasingQuality()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAntiAliasingQuality, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void EnableHDRDisplayOutput(bool bEnable, int DisplayNits = 1000)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(bool*)(__InBuffer) = bEnable;

				*(int*)(__InBuffer + 1) = DisplayNits;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __EnableHDRDisplayOutput, __InBuffer);
			}
		}

		public virtual void ConfirmVideoMode()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ConfirmVideoMode);
			}
		}

		public virtual void ApplySettings(bool bCheckForCommandLineOverrides)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bCheckForCommandLineOverrides;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplySettings, __InBuffer);
			}
		}

		public virtual void ApplyResolutionSettings(bool bCheckForCommandLineOverrides)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bCheckForCommandLineOverrides;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyResolutionSettings, __InBuffer);
			}
		}

		public virtual void ApplyNonResolutionSettings()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ApplyNonResolutionSettings);
			}
		}

		public virtual void ApplyHardwareBenchmarkResults()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ApplyHardwareBenchmarkResults);
			}
		}

		private static uint __bUseVSync = 0;

		private static uint __bUseDynamicResolution = 0;

		private static uint __ResolutionSizeX = 0;

		private static uint __ResolutionSizeY = 0;

		private static uint __LastUserConfirmedResolutionSizeX = 0;

		private static uint __LastUserConfirmedResolutionSizeY = 0;

		private static uint __WindowPosX = 0;

		private static uint __WindowPosY = 0;

		private static uint __FullscreenMode = 0;

		private static uint __LastConfirmedFullscreenMode = 0;

		private static uint __PreferredFullscreenMode = 0;

		private static uint __Version = 0;

		private static uint __AudioQualityLevel = 0;

		private static uint __LastConfirmedAudioQualityLevel = 0;

		private static uint __FrameRateLimit = 0;

		private static uint __DesiredScreenWidth = 0;

		private static uint __bUseDesiredScreenHeight = 0;

		private static uint __DesiredScreenHeight = 0;

		private static uint __LastUserConfirmedDesiredScreenWidth = 0;

		private static uint __LastUserConfirmedDesiredScreenHeight = 0;

		private static uint __LastRecommendedScreenWidth = 0;

		private static uint __LastRecommendedScreenHeight = 0;

		private static uint __LastCPUBenchmarkResult = 0;

		private static uint __LastGPUBenchmarkResult = 0;

		private static uint __LastCPUBenchmarkSteps = 0;

		private static uint __LastGPUBenchmarkSteps = 0;

		private static uint __LastGPUBenchmarkMultiplier = 0;

		private static uint __bUseHDRDisplayOutput = 0;

		private static uint __HDRDisplayOutputNits = 0;

		private static uint __OnGameUserSettingsUINeedsUpdate = 0;

		private static uint __ValidateSettings = 0;

		private static uint __SupportsHDRDisplayOutput = 0;

		private static uint __SetVSyncEnabled = 0;

		private static uint __SetVisualEffectQuality = 0;

		private static uint __SetViewDistanceQuality = 0;

		private static uint __SetToDefaults = 0;

		private static uint __SetTextureQuality = 0;

		private static uint __SetShadowQuality = 0;

		private static uint __SetShadingQuality = 0;

		private static uint __SetScreenResolution = 0;

		private static uint __SetResolutionScaleValueEx = 0;

		private static uint __SetResolutionScaleNormalized = 0;

		private static uint __SetReflectionQuality = 0;

		private static uint __SetPostProcessingQuality = 0;

		private static uint __SetOverallScalabilityLevel = 0;

		private static uint __SetGlobalIlluminationQuality = 0;

		private static uint __SetFullscreenMode = 0;

		private static uint __SetFrameRateLimit = 0;

		private static uint __SetFoliageQuality = 0;

		private static uint __SetDynamicResolutionEnabled = 0;

		private static uint __SetBenchmarkFallbackValues = 0;

		private static uint __SetAudioQualityLevel = 0;

		private static uint __SetAntiAliasingQuality = 0;

		private static uint __SaveSettings = 0;

		private static uint __RunHardwareBenchmark = 0;

		private static uint __RevertVideoMode = 0;

		private static uint __ResetToCurrentSettings = 0;

		private static uint __LoadSettings = 0;

		private static uint __IsVSyncEnabled = 0;

		private static uint __IsVSyncDirty = 0;

		private static uint __IsScreenResolutionDirty = 0;

		private static uint __IsHDREnabled = 0;

		private static uint __IsFullscreenModeDirty = 0;

		private static uint __IsDynamicResolutionEnabled = 0;

		private static uint __IsDynamicResolutionDirty = 0;

		private static uint __IsDirty = 0;

		private static uint __GetVisualEffectQuality = 0;

		private static uint __GetViewDistanceQuality = 0;

		private static uint __GetTextureQuality = 0;

		private static uint __GetSyncInterval = 0;

		private static uint __GetShadowQuality = 0;

		private static uint __GetShadingQuality = 0;

		private static uint __GetScreenResolution = 0;

		private static uint __GetResolutionScaleNormalized = 0;

		private static uint __GetResolutionScaleInformationEx = 0;

		private static uint __GetReflectionQuality = 0;

		private static uint __GetRecommendedResolutionScale = 0;

		private static uint __GetPreferredFullscreenMode = 0;

		private static uint __GetPostProcessingQuality = 0;

		private static uint __GetOverallScalabilityLevel = 0;

		private static uint __GetLastConfirmedScreenResolution = 0;

		private static uint __GetLastConfirmedFullscreenMode = 0;

		private static uint __GetGlobalIlluminationQuality = 0;

		private static uint __GetGameUserSettings = 0;

		private static uint __GetFullscreenMode = 0;

		private static uint __GetFrameRateLimit = 0;

		private static uint __GetFramePace = 0;

		private static uint __GetFoliageQuality = 0;

		private static uint __GetDesktopResolution = 0;

		private static uint __GetDefaultWindowPosition = 0;

		private static uint __GetDefaultWindowMode = 0;

		private static uint __GetDefaultResolutionScale = 0;

		private static uint __GetDefaultResolution = 0;

		private static uint __GetCurrentHDRDisplayNits = 0;

		private static uint __GetAudioQualityLevel = 0;

		private static uint __GetAntiAliasingQuality = 0;

		private static uint __EnableHDRDisplayOutput = 0;

		private static uint __ConfirmVideoMode = 0;

		private static uint __ApplySettings = 0;

		private static uint __ApplyResolutionSettings = 0;

		private static uint __ApplyNonResolutionSettings = 0;

		private static uint __ApplyHardwareBenchmarkResults = 0;
	}
}