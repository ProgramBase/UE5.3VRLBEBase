using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleLocationPrimitiveSphere")]
	public partial class UParticleModuleLocationPrimitiveSphere : UParticleModuleLocationPrimitiveBase, IStaticClass
	{
		public FRawDistributionFloat StartRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StartRadius, __ReturnBuffer);

					return *(FRawDistributionFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StartRadius, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleLocationPrimitiveSphere");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __StartRadius = 0;
	}
}