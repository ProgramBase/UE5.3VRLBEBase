using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleVectorFieldScale")]
	public partial class UParticleModuleVectorFieldScale : UParticleModuleVectorFieldBase, IStaticClass
	{
		public FRawDistributionFloat VectorFieldScaleRaw
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VectorFieldScaleRaw, __ReturnBuffer);

					return *(FRawDistributionFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VectorFieldScaleRaw, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleVectorFieldScale");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __VectorFieldScaleRaw = 0;
	}
}