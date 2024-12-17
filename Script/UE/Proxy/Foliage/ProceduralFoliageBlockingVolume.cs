using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.ProceduralFoliageBlockingVolume")]
	public partial class AProceduralFoliageBlockingVolume : AVolume, IStaticClass
	{
		public AProceduralFoliageVolume ProceduralFoliageVolume
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProceduralFoliageVolume, __ReturnBuffer);

					return *(AProceduralFoliageVolume*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProceduralFoliageVolume, __InBuffer);
				}
			}
		}

		public FFoliageDensityFalloff DensityFalloff
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DensityFalloff, __ReturnBuffer);

					return *(FFoliageDensityFalloff*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DensityFalloff, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Foliage.ProceduralFoliageBlockingVolume");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ProceduralFoliageVolume = 0;

		private static uint __DensityFalloff = 0;
	}
}