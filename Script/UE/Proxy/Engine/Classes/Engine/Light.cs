using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Light")]
	public partial class ALight : AActor, IStaticClass
	{
		public ULightComponent LightComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LightComponent, __ReturnBuffer);

					return *(ULightComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LightComponent, __InBuffer);
				}
			}
		}

		public bool bEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnabled, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Light");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ToggleEnabled()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ToggleEnabled);
			}
		}

		public virtual void SetLightFunctionScale(FVector NewLightFunctionScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewLightFunctionScale?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLightFunctionScale, __InBuffer);
			}
		}

		public virtual void SetLightFunctionMaterial(UMaterialInterface NewLightFunctionMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewLightFunctionMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLightFunctionMaterial, __InBuffer);
			}
		}

		public virtual void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewLightFunctionFadeDistance;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLightFunctionFadeDistance, __InBuffer);
			}
		}

		public virtual void SetLightColor(FLinearColor NewLightColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewLightColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLightColor, __InBuffer);
			}
		}

		public virtual void SetEnabled(bool bSetEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSetEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnabled, __InBuffer);
			}
		}

		public virtual void SetCastShadows(bool bNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCastShadows, __InBuffer);
			}
		}

		public virtual void SetBrightness(float NewBrightness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewBrightness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBrightness, __InBuffer);
			}
		}

		public virtual void SetAffectTranslucentLighting(bool bNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAffectTranslucentLighting, __InBuffer);
			}
		}

		public virtual void OnRep_bEnabled()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_bEnabled);
			}
		}

		public virtual bool IsEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FLinearColor GetLightColor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLightColor, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public virtual float GetBrightness()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetBrightness, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __LightComponent = 0;

		private static uint __bEnabled = 0;

		private static uint __ToggleEnabled = 0;

		private static uint __SetLightFunctionScale = 0;

		private static uint __SetLightFunctionMaterial = 0;

		private static uint __SetLightFunctionFadeDistance = 0;

		private static uint __SetLightColor = 0;

		private static uint __SetEnabled = 0;

		private static uint __SetCastShadows = 0;

		private static uint __SetBrightness = 0;

		private static uint __SetAffectTranslucentLighting = 0;

		private static uint __OnRep_bEnabled = 0;

		private static uint __IsEnabled = 0;

		private static uint __GetLightColor = 0;

		private static uint __GetBrightness = 0;
	}
}