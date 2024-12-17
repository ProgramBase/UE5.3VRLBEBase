using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PointLight")]
	public partial class APointLight : ALight, IStaticClass
	{
		public UPointLightComponent PointLightComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PointLightComponent, __ReturnBuffer);

					return *(UPointLightComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PointLightComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PointLight");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetRadius(float NewRadius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewRadius;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRadius, __InBuffer);
			}
		}

		public virtual void SetLightFalloffExponent(float NewLightFalloffExponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewLightFalloffExponent;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLightFalloffExponent, __InBuffer);
			}
		}

		private static uint __PointLightComponent = 0;

		private static uint __SetRadius = 0;

		private static uint __SetLightFalloffExponent = 0;
	}
}