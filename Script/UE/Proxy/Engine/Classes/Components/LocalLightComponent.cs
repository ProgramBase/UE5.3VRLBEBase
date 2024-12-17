using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LocalLightComponent")]
	public partial class ULocalLightComponent : ULightComponent, IStaticClass
	{
		public ELightUnits IntensityUnits
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IntensityUnits, __ReturnBuffer);

					return *(ELightUnits*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IntensityUnits, __InBuffer);
				}
			}
		}

		public float InverseExposureBlend
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InverseExposureBlend, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InverseExposureBlend, __InBuffer);
				}
			}
		}

		public float AttenuationRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AttenuationRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AttenuationRadius, __InBuffer);
				}
			}
		}

		public FLightmassPointLightSettings LightmassSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LightmassSettings, __ReturnBuffer);

					return *(FLightmassPointLightSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LightmassSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LocalLightComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetIntensityUnits(ELightUnits NewIntensityUnits)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewIntensityUnits;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIntensityUnits, __InBuffer);
			}
		}

		public virtual void SetAttenuationRadius(float NewRadius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewRadius;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAttenuationRadius, __InBuffer);
			}
		}

		public static float GetUnitsConversionFactor(ELightUnits SrcUnits, ELightUnits TargetUnits, float CosHalfConeAngle = -1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(byte*)(__InBuffer) = (byte)SrcUnits;

				*(byte*)(__InBuffer + 1) = (byte)TargetUnits;

				*(float*)(__InBuffer + 2) = CosHalfConeAngle;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetUnitsConversionFactor, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __IntensityUnits = 0;

		private static uint __InverseExposureBlend = 0;

		private static uint __AttenuationRadius = 0;

		private static uint __LightmassSettings = 0;

		private static uint __SetIntensityUnits = 0;

		private static uint __SetAttenuationRadius = 0;

		private static uint __GetUnitsConversionFactor = 0;
	}
}