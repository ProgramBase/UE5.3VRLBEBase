using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SpotLightComponent")]
	public partial class USpotLightComponent : UPointLightComponent, IStaticClass
	{
		public float InnerConeAngle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InnerConeAngle, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InnerConeAngle, __InBuffer);
				}
			}
		}

		public float OuterConeAngle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OuterConeAngle, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OuterConeAngle, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SpotLightComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetOuterConeAngle(float NewOuterConeAngle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewOuterConeAngle;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOuterConeAngle, __InBuffer);
			}
		}

		public virtual void SetInnerConeAngle(float NewInnerConeAngle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewInnerConeAngle;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInnerConeAngle, __InBuffer);
			}
		}

		private static uint __InnerConeAngle = 0;

		private static uint __OuterConeAngle = 0;

		private static uint __SetOuterConeAngle = 0;

		private static uint __SetInnerConeAngle = 0;
	}
}