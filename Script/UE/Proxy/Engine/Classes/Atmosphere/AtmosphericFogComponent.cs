using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AtmosphericFogComponent")]
	public partial class UAtmosphericFogComponent : USkyAtmosphereComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AtmosphericFogComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSunMultiplier(float NewSunMultiplier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewSunMultiplier;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSunMultiplier, __InBuffer);
			}
		}

		public virtual void SetStartDistance(float NewStartDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewStartDistance;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStartDistance, __InBuffer);
			}
		}

		public virtual void SetPrecomputeParams(float DensityHeight, int MaxScatteringOrder, int InscatterAltitudeSampleNum)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = DensityHeight;

				*(int*)(__InBuffer + 4) = MaxScatteringOrder;

				*(int*)(__InBuffer + 8) = InscatterAltitudeSampleNum;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPrecomputeParams, __InBuffer);
			}
		}

		public virtual void SetFogMultiplier(float NewFogMultiplier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewFogMultiplier;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFogMultiplier, __InBuffer);
			}
		}

		public virtual void SetDistanceScale(float NewDistanceScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewDistanceScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDistanceScale, __InBuffer);
			}
		}

		public virtual void SetDistanceOffset(float NewDistanceOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewDistanceOffset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDistanceOffset, __InBuffer);
			}
		}

		public virtual void SetDensityOffset(float NewDensityOffset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewDensityOffset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDensityOffset, __InBuffer);
			}
		}

		public virtual void SetDensityMultiplier(float NewDensityMultiplier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewDensityMultiplier;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDensityMultiplier, __InBuffer);
			}
		}

		public virtual void SetDefaultLightColor(FLinearColor NewLightColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewLightColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultLightColor, __InBuffer);
			}
		}

		public virtual void SetDefaultBrightness(float NewBrightness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewBrightness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultBrightness, __InBuffer);
			}
		}

		public virtual void SetAltitudeScale(float NewAltitudeScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewAltitudeScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAltitudeScale, __InBuffer);
			}
		}

		public virtual void DisableSunDisk(bool NewSunDisk)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = NewSunDisk;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DisableSunDisk, __InBuffer);
			}
		}

		public virtual void DisableGroundScattering(bool NewGroundScattering)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = NewGroundScattering;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DisableGroundScattering, __InBuffer);
			}
		}

		private static uint __SetSunMultiplier = 0;

		private static uint __SetStartDistance = 0;

		private static uint __SetPrecomputeParams = 0;

		private static uint __SetFogMultiplier = 0;

		private static uint __SetDistanceScale = 0;

		private static uint __SetDistanceOffset = 0;

		private static uint __SetDensityOffset = 0;

		private static uint __SetDensityMultiplier = 0;

		private static uint __SetDefaultLightColor = 0;

		private static uint __SetDefaultBrightness = 0;

		private static uint __SetAltitudeScale = 0;

		private static uint __DisableSunDisk = 0;

		private static uint __DisableGroundScattering = 0;
	}
}