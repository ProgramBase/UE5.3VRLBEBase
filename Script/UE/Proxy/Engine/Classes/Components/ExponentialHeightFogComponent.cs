using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ExponentialHeightFogComponent")]
	public partial class UExponentialHeightFogComponent : USceneComponent, IStaticClass
	{
		public float FogDensity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FogDensity, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FogDensity, __InBuffer);
				}
			}
		}

		public float FogHeightFalloff
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FogHeightFalloff, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FogHeightFalloff, __InBuffer);
				}
			}
		}

		public FExponentialHeightFogData SecondFogData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SecondFogData, __ReturnBuffer);

					return *(FExponentialHeightFogData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SecondFogData, __InBuffer);
				}
			}
		}

		public FLinearColor FogInscatteringLuminance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FogInscatteringLuminance, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FogInscatteringLuminance, __InBuffer);
				}
			}
		}

		public FLinearColor SkyAtmosphereAmbientContributionColorScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkyAtmosphereAmbientContributionColorScale, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkyAtmosphereAmbientContributionColorScale, __InBuffer);
				}
			}
		}

		public UTextureCube InscatteringColorCubemap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InscatteringColorCubemap, __ReturnBuffer);

					return *(UTextureCube*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InscatteringColorCubemap, __InBuffer);
				}
			}
		}

		public float InscatteringColorCubemapAngle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InscatteringColorCubemapAngle, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InscatteringColorCubemapAngle, __InBuffer);
				}
			}
		}

		public FLinearColor InscatteringTextureTint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InscatteringTextureTint, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InscatteringTextureTint, __InBuffer);
				}
			}
		}

		public float FullyDirectionalInscatteringColorDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FullyDirectionalInscatteringColorDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FullyDirectionalInscatteringColorDistance, __InBuffer);
				}
			}
		}

		public float NonDirectionalInscatteringColorDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NonDirectionalInscatteringColorDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NonDirectionalInscatteringColorDistance, __InBuffer);
				}
			}
		}

		public float DirectionalInscatteringExponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectionalInscatteringExponent, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectionalInscatteringExponent, __InBuffer);
				}
			}
		}

		public float DirectionalInscatteringStartDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectionalInscatteringStartDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectionalInscatteringStartDistance, __InBuffer);
				}
			}
		}

		public FLinearColor DirectionalInscatteringLuminance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DirectionalInscatteringLuminance, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DirectionalInscatteringLuminance, __InBuffer);
				}
			}
		}

		public float FogMaxOpacity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FogMaxOpacity, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FogMaxOpacity, __InBuffer);
				}
			}
		}

		public float StartDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StartDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StartDistance, __InBuffer);
				}
			}
		}

		public float FogCutoffDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FogCutoffDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FogCutoffDistance, __InBuffer);
				}
			}
		}

		public bool bEnableVolumetricFog
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableVolumetricFog, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableVolumetricFog, __InBuffer);
				}
			}
		}

		public float VolumetricFogScatteringDistribution
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogScatteringDistribution, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogScatteringDistribution, __InBuffer);
				}
			}
		}

		public FColor VolumetricFogAlbedo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogAlbedo, __ReturnBuffer);

					return *(FColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogAlbedo, __InBuffer);
				}
			}
		}

		public FLinearColor VolumetricFogEmissive
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogEmissive, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogEmissive, __InBuffer);
				}
			}
		}

		public float VolumetricFogExtinctionScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogExtinctionScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogExtinctionScale, __InBuffer);
				}
			}
		}

		public float VolumetricFogDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogDistance, __InBuffer);
				}
			}
		}

		public float VolumetricFogStartDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogStartDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogStartDistance, __InBuffer);
				}
			}
		}

		public float VolumetricFogNearFadeInDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogNearFadeInDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogNearFadeInDistance, __InBuffer);
				}
			}
		}

		public float VolumetricFogStaticLightingScatteringIntensity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogStaticLightingScatteringIntensity, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricFogStaticLightingScatteringIntensity, __InBuffer);
				}
			}
		}

		public bool bOverrideLightColorsWithFogInscatteringColors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideLightColorsWithFogInscatteringColors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideLightColorsWithFogInscatteringColors, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ExponentialHeightFogComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetVolumetricFogScatteringDistribution(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVolumetricFogScatteringDistribution, __InBuffer);
			}
		}

		public virtual void SetVolumetricFogExtinctionScale(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVolumetricFogExtinctionScale, __InBuffer);
			}
		}

		public virtual void SetVolumetricFogEmissive(FLinearColor NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVolumetricFogEmissive, __InBuffer);
			}
		}

		public virtual void SetVolumetricFogDistance(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVolumetricFogDistance, __InBuffer);
			}
		}

		public virtual void SetVolumetricFogAlbedo(FColor NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVolumetricFogAlbedo, __InBuffer);
			}
		}

		public virtual void SetVolumetricFog(bool bNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVolumetricFog, __InBuffer);
			}
		}

		public virtual void SetStartDistance(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStartDistance, __InBuffer);
			}
		}

		public virtual void SetSecondFogHeightOffset(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSecondFogHeightOffset, __InBuffer);
			}
		}

		public virtual void SetSecondFogHeightFalloff(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSecondFogHeightFalloff, __InBuffer);
			}
		}

		public virtual void SetSecondFogDensity(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSecondFogDensity, __InBuffer);
			}
		}

		public virtual void SetSecondFogData(FExponentialHeightFogData NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSecondFogData, __InBuffer);
			}
		}

		public virtual void SetNonDirectionalInscatteringColorDistance(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNonDirectionalInscatteringColorDistance, __InBuffer);
			}
		}

		public virtual void SetInscatteringTextureTint(FLinearColor Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInscatteringTextureTint, __InBuffer);
			}
		}

		public virtual void SetInscatteringColorCubemapAngle(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInscatteringColorCubemapAngle, __InBuffer);
			}
		}

		public virtual void SetInscatteringColorCubemap(UTextureCube Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInscatteringColorCubemap, __InBuffer);
			}
		}

		public virtual void SetFullyDirectionalInscatteringColorDistance(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFullyDirectionalInscatteringColorDistance, __InBuffer);
			}
		}

		public virtual void SetFogMaxOpacity(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFogMaxOpacity, __InBuffer);
			}
		}

		public virtual void SetFogInscatteringColor(FLinearColor Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFogInscatteringColor, __InBuffer);
			}
		}

		public virtual void SetFogHeightFalloff(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFogHeightFalloff, __InBuffer);
			}
		}

		public virtual void SetFogDensity(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFogDensity, __InBuffer);
			}
		}

		public virtual void SetFogCutoffDistance(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFogCutoffDistance, __InBuffer);
			}
		}

		public virtual void SetDirectionalInscatteringStartDistance(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDirectionalInscatteringStartDistance, __InBuffer);
			}
		}

		public virtual void SetDirectionalInscatteringExponent(float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDirectionalInscatteringExponent, __InBuffer);
			}
		}

		public virtual void SetDirectionalInscatteringColor(FLinearColor Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDirectionalInscatteringColor, __InBuffer);
			}
		}

		private static uint __FogDensity = 0;

		private static uint __FogHeightFalloff = 0;

		private static uint __SecondFogData = 0;

		private static uint __FogInscatteringLuminance = 0;

		private static uint __SkyAtmosphereAmbientContributionColorScale = 0;

		private static uint __InscatteringColorCubemap = 0;

		private static uint __InscatteringColorCubemapAngle = 0;

		private static uint __InscatteringTextureTint = 0;

		private static uint __FullyDirectionalInscatteringColorDistance = 0;

		private static uint __NonDirectionalInscatteringColorDistance = 0;

		private static uint __DirectionalInscatteringExponent = 0;

		private static uint __DirectionalInscatteringStartDistance = 0;

		private static uint __DirectionalInscatteringLuminance = 0;

		private static uint __FogMaxOpacity = 0;

		private static uint __StartDistance = 0;

		private static uint __FogCutoffDistance = 0;

		private static uint __bEnableVolumetricFog = 0;

		private static uint __VolumetricFogScatteringDistribution = 0;

		private static uint __VolumetricFogAlbedo = 0;

		private static uint __VolumetricFogEmissive = 0;

		private static uint __VolumetricFogExtinctionScale = 0;

		private static uint __VolumetricFogDistance = 0;

		private static uint __VolumetricFogStartDistance = 0;

		private static uint __VolumetricFogNearFadeInDistance = 0;

		private static uint __VolumetricFogStaticLightingScatteringIntensity = 0;

		private static uint __bOverrideLightColorsWithFogInscatteringColors = 0;

		private static uint __SetVolumetricFogScatteringDistribution = 0;

		private static uint __SetVolumetricFogExtinctionScale = 0;

		private static uint __SetVolumetricFogEmissive = 0;

		private static uint __SetVolumetricFogDistance = 0;

		private static uint __SetVolumetricFogAlbedo = 0;

		private static uint __SetVolumetricFog = 0;

		private static uint __SetStartDistance = 0;

		private static uint __SetSecondFogHeightOffset = 0;

		private static uint __SetSecondFogHeightFalloff = 0;

		private static uint __SetSecondFogDensity = 0;

		private static uint __SetSecondFogData = 0;

		private static uint __SetNonDirectionalInscatteringColorDistance = 0;

		private static uint __SetInscatteringTextureTint = 0;

		private static uint __SetInscatteringColorCubemapAngle = 0;

		private static uint __SetInscatteringColorCubemap = 0;

		private static uint __SetFullyDirectionalInscatteringColorDistance = 0;

		private static uint __SetFogMaxOpacity = 0;

		private static uint __SetFogInscatteringColor = 0;

		private static uint __SetFogHeightFalloff = 0;

		private static uint __SetFogDensity = 0;

		private static uint __SetFogCutoffDistance = 0;

		private static uint __SetDirectionalInscatteringStartDistance = 0;

		private static uint __SetDirectionalInscatteringExponent = 0;

		private static uint __SetDirectionalInscatteringColor = 0;
	}
}