using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleMeshRotationRate_Seeded")]
	public partial class UParticleModuleMeshRotationRate_Seeded : UParticleModuleMeshRotationRate, IStaticClass
	{
		public FParticleRandomSeedInfo RandomSeedInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RandomSeedInfo, __ReturnBuffer);

					return *(FParticleRandomSeedInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RandomSeedInfo, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleMeshRotationRate_Seeded");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RandomSeedInfo = 0;
	}
}