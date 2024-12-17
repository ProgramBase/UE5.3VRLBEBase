using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VolumetricCloudComponent")]
	public partial class UVolumetricCloudComponent : USceneComponent, IStaticClass
	{
		public float LayerBottomAltitude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LayerBottomAltitude, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LayerBottomAltitude, __InBuffer);
				}
			}
		}

		public float LayerHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LayerHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LayerHeight, __InBuffer);
				}
			}
		}

		public float TracingStartMaxDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TracingStartMaxDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TracingStartMaxDistance, __InBuffer);
				}
			}
		}

		public EVolumetricCloudTracingMaxDistanceMode TracingMaxDistanceMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TracingMaxDistanceMode, __ReturnBuffer);

					return *(EVolumetricCloudTracingMaxDistanceMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TracingMaxDistanceMode, __InBuffer);
				}
			}
		}

		public float TracingMaxDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TracingMaxDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TracingMaxDistance, __InBuffer);
				}
			}
		}

		public float PlanetRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlanetRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlanetRadius, __InBuffer);
				}
			}
		}

		public FColor GroundAlbedo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GroundAlbedo, __ReturnBuffer);

					return *(FColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GroundAlbedo, __InBuffer);
				}
			}
		}

		public UMaterialInterface Material
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Material, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Material, __InBuffer);
				}
			}
		}

		public bool bUsePerSampleAtmosphericLightTransmittance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUsePerSampleAtmosphericLightTransmittance, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUsePerSampleAtmosphericLightTransmittance, __InBuffer);
				}
			}
		}

		public float SkyLightCloudBottomOcclusion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkyLightCloudBottomOcclusion, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkyLightCloudBottomOcclusion, __InBuffer);
				}
			}
		}

		public float ViewSampleCountScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewSampleCountScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewSampleCountScale, __InBuffer);
				}
			}
		}

		public float ReflectionViewSampleCountScaleValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReflectionViewSampleCountScaleValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReflectionViewSampleCountScaleValue, __InBuffer);
				}
			}
		}

		public float ShadowViewSampleCountScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowViewSampleCountScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowViewSampleCountScale, __InBuffer);
				}
			}
		}

		public float ShadowReflectionViewSampleCountScaleValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowReflectionViewSampleCountScaleValue, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowReflectionViewSampleCountScaleValue, __InBuffer);
				}
			}
		}

		public float ShadowTracingDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowTracingDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowTracingDistance, __InBuffer);
				}
			}
		}

		public float StopTracingTransmittanceThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StopTracingTransmittanceThreshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StopTracingTransmittanceThreshold, __InBuffer);
				}
			}
		}

		public float AerialPespectiveRayleighScatteringStartDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AerialPespectiveRayleighScatteringStartDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AerialPespectiveRayleighScatteringStartDistance, __InBuffer);
				}
			}
		}

		public float AerialPespectiveRayleighScatteringFadeDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AerialPespectiveRayleighScatteringFadeDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AerialPespectiveRayleighScatteringFadeDistance, __InBuffer);
				}
			}
		}

		public float AerialPespectiveMieScatteringStartDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AerialPespectiveMieScatteringStartDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AerialPespectiveMieScatteringStartDistance, __InBuffer);
				}
			}
		}

		public float AerialPespectiveMieScatteringFadeDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AerialPespectiveMieScatteringFadeDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AerialPespectiveMieScatteringFadeDistance, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.VolumetricCloudComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetViewSampleCountScale(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetViewSampleCountScale, __InBuffer);
			}
		}

		public virtual void SetTracingStartMaxDistance(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTracingStartMaxDistance, __InBuffer);
			}
		}

		public virtual void SetTracingMaxDistance(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTracingMaxDistance, __InBuffer);
			}
		}

		public virtual void SetStopTracingTransmittanceThreshold(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStopTracingTransmittanceThreshold, __InBuffer);
			}
		}

		public virtual void SetSkyLightCloudBottomOcclusion(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSkyLightCloudBottomOcclusion, __InBuffer);
			}
		}

		public virtual void SetShadowViewSampleCountScale(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShadowViewSampleCountScale, __InBuffer);
			}
		}

		public virtual void SetShadowTracingDistance(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShadowTracingDistance, __InBuffer);
			}
		}

		public virtual void SetShadowReflectionViewSampleCountScale(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShadowReflectionViewSampleCountScale, __InBuffer);
			}
		}

		public virtual void SetShadowReflectionSampleCountScale(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShadowReflectionSampleCountScale, __InBuffer);
			}
		}

		public virtual void SetReflectionViewSampleCountScale(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReflectionViewSampleCountScale, __InBuffer);
			}
		}

		public virtual void SetReflectionSampleCountScale(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReflectionSampleCountScale, __InBuffer);
			}
		}

		public virtual void SetPlanetRadius(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlanetRadius, __InBuffer);
			}
		}

		public virtual void SetMaterial(UMaterialInterface NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaterial, __InBuffer);
			}
		}

		public virtual void SetLayerHeight(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLayerHeight, __InBuffer);
			}
		}

		public virtual void SetLayerBottomAltitude(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLayerBottomAltitude, __InBuffer);
			}
		}

		public virtual void SetGroundAlbedo(FColor NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGroundAlbedo, __InBuffer);
			}
		}

		public virtual void SetbUsePerSampleAtmosphericLightTransmittance(bool NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetbUsePerSampleAtmosphericLightTransmittance, __InBuffer);
			}
		}

		private static uint __LayerBottomAltitude = 0;

		private static uint __LayerHeight = 0;

		private static uint __TracingStartMaxDistance = 0;

		private static uint __TracingMaxDistanceMode = 0;

		private static uint __TracingMaxDistance = 0;

		private static uint __PlanetRadius = 0;

		private static uint __GroundAlbedo = 0;

		private static uint __Material = 0;

		private static uint __bUsePerSampleAtmosphericLightTransmittance = 0;

		private static uint __SkyLightCloudBottomOcclusion = 0;

		private static uint __ViewSampleCountScale = 0;

		private static uint __ReflectionViewSampleCountScaleValue = 0;

		private static uint __ShadowViewSampleCountScale = 0;

		private static uint __ShadowReflectionViewSampleCountScaleValue = 0;

		private static uint __ShadowTracingDistance = 0;

		private static uint __StopTracingTransmittanceThreshold = 0;

		private static uint __AerialPespectiveRayleighScatteringStartDistance = 0;

		private static uint __AerialPespectiveRayleighScatteringFadeDistance = 0;

		private static uint __AerialPespectiveMieScatteringStartDistance = 0;

		private static uint __AerialPespectiveMieScatteringFadeDistance = 0;

		private static uint __SetViewSampleCountScale = 0;

		private static uint __SetTracingStartMaxDistance = 0;

		private static uint __SetTracingMaxDistance = 0;

		private static uint __SetStopTracingTransmittanceThreshold = 0;

		private static uint __SetSkyLightCloudBottomOcclusion = 0;

		private static uint __SetShadowViewSampleCountScale = 0;

		private static uint __SetShadowTracingDistance = 0;

		private static uint __SetShadowReflectionViewSampleCountScale = 0;

		private static uint __SetShadowReflectionSampleCountScale = 0;

		private static uint __SetReflectionViewSampleCountScale = 0;

		private static uint __SetReflectionSampleCountScale = 0;

		private static uint __SetPlanetRadius = 0;

		private static uint __SetMaterial = 0;

		private static uint __SetLayerHeight = 0;

		private static uint __SetLayerBottomAltitude = 0;

		private static uint __SetGroundAlbedo = 0;

		private static uint __SetbUsePerSampleAtmosphericLightTransmittance = 0;
	}
}