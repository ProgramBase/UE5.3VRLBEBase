using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleVectorFieldScaleOverLife")]
	public partial class UParticleModuleVectorFieldScaleOverLife : UParticleModuleVectorFieldBase, IStaticClass
	{
		public FRawDistributionFloat VectorFieldScaleOverLifeRaw
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VectorFieldScaleOverLifeRaw, __ReturnBuffer);

					return *(FRawDistributionFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VectorFieldScaleOverLifeRaw, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleVectorFieldScaleOverLife");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __VectorFieldScaleOverLifeRaw = 0;
	}
}