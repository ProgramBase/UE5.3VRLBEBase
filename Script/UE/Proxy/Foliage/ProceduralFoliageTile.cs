using Script.CoreUObject;
using Script.Library;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.ProceduralFoliageTile")]
	public partial class UProceduralFoliageTile : UObject, IStaticClass
	{
		public UProceduralFoliageSpawner FoliageSpawner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageSpawner, __ReturnBuffer);

					return *(UProceduralFoliageSpawner*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageSpawner, __InBuffer);
				}
			}
		}

		public TArray<FProceduralFoliageInstance> InstancesArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InstancesArray, __ReturnBuffer);

					return *(TArray<FProceduralFoliageInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InstancesArray, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Foliage.ProceduralFoliageTile");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FoliageSpawner = 0;

		private static uint __InstancesArray = 0;
	}
}